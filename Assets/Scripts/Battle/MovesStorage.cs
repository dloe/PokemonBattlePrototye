using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovesStorage
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
    ///     - this is how we store the json info into something accessable easily by unity classes
    /// </summary>

    public Move[] moveList;

    public MovesStorage()
    {
        moveList = new Move[4];

    }

}
