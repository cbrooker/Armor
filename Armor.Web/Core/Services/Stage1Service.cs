using System;
using System.Linq;

using Armor.Data;
using System.Collections.Generic;
using Armor.Web.Models;
using SubSonic.Schema;

namespace Armor.Web {
    public class Stage1Service : ServiceBase<ProgramEvaluatorStage1>{

        protected override string CacheKey {
            get { return "Armor.Web.Assessment"; }
        }

        public object Save(ProgramEvaluatorStage1 entity)
        {
            if (entity.ID > 0)
                return base.GetRepository<ProgramEvaluatorStage1>().Update(entity);

            return base.GetRepository<ProgramEvaluatorStage1>().Add(entity);
        }

        public ProgramEvaluatorStage1 GetByID(int ID)
        {
            return db.ProgramEvaluatorStage1s.Where(e => e.ID == ID).FirstOrDefault();
        }

    }
}