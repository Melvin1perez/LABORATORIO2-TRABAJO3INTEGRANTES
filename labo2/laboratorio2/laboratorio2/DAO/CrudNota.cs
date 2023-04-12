using laboratorio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio2.DAO
{
    public class CrudNota
    {
        public void AgregarNota(Nota ParametroNota)
        {
            using (NotasEstudiantesContext db = new NotasEstudiantesContext())
            {
                Nota Nota = new Nota();
                Nota.Materia = ParametroNota.Materia;
                Nota.NombreEstudiante = ParametroNota.NombreEstudiante;
                Nota.Lab1 = ParametroNota.Lab1;
                Nota.Parcial1 = ParametroNota.Parcial1;
                Nota.Lab2= ParametroNota.Lab2;
                Nota.Parcial2 = ParametroNota.Parcial2;
                Nota.Lab3= ParametroNota.Lab3;
                Nota.Parcial3 = ParametroNota.Parcial3;
                Nota.Resultado= ParametroNota.Resultado;
                db.Add(Nota);
                db.SaveChanges();

            }
        }

        public Nota NotaIndividual(int id)
        {
            using (NotasEstudiantesContext db = new NotasEstudiantesContext())
            {
                var buscar = db.Notas.FirstOrDefault(x => x.IdNotas == id);
                return buscar;
            }
        }

        public List<Nota> ListarNotas()
        {
            using (NotasEstudiantesContext db = new NotasEstudiantesContext())
            { return db.Notas.ToList(); }
        }

        public void CalcularResultado(Nota notas)
        {

            var Periodo1 = (notas.Lab1 * Convert.ToDecimal(0.4)) + (notas.Parcial1 * Convert.ToDecimal(0.6));
            var Periodo2 = (notas.Lab2 * Convert.ToDecimal(0.4)) + (notas.Parcial2 * Convert.ToDecimal(0.6));
            var Periodo3 = (notas.Lab3 * Convert.ToDecimal(0.4)) + (notas.Parcial3 * Convert.ToDecimal(0.6));

            notas.Resultado = (Periodo1 + Periodo2 + Periodo3)/3;

        }

    }
}