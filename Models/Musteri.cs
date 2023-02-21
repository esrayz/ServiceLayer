using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ServiceLayer.Models;

public partial class Musteri
{
    //[JsonProperty(PropertyName = "ID")]
    [JsonPropertyName("ID")]
    public int MusteriId { get; set; }

    public string MusteriAdi { get; set; } = null!;

    public string MusteriSoyadi { get; set; } = null!;

    //Cinsiyet
    public int CinsiyetId { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public string? Adres { get; set; }

    //Sehir
    public int SehirId { get; set; }

    [JsonIgnore]
    public virtual Cinsiyet Cinsiyet { get; set; } = null!;

    //[NotMapped]
    //[JsonPropertyName("Cinsiyet")]
    //public string Cins { get { return "Kadın"; } }

    //[JsonIgnore]
    //public virtual Sehir MusteriNavigation { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Odeme> Odemes { get; } = new List<Odeme>();

    [JsonIgnore]
    public virtual ICollection<Sipari> Siparis { get; } = new List<Sipari>();

    [JsonIgnore]
    public virtual ICollection<Tahsilat> Tahsilats { get; } = new List<Tahsilat>();
}
