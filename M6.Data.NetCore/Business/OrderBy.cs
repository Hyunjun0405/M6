using System;
using System.Collections.Generic;
using System.Text;

namespace M6.Business
{
	public class OrderBy : IOrderBy
	{
		protected string _propertyName;
		protected OrderDirection _direction;
		public enum OrderDirection { Ascending = 1, Descending }
		public OrderBy(string propertyName, OrderDirection orderDirection)
		{
			_propertyName = propertyName;
			_direction = orderDirection;
		}
		public virtual string PropertyName
		{
			get { return _propertyName; }
			set { _propertyName = value; }
		}
		public virtual OrderDirection Direction
		{
			get { return _direction; }
			set { _direction = value; }
		}
		public static OrderBy Asc(string propertyName) { return new OrderBy(propertyName, OrderDirection.Ascending); }
		public static OrderBy Desc(string propertyName) { return new OrderBy(propertyName, OrderDirection.Descending); }
		public object Clone() { return new OrderBy(this.PropertyName, this.Direction); }
		public IDataOrderBy DataOrderBy() { return new DataOrderBy(this.PropertyName, this.Direction == OrderDirection.Ascending ? "ASC" : "DESC"); }
	}

	public class DataOrderBy : IDataOrderBy
	{
		protected string _propertyName;
		protected string _direction;
		public DataOrderBy() { }
		public DataOrderBy(string propertyName, string direction)
		{
			_propertyName = propertyName;
			_direction = direction;
		}
		public virtual string ToSql()
		{
			return "[" + PropertyName + "] " + Direction;
		}
		public virtual string PropertyName
		{
			get { return _propertyName; }
			set { _propertyName = value; }
		}
		public virtual string Direction
		{
			get { return _direction; }
			set { _direction = value; }
		}
	}
}
