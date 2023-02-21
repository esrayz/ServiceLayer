using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class Urun
{
    public int UrunId { get; set; }

    public string UrunAdi { get; set; } = null!;

    public string UrunKodu { get; set; } = null!;

    //ParaBirimi
    public int ParaBirimiId { get; set; }

    //Fiyat
    public decimal Fiyati { get; set; }

    public int Stok { get; set; }

    public string? Aciklama { get; set; }

    public virtual ParaBirimi ParaBirimi { get; set; } = null!;

    public virtual ICollection<UrunKategorisi> UrunKategorisis { get; } = new List<UrunKategorisi>();
}
