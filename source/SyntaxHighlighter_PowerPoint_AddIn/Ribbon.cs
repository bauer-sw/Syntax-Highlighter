using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace SyntaxHighlighter
{
  public partial class Ribbon
  {
    
    protected GeshiAdapter Geshi = new GeshiAdapter();

    public void LoadSettings()
    {
      // sync settings to UI
      lineNumbers.Checked = Properties.Settings.Default.LINE_NUMBERS;
    }

    public void SaveSettings()
    {
      Properties.Settings.Default.LINE_NUMBERS = lineNumbers.Checked;
      Properties.Settings.Default.LANGUAGE = language.Text;

      Properties.Settings.Default.Save();
    }

    private void UpdateLanguagesDropDown()
    {
      // convert string list as array
      var arrayOfLangs = Geshi.AvailableLanguages();
      int selectedIndex = 0;
      language.Items.Clear();
      // add all list items to drop down menu
      for (int i = 0; i < arrayOfLangs.Count(); ++i)
      {
        // create item
        RibbonDropDownItem itm = Factory.CreateRibbonDropDownItem();
        // update label
        itm.Label = arrayOfLangs[i];
        if (itm.Label == Properties.Settings.Default.LANGUAGE)
        {
          selectedIndex = i;
        }
        // add label
        language.Items.Add(itm);
      }

      // set default text
      language.Text = arrayOfLangs[selectedIndex];
    }

    private void Ribbon_Load(object sender, RibbonUIEventArgs e)
    {
      UpdateLanguagesDropDown();
    }
   
    private void highlight_Click(object sender, RibbonControlEventArgs e)
    {
      try
      {
        // get the current selection from document
        var range = Globals.PowerPointAddIn.Application.ActiveWindow.Selection.TextRange;

        // store current clipboard data
        var previousData = Clipboard.GetDataObject();

        // colorize and format it to clipboard HTML format
        var clipboardData = Geshi.AsClipboardHTMLFormat(range.Text);

        // set clipboard data
        Clipboard.SetText(clipboardData, TextDataFormat.Html);

        // insert content via clipboard
        range.PasteSpecial(Microsoft.Office.Interop.PowerPoint.PpPasteDataType.ppPasteHTML);

        // restore old data
        Clipboard.SetDataObject(previousData);
      } catch (Exception ex)
      {
        MessageBox.Show(String.Format("{0}", ex));
      }
    }

    private void settings_Click(object sender, RibbonControlEventArgs e)
    {
      Settings settings = new Settings();
      if(settings.ShowDialog() == DialogResult.OK)
      {
        UpdateLanguagesDropDown();
      }      
    }

    private void language_TextChanged(object sender, RibbonControlEventArgs e)
    {
      Properties.Settings.Default.LANGUAGE = language.Text;
    }

    private void lineNumbers_Click(object sender, RibbonControlEventArgs e)
    {
      Properties.Settings.Default.LINE_NUMBERS = lineNumbers.Checked;
    }
  } 
}
