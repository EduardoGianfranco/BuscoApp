namespace BuscoApp.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string NombreP { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Celular { get; set; }
        public string LugarCompra { get; set; }
        public string NomComprador { get; set; }
        public string Categoria { get; set;}
    }
}