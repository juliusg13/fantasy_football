using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tables_game_manager : MonoBehaviour {
    public GameObject MGManager, gm, inviteFriends;
    public bool isItPublicGame;

	// Use this for initialization
	void Start () {
        isItPublicGame = true;
        publicVsPrivateHandler(isItPublicGame);
        /*if(gm = GameObject.Find("MainGameManager")) {
            
        } else {
            gm = GameObject.Instantiate(MGManager, transform.position, transform.rotation);
        }*/

	}

    // Update is called once per frame
    void Update() {
        if (gm == null) {
            gm = GameObject.Find("MainGameManager");
        }
    }

    public void publicVsPrivateHandler(bool status) {
        if (status == true) {
            inviteFriends.SetActive(false);
        } else {
            inviteFriends.SetActive(true);
        }
    }

    public void createNewTable() {
        gm.GetComponent<general_game_manager>().callNewTablesScreen();
    }
    public void joinExistingTable() {
        gm.GetComponent<general_game_manager>().callJoinTablesScreen();
    }
    public void chooseGamesScreen() {
        gm.GetComponent<general_game_manager>().callChooseGamesScreen();
    }
}
