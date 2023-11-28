using SQLite;

using FoodDevApp.MVVM.Model;

namespace FoodDevApp.MVVM
{
    class LocalDBService
    {
        private const string Db_name = "demo_local_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDBService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, Db_name));
            _connection.CreateTableAsync<Users>();
        }

        public async Task<List<Users>> GetUsers()
        {
            return await _connection.Table<Users>().ToListAsync();
        }

        public async Task<Users> GetByID(int id)
        {
            return await _connection.Table<Users>().Where(X => X.Id == id).FirstOrDefaultAsync();
        }

        public async Task Create(Users user)
        {
            await _connection.InsertAsync(user);
        }

        public async Task Update(Users user)
        {
            await _connection.UpdateAsync(user);
        }

        public async Task Delete(Users user)
        {
            await _connection.DeleteAsync(user);
        }
    }
}
