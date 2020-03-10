using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnxVal : MonoBehaviour
{
    public float anxietyLv;
    public AnxietyBar ABar;
    // Start is called before the first frame update
    void Start()
    {
        anxietyLv = 100;
    }

    public void AnxLevel()
    {
        anxietyLv = 75;
    }

    // Update is called once per frame
    void Update()
    {
        //ABar = GameObject.Find("/AnxBar");

        ABar.SetAnx(anxietyLv);
    }
}
