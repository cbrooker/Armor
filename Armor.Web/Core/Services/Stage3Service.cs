using System;
using System.Linq;

using Armor.Data;
using System.Collections.Generic;
using Armor.Web.Models;
using SubSonic.Schema;

namespace Armor.Web {
    public class Stage3Service : ServiceBase<ProgramEvaluatorStage3>{

        protected override string CacheKey {
            get { return "Armor.Web.Assessment"; }
        }

        public object Save(ProgramEvaluatorStage3 entity)
        {
            if (entity.ID > 0)
                return base.GetRepository<ProgramEvaluatorStage3>().Update(entity);

            return base.GetRepository<ProgramEvaluatorStage3>().Add(entity);
        }

        public ProgramEvaluatorStage3 GetByID(int ID)
        {
            return db.ProgramEvaluatorStage3s.Where(e => e.ID == ID).FirstOrDefault();
        }

    }
}