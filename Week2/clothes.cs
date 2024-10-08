﻿namespace ConsoleApp9;

public class Clothes
{
    public string Colour { get; }
    
    public Clothes(string colour) {
        Colour = colour;
    }

    public virtual string WhatType() {
        return "I am clothes with colour " + Colour;
    }

    public override string ToString() {
        return Colour + " clothes";
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
        result += "sleeved " + Colour + " shirt";
        return result;
    }

    public override string ToString() {
        return Colour + " shirt";
    }
}

