using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseLight()
    {
        if (RenderSettings.ambientIntensity < 1.0f)
        {
            RenderSettings.ambientIntensity += 0.1f;
        }
    }

    public void DecreaseLight()
    {
        if (RenderSettings.ambientIntensity > 0f)
        {
            RenderSettings.ambientIntensity -= 0.1f;
        }
    }
}
