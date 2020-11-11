using System;
using System.Collections.Generic;
using System.Text;

namespace M6.Business
{
	public partial interface IOrderBy : ICloneable
	{
		IDataOrderBy DataOrderBy();
	}

	public partial interface ISkip : ICloneable
	{
		IDataSkip DataSkip();
	}

	public partial interface ITake : ICloneable
	{
		IDataTake DataTake();
	}

	public partial interface ICriterion : ICloneable
	{
		IDataCriterion DataCriterion();
	}

	public partial interface IProjection
	{
		IDataProjection DataProjection();
		string Member { get; set; }
	}

	public partial interface ICriteria
	{
		ICriteria Add(IProjection projection);
		ICriteria Add(ICriterion criterion);
		ICriteria Add(IOrderBy orderBy);
		ICriteria Skip(int val);
		ICriteria Take(int val);
		ICriterion Criterion(int pos);
		IList<IDataProjection> ListDataProjection();
		IList<IDataCriterion> ListDataCriteria();
		IList<IDataOrderBy> ListDataOrder();
		IDataSkip DataSkip();
		IDataTake DataTake();
		IList<T> List<T>();
		Int32 Count();
		T Single<T>();
		T SingleOrDefault<T>();
		T First<T>();
		T FirstOrDefault<T>();
	}
}
