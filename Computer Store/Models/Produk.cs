//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Computer_Store.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produk()
        {
            this.PembelianBarangs = new HashSet<PembelianBarang>();
            this.PenjualanBarangs = new HashSet<PenjualanBarang>();
        }
    
        public int IDProduk { get; set; }
        public string NamaProduk { get; set; }
        public string KategoriProduk { get; set; }
        public string MerkProduk { get; set; }
        public int StockProduk { get; set; }
        public decimal HargaProduk { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PembelianBarang> PembelianBarangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PenjualanBarang> PenjualanBarangs { get; set; }
    }
}
