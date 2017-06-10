using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Base
    {       

    }
    public class Donator
    {
        //Create properties based on table columns	
        public int DonatorId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Active { get; set; }
        public string Role { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class Animal
    {
        //Create properties based on table columns	
        public int AnimalId { get; set; }
        public  string AnimalName { get; set; }
        public string Type { get; set; }
        public string RegNumber { get; set; }
        public string Status { get; set; }
        public int Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Location { get; set; }
        public int DonatorId { get; set; }
        public int AdopterId { get; set; }
        public string AdopterName { get; set; }

        public string PickUpDate { get; set; }
    }

    public class Adopter
    {
        //Create properties based on table columns	
        public int AdoptorId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Active { get; set; }
        public string AnimalType { get; set; }
    }
    public class Data
    {
        public string ColumnName = "";
        public int Value = 0;

        public Data() { }

        public Data(string columnName, int value)
        {
            ColumnName = columnName;
            Value = value;
        }
    }

    public class ChartData
    {
        public string ChartType = "";
        public List<Data> lstData;
    }

}
