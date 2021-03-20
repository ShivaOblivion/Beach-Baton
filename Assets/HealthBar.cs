using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public void SetMaxHealth(int heart)
    {
        slider.maxValue = heart;
        slider.value = heart;

    }
    public void SetHeart(int heart)
    {
        slider.value = heart;
    }

}