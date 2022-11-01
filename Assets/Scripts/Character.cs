using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName = "My name";
    private int currentLevel = 3;
    public int addedLevel = 1;
    private int outputValue;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(characterName);
        ComputeLevels();
        PrintValues(characterName, currentLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /// <summary> 
    /// Prints the characters name and level
    /// </summary> 
    /// <param name="name"></param>
    /// <param name="level"></param>

    public void PrintValues(string Name, int level) 
    {
        Debug.Log($"Character name: {Name} | Level: {level}");
    
    }

    public void ComputeLevels()
    {
        Debug.Log(currentLevel + addedLevel);
        outputValue = currentLevel + addedLevel;
    }
}
