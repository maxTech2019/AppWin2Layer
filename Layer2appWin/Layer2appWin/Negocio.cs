using System;

public class Negocio
{
    public Negocio()
    {
        ArrayList Personas = new ArrayList();
    }

    public Persona CrearPersona(string pCodigo, string pNombres, string pApellidos, string pEmail, DateTime pFecha, decimal pSueldo)
    {
        Persona miPersona = new Persona();
        miPersona.Codigo = pCodigo;
        miPersona.Nombres = pNombres;
        miPersona.Apellidos = pApellidos;
        miPersona.Email = pEmail;
        miPersona.FechNacimiento = pFecha;
        miPersona.Sueldo = pSueldo;
        Personas.Add(miPersona);
    }

}
