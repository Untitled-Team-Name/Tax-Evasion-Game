using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LoseHealth : MonoBehaviour
{

    public Slider slider;
    public Text moneyText;

    // Start is called before the first frame update
    void Start()
    {
        //Math.Round(slider.value, 2);
        moneyText.text = "$ " + (Math.Round(slider.value, 2)).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value -= 0.01f;
        //moneyText.text = "$ " + slider.value.ToString();
        moneyText.text = "$ " + (Math.Round(slider.value, 2)).ToString();
    }
}
