using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WaterWise.Repositories.Admin;

namespace WaterWise.Controller.Admin_by_Izul
{
    internal class C_LihatDataUser
    {
        private AdminUserRepository _userRepo;

        public C_LihatDataUser()
        {
            _userRepo = new AdminUserRepository();
        }

        public DataTable GetAllUsers()
        {
            return _userRepo.GetAllUsers();
        }

        public DataTable SearchUsers(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return _userRepo.GetAllUsers();
            return _userRepo.SearchUsers(keyword);
        }
    }
}
