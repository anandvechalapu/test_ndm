namespace NDM.Service
{
    using NDM.DataAccess;
    using NDM.DTO;
    using System.Threading.Tasks;

    public class ForgetPasswordService : IForgetPasswordService
    {
        private readonly IForgetPasswordRepository _forgetPasswordRepository;

        public ForgetPasswordService(IForgetPasswordRepository forgetPasswordRepository)
        {
            _forgetPasswordRepository = forgetPasswordRepository;
        }

        public async Task<ForgetPasswordModel> GetForgetPasswordDataByIdAsync(int id)
        {
            return await _forgetPasswordRepository.GetForgetPasswordDataByIdAsync(id);
        }

        public async Task<int> CreateForgetPasswordDataAsync(ForgetPasswordModel forgetPasswordModel)
        {
            return await _forgetPasswordRepository.CreateForgetPasswordDataAsync(forgetPasswordModel);
        }

        public async Task<int> UpdateForgetPasswordDataAsync(ForgetPasswordModel forgetPasswordModel)
        {
            return await _forgetPasswordRepository.UpdateForgetPasswordDataAsync(forgetPasswordModel);
        }

        public async Task<int> DeleteForgetPasswordDataAsync(int id)
        {
            return await _forgetPasswordRepository.DeleteForgetPasswordDataAsync(id);
        }
    }
}