using System;

namespace Challenge_Ej5
{
    public abstract class Animal
    {
        protected abstract string Nombre { get; }
     //   public abstract string SetNombre(string nombre) { set; }    
      //  public abstract string GetNombre() { return Nombre; }
        public abstract void Comer();
    }
}
