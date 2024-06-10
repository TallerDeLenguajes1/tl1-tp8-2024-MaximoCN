using System;

namespace Tareas;

 public class Tarea{
    private static Random random = new Random();
     private int tareaID; //Numerado en ciclo iterativo
    private string descripcion; //
    private int duracion; // entre 10 – 100
   

     public int TareaID { get => tareaID; }
    public string Descripcion { get => descripcion;set=>descripcion=value;}
    public int Duracion { get => duracion; }

    public Tarea(string descripcion)
    {
        this.descripcion = descripcion;
        this.duracion = Duracion;
        this.tareaID = random.Next(0,100);
    }
    
};
    