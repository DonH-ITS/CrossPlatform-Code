namespace ConsoleApp9;

public class Clothes
{
    public string colour { get; }
    
    public Clothes(string colour) {
        this.colour = colour;
    }

    public virtual string WhatType() {
        return "I am clothes with colour " + colour;
    }

    public override string ToString() {
        return colour + " clothes";
    }
}

public class Shirt : Clothes{
    private bool longsleeves; 
    public Shirt(string colour, bool longsleeves) : base(colour) {
        this.longsleeves = longsleeves;
    }

    public override string WhatType() {
        string result = "I am a ";
        if (longsleeves)
            result += "long ";
        else
            result += "short ";
        result += "sleeved " + colour + " shirt";
        return result;
    }

    public override string ToString() {
        return colour + " shirt";
    }
}

