//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sotrs
    {
        public int sotrID { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public string otch { get; set; }
        public int rojd { get; set; }
        public string pas { get; set; }
        public int doljID { get; set; }
    
        public virtual Doljs Doljs { get; set; }
    }
}