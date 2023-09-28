using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.EmployeeManager.Data.Models;

namespace WiredBrainCoffee.EmployeeManager.Data
{
    public class EmplyeeManagerDbContext: DbContext
    {
        public EmplyeeManagerDbContext(DbContextOptions<EmplyeeManagerDbContext> options) : base(options) { }
       
        public DbSet<Employee>Employees => Set<Employee>();
        public DbSet<Department> Departments => Set<Department>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Finance" },
                new Department { Id = 2, Name = "Sales" },
                new Department { Id = 3, Name = "Marketing" },
                new Department { Id = 4, Name = "Human Resources" },
                new Department { Id = 5, Name = "IT" },
                new Department { Id = 6, Name = "R&D" });
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, FiestName="Tal",LastName="Vazana", DepartmrntId=6,IsDeveloper=true },
                new Employee { Id = 2, FiestName = "Sapir", LastName = "Pashali", DepartmrntId = 6, IsDeveloper = true },
                new Employee { Id = 3, FiestName = "Gal", LastName = "Cohen", DepartmrntId = 3, IsDeveloper = false },
                new Employee { Id = 4, FiestName = "Omer", LastName = "Vazana", DepartmrntId =6, IsDeveloper = true },
                new Employee { Id = 5, FiestName = "Guy", LastName = "Mitrany", DepartmrntId = 1, IsDeveloper = false },
                new Employee { Id = 6, FiestName = "Naor", LastName = "Waitzenberg", DepartmrntId = 4 , IsDeveloper = false },
                new Employee { Id = 7, FiestName = "Gigo", LastName = "Ben gigi", DepartmrntId = 5 , IsDeveloper = false },
                new Employee { Id = 8, FiestName = "Eyal", LastName = "Tamsot", DepartmrntId = 6 , IsDeveloper = true },
                new Employee { Id = 9, FiestName = "Ron", LastName = "Tzroya", DepartmrntId = 1 , IsDeveloper = false },
                new Employee { Id = 10, FiestName = "Ofek", LastName = "Malik", DepartmrntId = 3 , IsDeveloper = false });
                
        }
    }
 }
