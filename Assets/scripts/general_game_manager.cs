using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class general_game_manager : MonoBehaviour {
    public GameObject gm;
    public string user;
    public string money;

	// Use this for initialization
	void Start () {
		
	}

    void Awake() {
        DontDestroyOnLoad(gm);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
