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
      // get the current selection from document
      var code = Globals.WordAddIn.Application.Selection.Text;

      // colorize the code and store it as temporary file
      var temp = Geshi.SaveTemporaryAsHTMLDocument(code);

      // insert content via file
      var range = Globals.WordAddIn.Application.Selection;
      range.InsertFile(temp);

      // remove temp file
      System.IO.File.Delete(temp);
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
