using SweetShopBlazor.Shared;

namespace SweeshopBlazor.Client;

public partial class CommentSection
{
    // Replace this with your actual data model and data source
    private List<Comment> Comments { get; init; } = new List<Comment>
    {
        new Comment("User1", "This is a comment", "url_to_avatar"),
    };
}