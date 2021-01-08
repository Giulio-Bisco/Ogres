using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private bool esci = false;

    public void Gioca() {
        SceneManager.LoadScene("Gioco");
    } 

    public void Negozio() {  
        SceneManager.LoadScene("Negozio");  
    }

    public void MenuIniziale() {  
        SceneManager.LoadScene("MenuIniziale");  
    }
    
    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if(SceneManager.GetActiveScene().name == "MenuIniziale"){
                if(!esci){
                   Toast.Instance.Show("Premi di nuovo per uscire.");
                    esci = true;
                } else {
                   Application.Quit();
                }
            }
            else
                SceneManager.LoadScene("MenuIniziale"); 
        }
    }
}
