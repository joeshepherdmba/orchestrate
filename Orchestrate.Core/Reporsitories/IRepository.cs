using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Orchestrate.Core.Reporsitories
{
	/// <summary>
	/// Generic Repository Interface modeled from: http://www.remondo.net/repository-pattern-example-csharp/
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IRepository<T>
    {
        T Insert(Type entity);
		void Delete(T entity);
		IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
		IEnumerable<T> GetAll();
		T GetById(object id);
		//void Update(T entity);
		//void SaveChanges();
    }
}
