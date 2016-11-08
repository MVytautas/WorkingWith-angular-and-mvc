using AssignmentWithAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentWithAngular
{
    public class ForTest
    {
        public void ReadData(int Id, string Name, string Surename, string Address)
        {
            masterEntities _db = new masterEntities();
            foreach (var item in _db.Tables)
            {
                //Console.WriteLine(item);
            }
        }
    }
}