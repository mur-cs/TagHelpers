using TagHelpers.Models;

namespace TagHelpers.Services
{
	public interface ILaptopService
	{
		List<Laptop> GetLaptops();
	}
	public class LaptopService : ILaptopService
	{
		private List<Laptop> laptops;
		public LaptopService()
		{
			laptops = new List<Laptop>()
		{
			new Laptop
			{
				Id = 1,
				Brand = LaptopBrand.Apple,
				Name = "MacBook Air",
				Threads = 4,
				RAM = 8,
				ScreenSize = 13.3m,
				Description = "Легкий та портативний ноутбук з відмінною продуктивністю."
			},
			new Laptop
			{
				Id = 2,
				Brand = LaptopBrand.Lenovo,
				Name = "ThinkPad X1 Carbon",
				Threads = 8,
				RAM = 16,
				ScreenSize = 14.0m,
				Description = "Надійний бізнес-ноутбук з тривалим терміном служби батареї."
			},
			new Laptop
			{
				Id = 3,
				Brand = LaptopBrand.Apple,
				Name = "MacBook Pro",
				Threads = 8,
				RAM = 16,
				ScreenSize = 13.3m,
				Description = "Потужний ноутбук для професіоналів з високою продуктивністю."
			},
			new Laptop
			{
				Id = 4,
				Brand = LaptopBrand.Lenovo,
				Name = "Yoga 730",
				Threads = 4,
				RAM = 8,
				ScreenSize = 15.6m,
				Description = "Гнучкий ноутбук з можливістю використання в режимі планшета."
			}
		};
		}

		public List<Laptop> GetLaptops()
		{
			return laptops;
		}
	}
}
