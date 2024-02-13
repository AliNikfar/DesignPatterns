// Short Description About Composite:
// when we using a  "tree organization" and need to process a 
// operation without any node and its  all branches  



// Without Composite



public class GroupComposite : INode
{
    public string Name { get; set; }
    public List<INode> Nodes{ get; set; }
    public int Score {
        get
        {
            int score = 0;
            foreach (var node in Nodes)
            {
                score = node.Score;
            }
            return score;
        }
        set
        {
            var indivisualValue = value / Nodes.Count();
            Console.WriteLine($" Process Value Of {Name} ");
            foreach (var node in Nodes)
            {
                node.Score = indivisualValue;
            }

        }
        }
}