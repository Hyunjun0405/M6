﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using M6.Data;
using M6.Data.Models;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;

namespace M6.Win
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard               
            comboBoxEdit1.EditValueChanged += new System.EventHandler(SetValue);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            comboBoxEdit1.Properties.Items.Clear();

           var 코드리스트 = from u in global.코드리스트 where u.종류 == "공항" select u;

            foreach (기초코드 v in 코드리스트)
            {
                comboBoxEdit1.Properties.Items.Add(v.코드명);
            }           

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = typeof(상품);
            bs.AddNew();
            dataLayoutControl1.FieldRetrieving += dataLayoutControl1_FieldRetrieving;
            dataLayoutControl1.FieldRetrieved += DataLayoutControl1_FieldRetrieved;
            dataLayoutControl1.DataSource = bs;

            dataLayoutControl1.RetrieveFields();
        }

       

        private void dataLayoutControl1_FieldRetrieving(object sender, FieldRetrievingEventArgs e)
        {
            if (e.FieldName == "상품종류")
                e.EditorType = typeof(LookUpEdit);
            e.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            e.Handled = true;
        }

        private void DataLayoutControl1_FieldRetrieved(object sender, FieldRetrievedEventArgs e)
        {
            if (e.FieldName == "상품종류")
            {
                //ControlHelper.BindingDataToControl<기초코드>
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            global.RefreshData();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var rs = global.GetCodeValue("",comboBoxEdit1.Text);
            Console.WriteLine(rs);
        }

        private void SetValue(object sender, EventArgs e)
        {
            var rs = global.GetCodeValue("", comboBoxEdit1.Text);
            textBox1.Text = rs;

            //ControlHelper.BindingDataToControl(this.lookUpEdit1);
        }

    }
}