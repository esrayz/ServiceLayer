using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class VUrun
{
    public int UrunId { get; set; }

    public string UrunAdi { get; set; } = null!;

    public string Kodu { get; set; } = null!;

    
    public string ParaBirimi { get; set; }

   
    public decimal Fiyat { get; set; }

    public int Stok { get; set; }

    public string? Aciklama { get; set; }

    

    
}
