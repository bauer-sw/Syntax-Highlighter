namespace SyntaxHighlighter
{
  partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public Ribbon()
        : base(Globals.Factory.GetRibbonFactory())
    {
      InitializeComponent();
    }

    /// <summary> 
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">"true", wenn verwaltete Ressourcen gelöscht werden sollen, andernfalls "false".</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Komponenten-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für Designerunterstützung -
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.tab1 = this.Factory.CreateRibbonTab();
      this.group1 = this.Factory.CreateRibbonGroup();
      this.highlight = this.Factory.CreateRibbonButton();
      this.language = this.Factory.CreateRibbonComboBox();
      this.lineNumbers = this.Factory.CreateRibbonCheckBox();
      this.settings = this.Factory.CreateRibbonButton();
      this.tab1.SuspendLayout();
      this.group1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tab1
      // 
      this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
      this.tab1.Groups.Add(this.group1);
      this.tab1.Label = "TabAddIns";
      this.tab1.Name = "tab1";
      // 
      // group1
      // 
      this.group1.Items.Add(this.highlight);
      this.group1.Items.Add(this.language);
      this.group1.Items.Add(this.lineNumbers);
      this.group1.Items.Add(this.settings);
      this.group1.Label = "Syntax Highlighter";
      this.group1.Name = "group1";
      // 
      // highlight
      // 
      this.highlight.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
      this.highlight.Image = global::SyntaxHighlighter.Properties.Resources.photos;
      this.highlight.Label = "Highlight";
      this.highlight.Name = "highlight";
      this.highlight.ShowImage = true;
      this.highlight.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.highlight_Click);
      // 
      // language
      // 
      this.language.Label = "Language";
      this.language.Name = "language";
      this.language.Text = null;
      this.language.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.language_TextChanged);
      // 
      // lineNumbers
      // 
      this.lineNumbers.Checked = true;
      this.lineNumbers.Label = "Line numbers";
      this.lineNumbers.Name = "lineNumbers";
      this.lineNumbers.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.lineNumbers_Click);
      // 
      // settings
      // 
      this.settings.Image = global::SyntaxHighlighter.Properties.Resources.settings;
      this.settings.Label = "Settings";
      this.settings.Name = "settings";
      this.settings.ShowImage = true;
      this.settings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.settings_Click);
      // 
      // Ribbon
      // 
      this.Name = "Ribbon";
      this.RibbonType = "Microsoft.PowerPoint.Presentation";
      this.Tabs.Add(this.tab1);
      this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
      this.tab1.ResumeLayout(false);
      this.tab1.PerformLayout();
      this.group1.ResumeLayout(false);
      this.group1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
    internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
    internal Microsoft.Office.Tools.Ribbon.RibbonComboBox language;
    internal Microsoft.Office.Tools.Ribbon.RibbonButton highlight;
    internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox lineNumbers;
    internal Microsoft.Office.Tools.Ribbon.RibbonButton settings;
  }

  partial class ThisRibbonCollection
  {
    internal Ribbon Ribbon
    {
      get { return this.GetRibbon<Ribbon>(); }
    }
  }
}
