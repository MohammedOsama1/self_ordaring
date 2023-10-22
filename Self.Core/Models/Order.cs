namespace Self_ordaring_sys.Models
{
    public class Order
    {   
        public int OrderId { get; set; }
        public string Comments { get; set; }
        public List<ItemDetails> Items { get; set; }
        public double Price { get; set; }
    }
}
