namespace AdventureWorksEntityFramework.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(vProductProductInventory_Meta))]
    public partial class vProductProductInventory
    {

    }
    public class vProductProductInventory_Meta
    {
        [Key]
        public string ProductID { get; set; }
    }
}
