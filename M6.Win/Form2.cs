using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net.Http;

namespace M6.Win
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            //string url = @"https://localhost:44341/api/DateSet/GetDataSet";

            //using (var client = new HttpClient())
            //{
            //    using (var response = client.GetAsync(url))
            //    {                   

            //            gridControl1.DataSource = response;
            //        }
            //    }


            //}
        }
    }
}