namespace Exercise_6
{
    class Mouse : Animal
    {
        public Mouse(string animalType, string animalName, double animalWeight, int foodEaten = 0) : base(animalType, animalName, animalWeight, foodEaten)
        {
        }

        public bool MouseEat(string userInput)
        {
            if (userInput == "Vegetable")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
