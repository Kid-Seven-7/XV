using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;

public class StartMenu : MonoBehaviour {

	public Button load;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		load.onClick.AddListener(loadOnClick);
	}

	void loadOnClick(){
        EditorUtility.DisplayPopupMenu(new Rect(Input.mousePosition.x, Input.mousePosition.y, 0, 0), "Assets/", null);
	}
}
