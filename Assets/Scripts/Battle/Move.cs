using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    /// <summary>
    /// Basic Constructor (for making moves from predetermined list)
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
    public Move()
    {
        moveNum = 0;
        moveName = "empty";
        baseAttackDamage = 0;
        powerPoints = 0;
        moveDescription = "empty empty empty";
    }

}
