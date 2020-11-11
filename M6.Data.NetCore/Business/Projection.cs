using M6.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace M6
{
	public partial class Projection : IProjection
	{
		public Projection(string member) { Member = member; }
		public IDataProjection DataProjection() { return new DataProjection() { Member = this.Member }; }
		public string Member { get; set; }
	}

	public partial class DataProjection : IDataProjection
	{
		public virtual string Member { get; set; }
		public virtual string ToSql() { return "[" + Member + "]"; }
	}
}
