using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class choose_games_manager : MonoBehaviour {
    public GameObject choose1, choose2;
    private Color highlightColor;
    GameObject gm;
    int[] chosenGames;
    // Use this for initialization
    void Start() {
        gm = GameObject.Find("MainGameManager");
        showGames1(true);
        highlightColor = new Color(1f, 0f, 0f, 1f);
        chosenGames = new int[6];
        initArray();
        checkArraySize();

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

    public void highlightChosenGameHandler(GameObject btn) {
        int firstFreeSpot = checkArraySize();
        if(firstFreeSpot != -1) { 
            GameObject parent = btn.transform.parent.gameObject;
            if(btn.name != "tieBtn" && parent.GetComponent<Image>().color != highlightColor) {
                disableHighlightOnSiblings(parent.transform.parent.gameObject);
                highlightChosenGame(parent);
            }
            else if (btn.name == "tieBtn" && btn.GetComponent<Image>().color != new Color(1f, 0f, 0f, 1f)) {
                disableHighlightOnSiblings(parent);
                highlightChosenGame(btn);
            } 
            else {
                if (btn.name == "tieBtn") {
                    disableHighlightOnSiblings(parent);
                }
                if (parent.name == "team1Img" || parent.name == "team2Img") {
                    disableHighlightOnSiblings(parent.transform.parent.gameObject);
                }
            }
        }
        else {
            Debug.Log("NO SPACE, POP UP WINDOW.");
        }
    }

    private void highlightChosenGame(GameObject btn) {
        btn.GetComponent<Image>().color = highlightColor;
    }

    private void disableHighlightOnSiblings(GameObject parent) {
        foreach(Transform child in parent.transform) {
            child.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
        }
    }

    public void callPreviousScene() {
        gm.GetComponent<general_game_manager>().callNewTablesScreen();
    }

    private void initArray() {
        for(int i = 0; i < 6; i++) {
            chosenGames[i] = 11;
        }
    }

    private int checkArraySize() {
        int firstEmpty;
        firstEmpty = System.Array.IndexOf(chosenGames, 11);

        Debug.Log(firstEmpty);
        return firstEmpty;
    }
}
