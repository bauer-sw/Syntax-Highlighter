using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace SyntaxHighlighter
{
  public partial class PowerPointAddIn
  {
    private void PowerPointAddIn_Startup(object sender, System.EventArgs e)
    {
      Globals.Ribbons.Ribbon.LoadSettings();
    }

    private void PowerPointAddIn_Shutdown(object sender, System.EventArgs e)
    {
      Globals.Ribbons.Ribbon.SaveSettings();
    }

    #region Von VSTO generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InternalStartup()
    {
      this.Startup += new System.EventHandler(PowerPointAddIn_Startup);
      this.Shutdown += new System.EventHandler(PowerPointAddIn_Shutdown);
    }

    #endregion
  }
}
