using DemoProject.Models;
using DemoProject.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoProject.Services.Business
{
    public class SecurityService
    {
        SecurityDAO daoService = new SecurityDAO();
        public bool Authenticate(User user)
        {
            return daoService.FindByUser(user);
        }
    }
}