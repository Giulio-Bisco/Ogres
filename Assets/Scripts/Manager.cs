using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
     public static Manager Instance {get; private set;}

     public int Damage = 2;
     public int Gold = 0;

     private void Awake() 
     {
         if(Instance == null)
         {
             Instance = this;
             DontDestroyOnLoad(gameObject);
         }
         else 
         {
             Destroy(gameObject);
         }

        if(PlayerPrefs.GetInt("First") != 10){
            PlayerPrefs.SetInt("First", 10);
            PlayerPrefs.SetInt("Damage", 2);
            PlayerPrefs.SetInt("Gold", 0);
        }

         Damage = PlayerPrefs.GetInt("Damage");
         Gold = PlayerPrefs.GetInt("Gold");

         Debug.Log(Damage);
         Debug.Log(Gold);
     }
 }