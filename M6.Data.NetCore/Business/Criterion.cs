using System;
using System.Collections.Generic;
using System.Text;

namespace M6.Business
{
	#region Criterion
	public abstract class Criterion
	{
		public virtual string PropertyName { get; set; }
		public virtual object PropertyValue { get; set; }
		public virtual Func<object, string> Formatter { get; set; }
		public abstract IDataCriterion DataCriterion();
		public abstract object Clone();
	}

	public abstract class CriterionDuplex : ICriterion
	{
		public virtual string PropertyName { get; set; }
		public virtual object PropertyValue1 { get; set; }
		public virtual object PropertyValue2 { get; set; }
		public virtual Func<object, string> Formatter { get; set; }
		public abstract IDataCriterion DataCriterion();
		public abstract object Clone();
	}

	public abstract class CriterionMulti : ICriterion
	{
		public virtual List<ICriterion> Restrictions { get; set; }
		public abstract IDataCriterion DataCriterion();
		public abstract object Clone();
	}

	public class CriterionEq : Criterion
	{
		public override object Clone()
		{
			return new CriterionEq() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionEq() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class CriterionNotEq : Criterion
	{
		public override object Clone()
		{
			return new CriterionNotEq() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionNotEq() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class CriterionLt : Criterion
	{
		public override object Clone()
		{
			return new CriterionLt() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionLt() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class CriterionLte : Criterion
	{
		public override object Clone()
		{
			return new CriterionLte() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionLte() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class CriterionGt : Criterion
	{
		public override object Clone()
		{
			return new CriterionGt() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionGt() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class CriterionGte : Criterion
	{
		public override object Clone()
		{
			return new CriterionGte() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionGte() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class CriterionIn : Criterion
	{
		public override object Clone()
		{
			return new CriterionIn() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionIn() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public partial class CriterionInSqlSubQuery : Criterion
	{

		public override object Clone()
		{
			return new CriterionInSqlSubQuery() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionInSqlSubQuery() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public partial class CriterionInSubQuery : Criterion
	{

		public override object Clone()
		{
			return new CriterionInSubQuery() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return null;
		}
	}

	public class CriterionNull : Criterion
	{
		public override object Clone()
		{
			return new CriterionNull() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionNull() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class CriterionNotNull : Criterion
	{
		public override object Clone()
		{
			return new CriterionNotNull() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionNotNull() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

	public class CriterionLike : Criterion
	{
		public override object Clone()
		{
			return new CriterionLike() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}

		public override IDataCriterion DataCriterion()
		{
			return (IDataCriterion)new DataCriterionLike() { PropertyName = this.PropertyName, PropertyValue = this.PropertyValue, Formatter = this.Formatter };
		}
	}

    public class CriterionOr : CriterionMulti
    {
		public override object Clone()
		{
			return new CriterionOr() { Restrictions = this.Restrictions };
		}

		public override IDataCriterion DataCriterion()
		{
			List<IDataCriterion> lst = new List<IDataCriterion>();
			foreach (Criterion criterion in this.Restrictions)
				lst.Add(criterion.DataCriterion());

			return (IDataCriterion)new DataCriterionOr() { List = lst };
		}
	}

    public class CriterionBetween : CriterionDuplex
    {
        public override object Clone()
        {
            return new CriterionBetween() { PropertyName = this.PropertyName, PropertyValue1 = this.PropertyValue1, PropertyValue2 = this.PropertyValue2, Formatter = this.Formatter };
        }

        public override IDataCriterion DataCriterion()
        {
            return (IDataCriterion)new DataCriterionBetween() { PropertyName = this.PropertyName, PropertyValue1 = this.PropertyValue1, PropertyValue2 = this.PropertyValue2, Formatter = this.Formatter };
        }
    }
    #endregion

    #region DataCriterion
    public partial class DataCriterion
	{
		public virtual string PropertyName { get; set; }
		public virtual object PropertyValue { get; set; }
		public virtual Func<object, string> Formatter { get; set; }
	}

	public partial class DataCriterionDuplex
	{
		public virtual string PropertyName { get; set; }
		public virtual object PropertyValue1 { get; set; }
		public virtual object PropertyValue2 { get; set; }
		public virtual Func<object, string> Formatter { get; set; }
	}

	public partial class DataCriterionMulti : DataCriterion
	{
		public virtual List<IDataCriterion> List { get; set; }
	}

	public class DataCriterionEq : DataCriterion
	{
		public string ToSql()
		{
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			return "[" + PropertyName + "] = '" + propValue + "'";
		}
	}

	public class DataCriterionNotEq : DataCriterion
	{
		public string ToSql()
		{
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			return "[" + PropertyName + "] != '" + propValue + "'";
		}
	}

	public class DataCriterionLt : DataCriterion
	{
		public string ToSql()
		{
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			return "[" + PropertyName + "] < '" + propValue + "'";
		}
	}

	public class DataCriterionLte : DataCriterion
	{
		public string ToSql()
		{
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			return "[" + PropertyName + "] <= '" + propValue + "'";
		}
	}

	public class DataCriterionGt : DataCriterion
	{
		public string ToSql()
		{
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			return "[" + PropertyName + "] > '" + propValue + "'";
		}
	}

	public class DataCriterionGte : DataCriterion
	{
		public string ToSql()
		{
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			return "[" + PropertyName + "] >= '" + propValue + "'";
		}
	}

	public partial class DataCriterionInSqlSubQuery : DataCriterion
	{
		public virtual string ToSql()
		{
			string quote = "";
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			return "[" + PropertyName + "] IN (" + quote + propValue + quote + ")";
		}
	}

	public class DataCriterionIn : DataCriterion
	{
		public string ToSql()
		{
			string quote = "";
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			propValue = propValue.Replace("\"", "'");
			return "[" + PropertyName + "] IN (" + quote + propValue + quote + ")";
		}
	}

	public class DataCriterionNull : DataCriterion
	{
		public string ToSql()
		{
			return "[" + PropertyName + "] IS NULL";
		}
	}

	public class DataCriterionNotNull : DataCriterion
	{
		public string ToSql()
		{
			return "[" + PropertyName + "] IS NOT NULL";
		}
	}

	public class DataCriterionLike : DataCriterion
	{
		public string ToSql()
		{
			string quote = "";
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			if ((propValue != null) && !propValue.Contains("%")) quote = "%";
			if (propValue.StartsWith("'")) propValue = propValue.Substring(1, propValue.Length - 1);
			if (propValue.EndsWith("'")) propValue = propValue.Substring(0, propValue.Length - 1);
			return "[" + PropertyName + "] LIKE '" + quote + propValue + quote + "'";
		}
	}

	public class DataCriterionOr : DataCriterionMulti, IDataCriterion
	{
		public string ToSql()
		{
			string ret = "";
			foreach (var condition in List)
			{
				ret += (ret == "") ? "" : " OR ";
				ret += condition.ToSql();
			}
			if (!string.IsNullOrEmpty(ret)) ret = "(" + ret + ")";
			return ret;
		}
	}

	public class DataCriterionBetween : DataCriterionDuplex, IDataCriterion
	{
		public string ToSql()
		{
			string propValue1 = Formatter != null ? Formatter(PropertyValue1) : PropertyValue1.ToString();
			string propValue2 = Formatter != null ? Formatter(PropertyValue2) : PropertyValue2.ToString();
			return "[" + PropertyName + "] > '" + propValue1 + "' AND [" + PropertyName + "] < '" + propValue2 + "'";
		}
	}
    #endregion
}
