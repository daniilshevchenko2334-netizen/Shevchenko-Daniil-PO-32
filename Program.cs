namespace ConsoleApp20
{

    public abstract class Entity
    {

        public int Id { get; protected set; }


        public string Name { get; protected set; }


        protected Entity(int id, string name)
        {
            Id = id;
            Name = name;
        }


        public abstract string Category { get; }


        public abstract string GetEntityDetails();


        public void PrintSummary()
        {
            Console.WriteLine(
                $"Категория: {Category}, ID: {Id}, Название: {Name}"
            );
        }
    }



    public class UserEntity : Entity
    {
        public string Email { get; set; }
        public string Role { get; set; }


        public UserEntity(int id, string name, string email, string role)
            : base(id, name)
        {
            Email = email;
            Role = role;
        }


        public override string Category => "Пользователи";


        public override string GetEntityDetails()
        {
            return $"Пользователь: {Name}, ID: {Id}, " +
                   $"Email: {Email}, Роль: {Role}";
        }
    }



    public class ProductEntity : Entity
    {
        public double Price { get; set; }
        public int StockQuantity { get; set; }


        public ProductEntity(
            int id,
            string name,
            double price,
            int stockQuantity)
            : base(id, name)
        {
            Price = price;
            StockQuantity = stockQuantity;
        }


        public override string Category => "Товары";


        public override string GetEntityDetails()
        {
            return $"Товар: {Name}, ID: {Id}, " +
                   $"Цена: {Price}, Остаток: {StockQuantity} шт.";
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            UserEntity user = new UserEntity(
                1,
                "Алина Колкова",
                "alinka_08@example.com",
                "User"
            );

            ProductEntity product = new ProductEntity(
                101,
                "WAKA 10",
                14999.50,
                5
            );


            user.PrintSummary();
            product.PrintSummary();

            Console.WriteLine();


            Console.WriteLine(user.GetEntityDetails());
            Console.WriteLine(product.GetEntityDetails());
        }
    }
}