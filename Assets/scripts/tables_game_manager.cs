using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tables_game_manager : MonoBehaviour {
    public GameObject options_tables, options_new_table;

	// Use this for initialization
	void Start () {
        options_tables.SetActive(true);
        options_new_table.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void createNewTable() {
        options_tables.SetActive(false);
        options_new_table.SetActive(true);
    }
}
