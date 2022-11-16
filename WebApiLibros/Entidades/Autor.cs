namespace WebApiLibros.Entidades
{
    public class Autor
    {
        public Autor(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
