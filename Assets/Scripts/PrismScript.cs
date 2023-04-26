using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrismScript : MonoBehaviour
{

    
    public Color newColor = new Color(1f, 0f, 0f, 1f);

    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        renderer.material.color = newColor;
    }
}
