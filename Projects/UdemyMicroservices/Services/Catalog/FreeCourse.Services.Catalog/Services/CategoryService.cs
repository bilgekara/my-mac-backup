using System;
using AutoMapper;
using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Services.Catalog.Models;
using FreeCourse.Services.Catalog.Settings;
using FreeCourse.Shared.Dtos;
using MongoDB.Driver;

namespace FreeCourse.Services.Catalog.Services
{
    public class CategoryService : ICategoryService
    {
        //veri tabanı yolu hangi collectiona baglanacam -> bu bilgiler IDatabaseSettings ten geliyor
        private readonly IMongoCollection<Category> _categoryCollection;

        // donusturme islemi
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            // client olustur
            var client = new MongoClient(databaseSettings.ConnectionString);

            // db baglan
            var database = client.GetDatabase(databaseSettings.DatabaseName);

            // artık elimde dolu bir category collection var
            _categoryCollection = database.GetCollection<Category>(databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }

        // categoryleri listelicek bir metod
        public async Task<Response<List<CategoryDto>>> GetAllAsync()
        {
            var categories = await _categoryCollection.Find(category => true).ToListAsync();

            // static factory metodu -> listcategoryDto, statuscode
            return Response<List<CategoryDto>>.Success(_mapper.Map<List<CategoryDto>>(categories), 200);
        }

        public async Task<Response<CategoryDto>> CreateAsync(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            await _categoryCollection.InsertOneAsync(category);
            return Response<CategoryDto>.Success(_mapper.Map<CategoryDto>(category), 200);
        }

        public async Task<Response<CategoryDto>> GetByIdAsync(string id)
        {
            var category = await _categoryCollection.Find<Category>(x => x.Id == id).FirstOrDefaultAsync(); //category üzerinden arama yapıyorum
            if (category == null)
            {
                return Response<CategoryDto>.Fail("Category not found", 404);
            }

            return Response<CategoryDto>.Success(_mapper.Map<CategoryDto>(category), 200);
        }

    }
}

