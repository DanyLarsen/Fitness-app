using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Woman : Workout
{

    public override string MondayGenerateWorkoutProgram()
    {
        // Example workout program for women
        return "Day 1: Cardio & Core";
    }
    public override string WendsdayGenerateWorkoutProgram()
    {
        // Example workout program for women
        return "Day 2: Legs & Glutes";
    }
    public override string FridayGenerateWorkoutProgram()
    {
        // Example workout program for women
        return "Day 3: Arms & Back";
    }
}
