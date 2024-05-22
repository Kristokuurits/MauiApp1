using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

public class Database
{
    private readonly SQLiteAsyncConnection _database;

    public Database(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Item>().Wait();
    }

    public Task<List<Item>> GetItemsAsync()
    {
        return _database.Table<Item>().ToListAsync();
    }

    public Task<Item> GetItemAsync(int id)
    {
        return _database.Table<Item>().Where(i => i.ID == id).FirstOrDefaultAsync();
    }

    public Task<int> SaveItemAsync(Item item)
    {
        if (item.ID != 0)
        {
            return _database.UpdateAsync(item);
        }
        else
        {
            return _database.InsertAsync(item);
        }
    }

    public Task<int> DeleteItemAsync(Item item)
    {
        return _database.DeleteAsync(item);
    }
}

public class Item
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
