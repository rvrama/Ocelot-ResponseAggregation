using Content.Api.Models;

namespace Content.Api.Services
{
    public interface ICommentService
    {
        IEnumerable<CommentItem> GetCommentItems();
    }
}
