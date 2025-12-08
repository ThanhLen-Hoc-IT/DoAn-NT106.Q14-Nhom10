namespace UniGate.Domain
{
    // Lớp Model chứa dữ liệu người dùng nhập vào Form
    public class ScoreInputModel
    {
        public double UserTotalScore { get; set; } 
        public string SelectedCombination { get; set; } = string.Empty;
    }
}