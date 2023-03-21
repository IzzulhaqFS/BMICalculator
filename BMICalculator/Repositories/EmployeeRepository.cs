using BMICalculator.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.Repositories
{
    public class EmployeeRepository
    {
        string _dbPath;
        public string StatusMessage { get; set; }
        private SQLiteAsyncConnection conn;

        private async Task Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteAsyncConnection(_dbPath);
            await conn.CreateTableAsync<Employee>(); 
        }

        public EmployeeRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public async Task AddNewEmployee(Employee employee)
        {

        }

        public async Task<List<Employee>> GetAllEmployee()
        {
            try
            {
                await Init();
                return await conn.Table<Employee>().ToListAsync();
            }
            catch(Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }
            return new List<Employee>();
        }
    }
}
