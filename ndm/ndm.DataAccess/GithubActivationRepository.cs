namespace ndm
{
    public class GithubActivationRepository : IGithubActivationRepository
    {
        public async Task<GithubActivationModel> GetActivationDetailsAsync(int id)
        {
            //TODO: implement logic to get activation details
            return await Task.FromResult(new GithubActivationModel());
        }
        public async Task<bool> UpdateActivationDetailsAsync(GithubActivationModel model)
        {
            //TODO: implement logic to update activation details
            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteActivationDetailsAsync(int id)
        {
            //TODO: implement logic to delete activation details
            return await Task.FromResult(true);
        }
    }
}