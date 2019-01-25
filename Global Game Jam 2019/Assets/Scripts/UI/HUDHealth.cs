using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDHealth : MonoBehaviour
{
    private Text _healthText;

    // Start is called before the first frame update
    void Start()
    {
        _healthText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _healthText.text = Player_Health.Instance.GetHealth().ToString();
    }
}
