public class Cadete
{
    private string nombre;
    private string direccion;
    private string id;
    private string telofono;
    private List<Pedido> ListadoPedidos = new List<Pedido>();
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Id { get => id; set => id = value; }
    public string Telofono { get => telofono; set => telofono = value; }
    //no agregar metodos sin necesidad, a menos que sean claros.
    public Cadete(Pedido pedido)
    {

    }
}