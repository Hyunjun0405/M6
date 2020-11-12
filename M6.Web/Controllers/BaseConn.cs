using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace M6.Web.Controllers
{
	public partial class BaseConn : IDisposable
	{
		#region members		
		static string _staticConnectionString;
		bool _isDisposed = false;
		#endregion

		#region initialisation
		public BaseConn()
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

		#region connection support
		public static SqlConnection StaticSqlConnection
		{
			get
			{
				SqlConnection staticConnection = new SqlConnection();
				staticConnection.ConnectionString = StaticConnectionString;
				return staticConnection;
			}
		}


		public static string StaticConnectionString
		{
			set { _staticConnectionString = value; }
			get
			{
				if (!string.IsNullOrEmpty(_staticConnectionString))
					return _staticConnectionString;

				//return "Data Source=172.17.6.65,1942;Initial Catalog=M6;Persist Security Info=True;User ID=mode_jun;Password=M0detour!!";
				return @"Data Source=DESKTOP-GUKSU2D\SQLEXPRESS;Initial Catalog=M6;Integrated Security=True";
				//return ConfigWrapper.GetConnectionString("c8ed55d4-9993-47df-a4fb-d697b9b3d83d");
			}
		}
		#endregion	
	}
}