﻿using DoAnThucTap.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.Data.Reponsitory
{
    public partial class BaseReponsitory
    {
        public virtual async Task UpdateAsync<TEntity>(TEntity entity) where TEntity : BaseData
        {
            this.BeforeUpdate(entity);
            _db.Update(entity);
            await _db.SaveChangesAsync();
        }
        public virtual async Task UpdateAsync<TEntity>(IEnumerable<TEntity> entities) where TEntity : BaseData
        {
            var len = entities.Count();
            for (int i = 0; i < len; i++)
            {
                this.BeforeUpdate(entities.ElementAt(i));
            }
            _db.UpdateRange(entities);
            await _db.SaveChangesAsync();
        }
    }
}
