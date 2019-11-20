using System;
using Persona;

public class Negocio
{
    public Negocio()
    {
        ArrayList Personas = new ArrayList();
    }

    public void CrearPersona(string pCodigo, string pNombres, string pApellidos, string pEmail, DateTime pFecha, decimal pSueldo)
    {
        if (!existeRegistro())
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
        else
        {
            Messagebox.Show("Registro Ya Existe","Mensaje de Error..");
        }
    }
    public Personas actualizarListaPersonas()
    {
        return Personas;
    }

    public bool existeRegistro(string ID)
    {
        foreach (Persona Individual in Personas)
        {
            if (Individual.Codigo == ID)
            {
                return true;
            }
        }
        return false;
    }
}
