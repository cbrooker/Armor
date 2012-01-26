﻿using System;
using System.Linq;

using Armor.Data;
using System.Collections.Generic;
using Armor.Web.Models;
using SubSonic.Schema;

namespace Armor.Web {
    public class UserService : ServiceBase<User>{

        protected override string CacheKey {
            get { return "Armor.Web.Users"; }
        }

        public object Save(User entity) {
            //If GUID, then update.
            if (entity.ID != Guid.Empty)
                return base.GetRepository<User>().Update(entity);

            //No Guid, create a new one and insert
            entity.ID = Guid.NewGuid();
            return base.GetRepository<User>().Add(entity);
        }

        
        public User GetUserByID(Guid id) {
            return db.Users.Where(u => u.ID == id).FirstOrDefault();
        }

        public User GetUserByEmail(string emailAddress) {
            return GetData().Where(u => u.EmailAddress.ToLower() == emailAddress.ToLower()).FirstOrDefault();
        }

        public User GetUserByResetHash(Guid passwordResetHash) {
            return GetData().Where(u => u.ForgotPasswordHash == passwordResetHash).FirstOrDefault();
        }

        public User ValidateLogin(string emailaddress, string password) {
            return GetData().Where(u => u.EmailAddress == emailaddress && u.Password == password).FirstOrDefault();
        }

        public bool PreAssessmentComplete(Guid UserID)
        {
            if (db.PreAssessments.Where(i => i.UserID == UserID & i.Question12 != null).Count() > 0) return true;
            else return false;
        }
        public bool ProgramStage1Complete(Guid UserID)
        {
            if (db.ProgramEvaluatorStage1s.Where(i => i.UserID == UserID & i.Question20 != null).Count() > 0) return true;
            else return false;
        }
        public bool ProgramStage2Complete(Guid UserID)
        {
            if (db.ProgramEvaluatorStage2s.Where(i => i.UserID == UserID & i.Question20 != null).Count() > 0) return true;
            else return false;
        }
        public bool ProgramStage3Complete(Guid UserID)
        {
            if (db.ProgramEvaluatorStage3s.Where(i => i.UserID == UserID & i.Question20 != null).Count() > 0) return true;
            else return false;
        }

        public bool PatientAssessmentComplete(Guid UserID)
        {
            if (db.PatientAssessments.Where(i => i.UserID == UserID).Count() == 25) return true;
            else return false;
        }

        public int PatientAssessmentCount(Guid UserID)
        {
            return db.PatientAssessments.Where(i => i.UserID == UserID).Count();
        }

    }
}