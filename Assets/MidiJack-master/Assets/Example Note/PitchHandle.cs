using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PitchHandle : MonoBehaviour
{

    public int semiN;
    public Text t;

    // Use this for initialization
    void Start()
    {
        semiN = 12;
        updateFreq();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            semiN = 12;
            updateFreq();
        }
        if (Input.GetKeyDown("2"))
        {
            semiN = 24;
            updateFreq();
        }
        if (Input.GetKeyDown("2"))
        {
            semiN = 36;
            updateFreq();
        }
        if (Input.GetKeyDown("3"))
        {
            semiN = 7;
            updateFreq();
        }
        if (Input.GetKeyDown("4"))
        {
            semiN = 15;
            updateFreq();
        }
        if (Input.GetKeyDown("5"))
        {
            semiN = 21;
            updateFreq();
        }
        if (Input.GetKeyDown("6"))
        {
            semiN = 19;
            updateFreq();
        }
        if (Input.GetKeyDown("7"))
        {
            semiN = 100;
            updateFreq();
        }
        if (Input.GetKeyDown("8"))
        {
            semiN = 6;
            updateFreq();
        }
        if (Input.GetKeyDown("9"))
        {
            semiN = 20;
            updateFreq();
        }
        if (Input.GetKeyDown("0"))
        {
            semiN = 17;
            updateFreq();
        }



    }
    void updateFreq()
    {
        for (int i = 36; i <= 85; i++)
        {

            //GameObject.Find(i.ToString()).GetComponent<Oscillator>().frequency = 440f * (float)(Mathf.Pow(2, ((i - 49) / semiN)));
            //t.text = (Mathf.Pow(2, ((i - 49) / semiN))).ToString();
            GameObject.Find(i.ToString()).GetComponent<Oscillator>().frequency = 65.41f * (Mathf.Pow((Mathf.Pow(2.0f, (float)(1.0 / semiN))), i - 36));   
        }
    }



}
