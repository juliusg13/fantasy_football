using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class general_game_manager : MonoBehaviour {

    private static general_game_manager gm_instance;
    
    public GameObject gm;
    public string user;
    public string money;
    Scene currentScene;
    string currentSceneName;
    // Use this for initialization
    void Start () {
        currentSceneName = "main_screen";
    }

    void Awake() {
        DontDestroyOnLoad(this);
        if(gm_instance == null) {
            gm_instance = this;
        } else {
            DestroyObject(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Debug.Log(currentSceneName);


            if (currentSceneName == "tables_screen") {
                //SceneManager.LoadScene("main_screen");
                //Application.LoadLevel("main_screen");
                callMainScreen();
                Debug.Log(currentSceneName);

            } else if (currentSceneName == "tables_screen_new" || currentSceneName == "tables_screen_join") {
                //Application.LoadLevel("tables_screen");
                callTablesScene();
                Debug.Log(currentSceneName);

            }
        } 

    }
    public void callMainScreen() {
        //SceneManager.LoadScene("main_screen");
        updateSceneName("main_screen");
    }
    public void callTablesScene() {
        //SceneManager.LoadScene("tables_screen");
        updateSceneName("tables_screen");
    }
    public void callNewTablesScreen() {
        updateSceneName("tables_screen_new");
    }
    public void callJoinTablesScreen() {
        updateSceneName("tables_screen_join");
    }

    public void updateSceneName(string nextScene) {
        SceneManager.LoadScene(nextScene);
        currentScene = SceneManager.GetActiveScene();
        currentSceneName = nextScene;
        Debug.Log("switching to: " + currentSceneName);
    }

}
