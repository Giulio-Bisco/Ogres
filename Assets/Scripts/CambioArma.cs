using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioArma : MonoBehaviour
{
    public Text goldTxt;

    private void Start(){
        RefreshGold();
    }

    private void RefreshGold(){
        goldTxt.text = Manager.Instance.Gold.ToString();
        PlayerPrefs.SetInt("Gold", Manager.Instance.Gold);
        PlayerPrefs.SetInt("Damage", Manager.Instance.Damage);
    }

    public void NuovaArma(int codice){
        switch(codice){
        case 1:
            if(Manager.Instance.Gold<20){
                Toast.Instance.Show("Not enough gold.");
            } else {
                Manager.Instance.Gold-=20;
                Manager.Instance.Damage = 5;
                RefreshGold();
            }
            break;
        case 2:
            if(Manager.Instance.Gold<50){
                Toast.Instance.Show("Not enough gold.");
            } else {
                Manager.Instance.Gold-=50;
                Manager.Instance.Damage = 10;
                RefreshGold();
            }
            break;
        case 3:
            if(Manager.Instance.Gold<100){
                Toast.Instance.Show("Not enough gold.");
            } else {
                Manager.Instance.Gold-=100;
                Manager.Instance.Damage = 20;
                RefreshGold();
            }
            break;
        case 4:
            if(Manager.Instance.Gold<300){
                Toast.Instance.Show("Not enough gold.");
            } else {
                Manager.Instance.Gold-=300;
                Manager.Instance.Damage = 50;
                RefreshGold();
            }
            break;
        }
    }
}
