public class Cadeteria
{
    private List<Cadete> ListadoCadetes; //implementar composicion
    private long telefono;
    private string nombre;
    public long Telefono { get => telefono; set => telefono = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public Cadeteriaa()
    {
        ListadoCadetes = new List<Cadete>();
    }
}
