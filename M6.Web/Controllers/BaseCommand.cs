using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace M6.Web.Controllers
{
    public class BaseCommand : BaseConn , IDisposable
    {

		#region members
		static string _procedure;		
		static CommandType _commandType;
		protected bool _isDisposed = false;
		protected static SqlCommand _sqlCommand;
		protected static SqlDataAdapter _sqlAdapter;
		protected static DataSet _dataSet;
        #endregion

        #region initialisation
        public BaseCommand()
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
					if (StaticSqlConnection != null)
					{
						/*this will also rollback any pending transactions on this connection*/
						StaticSqlConnection.Close();
						StaticSqlConnection.Dispose();
					}					
				}
			}
			_isDisposed = true;
		}
		#endregion

		public static DataSet StaticDataSet
		{
			get
			{
				_sqlCommand = new SqlCommand();			
				SqlConnection staticConnection = StaticSqlConnection;
				_sqlCommand.Connection = staticConnection;
				_sqlAdapter = new SqlDataAdapter(_sqlCommand);
				_dataSet = new DataSet();
				return _dataSet;
			}
		}

		public static string procedure
		{
			set { _procedure = value; }
			get
			{
				if (!string.IsNullOrEmpty(_procedure))
					return _procedure;

				return "";				
			}
		}

		public static CommandType commandType
		{
			set { _commandType = value; }
			get
			{
				return _commandType;				
			}
		}
	}
}