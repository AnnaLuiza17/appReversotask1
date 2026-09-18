using System;
using System.Collections.Generic;

namespace appReversotask1.Models;

public partial class Medicamento
{
    public int MedicamentosId { get; set; }

    public int? ConsultaId { get; set; }

    public string? NomeMedicamento { get; set; }

    public string? Dosagem { get; set; }
}
