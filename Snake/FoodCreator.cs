using System;
namespace Snake
{
	class FoodCreator //класс для создания еды
    {
		int mapWidht;
		int mapHeight;
		char sym;

		Random random = new Random(); 

		public FoodCreator(int mapWidth, int mapHeight, char sym) //конструктор для создания еды, используя высоту и ширину поля
		{
			this.mapWidht = mapWidth;
			this.mapHeight = mapHeight;
			this.sym = sym;
		}

		public Point CreateFood() //метод создания еды в случайном месте на территории окна
		{
			int x = random.Next(2, mapWidht - 2); //рандомное значение точки
			int y = random.Next(2, mapHeight - 2); //рандомное значение точки
			return new Point(x, y, sym);
		}
	}
}
