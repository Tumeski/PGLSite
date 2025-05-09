using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Oqtane.Models;

namespace Oqtane.Repository
{
    public class JobLogRepository : IJobLogRepository
    {
        private MasterDBContext _db;

        public JobLogRepository(MasterDBContext context)
        {
            _db = context;
        }

        public IEnumerable<JobLog> GetJobLogs()
        {
            return GetJobLogs(-1);
        }

        public IEnumerable<JobLog> GetJobLogs(int jobId)
        {
            return _db.JobLog
                .AsNoTracking()
                .Where(item => item.JobId == jobId || jobId == -1)
                .Include(item => item.Job) // eager load jobs
                .OrderByDescending(item => item.JobLogId)
                .ToList();
        }

        public JobLog AddJobLog(JobLog jobLog)
        {
            _db.JobLog.Add(jobLog);
            _db.SaveChanges();
            return jobLog;
        }

        public JobLog UpdateJobLog(JobLog jobLog)
        {
            _db.Entry(jobLog).State = EntityState.Modified;
            _db.SaveChanges();
            return jobLog;
        }

        public JobLog GetJobLog(int jobLogId)
        {
            return _db.JobLog.Include(item => item.Job) // eager load job
                .SingleOrDefault(item => item.JobLogId == jobLogId); 
        }

        public void DeleteJobLog(int jobLogId)
        {
            JobLog joblog = _db.JobLog.Find(jobLogId);
            _db.JobLog.Remove(joblog);
            _db.SaveChanges();
        }
    }
}
