using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using KIM.data;
using KIM.utils;

namespace KIM.models.Tool
{
    public class UserDAL
    {
        private readonly KIMEntities _context;

        public UserDAL() => _context = new KIMEntities();

        public DataTable GetUsers()
        {
            return (from u in _context.Users
                    select new
                    {
                        u.IsActive,
                        Statue = u.IsActive == true ? "Active" : "Locked",
                        u.Username,
                        u.PermissionClass,
                        u.PermissionName
                    }).OrderBy(o => o.Username).ToDataTable();
        }

        public List<User> GetUserList() => _context.Users.OrderBy(o => o.Username).ToList();

        public static DataTable PermissionList() => EnumWithName<UserPermission>.ParseEnum().ToDataTable();

        public User GetUserByName(string userName) => _context.Users.Single(x => x.Username == userName);

        public int UpdateUser(DataActionMode mode, User user)
        {
            int _result = 0;
            try
            {
                switch (mode)
                {
                    case DataActionMode.Add:
                        _context.Users.Add(user);
                        break;
                    case DataActionMode.Edit:
                        var u = GetUserByName(user.Username);
                        u.IsActive = user.IsActive;
                        u.Password = user.Password;
                        u.PermissionClass = user.PermissionClass;
                        u.PermissionName = user.PermissionName;
                        u.Username = user.Username;
                        break;
                }

                _result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _result = 0;
            }

            return _result;
        }

        public User GetUserPermission(string userName, string password)
        {
             return _context.Users
                    .Where(x => x.Username.ToUpper() == userName.ToUpper() 
                                && x.Password == password 
                                && x.IsActive == true)
                    .SingleOrDefault();
        }

        public int GetNewUserId(SystemLog log)
        {
            int _id = 0;
            try
            {
                _context.SystemLogs.Add(log);
                _context.SaveChanges();
                _id = _context.SystemLogs.Max(x => x.LogId);
            }
            catch (Exception ex)
            {
                throw new Exception("ไม่สามารถลงชื่อเข้าใช้งานระบบได้", ex);
            }

            return _id;
        }

        public bool UserLogout(int logId)
        {
            try
            {
                var _logout = _context.SystemLogs.Where(x => x.LogId == logId).Single();
                _logout.LogoutDT = DateTime.Now;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
