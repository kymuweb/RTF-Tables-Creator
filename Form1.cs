using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTF_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RichTextBox richTextBox = new System.Windows.Forms.RichTextBox();
            richTextBox.Font = new Font("Arial", 18f, FontStyle.Bold);

            // We will use a string builder to contain the table
            StringBuilder tableRtf = new StringBuilder();

            // Beginning of rich text format            
            tableRtf.Append(@"{\rtf1\ansi\deff0 ");

            // Create rows
            for (int i = 0; i < 5; i++)
            {

                tableRtf.Append(@"\trowd");

                // Cells with width 2000.
                tableRtf.Append(@"\cellx2000");

                tableRtf.Append(@"\cellx4000");

                tableRtf.Append(@"\cellx6000");

                tableRtf.Append(@"\intbl Item 1 \cell Item 2 \cell Item 3 \row"); //create row

            }

            tableRtf.Append(@"}");
            richTextBox.Rtf = tableRtf.ToString();

            richTextBox.AppendText(Environment.NewLine + "End of document");

            richTextBox.SaveFile(textBox1.Text, RichTextBoxStreamType.RichText);
        }
    }
}
