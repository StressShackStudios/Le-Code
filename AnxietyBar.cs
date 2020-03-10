using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnxietyBar : MonoBehaviour
{
    public Image AnxBar;
    public int Min;
    public int Max;

    private float currentValue;
    // Start is called before the first frame update

    public void SetAnx(float Anxiety)
    {
        if (Anxiety != currentValue)
        {
            if (Max - Min == 0)
            {
                currentValue = 0;
            }
            else
            {
                currentValue = Anxiety;
            }

            AnxBar.fillAmount = (currentValue / 100);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
}
