using System;
using AutoMapper;
using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Services.Catalog.Models;

namespace FreeCourse.Services.Catalog.Mapping
{
	public class GeneralMapping:Profile
	{
		public GeneralMapping()
        {
			// course -> coursedto ya da tam tersi
			CreateMap<Course, CourseDto>().ReverseMap();
			CreateMap<Category, CategoryDto>().ReverseMap();
			CreateMap<Feature, FeatureDto>().ReverseMap();

			CreateMap<Course, CourseCreateDto>().ReverseMap();
			CreateMap<Course, CourseUpdateDto>().ReverseMap();
		}

	}
}

