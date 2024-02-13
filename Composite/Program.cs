// Short Description About Composite:
// when we using a  "tree organization" and need to process a 
// operation without any node and its  all branches  



// Without Composite
List<Person> List = new List<Person>()
{
    new Person { Name ="Alex Vandarfar"  },
    new Person { Name ="Sina Nikfar"  }
};

List<Group> groups = new List<Group>()
{
    new Group {
        Name ="Developers"
        , People =
        {
            new Person { Name ="Ali Pahlavan" },
            new Person { Name ="Max Amini" }
        }
    }
};

int score = 1000;
int Count = List.Count + groups.Count;
int IndivisualScore = score / Count;

foreach (var item in List)
{
    item.Score = IndivisualScore;
}
foreach (var item in groups)
{
    int groupScore = IndivisualScore / item.People.Count;
    foreach (var p in item.People)
    {
        p.Score = groupScore;
    }
}

Console.ReadKey();

// With Composite 
List<INode> itemsComposite = new List<INode>()
{
    new PersonComposite { Name ="Alex Vandarfar"  },
    new PersonComposite { Name ="Sina Nikfar"  } ,
            new GroupComposite {
                Name ="Developers"
                , Nodes = new List<INode>
                {
                    new PersonComposite { Name ="Ali Pahlavan" },
                    new PersonComposite { Name ="Max Amini" },
                    new PersonComposite { Name ="Maz Jobrani" },

                    new GroupComposite
                    {
                        Name ="Testers" ,
                        Nodes = new List<INode>
                        {
                            new PersonComposite { Name ="Third Person"},
                            new PersonComposite { Name ="Forth Person"},
                            new PersonComposite { Name ="Fifth Person"},
                            new PersonComposite { Name ="sixth Person"}
                        }
                    }

                }
        }
};


        

int scoreComposite = 999;
int CountComposite = itemsComposite.Count;
int IndivisualScoreComposite = scoreComposite / CountComposite;

foreach (var item in itemsComposite)
{
    item.Score = IndivisualScoreComposite;
}
Console.ReadLine();

