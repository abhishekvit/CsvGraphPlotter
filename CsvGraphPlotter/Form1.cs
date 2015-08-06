using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Data;

namespace CsvGraphPlotter
{
    public partial class Form1 : Form
    {
       // static string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr=new int[100];
            string path;
            int c = 0;
            OpenFileDialog obj = new OpenFileDialog();
            if (obj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = obj.FileName;
                //Func();
               MessageBox.Show(path);
               var reader = new StreamReader(File.OpenRead(@path));
               List<string> listA = new List<string>();
               List<string> listB = new List<string>();
              
               while (!reader.EndOfStream)
               {
                   var line = reader.ReadLine();
                   var values = line.Split(',');
                  
                   if (c > 0)
                   {
                       listA.Add(values[0]);
                       int a = Convert.ToInt32(values[0]);
                      // a++;
                       arr[c - 1] = a;
                       values[0].ToString();
                       //MessageBox.Show(arr[c-1].ToString());
                   }
                   c++;

                   //listB.Add(values[1]);
               }
               //MessageBox.Show(values[0]);
               /* StreamReader oStreamReader = new StreamReader(@path);
                DataTable oDataTable = new DataTable();
                int rc = 0;
                string[] columnnames = null;
                string[] oStreamDataValues = null;
                while (!oStreamReader.EndOfStream)
                {
                    string oStreamRowData = oStreamReader.ReadLine().Trim();
                    if (oStreamRowData.Length > 0)
                    {
                        oStreamDataValues = oStreamRowData.Split(',');
                        if (rc == 0)
                        {
                            rc = 1;
                            columnnames = oStreamDataValues;
                            foreach (string csvHeader in columnnames)
                            {
                                DataColumn oDataColumn = new DataColumn(csvHeader.ToUpper(), typeof(String));
                                oDataColumn.DefaultValue = string.Empty;
                                oDataTable.Columns.Add(oDataColumn);
                            }

                        }

                        else
                        {

                            DataRow oDataRow = oDataTable.NewRow();
                            for (int i = 0; i < columnnames.Length; i++)
                            {
                                oDataRow[columnnames[i]] = oStreamDataValues[i] == null ? string.Empty : oStreamDataValues[i].ToString();

                            }
                            oDataTable.Rows.Add(oDataRow);


                        }
                    }
                }*/
               /* oStreamReader.Close();
                oStreamReader.Dispose();
                foreach (DataRow dr in oDataTable.Rows)
                {

                    foreach (string csvCoulumns in columnnames)
                    {
                        dr[csvCoulumns] = dr[csvCoulumns];
                        MessageBox.Show(dr[csvCoulumns].ToString());
                    }
                }*/
            }
            //MessageBox.Show(path);
            for (int i = 0; i <= c; i++)
            {
                this.chart1.Series["Value"].Points.AddXY("max",arr[i]);
            }

        }

       
    }
}
