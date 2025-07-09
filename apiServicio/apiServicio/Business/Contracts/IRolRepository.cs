using apiServicio.Models;

namespace apiServicio.Business.Contracts
{
    public interface IRolRepository
    {
        Task<Rol> AgregaActualiza(Rol l, string t);
        Task<List<Rol>> GetList();
        
    }
}
