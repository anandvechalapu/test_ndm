namespace ndm
{
    public class ConfigureGithubRepository : IConfigureGithubRepository
    {
        private readonly ndmDTO _db;

        public ConfigureGithubRepository(ndmDTO db)
        {
            _db = db;
        }

        public async Task<int> Create(ConfigureGithubModel model)
        {
            var result = await _db.ConfigureGithub.AddAsync(model);
            await _db.SaveChangesAsync();
            return result.Entity.Id;
        }

        public async Task<ConfigureGithubModel> Read(int id)
        {
            return await _db.ConfigureGithub.FindAsync(id);
        }

        public async Task<bool> Update(ConfigureGithubModel model)
        {
            _db.ConfigureGithub.Update(model);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            _db.ConfigureGithub.Remove(await _db.ConfigureGithub.FindAsync(id));
            await _db.SaveChangesAsync();
            return true;
        }
    }
}