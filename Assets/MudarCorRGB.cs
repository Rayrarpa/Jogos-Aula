using UnityEngine;

public class MudarCorRGB : MonoBehaviour
{
    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Exemplo: Altera a cor usando RGB (valores de 0 a 1) baseada no tempo
        float r = Mathf.Sin(Time.time) * 0.5f + 0.5f;
        float g = Mathf.Cos(Time.time) * 0.5f + 0.5f;
        float b = Mathf.PingPong(Time.time, 1f);

        _renderer.material.color = new Color(r, g, b);
    }
}