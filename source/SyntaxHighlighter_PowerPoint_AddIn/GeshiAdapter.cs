using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxHighlighter
{
  public class GeshiAdapter
  {
    private ProcessStartInfo CreateCLIStartInfo()
    {
      // initialize start up parameters
      ProcessStartInfo startInfo = new ProcessStartInfo();
      //startInfo.CreateNoWindow = false;
      startInfo.UseShellExecute = false;
      startInfo.RedirectStandardInput = true;
      startInfo.RedirectStandardOutput = true;
      startInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;

      startInfo.FileName = Properties.Settings.Default.PHP_EXE;
      startInfo.WindowStyle = ProcessWindowStyle.Hidden;
      startInfo.Arguments = String.Format("-f {0} -n", Properties.Settings.Default.CLI_SCRIPT);
      //startInfo.WorkingDirectory = @"C:\SDK\geshi-word-addin\";
      startInfo.ErrorDialog = true;

      return startInfo;
    }

    public string[] AvailableLanguages()
    {
      if (String.IsNullOrEmpty(Properties.Settings.Default.AVAILABLE_LANGUAGES)
        || System.IO.Directory.GetLastWriteTime(Properties.Settings.Default.GESHI_LANGUAGES) != Properties.Settings.Default.GESHI_LANGUAGES_LAST_WRITE_DATE_TIME)
      {
        UpdateAvailableLanguagesByCLI();
      }

      // use selected or as fallback all available
      var langsAsString = String.IsNullOrEmpty(Properties.Settings.Default.SELECTED_LANGUAGES) ? Properties.Settings.Default.AVAILABLE_LANGUAGES : Properties.Settings.Default.SELECTED_LANGUAGES;
           
      // convert string list as array
      return langsAsString.Split('\n');
    }

    private void UpdateAvailableLanguagesByCLI()
    {
      // create start parameter
      ProcessStartInfo startInfo = CreateCLIStartInfo();
      // whole supported language as a list (separator is new line character)
      string listOfLangs;
      try
      {
        // Start the process
        using (Process exeProcess = Process.Start(startInfo))
        {
          // redirect STD::CIN and STD::COUT
          var reader = exeProcess.StandardOutput;
          var writer = exeProcess.StandardInput;

          // set options
          writer.WriteLine("START GESHI_SCRIPT");
          writer.WriteLine(Properties.Settings.Default.GESHI_SCRIPT);
          writer.WriteLine("END GESHI_SCRIPT");

          // change return type
          writer.WriteLine("START RETURN_TYPE");
          writer.WriteLine("LIST_OF_LANGUAGE");
          writer.WriteLine("END RETURN_TYPE");

          // finalize command stream
          writer.WriteLine("END TRANSACTION");

          // flush current content
          writer.Flush();

          // read the result
          listOfLangs = reader.ReadToEnd();

          // wait for finishing the process
          exeProcess.WaitForExit();
        }
      }
      catch (Exception ex)
      {
        // any error case
        Console.WriteLine("{0} Exception caught.", ex);
        listOfLangs = "";
      }

      // update list
      Properties.Settings.Default.AVAILABLE_LANGUAGES = listOfLangs;

      // update date time
      Properties.Settings.Default.GESHI_LANGUAGES_LAST_WRITE_DATE_TIME = System.IO.Directory.GetLastWriteTime(Properties.Settings.Default.GESHI_LANGUAGES);
    }

    public string Colorize(string raw)
    {
      // create start parameter for process
      ProcessStartInfo startInfo = CreateCLIStartInfo();

      try
      {
        // start process
        using (Process exeProcess = Process.Start(startInfo))
        {
          // redirect STD::COUT and STD::CIN
          var reader = exeProcess.StandardOutput;
          var writer = exeProcess.StandardInput;

          // start protocol for die CLI.php
          writer.WriteLine("START GESHI_SCRIPT");
          writer.WriteLine(Properties.Settings.Default.GESHI_SCRIPT);
          writer.WriteLine("END GESHI_SCRIPT");

          // select programming language
          writer.WriteLine("START LANGUAGE");
          writer.WriteLine(Properties.Settings.Default.LANGUAGE);
          writer.WriteLine("END LANGUAGE");

          // active the line numbers
          writer.WriteLine("START ENABLE_LINE_NUMBERS");
          writer.WriteLine(Properties.Settings.Default.LINE_NUMBERS);
          writer.WriteLine("END ENABLE_LINE_NUMBERS");

          // set tab width
          writer.WriteLine("START TAB_WIDTH");
          writer.WriteLine(Properties.Settings.Default.TAB_WIDTH);
          writer.WriteLine("END TAB_WIDTH");

          // set marker for extra highlighted lines
          writer.WriteLine("START MARKER_EXTRA_HIGHLIGHTED_LINES");
          writer.WriteLine(Properties.Settings.Default.MARKER_EXTRA_HIGHLIGHTED_LINES);
          writer.WriteLine("END MARKER_EXTRA_HIGHLIGHTED_LINES");

          // write source code, base64 encoding to have no restriction within the content
          writer.WriteLine("START SOURCE");
          // replace word escape characters
          raw = raw.Replace('„', '"');
          raw = raw.Replace('“', '"');
          raw = raw.Replace('‚', '\'');
          raw = raw.Replace('‘', '\'');
          raw = raw.Replace('\v', '\n');

          // convert to base 64
          var bytes = System.Text.Encoding.UTF8.GetBytes(raw);
          //var bytes = writer.Encoding.GetBytes(raw);
          writer.WriteLine(System.Convert.ToBase64String(bytes));
          writer.WriteLine("END SOURCE");

          // our statements completely
          writer.WriteLine("END TRANSACTION");

          // flush
          writer.Flush();

          //exeProcess.BeginOutputReadLine();
          var colorized = reader.ReadToEnd();

          // wait for processing
          exeProcess.WaitForExit();

          // Debug purpose only
          //System.IO.File.WriteAllText(@"C:\Temp\input_geshi.txt" , raw, Encoding.UTF8);
          //System.IO.File.WriteAllText(@"C:\Temp\output_geshi.txt", colorized, Encoding.UTF8);

          // read the return value          
          return colorized;
        }
      }
      catch (Exception ex)
      {
        // any error occurs
        return String.Format("{0} Exception caught.", ex);
      }
    }

    public void SaveAsHTMLDocument(string raw, string path)
    {
      var html = string.Format("<!DOCTYPE html><html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/><body>{0}</body></html>"
        , Colorize(raw));

      // write content to file
      System.IO.File.WriteAllText(path, html, Encoding.UTF8);
    }

    public string SaveTemporaryAsHTMLDocument(string raw)
    {
      // create temp file path
      var path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());

      SaveAsHTMLDocument(raw, path);

      return path;
    }

    static string To8DigitString(int x)
    {
      return String.Format("{0,8}", x);
    }

    public string AsClipboardHTMLFormat(string raw)
    {
      /*
        Version:0.9
        StartHTML:71
        EndHTML:160
        StartFragment:130
        EndFragment:150
        StartSelection:130
        EndSelection:150
        <!DOCTYPE ...>
        <BODY>
        <!-- StartFragment -->>
        <B>bold</B><I><B>This is bold italic</B>This</I>
        <!-- EndFragment -->
        </BODY>
        </HTML>
      */
      var colorized = Colorize(raw);

      System.Text.StringBuilder sb = new System.Text.StringBuilder();

      string header = @"Version: 1.0
StartHTML:<<<<<<< 1
EndHTML:<<<<<<< 2
StartFragment:<<<<<<< 3
EndFragment:<<<<<<< 4
StartSelection:<<<<<<< 3
EndSelection:<<<<<<< 3
";

      string pre = "<!DOCTYPE html><html><head><meta http-equiv=\"Content - Type\" content=\"text/html; charset=utf-8\"/><body>";
      string post = "</body></html>";
      sb.Append(header);

      int startHTML = sb.Length;
      sb.Append(pre);

      int fragmentStart = sb.Length;
      sb.Append(colorized);

      int fragmentEnd = sb.Length;
      sb.Append(post);

      int endHTML = sb.Length;

      // Backpatch offsets
      sb.Replace("<<<<<<< 1", To8DigitString(startHTML));
      sb.Replace("<<<<<<< 2", To8DigitString(endHTML));
      sb.Replace("<<<<<<< 3", To8DigitString(fragmentStart));
      sb.Replace("<<<<<<< 4", To8DigitString(fragmentEnd));
      
      return sb.ToString();
    }
  }
}
