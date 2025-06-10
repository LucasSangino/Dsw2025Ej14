using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Data
{
    public interface IPersistenciaEnMemoria
    {
        List<Product> ListaDeProductos { get; set; }

        void LoadsProducts();
    }
}