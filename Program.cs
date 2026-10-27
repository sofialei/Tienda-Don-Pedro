using var context = new AppDbContext();
ver service = new ProductoService(context);
service.Agregar("mouse", 13000);
service.Agregar("teclado", 123000);
console.WriteLine("Lista de Productos");
foreach (var p in service.ObtenerTodos){
    console.WriteLine($"{p.Id}-{p.Nombre}-{p.Precio}");
}

//git init 
//git add .
//git commit -m "primer commit - tienda simple"
//git remote add origin https://github.com/TU_USUARIO/tiendasimple.git
//git branch -M Main
//git push -u origin Main