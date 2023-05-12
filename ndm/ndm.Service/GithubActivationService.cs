namespace ndm.Service
{
    using ndm.DataAccess;
    using ndm.DTO;
    public class GithubActivationService : IGithubActivationService
    {
        private readonly IGithubActivationRepository _githubActivationRepository;
        public GithubActivationService(IGithubActivationRepository githubActivationRepository)
        {
            _githubActivationRepository = githubActivationRepository;
        }

        public async Task<GithubActivationModel> GetActivationDetailsAsync(int id)
        {
            return await _githubActivationRepository.GetActivationDetailsAsync(id);
        }

        public async Task<bool> UpdateActivationDetailsAsync(GithubActivationModel model)
        {
            return await _githubActivationRepository.UpdateActivationDetailsAsync(model);
        }

        public async Task<bool> DeleteActivationDetailsAsync(int id)
        {
            return await _githubActivationRepository.DeleteActivationDetailsAsync(id);
        }
    }
}