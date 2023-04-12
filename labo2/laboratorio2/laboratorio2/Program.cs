using laboratorio2.DAO;
using laboratorio2.Models;

CrudNota CrudNota = new CrudNota();
Nota Nota = new Nota();

bool continuar = true;
while (continuar)
{
    Console.WriteLine ("Bienvenido Aqui puede calcular sus Notas");
    Console.WriteLine ("/-/-/-/-/-/-/Menu/-/-/-/-/");
    Console.WriteLine ("pulse 1 para calcular Notas");
    Console.WriteLine ("pulse 2 para listar notas");

    var Menu = Convert.ToInt32(Console.ReadLine());
    switch (Menu)
    {

        case 1:
            Console.WriteLine("Digite el nombre de la materia");
            Nota.Materia = Console.ReadLine();
            Console.WriteLine("Digite el nombre del Estudiante ");
            Nota.NombreEstudiante = Console.ReadLine();
            Console.WriteLine("Digete la nota del laboratorio 1 ");
            Nota.Lab1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite la nota del Parcial 1 ");
            Nota.Parcial1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite la nota del laboratorio 2 ");
            Nota.Lab2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite la nota del Parcial 2 ");
            Nota.Parcial2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite la nota del laboratorio 3 ");
            Nota.Lab3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite la nota del Parcial 3 ");
            Nota.Parcial3 = Convert.ToDecimal(Console.ReadLine());


            CrudNota.CalcularResultado(Nota);
            CrudNota.AgregarNota(Nota);
            Console.WriteLine($"su resultado es {Nota.Resultado}");
            Console.WriteLine("Sus notas se han guardado");




            break;

        case 2:
            Console.WriteLine("Lista de Notas");
            var ListarNotas = CrudNota.ListarNotas();
            foreach (var iteracionNota in ListarNotas)
            {
                Console.WriteLine($"ID {iteracionNota.IdNotas},Nombre de la Materia: {iteracionNota.Materia},Nombre del Alumno:{iteracionNota.NombreEstudiante},lab 1:{iteracionNota.Lab1},parcial 2:{iteracionNota.Parcial1},lab 2: {iteracionNota.Lab2},parcial 2: {iteracionNota.Parcial2},lab 3:{iteracionNota.Lab3},parcial 3:{iteracionNota.Parcial3},su nota final: {iteracionNota.Resultado}");
            }
            break;

    }


    Console.WriteLine("desea continuar? /n presione S para si y N para No");
    var cont = Console.ReadLine();
    if (cont.Equals("N"))
    {
        continuar = false;
    }
}