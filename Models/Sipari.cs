using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class Sipari //Siparis
{
   
    public int SiparisId { get; set; }

    //SiparisVeren
    public int MusteriId { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    //ParaBirimi
    public int ParaBirimiId { get; set; }

    //Tutar
    public decimal ToplamTutar { get; set; }

    //SiparisDetaylari
    public string? SiparisDetayları { get; set; }

    //SiparisDurumu
    public int SiparisDurumuId { get; set; }

    public virtual Musteri Musteri { get; set; } = null!;

    public virtual ParaBirimi ParaBirimi { get; set; } = null!;

    public virtual SiparisDurumu SiparisDurumu { get; set; } = null!;

    public virtual ICollection<Tahsilat> Tahsilats { get; } = new List<Tahsilat>();
}
