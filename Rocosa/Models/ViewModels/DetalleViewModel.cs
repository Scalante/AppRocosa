namespace Rocosa.Models.ViewModels
{
    public class DetalleViewModel
    {
        public DetalleViewModel()
        {
            Producto = new Producto();
        }

        public Producto Producto { get; set; }
        public bool ExisteEnCarro { get; set; }
    }
}
