namespace ndm.Service
{
    using ndm.DataAccess;
    using ndm.DTO;

    public interface IGithubActivationService
    {
        Task<GithubActivationModel> GetActivationDetailsAsync(int id);
        Task<bool> UpdateActivationDetailsAsync(GithubActivationModel model);
        Task<bool> DeleteActivationDetailsAsync(int id);
    }
}