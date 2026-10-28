namespace Menu.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Imageurl { get; set; } 
        public double Price { get; set; }

        public List<DishIngredient>? DishIngredients { get; set; } 
    }
}
