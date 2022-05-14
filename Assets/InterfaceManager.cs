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
}
