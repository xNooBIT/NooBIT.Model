﻿using NooBIT.Model.Entities;
using NooBIT.Model.Specifications;

namespace NooBIT.Model.EntityFrameworkCore.Specifications
{
    public interface IIncludeSpecification<TEntity, TResult> : ISpecification<TEntity, TResult> where TEntity : class, IEntity
    {
    }

    public interface IIncludeSpecification<TEntity> : IIncludeSpecification<TEntity, TEntity>, ISpecification<TEntity> where TEntity : class, IEntity
    {
    }
}
