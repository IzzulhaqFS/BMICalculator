using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace BMICalculator.Models
{
    [Table("employees")]
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMIScore { get; set; }
        public string BMIResult { get; set; }
    }
}
