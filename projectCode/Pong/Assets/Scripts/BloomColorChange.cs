using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class BloomColorChange : MonoBehaviour
{
    [SerializeField]
    private Gradient colorGradient;
    [SerializeField]
    private float strobeDuration = 2f;

    private void Update()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        var postProcessVolume = GameObject.FindObjectOfType<UnityEngine.Rendering.PostProcessing.PostProcessVolume>();

        Bloom bloom = postProcessVolume.profile.GetSetting<UnityEngine.Rendering.PostProcessing.Bloom>();
        var colorParameter = new UnityEngine.Rendering.PostProcessing.ColorParameter();

        float t = Mathf.PingPong(Time.time / strobeDuration, 1f);
        colorParameter.value = colorGradient.Evaluate(t);
        bloom.color.Override(colorParameter);
    }
}
