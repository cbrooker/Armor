using System;
using System.Linq;

using Armor.Data;
using System.Collections.Generic;
using Armor.Web.Models;
using SubSonic.Schema;

namespace Armor.Web {
    public class PatientAssessmentService : ServiceBase<PatientAssessment>
    {

        protected override string CacheKey {
            get { return "Armor.Web.Assessment"; }
        }

        public object Save(PatientAssessment entity)
        {
            if (entity.ID > 0)
                return base.GetRepository<PatientAssessment>().Update(entity);

            return base.GetRepository<PatientAssessment>().Add(entity);
        }

    }
}