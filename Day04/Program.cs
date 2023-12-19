class Public
{
	static void Main()
	{
		Cat cat = new Cat();
		Dog dog = new Dog();
		Bird bird = new Bird();
		
		cat.Eat("Fish");
		cat.Meow();
		
		dog.Eat("Bone");
		dog.Bark();
		
		bird.Eat("Peanut");
		bird.Chirp();
	}
}