

public class Tv1
{
    public bool IsOn 
    {
        get
        {
            return isOn;
        }
        set
        {
            isOn = value;
            _state = isOn ? new OffState() : new OnState();
        }
    }
    public Tv1()
    {
        _state = new OffState();
    }

    private IState _state;
    private bool isOn { get; set; }
    public void OnOffBtnPshed()
    {
       IsOn =  _state.ChangeState();
    }
}

