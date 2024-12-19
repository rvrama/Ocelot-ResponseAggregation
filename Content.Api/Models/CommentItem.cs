namespace Content.Api.Models
{
    public class CommentItem
    {
            public Guid Id { get; set; }
            public string Comment { get; set; }
            public Guid ContentItemId { get; set; }
            public string Commentor { get; set; }
            public DateTime CommentDate { get; set; }
    }
}
