using System;
using System.Text.Json.Serialization;

namespace FreeCourse.Shared.Dtos
{
    public class Response<T> // where ile kısıtlamıyorum -> int, class, struct..
    {
        public T Data { get; private set; } // basarılıysa gidecek data

        /* status code u kendi icinde kullansın
		 * bir apiye istek yaptığımızda response'ında donus tipini verebiliyoruz
		 * response'in status codeu zaten var
		 * ama yazilim icinde benim buna ihtiyacım var
		 * response ın donus tipini belirlerken buradan faydalanıcam
		 * bu property den faydalanıcam ama bu property nınde response ın icinde olmasına gerek yok
		 * yazilim icinde kullanıcam client response aldıgında bu propertylerle karsılasmayacak 
		 * ama yazılım icinde bana fayda saglayabilir
		 */

        [JsonIgnore]
        public int StatusCode { get; private set; }

        [JsonIgnore]
        public bool IsSuccessful { get; private set; }

        public List<string> Errors { get; set; }

        /* response dto nesnesini üretmek icin static metodlar tanimlicam
		 * statik metodlar tanımlama özellikle nesne olusturmada bize buyuk bir artı saglıyor
		 * design patternlar var patternların hepsi interface ister
		 * static factory metodlar direk classın icersinde tanımlanarak nesne olustumaya yardımcı olur
		 * basarili oldugunda response donucem
		 */

        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T> { Data = data, StatusCode = statusCode, IsSuccessful = true };
        }
        // basarili olabilir ama data dondurmeyebilir
        public static Response<T> Success(int statusCode)
        {
            return new Response<T> { Data = default(T), StatusCode = statusCode, IsSuccessful = true };
        }

        public static Response<T> Fail(List<string> errors, int statusCode)
        {
            return new Response<T>
            {
                Errors = errors, StatusCode = statusCode, IsSuccessful = false
            };
        }
        public static Response<T> Fail(string error, int statusCode)
        {
            return new Response<T>
            {
                Errors = new List<string>() { error },
                StatusCode = statusCode,
                IsSuccessful = false
            };
        }

    }
}

