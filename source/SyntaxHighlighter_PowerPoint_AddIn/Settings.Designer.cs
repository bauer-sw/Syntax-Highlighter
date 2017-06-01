namespace SyntaxHighlighter
{
  partial class Settings
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabLanguages = new System.Windows.Forms.TabPage();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.languages = new System.Windows.Forms.CheckedListBox();
      this.tabPaths = new System.Windows.Forms.TabPage();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.label2 = new System.Windows.Forms.Label();
      this.php = new System.Windows.Forms.TextBox();
      this.phpBtn = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.geshi = new System.Windows.Forms.TextBox();
      this.geshiBtn = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.cli = new System.Windows.Forms.TextBox();
      this.cliBtn = new System.Windows.Forms.Button();
      this.geshiLangBtn = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.geshiLang = new System.Windows.Forms.TextBox();
      this.tabAbout = new System.Windows.Forms.TabPage();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tabExtra = new System.Windows.Forms.TabPage();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.label9 = new System.Windows.Forms.Label();
      this.tabWidth = new System.Windows.Forms.NumericUpDown();
      this.label10 = new System.Windows.Forms.Label();
      this.markerExtraHighlightedLines = new System.Windows.Forms.TextBox();
      this.openFileDialogExe = new System.Windows.Forms.OpenFileDialog();
      this.openFileDialogPHP = new System.Windows.Forms.OpenFileDialog();
      this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.cancelBtn = new System.Windows.Forms.Button();
      this.okBtn = new System.Windows.Forms.Button();
      this.tabControl.SuspendLayout();
      this.tabLanguages.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tabPaths.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tabAbout.SuspendLayout();
      this.tabExtra.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tabWidth)).BeginInit();
      this.tableLayoutPanel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      this.tabControl.Controls.Add(this.tabLanguages);
      this.tabControl.Controls.Add(this.tabPaths);
      this.tabControl.Controls.Add(this.tabExtra);
      this.tabControl.Controls.Add(this.tabAbout);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
      this.tabControl.Location = new System.Drawing.Point(0, 0);
      this.tabControl.Multiline = true;
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(355, 360);
      this.tabControl.TabIndex = 1;
      // 
      // tabLanguages
      // 
      this.tabLanguages.Controls.Add(this.tableLayoutPanel1);
      this.tabLanguages.Location = new System.Drawing.Point(4, 22);
      this.tabLanguages.Name = "tabLanguages";
      this.tabLanguages.Padding = new System.Windows.Forms.Padding(3);
      this.tabLanguages.Size = new System.Drawing.Size(347, 334);
      this.tabLanguages.TabIndex = 0;
      this.tabLanguages.Text = "Languages";
      this.tabLanguages.UseVisualStyleBackColor = true;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.languages, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 328);
      this.tableLayoutPanel1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(160, 39);
      this.label1.TabIndex = 1;
      this.label1.Text = "Select your prefered languages. \r\nOther languages are invisible \r\nat the ribbon d" +
    "rop down box.";
      // 
      // languages
      // 
      this.languages.CheckOnClick = true;
      this.languages.Dock = System.Windows.Forms.DockStyle.Fill;
      this.languages.FormattingEnabled = true;
      this.languages.Location = new System.Drawing.Point(3, 42);
      this.languages.Name = "languages";
      this.languages.Size = new System.Drawing.Size(335, 283);
      this.languages.Sorted = true;
      this.languages.TabIndex = 0;
      // 
      // tabPaths
      // 
      this.tabPaths.Controls.Add(this.tableLayoutPanel2);
      this.tabPaths.Location = new System.Drawing.Point(4, 22);
      this.tabPaths.Name = "tabPaths";
      this.tabPaths.Padding = new System.Windows.Forms.Padding(3);
      this.tabPaths.Size = new System.Drawing.Size(347, 334);
      this.tabPaths.TabIndex = 1;
      this.tabPaths.Text = "Paths";
      this.tabPaths.UseVisualStyleBackColor = true;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.php, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.phpBtn, 2, 0);
      this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.geshi, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.geshiBtn, 2, 1);
      this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
      this.tableLayoutPanel2.Controls.Add(this.cli, 1, 4);
      this.tableLayoutPanel2.Controls.Add(this.cliBtn, 2, 4);
      this.tableLayoutPanel2.Controls.Add(this.geshiLangBtn, 2, 3);
      this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
      this.tableLayoutPanel2.Controls.Add(this.geshiLang, 1, 3);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 6;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(341, 328);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Location = new System.Drawing.Point(3, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(94, 29);
      this.label2.TabIndex = 0;
      this.label2.Text = "PHP Interpreter\r\nphp.exe";
      // 
      // php
      // 
      this.php.Dock = System.Windows.Forms.DockStyle.Fill;
      this.php.Location = new System.Drawing.Point(103, 3);
      this.php.Name = "php";
      this.php.Size = new System.Drawing.Size(205, 20);
      this.php.TabIndex = 1;
      // 
      // phpBtn
      // 
      this.phpBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.phpBtn.Location = new System.Drawing.Point(314, 3);
      this.phpBtn.Name = "phpBtn";
      this.phpBtn.Size = new System.Drawing.Size(24, 23);
      this.phpBtn.TabIndex = 2;
      this.phpBtn.Text = "...";
      this.phpBtn.UseVisualStyleBackColor = true;
      this.phpBtn.Click += new System.EventHandler(this.phpBtn_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Location = new System.Drawing.Point(3, 29);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(94, 29);
      this.label3.TabIndex = 3;
      this.label3.Text = "GeSHi Script\r\ngeshi.php";
      // 
      // geshi
      // 
      this.geshi.Dock = System.Windows.Forms.DockStyle.Fill;
      this.geshi.Location = new System.Drawing.Point(103, 32);
      this.geshi.Name = "geshi";
      this.geshi.Size = new System.Drawing.Size(205, 20);
      this.geshi.TabIndex = 5;
      // 
      // geshiBtn
      // 
      this.geshiBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.geshiBtn.Location = new System.Drawing.Point(314, 32);
      this.geshiBtn.Name = "geshiBtn";
      this.geshiBtn.Size = new System.Drawing.Size(24, 23);
      this.geshiBtn.TabIndex = 7;
      this.geshiBtn.Text = "...";
      this.geshiBtn.UseVisualStyleBackColor = true;
      this.geshiBtn.Click += new System.EventHandler(this.geshiBtn_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label4.Location = new System.Drawing.Point(3, 87);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(94, 29);
      this.label4.TabIndex = 4;
      this.label4.Text = "AddIn CLI Script\r\ncli.php";
      // 
      // cli
      // 
      this.cli.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cli.Location = new System.Drawing.Point(103, 90);
      this.cli.Name = "cli";
      this.cli.Size = new System.Drawing.Size(205, 20);
      this.cli.TabIndex = 10;
      // 
      // cliBtn
      // 
      this.cliBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cliBtn.Location = new System.Drawing.Point(314, 90);
      this.cliBtn.Name = "cliBtn";
      this.cliBtn.Size = new System.Drawing.Size(24, 23);
      this.cliBtn.TabIndex = 8;
      this.cliBtn.Text = "...";
      this.cliBtn.UseVisualStyleBackColor = true;
      this.cliBtn.Click += new System.EventHandler(this.cliBtn_Click);
      // 
      // geshiLangBtn
      // 
      this.geshiLangBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.geshiLangBtn.Location = new System.Drawing.Point(314, 61);
      this.geshiLangBtn.Name = "geshiLangBtn";
      this.geshiLangBtn.Size = new System.Drawing.Size(24, 23);
      this.geshiLangBtn.TabIndex = 11;
      this.geshiLangBtn.Text = "...";
      this.geshiLangBtn.UseVisualStyleBackColor = true;
      this.geshiLangBtn.Click += new System.EventHandler(this.geshiLangBtn_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label5.Location = new System.Drawing.Point(3, 58);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(94, 29);
      this.label5.TabIndex = 12;
      this.label5.Text = "GeSHi Languages\r\n/geshi/";
      // 
      // geshiLang
      // 
      this.geshiLang.Dock = System.Windows.Forms.DockStyle.Fill;
      this.geshiLang.Location = new System.Drawing.Point(103, 61);
      this.geshiLang.Name = "geshiLang";
      this.geshiLang.Size = new System.Drawing.Size(205, 20);
      this.geshiLang.TabIndex = 13;
      // 
      // tabAbout
      // 
      this.tabAbout.Controls.Add(this.label8);
      this.tabAbout.Controls.Add(this.label7);
      this.tabAbout.Controls.Add(this.label6);
      this.tabAbout.Location = new System.Drawing.Point(4, 22);
      this.tabAbout.Name = "tabAbout";
      this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
      this.tabAbout.Size = new System.Drawing.Size(347, 334);
      this.tabAbout.TabIndex = 2;
      this.tabAbout.Text = "About";
      this.tabAbout.UseVisualStyleBackColor = true;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(8, 77);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(222, 13);
      this.label8.TabIndex = 3;
      this.label8.Text = "Mircosoft PowerPoint Add-In written by bauer-sw.de";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(8, 36);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(193, 26);
      this.label7.TabIndex = 2;
      this.label7.Text = "For syntax highlighting was used \r\nthe GeSHi - Generic Syntax Highlighter.";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(8, 13);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(222, 13);
      this.label6.TabIndex = 0;
      this.label6.Text = "Icons designed by Madebyoliver from Flaticon";
      // 
      // tabExtra
      // 
      this.tabExtra.Controls.Add(this.tableLayoutPanel4);
      this.tabExtra.Location = new System.Drawing.Point(4, 22);
      this.tabExtra.Name = "tabExtra";
      this.tabExtra.Padding = new System.Windows.Forms.Padding(3);
      this.tabExtra.Size = new System.Drawing.Size(347, 334);
      this.tabExtra.TabIndex = 3;
      this.tabExtra.Text = "Extra";
      this.tabExtra.UseVisualStyleBackColor = true;
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 2;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
      this.tableLayoutPanel4.Controls.Add(this.tabWidth, 1, 0);
      this.tableLayoutPanel4.Controls.Add(this.label10, 0, 1);
      this.tableLayoutPanel4.Controls.Add(this.markerExtraHighlightedLines, 1, 1);
      this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 2;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(341, 328);
      this.tableLayoutPanel4.TabIndex = 0;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(3, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(57, 13);
      this.label9.TabIndex = 0;
      this.label9.Text = "Tab width:";
      // 
      // tabWidth
      // 
      this.tabWidth.Location = new System.Drawing.Point(94, 3);
      this.tabWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.tabWidth.Name = "tabWidth";
      this.tabWidth.Size = new System.Drawing.Size(50, 20);
      this.tabWidth.TabIndex = 1;
      this.tabWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(3, 26);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(85, 26);
      this.label10.TabIndex = 2;
      this.label10.Text = "Marker for extra\r\nhighlighted lines:";
      // 
      // markerExtraHighlightedLines
      // 
      this.markerExtraHighlightedLines.Location = new System.Drawing.Point(94, 29);
      this.markerExtraHighlightedLines.Name = "markerExtraHighlightedLines";
      this.markerExtraHighlightedLines.Size = new System.Drawing.Size(100, 20);
      this.markerExtraHighlightedLines.TabIndex = 3;
      // 
      // openFileDialogExe
      // 
      this.openFileDialogExe.FileName = "openFileDialogExe";
      this.openFileDialogExe.Filter = "EXE-Dateien|*.exe";
      // 
      // openFileDialogPHP
      // 
      this.openFileDialogPHP.FileName = "openFileDialogPHP";
      this.openFileDialogPHP.Filter = "PHP-Dateien|*.php";
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 3;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel3.Controls.Add(this.cancelBtn, 2, 0);
      this.tableLayoutPanel3.Controls.Add(this.okBtn, 1, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 356);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(355, 33);
      this.tableLayoutPanel3.TabIndex = 2;
      // 
      // cancelBtn
      // 
      this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cancelBtn.Location = new System.Drawing.Point(277, 3);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(75, 27);
      this.cancelBtn.TabIndex = 0;
      this.cancelBtn.Text = "Cancel";
      this.cancelBtn.UseVisualStyleBackColor = true;
      this.cancelBtn.Click += new System.EventHandler(this.button1_Click);
      // 
      // okBtn
      // 
      this.okBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.okBtn.Location = new System.Drawing.Point(196, 3);
      this.okBtn.Name = "okBtn";
      this.okBtn.Size = new System.Drawing.Size(75, 27);
      this.okBtn.TabIndex = 1;
      this.okBtn.Text = "Ok";
      this.okBtn.UseVisualStyleBackColor = true;
      this.okBtn.Click += new System.EventHandler(this.button2_Click);
      // 
      // Settings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(355, 389);
      this.Controls.Add(this.tableLayoutPanel3);
      this.Controls.Add(this.tabControl);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Settings";
      this.Text = "Settings";
      this.tabControl.ResumeLayout(false);
      this.tabLanguages.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tabPaths.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.tabAbout.ResumeLayout(false);
      this.tabAbout.PerformLayout();
      this.tabExtra.ResumeLayout(false);
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tabWidth)).EndInit();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabLanguages;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckedListBox languages;
    private System.Windows.Forms.TabPage tabPaths;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox php;
    private System.Windows.Forms.Button phpBtn;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox geshi;
    private System.Windows.Forms.Button geshiBtn;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox cli;
    private System.Windows.Forms.Button cliBtn;
    private System.Windows.Forms.Button geshiLangBtn;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox geshiLang;
    private System.Windows.Forms.OpenFileDialog openFileDialogExe;
    private System.Windows.Forms.OpenFileDialog openFileDialogPHP;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Button cancelBtn;
    private System.Windows.Forms.Button okBtn;
    private System.Windows.Forms.TabPage tabAbout;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TabPage tabExtra;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.NumericUpDown tabWidth;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox markerExtraHighlightedLines;
  }
}