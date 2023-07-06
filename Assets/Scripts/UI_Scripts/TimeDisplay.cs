using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    
    private float elapsedTime;
    private Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<Text>();
    }
    private void LateUpdate()
    {

        float hue = Mathf.PingPong(Time.time, 1f);
        Color color = Color.HSVToRGB(hue, 0.8f, 1f);
        textComponent.color = color;

    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        string minutes = Mathf.Floor(elapsedTime / 60).ToString("00");
        string seconds = Mathf.Floor(elapsedTime % 60).ToString("00");
        string milliseconds = Mathf.Floor((elapsedTime * 1000) % 1000).ToString("000");

        textComponent.text = minutes + ":" + seconds + ":" + milliseconds;

    }
}