using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Counter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        counterText.text = counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = counter.ToString();
    }
}
