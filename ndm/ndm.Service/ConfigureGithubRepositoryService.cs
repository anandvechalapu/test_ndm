namespace ndm.Service
{   
    using ndm.DataAccess;
    using ndm.DTO;
    using System.Threading.Tasks;

    public class ConfigureGithubRepositoryService : IConfigureGithubRepositoryService
    {
        private readonly ndmDTO _db;

        public ConfigureGithubRepositoryService(ndmDTO db)
        {
            _db = db;
        }

        public async Task<int> CreateAsync(ConfigureGithubModel model)
        {
            var result = await _db.ConfigureGithub.AddAsync(model);
            await _db.SaveChangesAsync();
            return result.Entity.Id;
        }

        public async Task<ConfigureGithubModel> ReadAsync(int id)
        {
            return await _db.ConfigureGithub.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(ConfigureGithubModel model)
        {
            _db.ConfigureGithub.Update(model);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            _db.ConfigureGithub.Remove(await _db.ConfigureGithub.FindAsync(id));
            await _db.SaveChangesAsync();
            return true;
        }
    }
}