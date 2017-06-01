using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyntaxHighlighter
{
  public partial class Settings : Form
  {
    public Settings()
    {
      InitializeComponent();

      php.Text = Properties.Settings.Default.PHP_EXE;
      geshi.Text = Properties.Settings.Default.GESHI_SCRIPT;
      geshiLang.Text = Properties.Settings.Default.GESHI_LANGUAGES;
      cli.Text = Properties.Settings.Default.CLI_SCRIPT;
      tabWidth.Value = Properties.Settings.Default.TAB_WIDTH;
      markerExtraHighlightedLines.Text = Properties.Settings.Default.MARKER_EXTRA_HIGHLIGHTED_LINES;

      // use selected or as fallback all available
      var langsAsString = Properties.Settings.Default.AVAILABLE_LANGUAGES;

      // convert string list as array
      var arrayOfLangs = langsAsString.Split('\n');
      for (int i = 0; i < arrayOfLangs.Count(); ++i) {
        var exists = Properties.Settings.Default.SELECTED_LANGUAGES.IndexOf(arrayOfLangs[i] + "\n") >= 0
                    || Properties.Settings.Default.SELECTED_LANGUAGES.IndexOf("\n" + arrayOfLangs[i]) >= 0;
        languages.Items.Add(arrayOfLangs[i], exists);
      }
    }

    private void phpBtn_Click(object sender, EventArgs e)
    {
      if (openFileDialogExe.ShowDialog() == DialogResult.OK)
      {
        php.Text = openFileDialogExe.FileName;
      }
    }

    private void geshiBtn_Click(object sender, EventArgs e)
    {
      if (openFileDialogPHP.ShowDialog() == DialogResult.OK)
      {
        geshi.Text = openFileDialogPHP.FileName;
      }
    }

    private void cliBtn_Click(object sender, EventArgs e)
    {
      if (openFileDialogPHP.ShowDialog() == DialogResult.OK)
      {
        cli.Text = openFileDialogPHP.FileName;
      }
    }

    private void geshiLangBtn_Click(object sender, EventArgs e)
    {
      if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        geshiLang.Text = folderBrowserDialog.SelectedPath;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Properties.Settings.Default.CLI_SCRIPT = cli.Text;
      Properties.Settings.Default.PHP_EXE = php.Text;
      Properties.Settings.Default.GESHI_SCRIPT = geshi.Text;
      Properties.Settings.Default.TAB_WIDTH = (int)tabWidth.Value;
      Properties.Settings.Default.MARKER_EXTRA_HIGHLIGHTED_LINES = markerExtraHighlightedLines.Text;

      if (Properties.Settings.Default.GESHI_LANGUAGES != geshiLang.Text)
      {
        Properties.Settings.Default.AVAILABLE_LANGUAGES = null;
      }

      Properties.Settings.Default.GESHI_LANGUAGES = geshiLang.Text;

      StringBuilder sb = new StringBuilder();
      //string selected = "";
      for(int i=0; i < languages.CheckedItems.Count; ++i)
      {
        if(i > 0)
        {
          sb.Append("\n");
          //selected += "\n";
        }
        //selected += languages.CheckedItems[i].ToString();
        sb.Append(languages.CheckedItems[i].ToString());
      }
      Properties.Settings.Default.SELECTED_LANGUAGES = sb.ToString();

      DialogResult = DialogResult.OK;
      Close();
    }

  }
}
