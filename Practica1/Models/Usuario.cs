using System;
using System.Collections.Generic;

namespace Practica1.Models;

public partial class Usuario
{
    public int Idusuario { get; set; }

    public string? Nombre { get; set; }

    public string? Contrasenia { get; set; }

    public string? Genero { get; set; }

    public string? Direccion { get; set; }

     public List<string>? Pasatiempo { get; set; }

    public string? Curso { get; set; }

    public string? Conocimiento { get; set; }
}
