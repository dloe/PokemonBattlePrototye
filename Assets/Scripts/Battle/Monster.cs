using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public enum Type
{
    None,
    Fire,
    Water,
    Grass,
    Normal,
    Bug,
    Dark,
    Dragon,
    Electric,
    Fairy,
    Fighting,
    Flying,
    Ghost,
    Ground,
    Ice,
    Poison,
    Psychic,
    Rock,
    Steel
}

[System.Serializable]
public class Monster
{
    /// <summary>
    /// Monster.cs
    /// Dylan Loe
    /// 
    /// Last Updated: 4/3/22
    /// 
    /// - Data for Monster (pokemon)
    ///     - stats
    ///     - storage for 4 attacks
    ///     - sprite info (if any)
    ///     
    /// 
    /// 
    /// </summary>

    #region Stats
    [Header("Orgnization Num")]
    public int dexNum;
    [Header("Level")]
    public int level;
    [Header("Types")]
    public Type type1;
    public Type type2;
    [Header("Accuracy")]
    public int accuracy;
    [Header("Name")]
    public string mName;
    [Header("Health")]
    public int maxHealth;
    public int currentHealth;
    [Header("Attack")]
    public int maxAttack;
    public int currentAttack;
    [Header("Defense")]
    public int maxDefense;
    public int currentDefense;
    [Header("Special Attack")]
    public int maxSpeAtt;
    public int currentSpeAtt;
    [Header("Special Defnese")]
    public int maxSpeDef;
    public int currentSpeDef;
    [Header("Speed")]
    public int maxSpeed;
    public int currentSpeed;

    #endregion

    public Move[] moves;

    /// <summary>
    /// Monster Constructor
    /// - set move lists
    /// - load instance of monster with corresponding stats and moves (perhaps from save)
    /// </summary>
    public Monster()
    {
        //Debug.Log("made monster");
        dexNum = 0;
        level = 0;
        type1 = 0;
        type2 = 0;
        accuracy = 100;
        mName = "Empty";
        maxHealth = 50;
        currentHealth = 0;
        maxAttack = 0;
        currentAttack = 0;
        maxDefense = 0;
        currentDefense = 0;
        maxSpeAtt = 0;
        currentSpeAtt = 0;
        maxSpeDef = 0;
        currentSpeDef = 0;
        maxSpeed = 0;
        currentSpeed = 0;

        //they get 4 moves
        moves = new Move[4];
    }



}

public class MonsterData
{
    /// <summary>
    /// MonsterData.cs
    /// Dylan Loe
    /// 
    /// Updated: 4/4/22
    /// 
    /// 
    /// - stores ALL pokemon in game
    /// - Storing all our Pokemon Data from our Json to be accessable from unity classes
    /// </summary>
    public Monster[] Pokedex;
    public MonsterData()
    {
        Pokedex = new Monster[30];
    }
}
