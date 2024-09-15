namespace Estudiantes.Tests;

public class PruebaEstudiante2
{
    [SetUp]
    public void Setup()
    {
    }

    //Inciso 1

    [Test]
    public void TestNombreMenor10()
    {
        var niEstudiante = new Estudiante() {nombre = "Oscar", Punteo = 85, Carrera = "Ingenieria"};
        Assert.IsFalse(niEstudiante.EstudianteValido());
        Assert.IsTrue(niEstudiante.Errores.Any());
        Assert.IsTrue(niEstudiante.Errores.Contains("El Nombre del Estudiante es Muy Corto"));
    }

    [Test]
    public void TestNombreCorrecto()
    {
        var niEstudiante = new Estudiante() {nombre = "Oscar Javier Morales Solorzano", Punteo = 85, Carrera = "Ingenieria"};
        Assert.IsTrue(niEstudiante.EstudianteValido());
        Assert.IsFalse(niEstudiante.Errores.Any());
    }

    //Inciso 2

    [Test]
    public void TestCarreraInvalida()
    {
        var niEstudiante = new Estudiante() { nombre = "Oscar Javier", Punteo = 85, Carrera = "Historia" };
        Assert.IsFalse(niEstudiante.EstudianteValido());
        Assert.IsTrue(niEstudiante.Errores.Contains("Carrera no permitida"));
    }

    [Test]
    public void TestCarreraValida()
    {
        var niEstudiante = new Estudiante() { nombre = "Oscar Javier", Punteo = 85, Carrera = "Ingenieria" };
        Assert.IsTrue(niEstudiante.EstudianteValido());
        Assert.IsFalse(niEstudiante.Errores.Any());
    }

    //Inciso 3

    [Test]
    public void TestEstudianteAprobadoMedicina()
    {
        var estudiante = new Estudiante() { nombre = "Monica Michelle", Punteo = 85, Carrera = "Medicina" };
        Assert.IsTrue(estudiante.EstudianteAprobado());
    }

    [Test]
    public void TestEstudianteReprobadoMedicina()
    {
        var estudiante = new Estudiante() { nombre = "Monica Michelle", Punteo = 83, Carrera = "Medicina" };
        Assert.IsFalse(estudiante.EstudianteAprobado());
    }

    [Test]
    public void TestEstudianteAprobadoIngenieria()
    {
        var estudiante = new Estudiante() { nombre = "Oscar Javier", Punteo = 70, Carrera = "Ingenieria" };
        Assert.IsTrue(estudiante.EstudianteAprobado());
    }

    [Test]
    public void TestEstudianteReprobadoIngenieria()
    {
        var estudiante = new Estudiante() { nombre = "Oscar Javier", Punteo = 68, Carrera = "Ingenieria" };
        Assert.IsFalse(estudiante.EstudianteAprobado());
    }

    //Inciso 4

    [Test]
    public void TestPunteoInvalido()
    {
        var estudiante = new Estudiante() { nombre = "Oscar Javier", Punteo = 101, Carrera = "Ingenieria" };
        Assert.IsFalse(estudiante.EstudianteValido());
        Assert.IsTrue(estudiante.Errores.Contains("El punteo del estudiante no puede ser mayor a 100"));
    }

    [Test]
    public void TestPunteoValido()
    {
        var estudiante = new Estudiante() { nombre = "Oscar Javier", Punteo = 99, Carrera = "Ingenieria" };
        Assert.IsTrue(estudiante.EstudianteValido());
    }

    //Inciso 5

    [Test]
    public void TestNombreObligatorio()
    {
        var estudiante = new Estudiante() { nombre = "", Punteo = 85, Carrera = "Ingenieria" };
        Assert.IsFalse(estudiante.EstudianteValido());
        Assert.IsTrue(estudiante.Errores.Contains("El nombre del estudiante es requerido"));
    }

    [Test]
    public void TestPunteoObligatorio()
    {
        var estudiante = new Estudiante() { nombre = "Oscar Javier", Punteo = 0, Carrera = "Ingenieria" };
        Assert.IsFalse(estudiante.EstudianteValido());
        Assert.IsTrue(estudiante.Errores.Contains("El punteo del estudiante es requerido"));
    }

    [Test]
    public void TestCarreraObligatorio()
    {
        var estudiante = new Estudiante() { nombre = "Oscar Javier", Punteo = 85, Carrera = "" };
        Assert.IsFalse(estudiante.EstudianteValido());
        Assert.IsTrue(estudiante.Errores.Contains("La carrera del estudiante es requerida"));
    }



}