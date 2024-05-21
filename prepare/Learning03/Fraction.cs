
public class Fraction {
    
    private int _top;
    private int _bottom;

    public Fraction() {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int topNum) {
        _top = topNum;
        _bottom = 1;
    }

    public Fraction (int topNum, int bottomNum) {
        _top = topNum;
        _bottom = bottomNum;
    }

    public string getFraction(){
        string curFraction = $"{_top}/{_bottom}";
        return curFraction;
    }

    public double getDecimal() {
        return (double)_top / (double)_bottom;
    }


}

