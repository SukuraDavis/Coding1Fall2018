﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singleton itself
    static GameManager instance;

    //Accessor for the singleton
    public static GameManager Instance
    {
        get { return instance ?? ((instance = new GameManager())); }
    }

    public Ship MyCharacter
    {
        get; set;
    }

    

    //Because we only ever want one, we must make a PRIVATE constructor,
    //not a public onstructor
    private GameManager()
    {
        //Create a new object with a script of type Updater to update
        //The Gamemanager
        Object.DontDestroyOnLoad(new GameObject("Updater", typeof(Updater)));
    }

    private void Update()
    {
       //Game logic would go here like managing time, level resets, etc.
        
    }

    //Internal class used to update the GameManager since GameManager
    //Doesnt inherit from MonoBehaviour
    class Updater : MonoBehaviour
    {
        private void Update()
        {
            instance.Update();
        }
    }
}
