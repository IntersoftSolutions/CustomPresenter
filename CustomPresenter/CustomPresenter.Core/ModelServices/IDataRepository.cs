﻿using System.Collections.Generic;

namespace CustomPresenter.ModelServices
{
    /// <summary>
    /// Defines the methods to support a data repository implementation.
    /// </summary>
    public interface IDataRepository<TEntity, in TKey> where TEntity : class
    {
        #region Methods

        TEntity Get(TKey id);
        IEnumerable<TEntity> GetAll();

        #endregion
    }
}