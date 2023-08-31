using System.ComponentModel.DataAnnotations.Schema;

namespace Self_ordaring_sys.Models
{
    public class ItemDetails
    {
        public int ItemDetailsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }

        [ForeignKey(nameof(ItemDetailsId))]
        public int CategoryId { get; set;}
    }
}
