using CovidHealthDeclarationForm.Data;
using CovidHealthDeclarationForm.Enums;
using CovidHealthDeclarationForm.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidHealthDeclarationForm.Services
{
    public interface IAcivityLogger
    {
        void writeLog(ApplicationDBContext _db, string message, string logLevel, string controllerName, string actionStatus);
    }

    public class ActivityLogger : IAcivityLogger
    {
        public void writeLog(ApplicationDBContext _db, string message, string logLevel, string controllerName, string actionStatus)
        {
            ActivityLog log = new ActivityLog()
            {
                ActivityLogID = Guid.NewGuid().ToString(),
                Message = message,
                LogLevel = logLevel,
                ControllerName = controllerName,
                ActionStatus = actionStatus,
                Timestamp = DateTime.Now
            };
            _db.ActivityLog.Add(log);
            _db.SaveChanges();
        }
    }
}
