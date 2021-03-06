﻿using System.Linq;

namespace NooBIT.Model.Specifications
{
    public abstract class Specification<TEntity, TResult> : ISpecification<TEntity, TResult>
    {
        public IQueryBuilder<TEntity, TResult> Query { get; private set; }

        public Specification() : this(null)
        {
        }

        public Specification(IQueryBuilder<TEntity, TResult> queryBuilder)
        {
            Query = queryBuilder ?? new QueryBuilder<TEntity, TResult>();
        }

        public IQueryable<TResult> ApplyTo(IQueryable<TEntity> query)
            => Query.Build().Apply(query);
    }

    public abstract class Specification<TEntity> : Specification<TEntity, TEntity>, ISpecification<TEntity>
    {
        public Specification() : base(new QueryBuilder<TEntity>()) { }
    }

}
