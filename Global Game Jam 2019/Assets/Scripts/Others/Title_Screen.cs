using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Title_Screen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.anyKey)
            SceneManager.LoadScene("GGJ_Project");
	}
}
