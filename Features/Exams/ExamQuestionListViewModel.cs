namespace StudyMaster.Features.Exams
{
    public class ExamQuestionListViewModel
    {
        public long Id { get; set; }    
        public string Content { get; set; }
        public string AContent { get; set; }
        public string BContent { get; set; }
        public string CContent { get; set; }
        public string DContent { get; set; }
        public long CorrectAnswer { get; set; }
        public string Explain { get; set; }
    }
}