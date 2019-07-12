namespace CloudHR.ViewsModel
{
    public class PostViewModel:BaseViewModel
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public PostCategoryViewModel PostCategory { get; set; }       
        public int PostCategoryId { get; set; }       
        public bool Status { get; set; }       
        public int LevelId { get; set; }
        public LevelViewModel Level { get; set; }
        public int ServiceId { get; set; }
        public ServiceViewModel Service { get; set; }     
        public int WorkTypeId { get; set; }
        public WorkTypeViewModel WorkType { get; set; }
    }
}
