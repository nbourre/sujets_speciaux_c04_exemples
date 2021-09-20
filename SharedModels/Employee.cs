using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace SharedModels
{
    public class Employee
    {
        static int nextId;

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string CardId { get; set; }

        public string FullName => $"{LastName}, {FirstName}";

        public override string ToString() => $"{LastName}, {FirstName}";

        public Employee()
        {
            // Quicky pour simuler un Id autoincrémenté
            Id = Interlocked.Increment(ref nextId);
        }
    }
}
