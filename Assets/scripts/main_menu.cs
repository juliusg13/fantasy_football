using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class main_menu : MonoBehaviour {
    GameObject gm;
	// Use this for initialization
	void Start () {
        gm = GameObject.Find("MainGameManager");
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void callTables() {
        gm.GetComponent<general_game_manager>().callTablesScene();
    }
}
