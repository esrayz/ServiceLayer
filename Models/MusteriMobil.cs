using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ServiceLayer.Models;

public partial class MusteriMobil
{
    public int ID { get; set; }

    public string Adi { get; set; } = null!;

    public string Soyadi { get; set; } = null!;



    public string? Adres { get; set; }



}
