using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tables_game_manager : MonoBehaviour {
    public GameObject options_tables, MGManager;
    public GameObject gm;

	// Use this for initialization
	void Start () {
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

    public void createNewTable() {
        gm.GetComponent<general_game_manager>().callNewTablesScreen();
    }
    public void joinExistingTable() {
        gm.GetComponent<general_game_manager>().callJoinTablesScreen();
    }
}
