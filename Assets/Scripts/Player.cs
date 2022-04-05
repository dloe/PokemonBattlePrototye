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
    public MonsterData pokeDex;

    //will need list of all available pokemon


   // string path;
    

    // Start is called before the first frame update
    void Awake()
    {
        
        SetUpMoveData();
        SetUpPlayerInfo();
        SetUpPokedexInfo();
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
        //SaveParty();
        LoadParty();
    }

    void SetUpPokedexInfo()
    {
        pokeDex = new MonsterData();
        //SavePokedex();
        LoadPokedex();

    }

    //get move lists - will rework but this works and we will use it for setting up the pokemons move sets
    public void LoadData()
    {
        string path = Application.dataPath + "/GameData" + "/MoveData.JSON";
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
        string path = Application.dataPath + "/GameData" + "/PlayerInventory.JSON";
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
        string path  = Application.dataPath + "/GameData" + "/PlayerInventory.JSON";

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
        string path  = Application.dataPath + "/GameData" + "/MoveData.JSON";

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


    public void SavePokedex()
    {
        string pokeDexPath = Application.dataPath + "/GameData" + "/PokedexData.JSON";

        Monster m = new Monster();
        m.currentHealth = 100;
        m.mName = "MONSTER TEST";
        pokeDex.Pokedex[0] = m;

        string json = JsonUtility.ToJson(pokeDex);
        //Debug.Log(json);

        if (File.Exists(pokeDexPath))
        {
            //Debug.Log(content);
            File.WriteAllText(pokeDexPath, json);
        }
        else
        {
            Debug.LogError("Error: Cannot find path to PokedexData: " + pokeDexPath);
        }
    }

    public void LoadPokedex()
    {
        string path = Application.dataPath + "/GameData" + "/PokedexData.JSON";
        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);

            //JsonUtility.FromJsonOverwrite(content, this);
            pokeDex = JsonUtility.FromJson<MonsterData>(content);
            Debug.Log("Dex Data Loaded...");

        }
        else
        {
            Debug.LogError("Error: Cannot find path to Dex Data: " + path);
            //new player
        }
    }
    #endregion



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

