using System;
namespace FreeCourse.Services.Catalog.Dtos
{
    public class CourseCreateDto
	{

        public string Name { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        public string UserId { get; set; }

        public string Picture { get; set; }
         /* course olusturmadan fotografı kaydedicem
         * stok mikro servisine fotografı kaydettikten sonra
         * o bana bir url vericek
         * o urlle beraber buraya kaydetmem lazım
         */
        public FeatureDto Feature { get; set; }

        public string CategoryId { get; set; }
    }
}

