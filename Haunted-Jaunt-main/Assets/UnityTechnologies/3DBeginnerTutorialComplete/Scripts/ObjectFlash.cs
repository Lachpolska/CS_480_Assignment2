using UnityEngine;

public class ObjectFlash : MonoBehaviour
{
    public float minAlpha = 0.1f;
    public float maxAlpha = 1.0f;
    public float fadeSpeed = 1f;

    private Material objectMaterial;

    void Start()
    {
        objectMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        // Sine wave oscillates between -1 and 1
        float t = (Mathf.Sin(Time.time * fadeSpeed) + 1f) / 2f;

        // Linear interpolation of the alpha channel so that it is a fade
        float alpha = Mathf.Lerp(minAlpha, maxAlpha, t);

        Color c = objectMaterial.color;
        c.a = alpha;
        objectMaterial.color = c;
    }
}