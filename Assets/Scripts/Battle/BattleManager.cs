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
    // Start is called before the first frame update
    void Start()
    {
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
}
