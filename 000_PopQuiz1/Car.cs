namespace _000_PopQuiz1
{
    public class Car
    {
        // field: usually private, has a type and name
        private string _color;

        // property: always public, has type and name
        // also have getters and setters
        public Models Model { get; set; }

        // constructor: has the same name of the class
        // can have parameters
        // must have a body
        public Car(string color)
        {
            _color = color;
        }

        // method: has a return type, has a name
        // may have parameters (input)
        // need to return, unless void - no return
        public string GetColor() 
        {
            return _color;
        }
    }

    // enum: collection of int-enum symbols
    public enum Models 
    {
        Ford,
        Subary,
        KIA
    }

}
