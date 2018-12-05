using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour {

    public double frequency {get;set;}
    public double freq2;
    private double increment;
    private double phase;
    private double sampling_frequency = 48000.0;

    public float gain { get; set; }
    public float volume = 0.1f;

    void Start()
    {
        frequency = 440;
        gain = 0;
    }

    void Update()
    {
        freq2 = frequency;
    }
   
    void OnAudioFilterRead(float[] data, int channels)
   {
        increment = frequency * 1.0 * Mathf.PI / sampling_frequency;

        for(int i = 0; i < data.Length; i += channels)
        {
            phase += increment;
            data[i] = (float)(gain * Mathf.Sin((float)phase)) + (float)(gain * (double)Mathf.PingPong((float)phase, 1.0f));

            if(channels == 2)
            {
                data[i + 1] = data[i];
            }

            if(phase > (Mathf.PI * 2))
            {
                phase = 0.0;
            }
        }
    }
}
