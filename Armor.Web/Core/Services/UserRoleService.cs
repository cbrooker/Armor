using System;
using System.Linq;

using Armor.Data;
using System.Collections.Generic;
using Armor.Web.Models;
using SubSonic.Schema;

namespace Armor.Web {
    public class UserRoleService : ServiceBase<UserRole>{

        protected override string CacheKey {
            get { return "Armor.Web.UserRole"; }
        }

        public object Save(UserRole entity)
        {
            if (entity.ID > 0)
                return base.GetRepository<UserRole>().Update(entity);

            return base.GetRepository<UserRole>().Add(entity);
        }

        public UserRole GetByID(int ID)
        {
            return db.UserRoles.Where(e => e.ID == ID).FirstOrDefault();
        }

        public UserRole GetByRoleName(string name)
        {
            return db.UserRoles.Where(e => e.Name == name).FirstOrDefault();
        }


        public int GetCount()
        {
            return db.UserRoles.Count();
        }

    }
}