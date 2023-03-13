namespace EatTogether.Contracts.MenuContracts;

public record CreateMenuResponse(
    string Id,
    string Name,
    string Description, 
    float? AverageRating,
    List<CreateMenuSectionResponse> Sections,
    string HostId,
    List<string> MealIds,
    List<string> MenuReviewIds,
    DateTime CreatedAt,
    DateTime UpdatedAt);
    
public record CreateMenuSectionResponse(
    string Id,
    string Name,
    List<CreateMenuItemResponse> Items);
    
public record CreateMenuItemResponse(
    string Id,
    string Name,
    string Description);