// Top Down Starter Kit
// By J. Navarro-Fennell
// Class: WinLevel
// Description:

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WinLevel : MonoBehaviour {
	
	// On collision loads the LevelWin scene in the Example Scene folder 
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player") {			
            SceneManager.LoadScene("LevelWin");
        }
	}
}
