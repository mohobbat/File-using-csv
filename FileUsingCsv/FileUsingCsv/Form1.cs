using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace FileUsingCsv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string filelocation = @"Only save.csv";
        private string amount;
        private string category;
        private string practicular;
        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(filelocation, FileMode.OpenOrCreate);

            List<string>aExpressList=new List<string>();

            amount = amountTextBox.Text;
            category = categoryComboBox.Text;
            practicular = particularTextBox.Text;

            CsvFileReader

        }
    }
}
