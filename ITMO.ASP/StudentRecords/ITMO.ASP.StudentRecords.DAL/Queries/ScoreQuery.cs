using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ITMO.ASP.StudentRecords.DAL.Queries
{
    public class ScoreQuery: IDisposable
    {
        private readonly ApplicationContext _db;
        public ScoreQuery(ApplicationContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<string>> GetAllAsync()
        {
            try
            {
                return await _db.Scores.Select(x => x.ScoreDescription).ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {

            if (disposed) return;
            if (disposing)
            {
                // Освобождаем управляемые ресурсы
                _db.Dispose();
            }
            // освобождаем неуправляемые объекты
            disposed = true;
        }

        ~ScoreQuery()
        {
            Dispose(false);
        }
    }
}
