using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class ParaBirimi
{
    public int ParaBirimiId { get; set; }

    public string ParaBirimi1 { get; set; } = null!;

    public virtual ICollection<Odeme> Odemes { get; } = new List<Odeme>();

    public virtual ICollection<Sipari> Siparis { get; } = new List<Sipari>();

    public virtual ICollection<Tahsilat> Tahsilats { get; } = new List<Tahsilat>();

    public virtual ICollection<Urun> Uruns { get; } = new List<Urun>();
}
