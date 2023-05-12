namespace NDM {
    public class ForgetPasswordModel {
        public int Id { get; set; }
        public string NewPassword { get; set; } 
        public string ConfirmPassword { get; set; }
        public string EmailOrPhone { get; set; }
        public string OTP { get; set; }
    }
}