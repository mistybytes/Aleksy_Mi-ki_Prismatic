using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrismScript : MonoBehaviour
{

    
    public Color newColor = new Color(255f,255f,255f);

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
