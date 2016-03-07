namespace AdventureWorksEntityFramework.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(ProductInventory_Meta))]
    public partial class ProductInventory
    {

    }
    public class ProductInventory_Meta
    {
        [Key]
        public string ProductID { get; set; }
    }
}
