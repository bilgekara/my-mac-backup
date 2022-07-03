using System;
using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Services.Catalog.Models;
using FreeCourse.Shared.Dtos;

namespace FreeCourse.Services.Catalog.Services
{
    public interface ICategoryService
    {

        // categoryleri listelicek bir metod
        Task<Response<List<CategoryDto>>> GetAllAsync();

        Task<Response<CategoryDto>> CreateAsync(CategoryDto categoryDto);

        Task<Response<CategoryDto>> GetByIdAsync(string id);


    }
}

