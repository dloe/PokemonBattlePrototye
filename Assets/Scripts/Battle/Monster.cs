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
    /// </summary>

    #region Stats
    [Header("Orgnization Num")]
    public int dexNum;
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

    public Move[] moves = new Move[4];

    /// <summary>
    /// Monster Constructor
    /// - set move lists
    /// - load instance of monster with corresponding stats and moves (perhaps from save)
    /// </summary>
    public Monster()
    {
        
    }



}
