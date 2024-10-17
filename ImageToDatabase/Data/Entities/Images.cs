using System.ComponentModel.DataAnnotations;

namespace ImageToDatabase.Data.Entities
{
    public class Images
    {
        [Key]
        public int ImageId { get; set; }
        public required string ImageName { get; set; }
        public required byte[] ImageData { get; set; }
    }
}
