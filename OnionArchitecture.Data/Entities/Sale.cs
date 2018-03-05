using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureDemo.Domain.Entities
{
    public class Sale
    {
        public int MarkDownPercentage { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
