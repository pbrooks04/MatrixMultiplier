using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.Xml.XPath;

namespace MatrixMultiplierForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            // Run .exe with txtInput as arg
            string arg = txtInput.Text;
            // I'll assume the exe is in the same path
            try
            {
                //Process cppMatMul = Process.Start("\"C:\\Users\\Peter Brooks\\source\\repos\\MatrixMultiplier\\Debug\\MatrixMultiplier.exe\"", arg);
                Process cppMatMul = Process.Start("MatrixMultiplier.exe", arg);
                // Wait for process to finish
                cppMatMul.WaitForExit();

                // Open output file
                XmlDocument out_file = new XmlDocument();
                out_file.Load("MatrixMultiplierOutput.xml");

                XmlNodeList matrix_data = out_file.GetElementsByTagName("row");

                for (int i=0; i < matrix_data.Count; ++i)
                {
                    XmlNodeList row_data = matrix_data[i].ChildNodes;
                    for (int j=0; j < row_data.Count; ++j)
                    {
                        txtOutput.Text += row_data[j].InnerText + "  ";
                    }
                    txtOutput.Text += Environment.NewLine;
                }

            } catch (Exception ex)
            {
                txtOutput.Text += "An error occured\n" + Environment.NewLine;
                txtOutput.Text += ex.Message + Environment.NewLine;
                txtOutput.Text += arg;
            }
            // Display results
        }
    }
}
