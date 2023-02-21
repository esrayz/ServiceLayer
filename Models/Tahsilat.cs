using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class Tahsilat
{
    public int TahsilatId { get; set; }
    //Musteri
    public int MusteriId { get; set; }

    //ParaBirimi
    public int ParaBirimiId { get; set; }

    //Tutar
    public decimal ToplamTutar { get; set; }
    
    //İlgiliSiparis
    public int SiparisId { get; set; }

    //Tahsilat Tarihi

    public int TahsilatTipiId { get; set; }

    public virtual Musteri Musteri { get; set; } = null!;

    public virtual ParaBirimi ParaBirimi { get; set; } = null!;

    public virtual Sipari Siparis { get; set; } = null!;

    public virtual TahsilatTipi TahsilatTipi { get; set; } = null!;
}
