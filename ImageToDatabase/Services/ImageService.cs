using ImageToDatabase.Data;
using ImageToDatabase.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ImageToDatabase.Services
{
    public class ImageService : IImageService
    {
        readonly ApplicationDbContext _context;

        public ImageService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Images> GetLastImageAsync()
        {
            var result = await _context.Images
                                        .OrderByDescending(i => i.ImageId)
                                        .FirstOrDefaultAsync();

            if (result is null) 
            {
                throw new Exception();
            }

            return result;
        }

        public async Task PostImageAsync(Images image)
        {
            _context.Images.Add(image);
            await _context.SaveChangesAsync();
        }
    }
}
