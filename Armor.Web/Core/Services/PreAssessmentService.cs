using System;
using System.Linq;

using Armor.Data;
using System.Collections.Generic;
using Armor.Web.Models;
using SubSonic.Schema;

namespace Armor.Web {
    public class PreAssessmentService : ServiceBase<PreAssessment>
    {

        protected override string CacheKey {
            get { return "Armor.Web.Assessment"; }
        }

        public object Save(PreAssessment entity)
        {
            if (entity.ID > 0)
                return base.GetRepository<PreAssessment>().Update(entity);

            return base.GetRepository<PreAssessment>().Add(entity);
        }

    }
}