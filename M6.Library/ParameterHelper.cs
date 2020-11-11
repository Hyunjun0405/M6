using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace M6.Data
{
    public class ParameterHelper : IDisposable
    {
        bool _isDisposed = false;

        protected SqlParameter[] _sqlParam;

        #region initialisation
        public ParameterHelper()
        {
            Init();
        }

        private void Init()
        {
        }
        #endregion

        #region disposable interface support
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (!_isDisposed)
            {
                if (isDisposing)
                {
                    if (_sqlParam != null)
                    {
                        _sqlParam = null;
                    }
                }
            }
            _isDisposed = true;
        }
        #endregion

        #region method
        public static SqlParameter[] GetParameters(DataTable _paramTable)
        {
            int i = 0;
            SqlParameter[]  _sqlParam = new SqlParameter[_paramTable.Rows.Count];

            foreach (DataRow dr in _paramTable.Rows)
            {

                _sqlParam[i] = new SqlParameter();
                _sqlParam[i].ParameterName = dr["컬럼명"].ToString();

                _sqlParam[i].Value = dr["값"].ToString();

                i++;

            }

            return _sqlParam;
        }
        public static SqlParameter[] GetParameters(Dictionary<string, object> _paramDic)
        {
            int i = 0;
            SqlParameter[]  _sqlParam = new SqlParameter[_paramDic.Count];

            foreach (string key in _paramDic.Keys)
            {

                _sqlParam[i] = new SqlParameter();
                _sqlParam[i].ParameterName = _paramDic[key].ToString();

                _sqlParam[i].Value = _paramDic[key];

                i++;

            }

            return _sqlParam;
        }

        public static SqlParameter[] GetParameters(Dictionary<string, string> _paramDic)
        {
            int i = 0;
            SqlParameter[] _sqlParam = new SqlParameter[_paramDic.Count];

            foreach (string key in _paramDic.Keys)
            {

                _sqlParam[i] = new SqlParameter();
                _sqlParam[i].ParameterName = _paramDic[key].ToString();

                _sqlParam[i].Value = _paramDic[key];

                i++;

            }

            return _sqlParam;
        }


        public static object[][] ConvertObjectArray(Hashtable ht)
        {

            object[][] obj = new object[ht.Count][];
            int i = 0;
            foreach (object key in ht.Keys)
            {
                obj[i] = new object[] { key, ht[key] };
                i++;
            }

            return obj;
        }

        public static Hashtable ConvertHashtable(object[][] obj)
        {
            Hashtable ht = new Hashtable(obj.Length);
            foreach (object[] pair in obj)
            {
                object key = pair[0];
                object value = pair[1];
                ht[key] = value;

            }

            return ht;
        }

        public static Dictionary<string, object> ConvertDictionary(Hashtable ht)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            int i = 0;
            foreach (object key in ht.Keys)
            {
                param.Add(key.ToString(), ht[key]);
                i++;
            }

            return param;
        }

        public static Dictionary<string, object> ConvertDictionary(object[][] obj)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            int i = 0;
            foreach (object[] key in obj)
            {
                param.Add(key[0].ToString(), key[1]);
                i++;
            }

            return param;
        }
        #endregion
    }


}