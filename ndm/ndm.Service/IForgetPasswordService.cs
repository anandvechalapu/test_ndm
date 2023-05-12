namespace NDM.Service
{
    using NDM.DTO;
    using System.Threading.Tasks;

    public interface IForgetPasswordService
    {
        Task<ForgetPasswordModel> GetForgetPasswordDataByIdAsync(int id);
        Task<int> CreateForgetPasswordDataAsync(ForgetPasswordModel forgetPasswordModel);
        Task<int> UpdateForgetPasswordDataAsync(ForgetPasswordModel forgetPasswordModel);
        Task<int> DeleteForgetPasswordDataAsync(int id);
    }
}