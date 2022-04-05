using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

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

    public WildEncounterData myEncounterData;



    // Start is called before the first frame update
    void Start()
    {
        initializeBattle();
        myEncounterData = new WildEncounterData();
        WildEncounterGenerator();
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
        LoadEncounterData();


    }

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

    #endregion

}
