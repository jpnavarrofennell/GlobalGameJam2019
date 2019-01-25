using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Win_Screen : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		if(transform.position.z >= 4.689415f)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, (float)(transform.position.z - (8 * Time.deltaTime)));
		}
        else
		{
			StartCoroutine(esperar());
		}
	}
	
    public IEnumerator esperar()
	{
		yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Title Screen");
	}
	
	
	
}
