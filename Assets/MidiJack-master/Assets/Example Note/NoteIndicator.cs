using UnityEngine;
using MidiJack;

public class NoteIndicator : MonoBehaviour
{
    public int noteNumber { get;set; }
    GameObject aFile;
    private AudioSource sound;
    private bool pressed = false;
    private int tick = 0;
    public int sustanLength;

    void Start()
    {
        aFile = GameObject.Find("Sound");
        sound = aFile.GetComponent<AudioSource>();
    }

    void Update()
    {
        var color = Color.clear;
        if (MidiMaster.GetKeyDown(noteNumber))
        {
            color = Color.red;
            
        }
        else
        {
            if (pressed)
            {
                tick++;
                if (tick == sustanLength)
                {
                    tick = 0;
                    pressed = false;
                    color = Color.white;

                }
            }
            else
            {
                color = Color.white;
            }
        }

        
        if(MidiMaster.GetKeyDown(noteNumber)){

            GameObject.Find(noteNumber.ToString()).GetComponent<Oscillator>().gain = 1f;
        }
        if (MidiMaster.GetKeyUp(noteNumber))
        {
         
            GameObject.Find(noteNumber.ToString()).GetComponent<Oscillator>().gain = 0;
            pressed = true;
        }
        GetComponent<Renderer>().material.color = color;

    }
}
