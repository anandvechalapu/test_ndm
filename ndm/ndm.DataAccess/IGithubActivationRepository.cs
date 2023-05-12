namespace ndm.Service
{
    using ndm.DTO;
    public interface IGithubActivationRepository
    {
        Task<GithubActivationModel> GetActivationDetailsAsync(int id);
        Task<bool> UpdateActivationDetailsAsync(GithubActivationModel model);
        Task<bool> DeleteActivationDetailsAsync(int id);
    }
}