using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
    }
      OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PartiOy.mdb");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'partiOyDataSet.Oy' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oyTableAdapter.Fill(this.partiOyDataSet.Oy);
            pieChart1.LegendLocation = LegendLocation.Bottom;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Func<ChartPoint, string> fu = x => string.Format("{0}{1:P}", x.Y, x.Participation);
                SeriesCollection series = new SeriesCollection();
                foreach(var item in partiOyDataSet.Oy)
                {
                    PieSeries pie = new PieSeries();
                    pie.Title = item.Parti_Name;
                    pie.Values = new ChartValues<int> { item.Oy_Oran };
                    pie.DataLabels = true;
                    pie.LabelPoint = fu;
                    series.Add(pie);
                    pieChart1.Series = series;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Database connection error" + ex);
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
