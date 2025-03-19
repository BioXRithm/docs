using UnityEngine;
using TMPro;  // Import TextMeshPro namespace

public class GetInputText : MonoBehaviour
{
    // Reference to the TMP_InputField component
    public TMP_InputField inputField;

    void Start()
    {
        // Ensure the inputField reference is set up in the Inspector
        if (inputField == null)
        {
            Debug.LogError("Input Field is not assigned!");
        }
    }

    void Update()
    {
        if (inputField != null)
        {
            // Get the current text value of the input field
            string inputValue = inputField.text;

            // Log or process the value (you can do whatever you need here)
            Debug.Log("Input Text: " + inputValue);
        }
    }
}