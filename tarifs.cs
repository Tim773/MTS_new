//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MTS
{
    using System;
    using System.Collections.Generic;
    
    public partial class tarifs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tarifs()
        {
            this.abonents = new HashSet<abonents>();
        }
    
        public int idTarif { get; set; }
        public string nameTarif { get; set; }
        public string count { get; set; }
        public int minuts { get; set; }
        public int sms { get; set; }
        public double gb { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<abonents> abonents { get; set; }
    }
}
