namespace ndm.Service
{
    using ndm.DTO;
    using System.Threading.Tasks;

    public interface IConfigureGithubRepositoryService
    {
        Task<int> CreateAsync(ConfigureGithubModel model);
        Task<ConfigureGithubModel> ReadAsync(int id);
        Task<bool> UpdateAsync(ConfigureGithubModel model);
        Task<bool> DeleteAsync(int id);
    }
}