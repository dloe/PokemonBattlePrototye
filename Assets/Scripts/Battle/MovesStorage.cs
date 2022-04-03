using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "MoveList", menuName = "ScritableObjects/MoveList", order = 2)]
public class MovesStorage //: ScriptableObject
{
    /// <summary>
    /// MovesStorage.cs
    /// Dylan Loe
    /// 
    /// Last Updated: 4/3/22
    /// 
    /// Acts as a simple storage for all available moves
    /// 
    /// TO DO:
    /// - set up move loading through a javascript file (easier to to edit and visually understand)
    ///     - through the use of JsonUnity
    ///     - or i can just use scriptable objs ((long term longevity may require saving scriptable obj to jsob and visa versa for readability)
    ///         - for now using scriptable obj and can mess wtih local of json later
    /// </summary>

    public Move[] moveList;

    public MovesStorage()
    {
        moveList = new Move[3];

    }

}
