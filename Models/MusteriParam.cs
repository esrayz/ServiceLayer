using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ServiceLayer.Models;

public partial class MusteriParam
{
    
   

    public string MusteriAdi { get; set; } = null!;

    public string MusteriSoyadi { get; set; } = null!;

   
    public int Cinsiyet { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public string? Adres { get; set; }

    
    public int Sehir { get; set; }

    

    //[NotMapped]
    //[JsonPropertyName("Cinsiyet")]
    //public string Cins { get { return "Kadın"; } }

    //[JsonIgnore]
    //public virtual Sehir MusteriNavigation { get; set; } = null!;

}
