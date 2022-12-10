namespace _002_PopQuiz
{
    public class Rider
    {
        private string _rider;

        public string Destination { get; set; }

        public Rider() 
        {
        
        }
        public Rider(string ride) 
        {
            _rider = ride;
        }

        public string GoTo() 
        {
            return _rider + " goes to " + Destination;
        }
    }
}