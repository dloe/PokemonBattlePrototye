using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Player : MonoBehaviour
{
    /// <summary>
    /// Player.cs
    /// Dylan Loe
    /// 
    /// Last Updated: 4/3/22
    /// 
    /// 
    /// Notes:
    /// - Contains Player Controls
    /// - UI Hookup (most likely will seperate this)
    /// - CHECK LATER" Maybe contrain player data
    ///     - player data includes current monster party
    ///     
    /// </summary>

    public MovesStorage test;
    string path;
    

    // Start is called before the first frame update
    void Awake()
    {
        //loading json test
        path = Application.dataPath + "/MoveData.JSON";
        if(File.Exists(path))
        {
            string content = File.ReadAllText(path);

            test = new MovesStorage();
            //SaveData();
            LoadData(content);
        }
        else
        {
            Debug.Log("Check path");
        }

        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadData(string moveData)
    {

        //JsonUtility.FromJsonOverwrite(moveData, this);
        test = JsonUtility.FromJson<MovesStorage>(moveData);
        Debug.Log("Data Loaded: ");
        Debug.Log(test.moveList[0].moveName);
    }


    //temp testing of json format, will reference later for saving out playe stats and whatnot
    public void SaveData()
    {
       // MovesStorage temp1 = new MovesStorage();
       // Move[] moveListT = temp1.moveList;
       // moveListT = new Move[3];

        Move m = new Move();
        m.moveNum = 0;
        m.moveName = "TEST";
        m.baseAttackDamage = 69;
        m.powerPoints = 2;
        m.moveDescription = "this is test prey it works";

        //moveListT[0] = m;
        test.moveList[0] = m;

        string json = JsonUtility.ToJson(test);
        Debug.Log(json);

        File.WriteAllText(path, json);


    }
}
