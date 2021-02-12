// Copyright (c) Geta Digital. All rights reserved.
// Licensed under Apache-2.0. See the LICENSE file in the project root for more information

namespace Geta.NotFoundHandler.Core.Data
{
    public interface IRepository<in TEntity>
        where TEntity : class
    {
        void Save(TEntity entity);
        void Delete(TEntity entity);
    }
}