using System;

namespace Company.ClassLibrary1;

public class ProductoService
{
    private readonly AppDbContext _context
    {
        _context = context
    }
    
    public void Agregar(string Nombre, decimal Precio)
    {
        Nombre = nombre,
        Precio = precio
    };
    _context.Productos.add(Producto)
    _context.SaveChanges();
    public list<Producto> Obtener Todos(){
        return _context.Producto.ToList();
    }
}
