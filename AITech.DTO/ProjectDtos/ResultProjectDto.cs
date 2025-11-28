using AITech.DTO.CategoryDtos;

    public record ResultProjectDto(
                                    int Id, 
                                    string Title,
                                    string ImageUrl,
                                    int CategoryId,
                                    ResultCategoryDto Category);
    

