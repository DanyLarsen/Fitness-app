using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : Workout
{
    public override string MondayGenerateWorkoutProgram()
    {
        // Example workout program for men
        return "Day 1: Chest & Back";
    }
    public override string WendsdayGenerateWorkoutProgram()
    {
        // Example workout program for men
        return "Day 2: Legs & Core";
    }
    public override string FridayGenerateWorkoutProgram()
    {
        // Example workout program for men
        return "Day 3: Shoulders & Arms";
    }
}
