using System;
using System.Collections.Generic;
using System.Text;

namespace M6.Business
{
	public class Skip : ISkip
	{
		protected int _val;
		public Skip(int val) { _val = val; }
		public virtual int Value
		{
			get { return _val; }
			set { _val = value; }
		}
		public object Clone() { return new Skip(this.Value); }
		public IDataSkip DataSkip() { return new DataSkip(_val); }
	}
	public class DataSkip : IDataSkip
	{
		protected int _val;
		public DataSkip() { }
		public DataSkip(int val) { _val = val; }
		public virtual string ToSql()
		{
			return "OFFSET " + _val.ToString() + " ROWS";
		}
		public virtual int Value
		{
			get { return _val; }
			set { _val = value; }
		}
	}
}
