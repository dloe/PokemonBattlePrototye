using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[SerializeField]
public class PlayerParty
{
    /// <summary>
    /// PlayerParty.cs
    /// Dylan Loe
    /// 
    /// Updated: 4/3/2022
    /// 
    /// - will store players inventory/party
    ///     - reads from json
    /// 
    /// </summary>
    public Monster[] party;
    public int money;
    public int wins;

    public PlayerParty()
    {
        party = new Monster[6];
        money = 0;
        wins = 0;
    }

}
