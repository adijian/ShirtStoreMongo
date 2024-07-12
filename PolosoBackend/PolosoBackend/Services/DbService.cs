using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PolosoBackend.Models;

namespace BookStoreApi.Services;

public class DbService
{
    private readonly IMongoCollection<Shirt> _collection;

    public DbService(IOptions<StoreDatabaseSettings> storeDatabaseSettings)
    {
        var mongoClient = new MongoClient(storeDatabaseSettings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(storeDatabaseSettings.Value.DatabaseName);
        _collection = mongoDatabase.GetCollection<Shirt>(storeDatabaseSettings.Value.CollectionName);
    }

    public async Task<List<Shirt>> GetAsync() =>
        await _collection.Find(_ => true).ToListAsync();

    public async Task<Shirt?> GetAsync(string id) =>
        await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Shirt newShirt) =>
        await _collection.InsertOneAsync(newShirt);

    public async Task UpdateAsync(string id, Shirt updatedShirt) =>
        await _collection.ReplaceOneAsync(x => x.Id == id, updatedShirt);

    public async Task RemoveAsync(string id) =>
        await _collection.DeleteOneAsync(x => x.Id == id);
}