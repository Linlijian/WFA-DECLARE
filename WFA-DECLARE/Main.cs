using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_DECLARE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            var model = new SplitModel();
            
            model.FirstLoop = true;
            model.StringText = txt_from.Text;
            model.TextArea = model.StringText.Replace("\r\n", "").Replace("\t", "").Replace(",", "").Replace("[", "").Replace("]", "").Split(null);
            model.TextFindAll = model.StringText.Replace("\r\n", "")
                .Replace("[", "")
                .Replace("]", "")
                .Replace("\t", "")
                .Split(model.spearator, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                string last = model.TextFindAll.Last();

                foreach (var intem in model.TextFindAll)
                {
                    if (model.FirstLoop)
                    {
                        txt_toCur.Text = Text2Cur(intem, 114);
                        model.FirstLoop = false;
                    }
                    else
                    {
                        txt_toCur.Text += Text2Cur(intem, 114);
                    }
                   
                    if (last.Equals(intem))
                    {
                        DeleteLastComma();
                        model.StringText = txt_toCur.Text;
                        txt_toVal.Text = model.StringText.Replace("@C_", "@V_");
                    }
                }

                txt_toVal.Text = txt_toVal.Text.ToUpper();
                txt_toCur.Text = txt_toCur.Text.ToUpper();
            }
            catch (Exception ex)
            {
                string msg = "concut";
                MessageBox.Show("Check input text in format " + msg + " or null", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string Text2Cur(string txt, int type)
        {
            string t = string.Empty;
            if (type == 111)
            {
                t = txt + " ";
            }
            else if (type == 112)
            {
                t = txt;
            }
            else if (type == 113)
            {
                t = txt + " ";
            }
            else if (type == 114)
            {
                t = "@C_" + txt + ',' + "\r\n";
            }

            return t;
        }
        private void DeleteLastComma()
        {
            string t = txt_toCur.Text;
            txt_toCur.Text = t.Substring(0, t.Length - 3);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txt_toCur.Enabled = false;
            txt_toVal.Enabled = false;
        }

        private void btncopycursor_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_toCur.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_toVal.Text);
        }
    }
}
