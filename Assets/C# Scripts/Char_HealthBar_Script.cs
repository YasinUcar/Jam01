using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Char_HealthBar_Script : MonoBehaviour
{

    public Slider slider;

    public Gradient gradient;

    public Image fill;

    public void SetMaxHealth (int charhealth)
    {
        slider.maxValue = charhealth;
        slider.value = charhealth;

        fill.color =  gradient.Evaluate(1f);
    }

    public void SetHealth(int charhealth)
    {
        slider.value = charhealth;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

   
}
