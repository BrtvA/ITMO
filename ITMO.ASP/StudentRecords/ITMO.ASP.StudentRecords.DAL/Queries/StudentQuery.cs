using ITMO.ASP.StudentRecords.DAL.Entities;
using ITMO.ASP.StudentRecords.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ASP.StudentRecords.DAL.Queries
{
    public class StudentQuery: IDisposable
    {
        const string deletionError = "Deletion error";
        const string dataNotAvalible = "The data is not available";
        const string databaseError = "failed to add data";
        const string alreadyExists = "This entry already exists";

        private readonly ApplicationContext _db;

        public StudentQuery(ApplicationContext db)
        {
            _db = db;
        }

        public async Task<string> DeleteInfoAsync(int id)
        {
            try
            {
                var student = await _db.Students.Where(x => x.Id == id).FirstOrDefaultAsync();
                _db.Students.Remove(student);
                _db.SaveChanges();
                return String.Empty;
            }
            catch (DbUpdateException ex)
            {
                return deletionError;
            }
            catch(Exception ex)
            {
                return dataNotAvalible;
            }
        }

        public async Task<IEnumerable<StudentDeleteModel>> GetDeleteInfoAsync()
        {
            try
            {
                return await _db.Students.Join(_db.Scores,
                                               u => u.ScoreId,
                                               c => c.Id,
                                               (u, c) => new StudentDeleteModel
                                               {
                                                   Id = u.Id,
                                                   FirstName = u.FirstName,
                                                   LastName = u.LastName,
                                                   ScoreDescription = c.ScoreDescription
                                               })
                                         .ToListAsync();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<StudentAddModel>> GetTopAsync(string type)
        {
            try
            {
                var result = _db.Students.Join(_db.Scores,
                                           u => u.ScoreId,
                                           c => c.Id,
                                           (u, c) => new
                                           {
                                               FirstName = u.FirstName,
                                               LastName = u.LastName,
                                               ScoreValue = c.ScoreValue,
                                               ScoreDescription = c.ScoreDescription
                                           });

                if (type == "best")
                {
                    return await result.OrderByDescending(x => x.ScoreValue) //Топ 5 лучших
                                       .ThenByDescending(x => x.LastName)
                                       .ThenByDescending(x => x.FirstName)
                                       .Take(5)
                                       .Select(x => new StudentAddModel
                                       {
                                           FirstName = x.FirstName,
                                           LastName = x.LastName,
                                           ScoreDescription = x.ScoreDescription
                                       })
                                       .ToListAsync();
                }
                else
                {
                    return await result.OrderBy(x => x.ScoreValue) //Топ 5 худших
                                       .ThenBy(x => x.LastName)
                                       .ThenBy(x => x.FirstName)
                                       .Take(5)
                                       .Select(x => new StudentAddModel
                                       {
                                           FirstName = x.FirstName,
                                           LastName = x.LastName,
                                           ScoreDescription = x.ScoreDescription
                                       })
                                       .ToListAsync();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<int> SumAsync()
        {
            try
            {
                var list = await _db.Students.Join(_db.Scores,
                                               u => u.ScoreId,
                                               c => c.Id,
                                               (u, c) => (int)c.ScoreValue).ToListAsync();
                return list.Sum();
            }
            catch (Exception ex)
            {
                return -999;
            }
        }

        public async Task<IEnumerable<StudentAddModel>> GetAllAsync()
        {
            try
            {
                return await _db.Students.Join(_db.Scores,
                                               u => u.ScoreId,
                                               c => c.Id,
                                               (u, c) => new StudentAllModel
                                               {
                                                   FirstName = u.FirstName,
                                                   LastName = u.LastName,
                                                   ScoreValue = c.ScoreValue,
                                                   ScoreDescription = c.ScoreDescription
                                               })
                                         .ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<string> AddAsync(StudentAddModel studentAddModel)
        {
            try
            {
                int studentCount = await _db.Students.Where(x => x.FirstName == studentAddModel.FirstName)
                                                     .Where(x => x.LastName == studentAddModel.LastName)
                                                     .CountAsync();
                int scoreId;
                if (studentCount == 0)
                {
                    scoreId = await _db.Scores.Where(x => x.ScoreDescription == studentAddModel.ScoreDescription)
                                              .Select(x => x.Id)
                                              .FirstOrDefaultAsync();
                    _db.Students.Add(new Student
                    {
                        FirstName = studentAddModel.FirstName,
                        LastName = studentAddModel.LastName,
                        ScoreId = scoreId
                    });
                    await _db.SaveChangesAsync();
                    return string.Empty;
                }
                else
                {
                    return alreadyExists;
                }
            }
            catch(Exception ex)
            {
                return databaseError;
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

        ~StudentQuery()
        {
            Dispose(false);
        }
    }
}
