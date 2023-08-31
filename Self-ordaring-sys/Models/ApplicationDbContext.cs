using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Self_ordaring_sys.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            seedRules(builder);
            addingCategories(builder);
            addingItems(builder);
        }
        
       private void seedRules (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(

                new IdentityRole()
                {
                    Name = "User",
                    ConcurrencyStamp = "1",
                    NormalizedName = "User"
                },
                new IdentityRole()
                    {
                        Name = "Admin",
                        ConcurrencyStamp = "2",
                        NormalizedName = "Admin"
                    }); 
        }
       private void addingCategories (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
             new Category
          {
          CategoryId = 1,
          Name = "Italian Cuisine",
          Description = "Delicious Italian dishes.",
          ImageUrl = "https://th.bing.com/th/id/OIP.rDx9ms9ei0V1oepgr1IbXAHaE8?pid=ImgDet&rs=1"
           },
             new Category
    {
        CategoryId = 2,
        Name = "Mexican Food",
        Description = "Authentic Mexican flavors.",
        ImageUrl = "https://th.bing.com/th/id/R.37e7072424bf2df0a996e7b4685631b9?rik=VM4yF6k14iTa0Q&pid=ImgRaw&r=0"
                                },
             new Category
    {
        CategoryId = 3,
        Name = "Asian Fusion",
        Description = "A fusion of Asian flavors.",
        ImageUrl = "https://th.bing.com/th/id/R.cf1521aef59949cceeae9d772610170f?rik=jzoZUkRtDHzyMQ&pid=ImgRaw&r=0"
                                },
             new Category
                                {
                                    CategoryId = 4,
                                    Name = "Steakhouse",
                                    Description = "Premium steaks and grills.",
                                    ImageUrl = "https://tampamagazines.com/wp-content/uploads/2018/09/BestSteakhouse.jpg"
                                },
             new Category
                                {
                                    CategoryId = 5,
                                    Name = "Seafood",
                                    Description = "Fresh seafood specialties.",
                                    ImageUrl = "https://th.bing.com/th/id/OIP.D5hvEqNd5UZlib0PLS2GvQHaE7?pid=ImgDet&rs=1"
                                },
             new Category
                                {
                                    CategoryId = 6,
                                    Name = "Vegetarian/Vegan",
                                    Description = "Plant-based dining options.",
                                    ImageUrl = "https://th.bing.com/th/id/R.e521195a6160093f9e59d521b063dd9c?rik=P1Z%2bq1AA7UXZLQ&pid=ImgRaw&r=0"
                                }
                           
              );
        }
       private void addingItems (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemDetails>().HasData(

                new ItemDetails
                 {
                     ItemDetailsId = 2,
                     Title = "Margherita Pizza",
                     Description = "Classic Italian pizza with tomato, mozzarella, and basil.",
                     Price = 12.99,
                     CategoryId = 1,
                     ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                 },
                new ItemDetails
                {
                    ItemDetailsId = 3,
                    Title = "Taco Platter",
                    Description = "A platter of delicious tacos with various fillings.",
                    Price = 9.99,
                    CategoryId = 2,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                },
                new ItemDetails
                {
                    ItemDetailsId = 4,
                    Title = "Sushi Assortment",
                    Description = "Fresh sushi assortment with a variety of fish and flavors.",
                    Price = 24.99,
                    CategoryId = 3,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                },
                new ItemDetails
                {
                    ItemDetailsId = 5,
                    Title = "Filet Mignon Steak",
                    Description = "Tender filet mignon steak cooked to perfection.",
                    Price = 29.99,
                    CategoryId = 4,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                },
                new ItemDetails
                {
                    ItemDetailsId = 6,
                    Title = "Lobster Feast",
                    Description = "Indulge in a seafood feast with lobster as the star.",
                    Price = 39.99,
                    CategoryId = 5,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                },
                new ItemDetails
                {
                    ItemDetailsId = 7,
                    Title = "Vegan Burger",
                    Description = "A plant-based burger that's both delicious and sustainable.",
                    Price = 11.99,
                    CategoryId = 6,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                },
                new ItemDetails
                {
                    ItemDetailsId = 8,
                    Title = "Spicy Fried Chicken",
                    Description = "Crispy fried chicken with a spicy kick.",
                    Price = 10.99,
                    CategoryId = 1,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                },
                new ItemDetails
                {
                    ItemDetailsId = 9,
                    Title = "Enchiladas",
                    Description = "Rolled tortillas filled with delicious fillings and topped with sauce.",
                    Price = 13.99,
                    CategoryId = 2,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                },
                new ItemDetails
                {
                    ItemDetailsId = 10,
                    Title = "Tempura Platter",
                    Description = "Light and crispy tempura with a dipping sauce.",
                    Price = 16.99,
                    CategoryId = 3,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                },
                new ItemDetails
                {
                    ItemDetailsId = 11,
                    Title = "Ribeye Steak",
                    Description = "Juicy ribeye steak cooked to your liking.",
                    Price = 26.99,
                    CategoryId = 4,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                },
                new ItemDetails
                {
                    ItemDetailsId = 12,
                    Title = "Seafood Paella",
                    Description = "A flavorful Spanish paella with a variety of seafood.",
                    Price = 31.99,
                    CategoryId = 5,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                },
                new ItemDetails
                {
                    ItemDetailsId = 13,
                    Title = "Mushroom Risotto",
                    Description = "Creamy mushroom risotto with parmesan cheese.",
                    Price = 14.99,
                    CategoryId = 6,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                },
                new ItemDetails
                {
                    ItemDetailsId = 14,
                    Title = "Calzone",
                    Description = "A folded pizza stuffed with your favorite ingredients.",
                    Price = 12.99,
                    CategoryId = 1,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                },
                new ItemDetails
                {
                    ItemDetailsId = 15,
                    Title = "Burrito Bowl",
                    Description = "A flavorful bowl with rice, beans, and your choice of fillings.",
                    Price = 10.99,
                    CategoryId = 2,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                },
                new ItemDetails
                {
                    ItemDetailsId = 16,
                    Title = "Sashimi Platter",
                    Description = "Fresh sashimi slices of various fish.",
                    Price = 29.99,
                    CategoryId = 3,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                },
                new ItemDetails
                {
                    ItemDetailsId = 17,
                    Title = "T-Bone Steak",
                    Description = "A hearty T-bone steak with all the fixings.",
                    Price = 34.99,
                    CategoryId = 4,
                    ImageUrl = "https://scontent.fcai20-4.fna.fbcdn.net/v/t39.30808-6/306764357_494811602658458_3288163775496305099_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=qkpKvi-LVssAX98nzbb&_nc_ht=scontent.fcai20-4.fna&oh=00_AfDrnR3ioweprpC7eToRWgqX_JzYmrVj68jKRNMxVog--g&oe=64F44BED"
                }
                ); 
        }
       
       
    }
}
