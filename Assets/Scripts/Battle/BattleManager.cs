using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    /// - 
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// This will set the stage for the battle
    /// </summary>
    void initializeBattle()
    {

    }
<<<<<<< Updated upstream
=======
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

    }

    #endregion
>>>>>>> Stashed changes
}
