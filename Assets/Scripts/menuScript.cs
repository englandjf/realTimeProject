using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class menuScript:MonoBehaviour{
	public GameObject topMenu;
	public Button buildButton;
	public Button dropButton;

	public GameObject buildMenu;
	public Button backButtonBuild;

	public GameObject dropMenu;
	public Button backButtonDrop;

	GameObject activeMenu;

	public globalVars gv;



	void Start()
	{
		activeMenu = topMenu;
		buildMenu.SetActive (false);
		dropMenu.SetActive (false);
		gv.menuState = activeMenu;
	}

	public void stageChanged(string ms)
	{
		switch (ms) {
		case "TOP":
			switchMenus (topMenu);
			break;
		case "DROP":
			switchMenus (dropMenu);
			break;
		case "BUILD":
			switchMenus (buildMenu);
			break;
		}
	}

	void switchMenus(GameObject a)
	{
		activeMenu.SetActive (false);
		activeMenu = a;
		activeMenu.SetActive (true);
		gv.menuState = activeMenu;
		gv.clearTileState ();
	}

}
