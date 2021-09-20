using i18n.Helpers;
using SharedModels;
using System.Collections.Generic;
using System.Linq;

namespace i18n.Services
{
    public class EmployeeDataService : IDataService<Employee>
    {
        static List<Employee> employees;

        public EmployeeDataService()
        {
            initValues();
        }

        private void initValues()
        {
            employees = new List<Employee>()
            {
                new Employee { FirstName = "Nick", LastName = "Bourré", CardId = RandomFunctions.AlphanumericalString(5) },
                new Employee { FirstName = "Lyne", LastName = "Amyot", CardId = RandomFunctions.AlphanumericalString(5) },
                new Employee { FirstName = "France", LastName = "Jean", CardId = RandomFunctions.AlphanumericalString(5) },
                new Employee { FirstName = "Stevens", LastName = "Gagnon", CardId = RandomFunctions.AlphanumericalString(5) },
                new Employee { FirstName = "Mathieu", LastName = "St-Yves", CardId = RandomFunctions.AlphanumericalString(5) },
                new Employee { FirstName = "James", LastName = "Hoffman", CardId = RandomFunctions.AlphanumericalString(5) },
                new Employee { FirstName = "Marco", LastName = "Guilmette", CardId = RandomFunctions.AlphanumericalString(5) },
            };
        }

        public int Delete(Employee value)
        {
            return employees.Remove(value) ? 1 : 0;
        }

        public IEnumerable<Employee> GetAll()
        {
            foreach (var emp in employees)
            {
                yield return emp;
            }
        }

        public Employee GetById(int id)
        {
            return employees.Where(e => e.Id == id).First();
        }

        public int Insert(Employee value)
        {
            int result = 1;

            try
            {
                employees.Add(value);
                result = employees.Count;
            }
            catch
            {
                result = 0;
            }

            return result;
        }

        public int Update(Employee value)
        {
            // Pour l'instant l'argument est déjà référencé dans la collection 
            return 1;
        }
    }
}
