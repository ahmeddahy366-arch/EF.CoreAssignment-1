using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.CoreAssignment_1
{
    internal class Book
    {
        public int id { get; set; }

        public string  ISBN_Number { get; set; }
       
        public string Title { get; set; }
    
        public decimal Price { get; set; }
      
        public int NumberPages { get; set; }
       
        public int Year { get; set; }

        public bool IsStock { get; set; }

    }
}
