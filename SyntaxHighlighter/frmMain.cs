using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SyntaxHighlighter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        List<string> m_strLang = new List<string>()
        {
            "as3",
            "bash",
            "cf",
            "csharp",
            "cpp",
            "css",
            "delphi",
            "diff",
            "erl",
            "groovy",
            "js",
            "java",
            "jfx",
            "pl",
            "php",
            "ps",
            "py",
            "ruby",
            "sql",
            "vb",
            "xml"
        };

        int m_iSelected = -1;
        private void frmMain_Load(object sender, EventArgs e)
        {
            cbLanguage.SelectedIndex = 3;
            m_iSelected = 3;

        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_iSelected = ((ComboBox)sender).SelectedIndex;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            string str = "";

            

            if (rbCDATA.Checked)
            {
                str = "<script type=\"syntaxhighlighter\" class=\"brush: " + m_strLang[m_iSelected] + "\"><![CDATA[" + Environment.NewLine + txtSource.Text + Environment.NewLine + "]]></script>" + Environment.NewLine;
            }
            else if (rbPre.Checked)
            {
                str = "<pre class=\"brush: " + m_strLang[m_iSelected] + "\">" + Environment.NewLine + txtSource.Text + Environment.NewLine + "</pre>" + Environment.NewLine;
            }
            if (cbIsDynamic.Checked)
            {
                str += Environment.NewLine + "<script type=\"text/javascript\">" + Environment.NewLine + "SyntaxHighlighter.highlight();" + Environment.NewLine + "</script>";
            }
            txtCode.Text = str;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtCode.Text);
            MessageBox.Show("Copied");
        }

    }
}
