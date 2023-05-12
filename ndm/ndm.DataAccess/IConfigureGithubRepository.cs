namespace ndm.Service
{
    using ndm.DTO;

    public interface IConfigureGithubRepository
    {
        Task<int> Create(ConfigureGithubModel model);
        Task<ConfigureGithubModel> Read(int id);
        Task<bool> Update(ConfigureGithubModel model);
        Task<bool> Delete(int id);
    }
}