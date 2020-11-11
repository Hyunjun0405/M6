using System;
using System.Collections.Generic;
using System.Text;

namespace M6.Business
{
	public class Take : ITake
	{
		protected int _val;
		public Take(int val) { _val = val; }
		public virtual int Value
		{
			get { return _val; }
			set { _val = value; }
		}
		public object Clone() { return new Take(this.Value); }
		public IDataTake DataTake() { return new DataTake(_val); }
	}

	public class DataTake : IDataTake
	{
		protected int _val;
		public DataTake() { }
		public DataTake(int val) { _val = val; }
		public virtual string ToSql()
		{
			return "FETCH NEXT " + _val.ToString() + " ROWS ONLY ";
		}
		public virtual int Value
		{
			get { return _val; }
			set { _val = value; }
		}
	}
}
