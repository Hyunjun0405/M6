using System;
using System.Collections.Generic;
using System.Text;

namespace M6.Business
{
	#region implementation
	public class Expression
	{
		public static ICriterion Eq(string propertyName, params object[] value)
		{
			return (ICriterion)new CriterionEq() { PropertyName = propertyName, PropertyValue = value[0], Formatter = value.Length > 1 ? (Func<object, string>)value[1] : null };
		}

		public static ICriterion NotEq(string propertyName, params object[] value)
		{
			return (ICriterion)new CriterionNotEq() { PropertyName = propertyName, PropertyValue = value[0], Formatter = value.Length > 1 ? (Func<object, string>)value[1] : null };
		}

		public static ICriterion Lt(string propertyName, params object[] value)
		{
			return (ICriterion)new CriterionLt() { PropertyName = propertyName, PropertyValue = value[0], Formatter = value.Length > 1 ? (Func<object, string>)value[1] : null };
		}

		public static ICriterion Lte(string propertyName, params object[] value)
		{
			return (ICriterion)new CriterionLte() { PropertyName = propertyName, PropertyValue = value[0], Formatter = value.Length > 1 ? (Func<object, string>)value[1] : null };
		}

		public static ICriterion Gt(string propertyName, params object[] value)
		{
			return (ICriterion)new CriterionGt() { PropertyName = propertyName, PropertyValue = value[0], Formatter = value.Length > 1 ? (Func<object, string>)value[1] : null };
		}

		public static ICriterion Gte(string propertyName, params object[] value)
		{
			return (ICriterion)new CriterionGte() { PropertyName = propertyName, PropertyValue = value[0], Formatter = value.Length > 1 ? (Func<object, string>)value[1] : null };
		}

		public static ICriterion In(string propertyName, params object[] value)
		{
			return (ICriterion)new CriterionIn() { PropertyName = propertyName, PropertyValue = value[0], Formatter = value.Length > 1 ? (Func<object, string>)value[1] : null };
		}

		public static ICriterion InSqlSubQuery(string propertyName, params object[] value)
		{
			return (ICriterion)new CriterionInSqlSubQuery() { PropertyName = propertyName, PropertyValue = value[0], Formatter = value.Length > 1 ? (Func<object, string>)value[1] : null };
		}

		public static ICriterion InSubQuery(string propertyName, params object[] value)
		{
			return (ICriterion)new CriterionInSubQuery() { PropertyName = propertyName, PropertyValue = value[0], Formatter = value.Length > 1 ? (Func<object, string>)value[1] : null };
		}

		public static ICriterion Null(string propertyName)
		{
			return (ICriterion)new CriterionNull() { PropertyName = propertyName };
		}

		public static ICriterion NotNull(string propertyName)
		{
			return (ICriterion)new CriterionNotNull() { PropertyName = propertyName };
		}

		public static ICriterion Like(string propertyName, params object[] value)
		{
			return (ICriterion)new CriterionLike() { PropertyName = propertyName, PropertyValue = value[0], Formatter = value.Length > 1 ? (Func<object, string>)value[1] : null };
		}

		public static ICriterion Or(params object[] value)
		{
			List<ICriterion> lstCriterion = new List<ICriterion>();
			foreach (object obj in value)
				lstCriterion.Add(((ICriteria)obj).Criterion(0));
			return (ICriterion)new CriterionOr() { Restrictions = lstCriterion };
		}

		public static ICriterion Between(string propertyName, params object[] value)
		{
			return (ICriterion)new CriterionBetween() { PropertyName = propertyName, PropertyValue1 = value[0], PropertyValue2 = value[1], Formatter = value.Length > 2 ? (Func<object, string>)value[2] : null };
		}
	}
	#endregion
}
