using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScaling : MonoBehaviour
{

    public Scrollbar scaleSlider;
    public RawImage targetImage;
    private Vector3 originalScale;
    void Start()
    {
        if (scaleSlider != null)
        {
            scaleSlider.onValueChanged.AddListener(OnSliderValueChanged);
        }
        originalScale = targetImage.rectTransform.localScale;
    }

    // Update is called once per frame
    void OnSliderValueChanged(float value)
    {
        float scaleFactor = Mathf.Lerp(1f, 1.7f, value);
        targetImage.rectTransform.localScale = originalScale * scaleFactor;
    }
}
