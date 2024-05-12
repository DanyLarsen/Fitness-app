using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Workout : MonoBehaviour
{


    // Abstract method to be implemented by subclasses
    public abstract string MondayGenerateWorkoutProgram();
    public abstract string WendsdayGenerateWorkoutProgram();
    public abstract string FridayGenerateWorkoutProgram();

}
