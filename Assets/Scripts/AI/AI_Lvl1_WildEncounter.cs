using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AI_Lvl1_WildEncounter : MonoBehaviour
{
    /// <summary>
    /// AI_Lvl1_WildEncounter
    /// Dylan Loe
    /// 
    /// Updated: 4/3/22
    /// 
    /// - Level 1 AI - Used Specifically for Wild Pokemon Encounters
    /// 
    /// - has the same percent chance to pick from any of its active moves
    ///     - so for example if we have 4 moves for a bidoof, it has a 25% to pick any of them
    /// - will have a function to set up start of encounter for what pokemon (whwat moves, stats etc)
    /// - wont have to store in json since all info is determined in battlemanager
    /// 
    /// - only 1 pokemon
    /// </summary>

    //wild pokemon
    public Monster wildPokemon;
    int moveCount = 0;
    public BattleManager battleManager;
    //ublic MonsterData pokeDex;

    WildEncounterData myEncounterData;

    private void Awake()
    {
        //InitialSetup();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void TurnActive()
    {
        //first determine if we are going to attack (possibe for poke to run)

        //if we are for sure attacking we have to pick which move
        //even chances across available moves

        //
    }


    #region BattleInteractions

    //called from battle manager when it is encounters turn to choose move
    public Move ChooseMove()
    {
        int choice = UnityEngine.Random.Range(0, moveCount);
        Move encounterMove = wildPokemon.moves[choice];
        Debug.Log("Encounter: Choose move number " + choice + " -> " + encounterMove.moveName);
        //move choose between 0 -> moveCount on array
        //will send over info to battle manager
        


        return encounterMove;
    }



    #endregion


    #region Setup
    /// <summary>
    /// Runs in start
    /// - sets up data for determining encounter
    /// - runs setup for picking encounter 
    /// </summary>
    public void InitialSetup()
    {
        LoadEncounterData();

        PickEncounter();


    }

    void PickEncounter()
    {
        Debug.Log("WildEncounter: Determining Encounter Pokemon...");

        //pick random pokemon index
        int pokeIndex = UnityEngine.Random.Range(0, myEncounterData.encounterList.Length - 1);
        // Debug.Log(pokeIndex);
        //Debug.Log(myEncounterData.encounterList[pokeIndex].dexNum);
        PokeEncounter encounterInfo = myEncounterData.encounterList[pokeIndex];
        //should have the stats like types and whatnot, will override the max and current to be specific to encounter (they default to 0)
        Monster pokemonEncounter = battleManager.pokeDex.Pokedex[encounterInfo.dexNum];

        //set stats
        pokemonEncounter.maxHealth = pokemonEncounter.currentHealth = UnityEngine.Random.Range(encounterInfo.pMin_health, encounterInfo.pMax_health);
        pokemonEncounter.maxAttack = pokemonEncounter.currentAttack = UnityEngine.Random.Range(encounterInfo.pMin_attack, encounterInfo.pMax_attack);
        pokemonEncounter.maxDefense = pokemonEncounter.currentDefense = UnityEngine.Random.Range(encounterInfo.pMin_defense, encounterInfo.pMax_defense);
        pokemonEncounter.maxSpeAtt = pokemonEncounter.currentSpeAtt = UnityEngine.Random.Range(encounterInfo.pMin_speAtt, encounterInfo.pMax_speAtt);
        pokemonEncounter.maxSpeDef = pokemonEncounter.currentSpeDef = UnityEngine.Random.Range(encounterInfo.pMin_speDef, encounterInfo.pMax_speDef);
        pokemonEncounter.maxSpeed = pokemonEncounter.currentSpeed = UnityEngine.Random.Range(encounterInfo.pMin_speed, encounterInfo.pMax_speed);

        Debug.Log("WildEncounter: " + pokemonEncounter.mName);
        Debug.Log("Level: " + pokemonEncounter.level);

        //select moves (usually 3 - 4)
        int totalMoves = UnityEngine.Random.Range(3, 4);
        for (moveCount = 0; moveCount < totalMoves; moveCount++)
        {
            int[] moveList = encounterInfo.possibleMoves;
            //shuffle moves
            ShuffleArray(moveList);
            Move mov = battleManager.moveList.moveList[moveList[moveCount]];
            pokemonEncounter.moves[moveCount] = mov;

        }

        Debug.Log("Established Moves: " + totalMoves);


        wildPokemon = pokemonEncounter;
    }

    #endregion

    /// <summary>
    /// Get Encounter data from json file
    /// </summary>
    void LoadEncounterData()
    {
        string encounterDataPath = Application.dataPath + "/GameData" + "/EncounterData.JSON";

        if (File.Exists(encounterDataPath))
        {
            string content = File.ReadAllText(encounterDataPath);

            //load
            JsonUtility.FromJsonOverwrite(content, this);
            myEncounterData = JsonUtility.FromJson<WildEncounterData>(content);
            Debug.Log("Encounter Data Loaded...");
        }
        else
        {
            Debug.LogError("Error: Cannot find path to WildEncounterData: " + encounterDataPath);
        }
    }


    void ShuffleArray(int[] a)
    {
        // Loops through array
        for (int i = a.Length - 1; i > 0; i--)
        {
            // Randomize a number between 0 and i (so that the range decreases each time)
            int rnd = UnityEngine.Random.Range(0, i);

            // Save the value of the current i, otherwise it'll overright when we swap the values
            int temp = a[i];

            // Swap the new and old values
            a[i] = a[rnd];
            a[rnd] = temp;
        }
    }
}
    /// <summary>
    /// For storage of the Wild Encounter Data from Json
    /// 
    ///  each pokemon will have an array of available moves
    ///                 - contains stat rabges to generate (min to max)
    ///                 - level will be extername determination (50 as default for now)
    /// </summary>
    [Serializable]
public class WildEncounterData
{
    //will store info for each pokemon as struct
    public PokeEncounter[] encounterList;

    public WildEncounterData()
    {
        encounterList = new PokeEncounter[10];
    }
}

[Serializable]
public class PokeEncounter
{
    public int dexNum;
    //each move in our move list has a number (simple int array)
    public int[] possibleMoves;
    public int level;
    //stats (min and max for each stat we choose randomly)
    public int pMax_health;
    public int pMin_health;
    public int pMax_attack;
    public int pMin_attack;
    public int pMax_defense;
    public int pMin_defense;
    public int pMax_speAtt;
    public int pMin_speAtt;
    public int pMax_speDef;
    public int pMin_speDef;
    public int pMax_speed;
    public int pMin_speed;

    public PokeEncounter()
    {
        dexNum = 0;
        possibleMoves = new int[8];
        level = 50;
        pMax_health = 0;
        pMin_health = 0;
        pMax_attack = 0;
        pMin_attack = 0;
        pMax_defense = 0;
        pMin_defense = 0;
        pMax_speAtt = 0;
        pMin_speAtt = 0;
        pMax_speDef = 0;
        pMin_speDef = 0;
        pMax_speed = 0;
        pMin_speed = 0;
    }
}
