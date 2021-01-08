using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseEnemy : MonoBehaviour
{
    public GameObject canvas;
    public Button b;
    public Slider sl;
    public Text goldTxt;
    private float health, maxHealth;
    private int hit;
    private Sprite sp;

    private void Start(){
        hit = Manager.Instance.Damage;
        goldTxt.text = Manager.Instance.Gold.ToString();
    }

    public void SelectEnemy(Sprite s){
        sp = s;
        canvas.SetActive(false);
        b.image.sprite = sp;
        switch(sp.name){
        case "Ogre-1":
            maxHealth = 100;
            break;
        case "Ogre-2":
            maxHealth = 300;
            break;
        case "Ogre-3":
            maxHealth = 500;
            break;
        }
        health = maxHealth;
    }

    public void HitEnemy(){
        health-=hit;
        sl.value = health/maxHealth;
        if(health==0)
            KillEnemy();
    }

    private void KillEnemy(){
        switch(sp.name){
        case "Ogre-1":
            Manager.Instance.Gold+=3;
            goldTxt.text = Manager.Instance.Gold.ToString();
            break;
        case "Ogre-2":
            Manager.Instance.Gold+=10;
            goldTxt.text = Manager.Instance.Gold.ToString();
            break;
        case "Ogre-3":
            Manager.Instance.Gold+=30;
            goldTxt.text = Manager.Instance.Gold.ToString();
            break;
        }
        PlayerPrefs.SetInt("Gold", Manager.Instance.Gold);
        health = maxHealth;
        sl.value = health/maxHealth;
    }
}
