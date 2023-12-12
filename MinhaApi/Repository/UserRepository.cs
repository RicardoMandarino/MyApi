using Dapper;
using MinhaApi.Contracts.Repository;
using MinhaApi.Entity;
using MinhaApi.Infrastructure;

namespace MinhaApi.Repository
{
    public class UserRepository : Connection, IUserRepository
    {
        public Task Add(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public Task Delete(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserEntity>> Get()
        {
                string sql = "SELECT * FROM USER";
                return await GetConnection().QueryAsync<UserEntity>(sql);
        }

        public Task<UserEntity> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
