using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6.Win.UserControl
{
    public interface IUserControl
    {
        bool U_IsNullable { get; set; }

        string U_IsNullableErrorText { get; set; }

        void RemoveValueCheck();

        string GetText();

        void SetFocus();

        void SetClear();
    }
}
