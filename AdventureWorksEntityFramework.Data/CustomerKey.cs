namespace AdventureWorksEntityFramework.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(Customer_Meta))]
    public partial class Customer
    {

    }
    public class Customer_Meta
    {
        [Key]
        public string CustomerID { get; set; }
    }
}
