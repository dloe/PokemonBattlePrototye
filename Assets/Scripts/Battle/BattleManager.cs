using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[SerializeField]
public enum BattleType
{
    None,
    Wild,
    Legend,
    Trainer
}


public class BattleManager : MonoBehaviour
{
    /// <summary>
    /// BattleManager.cs
    ///
    /// Updated: 4/3/22
    ///
    /// Notes:
    /// - Manages all aspects of a battle
    ///
    /// - Vars for battle outside of monsters
    ///     - Weather: none, sunny, rain
    ///
    ///
    /// -initializeBattle()
    ///     - Checks the battle type
    ///     - This takes the players team and sets up the first monster
    ///     - This takes the enemy team ans sets up the first monster
    ///     - This will check for ablilty activation (if we get there)
    ///     - It will end by letting the player input actions
    ///
    /// - playActions()
    ///     - Takes the battle UI for inputs away
    ///     - This will take in the action of the players monster and enemy monster
    ///     - This will check the speed of each monster
    ///     - This will check the Priorty of the move selected my each monster
    ///     - This will create a queue for the turn to play out
    ///     - After each action will check the status of each monster and update queue id needed
    ///         - Checks win condition here.
    ///     - After checking status will check the speed of each remaing monster and update queue if needed
    ///     - After all moves have been executed will check to see if any statuses need to activate (EX burn)
    ///         - Checks win condition here.
    ///     - If monster has fainted in turn will Prompt game to check replacment IF yes will allow new monster to come out
    ///     - At end with input UI Reapearing
    ///
    ///
    /// - battleEnd()
    ///     - This is the check for the win condition if false game turn continues
    ///     - If true Winner UI will appear
    ///         - if player "you win"
    ///         - if enemy "you lose"
    /// </summary>
    ///

    

    public BattleType battleType;

    [Header("Encounter Prefabs")]
    public GameObject WildEncoounter_prefab;
    GameObject myEncounter;
    public PlayerParty myPlayerParty;
    public MovesStorage moveList;
    public MonsterData pokeDex;

    

    private void Awake()
    {
        SetUpMoveData();
        SetUpPlayerInfo();
        SetUpPokedexInfo();
    }

    // Start is called before the first frame update
    void Start()
    {
        //setup battle params
        BattleSetup();
        //begin battle - 
        initializeBattle();

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// This will set the stage for the battle
    ///
    /// -initializeBattle()
    ///     - Checks the battle type
    ///     - This takes the players team and sets up the first monster
    ///     - This takes the enemy team ans sets up the first monster
    ///     - This will check for ablilty activation (if we get there)
    ///     - It will end by letting the player input actions
    /// </summary>
    void initializeBattle()
    {

    }
    /// <summary>
    /// - playActions()
    ///     - Takes the battle UI for inputs away
    ///     - This will take in the action of the players monster and enemy monster
    ///     - This will check the speed of each monster
    ///     - This will check the Priorty of the move selected my each monster
    ///     - This will create a queue for the turn to play out
    ///     - After each action will check the status of each monster and update queue id needed
    ///         - Checks win condition here.
    ///     - After checking status will check the speed of each remaing monster and update queue if needed
    ///     - After all moves have been executed will check to see if any statuses need to activate (EX burn)
    ///         - Checks win condition here.
    ///     - If monster has fainted in turn will Prompt game to check replacment IF yes will allow new monster to come out
    ///     - At end with input UI Reapearing
    /// </summary>
    void playActions()
    {

    }
    /// <summary>
    /// - battleEnd()
    ///     - This is the check for the win condition if false game turn continues
    ///     - If true Winner UI will appear
    ///         - if player "you win"
    ///         - if enemy "you lose"
    /// </summary>
    void battleEnd()
    {

    }


    /// <summary>
    /// Set up battle paraneters, depending on what type of battle we are going to have
    ///     - reads enum (can be overriden in future update so can test specific scenarios)
    ///     
    /// </summary>
    void BattleSetup()
    {


        switch (battleType)
        {
            case BattleType.None:
                Debug.Log("BattleMan: No Battle Type Selected, defaulting to Wild Pokemon");
                WildEncounterGenerator();
                break;
            case BattleType.Wild:
                Debug.Log("BattleMan: Setting Up Wild Pokemon Encounter");
                WildEncounterGenerator();
                break;
            case BattleType.Legend:
                break;
            case BattleType.Trainer:
                break;
            default:
                Debug.Log("BattleManager: No Battle Type Selected, defaulting to Wild Pokemon");
                WildEncounterGenerator();
                break;
        }
        


    }

    #region Wild Encounter Event

    /// <summary>
    /// Runs when player is against a wild pokemon
    ///
    /// - will determine who we are fighint
    ///     - each pokemon should have some sort of moveset that will need to be preprogrammed
    ///         - will keep a list of wild pokemon
    ///             - each pokemon will have an array of available moves
    ///                 - contains stat rabges to generate (min to max)
    ///                 - level will be extername determination (50 as default for now)
    ///                 - wild encounter class found on AI_Lvl1_WildEncounter.cs
    ///         - NOTE: Not sure about complexity of how in depth we need to go, perhaps go for the straight forward basic 'rats'
    /// </summary>
    public void WildEncounterGenerator()
    {

        //for now, will just save it to encounter --- will revise in future
        myEncounter = WildEncoounter_prefab;



        myEncounter.GetComponent<AI_Lvl1_WildEncounter>().battleManager = this;


        myEncounter.GetComponent<AI_Lvl1_WildEncounter>().InitialSetup();
       // myEncounter.GetComponent<AI_Lvl1_WildEncounter>().pokeDex = pokeDex;


    }

    #endregion



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
        string path = Application.dataPath + "/GameData" + "/ALLMOVES.json";
        //C:\Users\Dylan\Desktop\GitHub\PokemonBattlePrototye\Assets\GameData\ALLMOVES.JSON.json
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
        string path = Application.dataPath + "/GameData" + "/PlayerInventory.JSON";

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
        string path = Application.dataPath + "/GameData" + "/MoveData.JSON";

        Move m = new Move();
        m.moveNum = 0;
        m.moveName = "TEST";
        m.power = 69;
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
            //Debug.Log(pokeDex.Pokedex[0].dexNum);
        }
        else
        {
            Debug.LogError("Error: Cannot find path to Dex Data: " + path);
            //new player
        }
    }
    #endregion

}
