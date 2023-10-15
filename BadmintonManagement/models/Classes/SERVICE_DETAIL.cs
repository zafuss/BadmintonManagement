namespace BadmintonManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVICE_DETAIL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string ServiceReceiptNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ServiceID { get; set; }

        public int? Quantity { get; set; }

        public virtual C_SERVICE C_SERVICE { get; set; }

        public virtual SERVICE_RECEIPT SERVICE_RECEIPT { get; set; }
    }
}
