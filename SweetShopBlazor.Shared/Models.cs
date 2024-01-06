namespace SweetShopBlazor.Shared;

public record Sweet(string Name, string Description, int Likes, int Id);
public record Comment(string UserName, string Text, string UserAvatarUrl);