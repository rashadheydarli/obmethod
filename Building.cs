using System;
namespace Cmethod
{
	public class Building
	{
		public string name;
		public int height;
		public int area;
		public string address;

		public int volume;

		
		public Building()
		{
				
		}

		public Building(string n, int h, int a)
		{
			name = n;
			height = h;
			area = a;
			volume = height * area;
		}

		public string GetDetails()
		{
			return  $"{name}, {volume}";
		}
		

		
		

		

	}
}

