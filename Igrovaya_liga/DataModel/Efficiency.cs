//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Igrovaya_liga.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Efficiency
    {
        public int Id { get; set; }
        public string Season { get; set; }
        public string Week { get; set; }
        public int ResultDay1 { get; set; }
        public int ResultDay2 { get; set; }
        public int ResultDay3 { get; set; }
        public int PlayerId { get; set; }
        public int GameId { get; set; }
    
        public virtual Game Game { get; set; }
        public virtual Player Player { get; set; }
    }
}
