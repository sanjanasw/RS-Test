using LumenWorks.Framework.IO.Csv;
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

namespace RS_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //open data
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"C:\book1.csv")), true))
            {
                csvTable.Load(csvReader);
            }

            //create object to pass data to database
            DataToDB ToDb = new DataToDB();


            //going troug dataset
            for (int i = 0; i < csvTable.Rows.Count; i++)
            {

                ToDb.addData((i+1), csvTable.Rows[i][0].ToString(), csvTable.Rows[i][1].ToString(), csvTable.Rows[i][2].ToString(), csvTable.Rows[i][3].ToString());
                                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataToDB ToDb = new DataToDB();
            ToDb.delData();
        }
    }
}
