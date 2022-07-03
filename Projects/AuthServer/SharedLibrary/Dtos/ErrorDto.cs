using System;
namespace SharedLibrary.Dtos
{
	public class ErrorDto
	{
        /* liste -> birden fazla hata dönebilirim
         * private-> sadece classta property set edeilsin */
        public List<string> Errors { get; private set; }

        // isShow -> true "kullanıcıya gösterilir", client(yazılımcı) anlıyacak
        public bool IsShow { get; private set; }

        public ErrorDto()
        {
            Errors = new List<string>();
        }

        public ErrorDto(string error, bool isShow)
        {
            Errors.Add(error);
            isShow = true;
        }

        public ErrorDto(List<string> errors, bool isShow)
        {
            Errors = Errors;
            IsShow = isShow;
        }
    }
}

