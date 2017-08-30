using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Word;

namespace CoverLetterGenerator
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            this.richTextBox1.Text = getLetterText();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private string getLetterText()
        {
            var app = new Microsoft.Office.Interop.Word.Application();
            var doc = app.Documents.Open("E:\\Users\\Kevin Lee\\Documents\\cover letters\\kevin_lee_software_general.docx");

            string text = doc.Range().Text;

            doc.Save();
            doc.Close();

            Marshal.ReleaseComObject(doc);
            Marshal.ReleaseComObject(app);

            return text;
        }

        private void GenerateLetter(object sender, EventArgs e)
        {
            
        }

        private void PreviewLetter(object sender, EventArgs e)
        {

        }

        private void textBoxEnter(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            switch (text.Text)
            {
                case "<insert date>":
                    textBox5.Text = "";
                    break;
                case "<insert company name>":
                    textBox4.Text = "";
                    break;
                case "<insert company address>":
                    textBox3.Text = "";
                    break;
                case "<insert position title>":
                    textBox2.Text = "";
                    break;
                case "<insert flavour text>":
                    textBox1.Text = "";
                    break;
            }
        }

        private void textBoxLeave(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            switch (text.Name)
            {
                case "textBox5":
                    if (textBox5.Text.Equals(""))
                    {
                        textBox5.Text = "<insert date>";
                    }
                    break;
                case "textBox4":
                    if (textBox4.Text.Equals(""))
                    {
                        textBox4.Text = "<insert company name>";
                    }
                    break;
                case "textBox3":
                    if (textBox3.Text.Equals(""))
                    {
                        textBox3.Text = "<insert company address>";
                    }
                    break;
                case "textBox2":
                    if (textBox2.Text.Equals(""))
                    {
                        textBox2.Text = "<insert position title>";
                    }
                    break;
                case "textBox1":
                    if (textBox1.Text.Equals(""))
                    {
                        textBox1.Text = "<insert flavour text>";
                    }
                    break;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
