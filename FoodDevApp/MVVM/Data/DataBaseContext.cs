using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodDevApp.MVVM.Data
{
    internal class DataBaseContext : IAsyncDisposable
    {
        private const string DBName = "Database.db3";
        private static string DbPath => Path.Combine(FileSystem.AppDataDirectory, DBName);

        private SQLiteAsyncConnection _connection;
        private SQLiteAsyncConnection Database => (_connection ??= new SQLiteAsyncConnection(DbPath,
            SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache));


        private async Task CreateTableIfNotExists<TTable>() where TTable : class, new()
        {
            await Database.CreateTableAsync<TTable>();
        }

        private async Task<AsyncTableQuery<TTable>> GetTableAsync<TTable>() where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return Database.Table<TTable>();
        }

        public async Task<IEnumerable<TTable>> GetAllAsync<TTable>() where TTable : class, new()
        {
            var table = await GetTableAsync<TTable>();
            return await table.ToListAsync();

        }

        public async Task<IEnumerable<TTable>> GetFilteredAsync<TTable>(Expression<Func<TTable, bool>> predicate) where TTable : class, new()
        {
            var table = await GetTableAsync<TTable>();
            return await table.Where(predicate).ToListAsync();
        }

        public async Task<TTable> GetitemByKeyAsync<TTable>(object primaryKey) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.GetAsync<TTable>(primaryKey);

        }


        public async Task<bool> AdditemAsync<TTable>(TTable Item) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.InsertAsync(Item) > 0;
        }
        public async Task<bool> UpdateitemAsync<TTable>(TTable Item) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.UpdateAsync(Item) > 0;
        }

        public async Task<bool> DeleteitemAsync<TTable>(TTable Item) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.DeleteAsync(Item) > 0;
        }
        public async Task<bool> DeleteitemByKeyAsync<TTable>(object primaryKey) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.DeleteAsync<TTable>(primaryKey) > 0;

        }

        public async ValueTask DisposeAsync() => await _connection?.CloseAsync();




    }
}
