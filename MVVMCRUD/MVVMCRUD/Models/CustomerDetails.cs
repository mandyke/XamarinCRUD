using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMCRUD.Models
{
    // This app is built with Realm Database
    public class CustomerDetails : RealmObject
    {
        [PrimaryKey]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int CustomerAge { get; set; }
    }
}
