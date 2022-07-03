using System;
using System.Linq.Expressions;

namespace AuthServer.Core.Repositories
{
	//Entitieler için en genel işlemler -> CRUD
	public interface IGenericRepository<TEntity> where TEntity : class
	{
		Task<TEntity> GetByIdAsync(int id);

		/* IQueryable-> gelen data üzerinde baska where sorguları yazdıgım zaman,
		 * ne zamanki tol(toList) istersem o zaman db ye yansıtır hala data üzerinde sorgu yazabilirsin
		 * IEnumarable -> tüm dataları alıyorsam gelen data üzerinde daha sorgu yapmıyacaksam
		 * -----
		 * Func -> C# ta delege yi temsil ediyor,boolt in olarak gene bu delege
		 * (delegeler metodu işaret eder)
		 * func nasıl bir metodu işaret eder
		 * Func<TEntity, bool>
		 * entitie alcak geriye bool dönecek
		 * where(x=>x.id>5)
		 * x->tentity, 
		 * x.id>5->bool, 5 ten buyuk mu degil mi
		 */

		Task<IEnumerable<TEntity>> GetAllAsync();

		IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

		Task AddAsync(TEntity entity);

		void Remove(TEntity entity);
		/* Ef tarafında bir entitieyi sildiğiniz zaman
		 * SaveChanges diyene kadar bu entite bellekte statei yani durumu deleted olarak işaretlenir
		 * yani siz aslında db context üzerinden remove metodu çağırdığınızda
		 * bunun askenron metodu yok, yaptığı işlem;
		 * products.remove(product) ->
		 * veri tabanından direk kaldırılmıyor saveshanges cagrılana kadar
		 * her entitienin statei vardır -> değişmiş mi, silinmiş mi
		 * bu ef tarafından memoryde tutulurğin zaman
		 * savechanges dedigin zaman ilgili elemanın statei delete ise gider db den siler,
		 * update ise db update yapar
		 * add direk memory ye data eklediği icin async,
		 * remove de ise sadece state deleted yapılıyor
		 * ****************
		 * 
		 */

		TEntity Update(TEntity entity);

		/*
		 * _context.Entry(entity).state=EntityState.Modified
		 * entitienin memorydeki durumunu belirliyorum ki,
		 * ef memorydeki tüm entitielerin stetine bakacak,
		 * modified varsa update işlemi gerçekleştirecek
		 */
	}
}