using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class Player : MonoBehaviour
{
    /// <summary>
    /// Player.cs
    /// Dylan Loe
    /// 
    /// Last Updated: 4/3/22
    /// 
    /// 
    /// Notes:
    /// - Contains Player Controls
    /// - UI Hookup (most likely will seperate this)
    /// - CHECK LATER" Maybe contrain player data
    ///     - player data includes current monster party
    ///     
    /// 
    /// - players party will be saved out on  json file
    ///     - will have 6 in party
    /// </summary>

   

    //will need list of all available pokemon


   // string path;
    

    // Start is called before the first frame update
    void Awake()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




}

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

