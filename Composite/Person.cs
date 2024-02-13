// Short Description About Composite:
// when we using a  "tree organization" and need to process a 
// operation without any node and its  all branches  

public class Person
{
    public string Name { get; set; }
    private int _score;
    public int Score
    {
        get
        {
            return _score;
        }
        set
        { 
            _score = value;
            Console.WriteLine($" {Name}  => {_score} ");
        }
    }
}


