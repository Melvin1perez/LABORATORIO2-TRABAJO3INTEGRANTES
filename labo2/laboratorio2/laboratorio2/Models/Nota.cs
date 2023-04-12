using System;
using System.Collections.Generic;

namespace laboratorio2.Models;

public partial class Nota
{
    public int IdNotas { get; set; }

    public string NombreEstudiante { get; set; } = null!;

    public decimal Lab1 { get; set; }

    public decimal Parcial1 { get; set; }

    public decimal Lab2 { get; set; }

    public decimal Parcial2 { get; set; }

    public decimal Lab3 { get; set; }

    public decimal Parcial3 { get; set; }

    public decimal Resultado { get; set; }

    public string Materia { get; set; } = null!;
}
