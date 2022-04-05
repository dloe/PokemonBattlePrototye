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

    public PlayerParty myPlayerParty;
    public MovesStorage moveList;

    //will need list of all available pokemon


    string path;
    

    // Start is called before the first frame update
    void Awake()
    {
        
        

        SetUpMoveData();
        SetUpPlayerInfo();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    #region SetupInfo

    void SetUpMoveData()
    {
        moveList = new MovesStorage();
        //loading json test
        //overrides current json btw
        //SaveData();
        LoadData();
       
    }

    void SetUpPlayerInfo()
    {
        myPlayerParty = new PlayerParty();
        //save overrides current json btw
        SaveParty();
        LoadParty();
    }

    //get move lists - will rework but this works and we will use it for setting up the pokemons move sets
    public void LoadData()
    {
        path = Application.dataPath + "/GameData" + "/MoveData.JSON";
        if (File.Exists(path))
        {

            string content = File.ReadAllText(path);
            //JsonUtility.FromJsonOverwrite(moveData, this);
            moveList = JsonUtility.FromJson<MovesStorage>(content);
            Debug.Log("Move Data Loaded...");
        }
        else
        {
            Debug.LogError("Error: Cannot find path to Moves Data path: " + path);
        }
    }

    public void LoadParty()
    {
        path = Application.dataPath + "/GameData" + "/PlayerInventory.JSON";
        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            
            //JsonUtility.FromJsonOverwrite(content, this);
            myPlayerParty = JsonUtility.FromJson<PlayerParty>(content);
            Debug.Log("Party Data Loaded...");

        }
        else
        {
            Debug.LogError("Error: Cannot find path to Player party: " + path);
            //new player
        }
    }

    public void SaveParty()
    {
        path = Application.dataPath + "/GameData" + "/PlayerInventory.JSON";

        Monster m = new Monster();
        m.currentHealth = 100;
        m.mName = "MONSTER TEST";
        myPlayerParty.party[0] = m;

        string json = JsonUtility.ToJson(myPlayerParty);
        //Debug.Log(json);

        if (File.Exists(path))
        {
            //Debug.Log(content);
            File.WriteAllText(path, json);
        }
        else
        {
            Debug.LogError("Error: Cannot find path to Player party: " + path);
        }
    }

    //temp testing of json format, will reference later for saving out playe stats and whatnot
    public void SaveData()
    {
        path = Application.dataPath + "/GameData" + "/MoveData.JSON";

        Move m = new Move();
        m.moveNum = 0;
        m.moveName = "TEST";
        m.baseAttackDamage = 69;
        m.powerPoints = 2;
        m.moveDescription = "this is test prey it works";

        moveList.moveList[0] = m;

        string json = JsonUtility.ToJson(moveList);
        Debug.Log(json);

        File.WriteAllText(path, json);


    }

    #endregion
}
