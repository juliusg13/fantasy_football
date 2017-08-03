using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choose_games_manager : MonoBehaviour {
    public GameObject choose1, choose2;
	// Use this for initialization
	void Start () {
		
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

}
