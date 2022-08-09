Console.Write("Введите скорость первого друга: ");
int first_friend_speed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость второго друга: ");
int second_friend_speed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость собаки: ");
int dog_speed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите расстояние: ");
int distance = Convert.ToInt32(Console.ReadLine());
int friend = 2;
int count = 0;
int time = 0;

while (distance > 10)
{
	if (friend == 1)
	{
		time = distance / (first_friend_speed + dog_speed);
		friend = 2;
	}
	else
	{
		time = distance / (first_friend_speed + dog_speed);
		friend = 1;
	}
distance = distance - (first_friend_speed + second_friend_speed) * time;
count++;
}
Console.Write($"Собака пробежит {count} раз");