using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar : MonoBehaviour
{
    public Health health;
    public Image fillImage;
    private Slider slider;


    void Awake()
    {
        slider = GetComponent<slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
        }

        if (slider.value > slider.minValue && !fillImage.enabled)
        {
            fillImage.enabled = true;
        }

        float fillValue = health.currentHealth / health.maxHealth;

        if (fillValue <= slider.maxValue / 3)
        {
            fillImage.color = Color.white;
        }
        else if (fillValue > slider.maxValue / 3)
        {
            fillImage.color = Color.red;
        }
        slider.value = fillValue;
    }
}
