using Content.Api.Models;

namespace Content.Api.Services
{
    public class CommentService : ICommentService
    {
        public IEnumerable<CommentItem>  GetCommentItems()
        {
            return new List<CommentItem>
        {
                new CommentItem
                {
                    Id = new Guid("b198e834-b670-40c9-99bd-4a00c02df3b7"),
                    Comment = "Great article! I learned a lot from this.",
                    ContentItemId = new Guid("b198e834-b670-40c9-99bd-4a00c02df3b8"),
                    Commentor = "Alice",
                    CommentDate = new DateTime(2023, 5, 10)
                },
                new CommentItem
                {
                    Id = new Guid("b198e834-b670-40c9-99bd-4a00c02df3b9"),
                    Comment = "I have a different opinion on this topic.",
                    ContentItemId = new Guid("59d01fb0-a679-40f3-adac-407af3cea5ad"),
                    Commentor = "Bob",
                    CommentDate = new DateTime(2023, 5, 12)
                },
                new CommentItem
                {
                    Id = new Guid("b198e834-b670-40c9-99bd-4a00c02df3ba"),
                    Comment = "This article is very informative.",
                    ContentItemId = new Guid("80118e83-facf-49ee-b92e-67c1aafa33f6"),
                    Commentor = "Charlie",
                    CommentDate = new DateTime(2023, 5, 15)
                }
            };
        }
    }
}
