using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LogiSys.Model
{
    public class Order
    {
        public Order()
        {
            this.Articles = new HashSet<Article>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int FilialId { get; set; }

        public Filial Filial { get; set; }

        [Required]
        public int SectorId { get; set; }

        public Sector Sector { get; set; }

        public OrderStatus Status { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int EmployeeId { get; set; }

        public int EmployeeNumber { get; set; }

        public Employee Employee { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
