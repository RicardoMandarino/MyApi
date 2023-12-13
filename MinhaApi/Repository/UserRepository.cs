﻿using Dapper;
using MinhaApi.Contracts.Repository;
using MinhaApi.DTO;
using MinhaApi.Entity;
using MinhaApi.Infrastructure;
using System.Collections;

namespace MinhaApi.Repository
{
    public class UserRepository : Connection, IUserRepository
    {
        public async Task Add(UserDTO user)
        {
            string sql = @"
                INSERT INTO USER(Name, Email, Password)
                            VALUE (@Name, @Email, @Password)
            ";
            await Execute(sql, user);
        }

        public async Task Delete(int id)
        {
            string sql = "DELETE FROM USER WHERE Id = @id";
            await Execute(sql, new { id });
        }

        public async Task<IEnumerable<UserEntity>> Get()
        {
             string sql = "SELECT * FROM USER";
             return await GetConnection().QueryAsync<UserEntity>(sql);
        }

        public async Task<UserEntity> GetByID(int id)
        {
            string sql = "SELECT * FROM USER WHERE ID = @id";
            return await GetConnection().QueryFirstAsync<UserEntity>(sql, new { id });
        }

        public async Task Update(UserEntity user)
        {
            string sql = @"
                 UPDATE USER
                    SET Name = @Name, 
                        Email = @Email, 
                        Password = @Password
                WHERE Id = @Id
            ";
            await Execute(sql, user);
        }
    }
}
