using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum M_Category
{
    None,
    Physical,
    Special,
    Buff,
    Status
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
    Leech_Seed,
    Self_Damage
}

public enum StatType
{
    None,
    Accuracy,
    Health,
    Attack,
    Defense,
    SpecialAttack,
    SpecialDefense,
    Speed
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
    public int power;
    //Power Points: how much move can be used
    public int powerPoints;
    //Description of Move
    public string moveDescription;
    //move functionality
    public M_Category category;
    //what type of damage the move does
    public PokeType type;
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
    //some moves have higher crit chances than others
    public float critChance;

    //what type of status can be applied
    public Status posStatus;
    public int statusChance;

    //how often will boost be applied
    public int boostChance;

    //buff stats (considering condenseing into array) - 0 is outselves while is enemy
    public StatType boostType1;
    public StatType boostType2;
    public StatType boostType3;
    public StatType boostType4;
    public StatType boostType5;
    public StatType boostType6;

    //are boosts being applied to themselves or the opponent
    public int boostTarget1;
    public int boostTarget2;
    public int boostTarget3;
    public int boostTarget4;
    public int boostTarget5;
    public int boostTarget6;

    //could either have it be measrued in stages or just an int increase
    public int statBoost1;
    public int statBoost2;
    public int statBoost3;
    public int statBoost4;
    public int statBoost5;
    public int statBoost6;
    public int turnsActive;
   

    //for certain moves, special events can occur for now this will keep track of it
    //will use a switch statement for each event number (only about 20?)
    //default 0;
    public int eventNumber;

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
        this.power = baseAttackDamage;
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
        power = 0;
        powerPoints = 0;
        moveDescription = "empty empty empty";
        category = 0;
        type = 0;
        priority = 0;
        turns = 0;
        status = 0;
        amount = 0;
        accuracy = 100;
        critChance = 0.1f;
        posStatus = 0;
        statusChance = 0;
        eventNumber = 0;
    }

}
