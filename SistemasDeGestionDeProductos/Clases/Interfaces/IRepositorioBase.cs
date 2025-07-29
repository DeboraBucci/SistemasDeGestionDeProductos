namespace SistemasDeGestionDeProductos.Clases.Interfaces
{
    public interface IRepositorioBase<T>
    {
        IReadOnlyCollection<T> BuscarTodos();
        T? BuscarPorId(Guid id);
        void Agregar(T entidad);
    }
}
