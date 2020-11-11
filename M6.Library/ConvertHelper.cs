using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6.Library
{
    class ConvertHelper :  IDisposable
    {
        bool _isDisposed = false;   
        protected Hashtable _hashtable;
        protected object[,] _objectArray;
        protected Dictionary<string, object> _dictionay;


        #region initialisation
        public ConvertHelper()
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
