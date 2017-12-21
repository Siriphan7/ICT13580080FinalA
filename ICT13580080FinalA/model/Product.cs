using System;
using SQLite;
namespace ICT13580080FinalA.model
{
    public class Product
    {
        [PrimaryKey,AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        [NotNull]
        [MaxLength(200)]
        public string Name
        {
            get;
            set;
        }
        [NotNull]
        [MaxLength(200)]
        public string Surename
        {
            get;
            set;
        }
        public int Yearold
        {
            get;
            set;
        }
        public string Sex
        {
            get;
            set;
        }

        public string Department
        {
            get;
            set;
        }
        public int Telephone
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }

        public string Status
        {
            get;
            set;
        }
        public int Chlidrens
        {
            get;
            set;
     
        }

        public int Salary
        {
            get;
            set;
  
        }

        }

    }
