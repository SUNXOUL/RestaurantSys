using System;

public class Platillo{

    public String Nombre;
    public String Ingredientes;
    public int Precio;
    public String Tipo;

    public String Pic;

    public Platillo(String Nombre, String Ingredientes,int Precio,String Tipo,String Pic)
    {
        this.Nombre=Nombre;
        this.Ingredientes=Ingredientes;
        this.Precio = Precio;
        this.Tipo=Tipo;
        this.Pic=Pic;
    }

}