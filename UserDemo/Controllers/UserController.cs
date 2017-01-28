﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserDataAccess;

namespace UserDemo.Controllers
{
    
    public class UserController : ApiController
    {
        userInfoEntities entities = new userInfoEntities();
        
        public IEnumerable<sp_SelectAllUserDetails_Result> Get()
        {
            return entities.sp_SelectAllUserDetails().AsEnumerable();
        }
        [HttpGet]
        public IEnumerable<sp_SelectUserDetails_Result> Get(int id)
        {
            return entities.sp_SelectUserDetails(id).AsEnumerable(); ;
        }
        [HttpDelete]
        public string Delete(int id)
        {
            return entities.sp_DeleteUserDetails(id).ToString();
        }
        [HttpPost]
        public string Add(string name, decimal age, decimal salary, string designation, DateTime DOB)
        {
            return entities.sp_InserUserDetails(name, age, salary, designation, DOB).ToString();
        }
        [HttpPut]
        public string Put(decimal ID, string name, decimal age, decimal salary, string designation, DateTime DOB)
        {
            return entities.sp_UpdateUserDetails(ID,name, age, salary, designation, DOB).ToString();
        }
    }
}