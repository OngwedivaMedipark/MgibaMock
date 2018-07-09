using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSystem.Data.Model
{
    public class User
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Occupation Occupation { get; set; }

        public int Id { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
    public enum Occupation
    {
        Administrator,
        Doctor,
        User

    }
}
