using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Raffler.Models
{
    public class CsvItemModel
    {
        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }

        public string Title { get; set; }
        public string CoWorkerName { get; set; }
        //public string UniqueID { get; set; }
        public int TicketsAllocated { get; set; }
        public int? TicketsUsed { get; set; }
        public int? Basket1 { get; set; }
        public int? Basket2 { get; set; }
        public int? Basket3 { get; set; }
        public int? Basket4 { get; set; }
        public int? Basket5 { get; set; }
        public int? Basket6 { get; set; }
        public int? Basket7 { get; set; }
        public int? Basket8 { get; set; }
        public int? Basket9 { get; set; }
        public int? Basket10 { get; set; }
        public string AmountDonated { get; set; }

        // [Name("Set Permissions Workflow")]
        //public int SetPermissionsWorkflow { get; set; }
        //public string Status { get; set; }
        public int? Basket11 { get; set; }
        public int? Basket12 { get; set; }
        public int? Basket13 { get; set; }
        public int? Basket14 { get; set; }
        public int? Basket15 { get; set; }

        //  [Name("Set Permissions on Create")]
        //   public int SetPermissionsonCreate { get; set; }
        /// <summary>
        /// public int? Basket16 { get; set; }
        /// </summary>
        //public int? Basket17 { get; set; }
        //public int? Basket18 { get; set; }
        //public int? Basket19 { get; set; }
        //public int? Basket20 { get; set; }
        //public int? Basket21 { get; set; }
       // public int? Basket22 { get; set; }
        //public int? Basket23 { get; set; }
       // public int? Basket24 { get; set; }
        //public int? Basket25 { get; set; }

        //public int? Basket26 {get;set;}
       // public int? Basket27 { get; set; }
        
        //public DateTime Modified { get; set; }

        //[Name("Modified By")]
       // public string ModifiedBy { get; set; }

       // [Name("Item Type")]
       // public string ItemType { get; set; }
       // public string Path { get; set; }
    }
}
