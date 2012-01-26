using System;
using System.Linq;

using Armor.Data;
using System.Collections.Generic;
using Armor.Web.Models;
using SubSonic.Schema;

namespace Armor.Web {
    public class Stage2Service : ServiceBase<ProgramEvaluatorStage2>{

        protected override string CacheKey {
            get { return "Armor.Web.Assessment"; }
        }

        public object Save(ProgramEvaluatorStage2 entity)
        {
            if (entity.ID > 0)
                return base.GetRepository<ProgramEvaluatorStage2>().Update(entity);

            return base.GetRepository<ProgramEvaluatorStage2>().Add(entity);
        }

        public ProgramEvaluatorStage2 GetByID(int ID)
        {
            return db.ProgramEvaluatorStage2s.Where(e => e.ID == ID).FirstOrDefault();
        }

    }
}