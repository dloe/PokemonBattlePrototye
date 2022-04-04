using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public BattleManager battleManager;


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



}

/// <summary>
/// For storage of the Wild Encounter Data from Json
/// 
///  each pokemon will have an array of available moves
///                 - contains stat rabges to generate (min to max)
///                 - level will be extername determination (50 as default for now)
/// </summary>
public class WildEncounterData
{
    //will store info for each pokemon as struct
    public struct PokeEncounter
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
    }

    public PokeEncounter[] encounterList;


}
