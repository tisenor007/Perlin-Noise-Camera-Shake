using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float freq;
    public float amp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(PerlinNoise(Time.time, 0.1f * freq) * amp, PerlinNoise(Time.time, 0f * freq) * amp, 0f);
    }

    public float PerlinNoise(float x, float y)
    {
        return (Mathf.PerlinNoise(x, y) * 2.0f) - 1.0f;
    }
}
