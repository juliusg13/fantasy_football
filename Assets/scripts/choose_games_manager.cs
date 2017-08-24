using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class choose_games_manager : MonoBehaviour {
    public GameObject choose1, choose2;
    GameObject gm;
	// Use this for initialization
	void Start () {
        gm = GameObject.Find("MainGameManager");
        showGames1(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// if true, enable games1 and disable games 2, vice versa if false.
    /// </summary>
    /// <param name="status"></param>
    public void showGames1(bool status) {
        if(status == true) {
            choose1.SetActive(true);
            choose2.SetActive(false);
        } else {
            choose1.SetActive(false);
            choose2.SetActive(true);
        }
    }
    public void highlightChosenGame(GameObject btn) {
        GameObject parent = btn.transform.parent.gameObject;
        disableHighlightOnSiblings(parent);
        if (btn.name == "tieBtn") {
            btn.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        } else {
            disableHighlightOnSiblings(parent.transform.parent.gameObject);
            btn.transform.parent.gameObject.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }
    }

    private void disableHighlightOnSiblings(GameObject parent) {
        foreach(Transform child in parent.transform) {
            child.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }

    public void callPreviousScene() {
        gm.GetComponent<general_game_manager>().callNewTablesScreen();
    }
}
