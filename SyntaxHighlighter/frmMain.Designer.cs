namespace SyntaxHighlighter
{
    partial class frmMain
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
            this.lblAbout = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblPasteCode = new System.Windows.Forms.Label();
            this.pnlCon = new System.Windows.Forms.Panel();
            this.cbIsDynamic = new System.Windows.Forms.CheckBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.gbCodeClass = new System.Windows.Forms.GroupBox();
            this.rbPre = new System.Windows.Forms.RadioButton();
            this.rbCDATA = new System.Windows.Forms.RadioButton();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.txtSH = new System.Windows.Forms.TextBox();
            this.txtGN = new System.Windows.Forms.TextBox();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.pnlCon.SuspendLayout();
            this.gbCodeClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAbout.Location = new System.Drawing.Point(0, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(826, 86);
            this.lblAbout.TabIndex = 10;
            this.lblAbout.Text = "SyntaxHighlighter HTML Code Generator\r\n\r\n* You must first install the necessary c" +
                "ode - Visit here : http://alexgorbatchev.com/SyntaxHighlighter/\r\n\r\nMade By GaryN" +
                "g @ http://garyngzhongbo.blogspot.com/";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(3, 25);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSource.Size = new System.Drawing.Size(403, 134);
            this.txtSource.TabIndex = 1;
            // 
            // lblPasteCode
            // 
            this.lblPasteCode.AutoSize = true;
            this.lblPasteCode.Location = new System.Drawing.Point(3, 11);
            this.lblPasteCode.Name = "lblPasteCode";
            this.lblPasteCode.Size = new System.Drawing.Size(126, 13);
            this.lblPasteCode.TabIndex = 0;
            this.lblPasteCode.Text = "Paste Your Code Here : ";
            // 
            // pnlCon
            // 
            this.pnlCon.Controls.Add(this.chkAuto);
            this.pnlCon.Controls.Add(this.cbIsDynamic);
            this.pnlCon.Controls.Add(this.btnCopy);
            this.pnlCon.Controls.Add(this.txtCode);
            this.pnlCon.Controls.Add(this.btnGen);
            this.pnlCon.Controls.Add(this.gbCodeClass);
            this.pnlCon.Controls.Add(this.cbLanguage);
            this.pnlCon.Controls.Add(this.lblLanguage);
            this.pnlCon.Controls.Add(this.lblPasteCode);
            this.pnlCon.Controls.Add(this.txtSource);
            this.pnlCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCon.Location = new System.Drawing.Point(0, 86);
            this.pnlCon.Name = "pnlCon";
            this.pnlCon.Size = new System.Drawing.Size(826, 351);
            this.pnlCon.TabIndex = 2;
            // 
            // cbIsDynamic
            // 
            this.cbIsDynamic.AutoSize = true;
            this.cbIsDynamic.Location = new System.Drawing.Point(12, 267);
            this.cbIsDynamic.Name = "cbIsDynamic";
            this.cbIsDynamic.Size = new System.Drawing.Size(169, 17);
            this.cbIsDynamic.TabIndex = 6;
            this.cbIsDynamic.Text = "Blogger with dynamic views";
            this.cbIsDynamic.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(427, 290);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(385, 40);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy To Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(427, 8);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCode.Size = new System.Drawing.Size(385, 276);
            this.txtCode.TabIndex = 9;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(12, 290);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(394, 40);
            this.btnGen.TabIndex = 7;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // gbCodeClass
            // 
            this.gbCodeClass.Controls.Add(this.rbPre);
            this.gbCodeClass.Controls.Add(this.rbCDATA);
            this.gbCodeClass.Location = new System.Drawing.Point(6, 189);
            this.gbCodeClass.Name = "gbCodeClass";
            this.gbCodeClass.Size = new System.Drawing.Size(400, 72);
            this.gbCodeClass.TabIndex = 4;
            this.gbCodeClass.TabStop = false;
            // 
            // rbPre
            // 
            this.rbPre.AutoSize = true;
            this.rbPre.Checked = true;
            this.rbPre.Location = new System.Drawing.Point(6, 21);
            this.rbPre.Name = "rbPre";
            this.rbPre.Size = new System.Drawing.Size(114, 17);
            this.rbPre.TabIndex = 4;
            this.rbPre.TabStop = true;
            this.rbPre.Text = "use <Pre></Pre>";
            this.rbPre.UseVisualStyleBackColor = true;
            // 
            // rbCDATA
            // 
            this.rbCDATA.AutoSize = true;
            this.rbCDATA.Location = new System.Drawing.Point(6, 44);
            this.rbCDATA.Name = "rbCDATA";
            this.rbCDATA.Size = new System.Drawing.Size(101, 17);
            this.rbCDATA.TabIndex = 5;
            this.rbCDATA.Text = "use ![CDATA[..]]";
            this.rbCDATA.UseVisualStyleBackColor = true;
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "ActionScript3",
            "Bash/Shell",
            "ColdFusion",
            "C#",
            "C++",
            "CSS",
            "Delphi",
            "Diff",
            "Erlang",
            "Groovy",
            "Javascript",
            "Java",
            "JavaFX",
            "Perl",
            "PHP",
            "Plain Text",
            "PHP",
            "Power Shell",
            "Python",
            "Ruby",
            "Scala",
            "SQL",
            "Visual Basic",
            "XML"});
            this.cbLanguage.Location = new System.Drawing.Point(109, 165);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(121, 21);
            this.cbLanguage.TabIndex = 3;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(3, 168);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(100, 13);
            this.lblLanguage.TabIndex = 2;
            this.lblLanguage.Text = "Select Language : ";
            // 
            // txtSH
            // 
            this.txtSH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSH.Location = new System.Drawing.Point(435, 36);
            this.txtSH.Name = "txtSH";
            this.txtSH.ReadOnly = true;
            this.txtSH.Size = new System.Drawing.Size(247, 22);
            this.txtSH.TabIndex = 11;
            this.txtSH.Text = "http://alexgorbatchev.com/SyntaxHighlighter/";
            // 
            // txtGN
            // 
            this.txtGN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGN.Location = new System.Drawing.Point(367, 61);
            this.txtGN.Name = "txtGN";
            this.txtGN.ReadOnly = true;
            this.txtGN.Size = new System.Drawing.Size(204, 22);
            this.txtGN.TabIndex = 12;
            this.txtGN.Text = "http://garyngzhongbo.blogspot.com/";
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Checked = true;
            this.chkAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuto.Location = new System.Drawing.Point(187, 267);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(148, 17);
            this.chkAuto.TabIndex = 10;
            this.chkAuto.Text = "Auto Copy to Clipboard";
            this.chkAuto.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 437);
            this.Controls.Add(this.txtGN);
            this.Controls.Add(this.txtSH);
            this.Controls.Add(this.pnlCon);
            this.Controls.Add(this.lblAbout);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "SyntaxHighlighter - HTML Code Generator ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlCon.ResumeLayout(false);
            this.pnlCon.PerformLayout();
            this.gbCodeClass.ResumeLayout(false);
            this.gbCodeClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblPasteCode;
        private System.Windows.Forms.Panel pnlCon;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.GroupBox gbCodeClass;
        private System.Windows.Forms.RadioButton rbPre;
        private System.Windows.Forms.RadioButton rbCDATA;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.CheckBox cbIsDynamic;
        private System.Windows.Forms.TextBox txtSH;
        private System.Windows.Forms.TextBox txtGN;
        private System.Windows.Forms.CheckBox chkAuto;
    }
}

