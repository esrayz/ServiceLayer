using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class UrunKategorisi
{
    public int UrunKategorisiId { get; set; }

    public int UrunId { get; set; }

    //Urun Kategorisi
    public string UrunKategorisi1 { get; set; } = null!;

    public virtual Urun Urun { get; set; } = null!;
}
