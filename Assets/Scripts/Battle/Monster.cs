using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Monster : MonoBehaviour
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
        dexNum = 0;
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
        moves = new Move[4];
    }



}
