using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tables_game_manager : MonoBehaviour {
    public GameObject MGManager, gm, inviteFriends, pubBtn, privBtn;
    public bool isItPublicGame;
    Sprite publicNeutral, privateNeutral, publicSelected, privateSelected;

	// Use this for initialization
	void Start () {
        setResources();
        findGameObjects();
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
            setButtonWithSprite(pubBtn, publicSelected);
            setButtonWithSprite(privBtn, privateNeutral);
        } else {
            inviteFriends.SetActive(true);
            setButtonWithSprite(pubBtn, publicNeutral);
            setButtonWithSprite(privBtn, privateSelected);
        }
    }

    private void setButtonWithSprite(GameObject btn, Sprite img) {
        btn.GetComponent<Image>().sprite = img;
    }

    private void setResources() {
        publicNeutral = Resources.Load("Public_Neutral", typeof(Sprite)) as Sprite;
        privateNeutral = Resources.Load("Private_Neutral", typeof(Sprite)) as Sprite;
        publicSelected = Resources.Load("Public_Selected", typeof(Sprite)) as Sprite;
        privateSelected = Resources.Load("Private_Selected", typeof(Sprite)) as Sprite;
        Debug.Log(publicNeutral);
    }

    private void findGameObjects() {
        pubBtn = GameObject.Find("public_btn");
        privBtn = GameObject.Find("private_btn");
    }

    public void createNewTable() {
        gm.GetComponent<general_game_manager>().callNewTablesScreen();
    }
    public void joinExistingTable() {
        gm.GetComponent<general_game_manager>().callJoinTablesScreen();
    }
    public void chooseGamesScene() {
        gm.GetComponent<general_game_manager>().callChooseGamesScreen();
    }
    public void inviteFriendsScene() {
        gm.GetComponent<general_game_manager>().callInviteScreen();
    }
}
