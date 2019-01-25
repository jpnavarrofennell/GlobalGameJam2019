using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class blinkingTxt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(Blink());
	}
	
	public IEnumerator Blink()
	{
		while (true)
		{
			GetComponent<Text>().enabled = false;
			yield return new WaitForSeconds(.5f);

			GetComponent<Text>().enabled = true;
			yield return new WaitForSeconds(.5f);
		}
	}
}
