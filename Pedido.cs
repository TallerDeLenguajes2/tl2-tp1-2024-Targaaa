public class Pedido
{
    private int nro;
    private string obs;
    private Cliente cliente;
    private int estado;

    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }
    public Cliente Cliente { get => cliente; set => cliente = value; }
    public int Estado { get => estado; set => estado = value; }
    public Pedido(string nombre, string direccion, string telefono, string datosDireccion)
    {
        this.cliente = new Cliente(){
            Nombre =  nombre,
            Direccion = direccion,
            Telofono = telefono,
            DatosDireccion =  datosDireccion
        };
    }
}