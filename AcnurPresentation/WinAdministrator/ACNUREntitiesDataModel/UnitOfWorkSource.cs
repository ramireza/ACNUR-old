using System;
using System.Linq;
using System.Data;
using System.Linq.Expressions;
using System.Collections.Generic;
using WinAdministrator.Common.Utils;
using WinAdministrator.Common.DataModel;
using WinAdministrator.Common.DataModel.EntityFramework;
using Acnur.App.Repository.Data;
using DevExpress.Mvvm;
using System.Collections;
using System.ComponentModel;
using DevExpress.Data.Linq;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.Async.Helpers;

namespace WinAdministrator.ACNUREntitiesDataModel
{
    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource
    {

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> GetUnitOfWorkFactory()
        {
            return new DbUnitOfWorkFactory<IACNUREntitiesUnitOfWork>(() => new ACNUREntitiesUnitOfWork(() => new ACNUREntities()));
        }
    }
}