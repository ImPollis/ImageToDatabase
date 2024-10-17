using ImageToDatabase.Data.Entities;

namespace ImageToDatabase.Services
{
    public interface IImageService
    {
        Task PostImageAsync(Images image);
        Task<Images> GetLastImageAsync();
    }
}
