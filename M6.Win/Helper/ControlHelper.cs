using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6.Win
{
    class ControlHelper
    {
        public static void BindingDataToControl<T>(DevExpress.XtraEditors.LookUpEdit control, List<T> list, string codeName, string code)
        {
            if (control.GetType() == typeof(DevExpress.XtraEditors.LookUpEdit))
            {
                Console.WriteLine(typeof(DevExpress.XtraEditors.LookUpEdit).ToString());
            }

            LookUpColumnInfo col = new LookUpColumnInfo(codeName);
            control.Properties.Columns.Clear();

            control.Properties.DataSource = list;
            control.Properties.DisplayMember = codeName;
            control.Properties.ValueMember = code;
            control.Properties.Columns.Add(col);
            control.EditValue = string.Empty;

            control.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            control.Properties.NullText = string.Empty;
            control.Properties.ShowFooter = false;
            control.Properties.ShowHeader = false;
            control.Properties.ShowLines = false;
        }
    }
}
