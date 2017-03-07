using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NavigationUpdate.Tests
{
    [TestClass]
    public class AddUserTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var context = new MyDbContext();
            //context.Usergroups.Add(
            ////    new Usergroup() {
            ////        Name = "Group1"
            ////    }
            ////    );
            ////context.Permissions.Add(
            ////    new Permission()
            ////    {
            ////        Name = "Permission1"
            ////    }
            ////    );
            var usergroup = context.Usergroups.FirstOrDefault();
            usergroup.Name = "bla-bla";
            usergroup.Permissions = new Collection<Permission>()
            {
                new Permission() {
                     Name="test1"
                },
                new Permission() {
                     Name="test2"
                }
            };
            context.SaveChanges();
        }
    }
}
