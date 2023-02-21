using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ServiceLayer.Models;

public partial class VMusteri
{
    
    public int ID { get; set; }

    public string MusteriAdi { get; set; } = null!;

    public string MusteriSoyadi { get; set; } = null!;

    
    public string Cinsiyet { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public string? Adres { get; set; }

    public string Sehir { get; set; }


}
