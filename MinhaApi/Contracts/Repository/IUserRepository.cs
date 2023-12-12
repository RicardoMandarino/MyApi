using MinhaApi.Entity;

namespace MinhaApi.Contracts.Repository
{
    public interface IUserRepository
    {
        Task Add(UserEntity user);
        Task Update(UserEntity user);
        Task Delete(UserEntity user);
        Task<UserEntity> GetByID(int id);
        Task<IEnumerable<UserEntity>> Get();
    }
}
