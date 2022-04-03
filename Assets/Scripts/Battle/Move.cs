using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum M_Functionality
{
    None,
    Physical,
    Special,
    Buff
}

public enum Status
{
    None, 
    Paralyzed,
    Poisoned,
    Badly_Poisoned,
    Burned,
    Frozen,
    Flinch,
    Confused,
    Infatuation,
    Leech_Seed
}

[Serializable]
public class Move
{
    /// <summary>
    /// Move.cs
    /// Dylan Loe
    /// 
    /// Updated: 4/3/22
    /// 
    /// Notes:
    /// - Contains Stats for corresponding moves
    ///     - damage (if any), power points (pp), etc
    ///     - text of move (for ui)
    /// </summary>
    /// 

    //Organizational Number for each move
    public int moveNum;
   //Name of move
    public string moveName;
    //Base Damaage move does (if any)
    public int baseAttackDamage;
    //Power Points: how much move can be used
    public int powerPoints;
    //Description of Move
    public string moveDescription;
    //move functionality
    public M_Functionality function;
    //what type of damage the move does
    public Type type;
    //from -2 to +3, if both moves are the same it is up to the speed stat of the pokemon
    public int priority;
    //how many turns is this move (IE solar beam)
    public int turns;
    //if this move leaves a status effect on the target
    public Status status;
    //amount of times this move happens in a turn
    public int amount;
    //accuracy (same as accuracy on monster class) aka determines how often the move will land
    public int accuracy;



    /// <summary>
    /// Basic Constructor (for making moves from predetermined list) - not sure if needed
    /// </summary>
    /// <param name="moveNum"></param>
    /// <param name="baseAttackDamage"></param>
    /// <param name="powerPoints"></param>
    /// <param name="moveName"></param>
    /// <param name="moveDescription"></param>
     public Move(int moveNum, int baseAttackDamage, int powerPoints, string moveName, string moveDescription)
    {
        this.moveNum = moveNum;
        this.baseAttackDamage = baseAttackDamage;
        this.powerPoints = powerPoints;
        this.moveName = moveName;
        this.moveDescription = moveDescription;

     }
    /// <summary>
    /// Constructor - sets everything as default
    /// </summary>
    public Move()
    {
        moveNum = 0;
        moveName = "empty";
        baseAttackDamage = 0;
        powerPoints = 0;
        moveDescription = "empty empty empty";
        function = 0;
        type = 0;
        priority = 0;
        turns = 0;
        status = 0;
        amount = 0;
        accuracy = 100;
    }

}
