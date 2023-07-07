using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GlitchTextEffect : MonoBehaviour
{
    public Text textObject;  // Reference to your Text object
    private string originalText;  // Original text

    void Start()
    {
        textObject = GetComponent<Text>();
        originalText = textObject.text;  // Save the original text
        StartCoroutine(GlitchText());
    }

    IEnumerator GlitchText()
    {
        
        while (true)
        {
            
            textObject.text = GetGlitchText(originalText);  // Apply glitch effect
            yield return new WaitForSeconds(Random.Range(0.05f, 0.2f));  // Wait a random time
            textObject.text = originalText;  // Restore original text
            yield return new WaitForSeconds(Random.Range(1, 3));  // Wait a random time
        }
    }

    string GetGlitchText(string text)
    {
        char[] glitchedText = text.ToCharArray();

        for (int i = 0; i < glitchedText.Length; i++)
        {
            if (Random.value < 0.1f)  // 10% chance to glitch a character
            {
                glitchedText[i] = (char)('A' + Random.Range(0, 26));  // Replace with a random capital letter
            }
        }

        return new string(glitchedText);
    }
}