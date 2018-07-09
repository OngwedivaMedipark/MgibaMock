using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSystem.Data.Model
{
 public class Hospital
    {
        public string Id { get; set; }
        public bool isAvailable { get; set; }
        public WardStatus WardStatus { get; set; }
        public List<User> User { get; set; }
    }
  
   public enum WardStatus
    {
       Pending,
       Available,
       Unavailalbe
    }
}
