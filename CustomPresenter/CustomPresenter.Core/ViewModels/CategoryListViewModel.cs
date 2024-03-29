﻿using CustomPresenter.Infrastructure;
using CustomPresenter.ModelServices;
using CustomPresenter.Models;
using Intersoft.Crosslight;
using Intersoft.Crosslight.ViewModels;

namespace CustomPresenter.ViewModels
{
    public class CategoryListViewModel : ListViewModelBase<Category>
    {
        #region Properties

        private ICategoryRepository Repository
        {
            get
            {
                if (Container.Current.CanResolve<ICategoryRepository>())
                    return Container.Current.Resolve<ICategoryRepository>();
                else
                    return new CategoryRepository(); // for designer support
            }
        }

        #endregion

        #region Constructors

        public CategoryListViewModel()
        {
            this.SourceItems = this.Repository.GetAll().ToObservable();
        }

        #endregion
    }
}