
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using M6.Data;


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
            memoEdit1.Text = "";
            memoEdit2.Text = "";
            //GetAllProducts();


        }

        //private async void GetAllProducts()
        //{           
        //}

        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {

            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //var t=Task.Run(() => M6.Win.Helper.CallAPI.PostBasicAsync(CommandType.Text, "SELECT TOP 10 번호,코드명,컬럼명 FROM 코드"));
            //t.Wait();

            
            //memoEdit1.Text = "";
            //memoEdit2.Text = "";

            //memoEdit1.Text = t.ToString();
            //memoEdit2.Text = t.Result.ToString();

        }
    }
}