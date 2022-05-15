using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InterfaceManager : MonoBehaviour
{
    /// <summary>
    /// InterfaceManager.cs
    /// Dylan Loe
    /// 
    /// Last Updated: 5/13/22
    /// 
    /// - Manager to handle all UI updates and changes
    ///     - IE Text updates, icon/sprite changes, etc
    /// - manage all dialog through a queue that the player can go through 
    /// 
    /// </summary>
    /// 

    [Header("Players Pokemon Info")]
    public Text PlayerPokemonName_text;
    public Text PlayerPokemonLevel_text;
    public Text PlayerPokemonHealth_text;
    public Sprite PlayerPokemonGender_sprite;
    public Slider PlayerPokemonHealth_slider;

    [Header("Opponents Pokemon Info")]
    public Text OppPokemonName_text;
    public Text OppPokemonLevel_text;
    public Sprite OppPokemonGender_sprite;
    public Slider OppPokemonHealth_slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    #region Updating UI Elements (IE text and sprite objs)

    public void SetOpponentUIText(Monster opponent)
    {
        OppPokemonName_text.text = opponent.mName;
        OppPokemonLevel_text.text = opponent.level.ToString();
        
    }

    public void SetPlayerUIText(Monster playerPoke)
    {
        PlayerPokemonName_text.text = playerPoke.mName;
        PlayerPokemonLevel_text.text = playerPoke.level.ToString();
        PlayerPokemonHealth_text.text = playerPoke.currentHealth.ToString() + " / " + playerPoke.maxHealth.ToString();
        PlayerPokemonHealth_slider.maxValue = playerPoke.maxHealth;
        PlayerPokemonHealth_slider.minValue = playerPoke.currentHealth;

    }

    public void MoveSlider()
    {

    }

    #endregion

    //display dialog
    //as we have stuff to say, add it to queue. certain
    //switching turns and whatnot require the player gets through the current list of text
    //queue wont simply just hold a string object, will hold some identifier so we know that once player has read through it, to begin next set of gameplay
    //cant display next element of text if they are currently viewing the only text element in queue



}
