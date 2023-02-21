using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class Odeme
{
    public int OdemeId { get; set; }

    //Kime
    public int MusteriId { get; set; }

    public DateTime? OdemeTarihi { get; set; }

    //ParaBirimi
    public int ParaBirimiId { get; set; }

    //Tutar
    public decimal ToplamTutar { get; set; }

    //OdemeKanali
    public int OdemeKanaliId { get; set; }

    public string? Aciklama { get; set; }

    public virtual Musteri Musteri { get; set; } = null!;

    public virtual OdemeKanali OdemeKanali { get; set; } = null!;

    public virtual ParaBirimi ParaBirimi { get; set; } = null!;
}
