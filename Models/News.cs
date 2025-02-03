namespace NewsWebsiteFinalProject.Models{
    public class News{
        public int NewsID {get;set;}
        public string? Title {get;set;}
         public string? Description {get;set;}
        public string? Content {get;set;}
        public string? ImageURL {get;set;}
        public int CategoryID {get;set;}
        public DateTime PublishDate {get;set;}
        public bool IsFeatured {get;set;}

        public Category? Category { get; set; }

    }
}