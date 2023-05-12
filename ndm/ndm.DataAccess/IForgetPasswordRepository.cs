namespace NDM.Service
{
    using NDM.DTO;

    public interface IForgetPasswordRepository
    {
        Task<ForgetPasswordModel> GetForgetPasswordDataByIdAsync(int id);
        Task<int> CreateForgetPasswordDataAsync(ForgetPasswordModel forgetPasswordModel);
        Task<int> UpdateForgetPasswordDataAsync(ForgetPasswordModel forgetPasswordModel);
        Task<int> DeleteForgetPasswordDataAsync(int id);
    }
}