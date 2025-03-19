using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SliderValueUpdater : MonoBehaviour
{
    public Slider[] sliders; // Array of Sliders
    public TMP_Text[] inputFields; // Array of TMP_InputFields

    void Start()
    {
        if (sliders.Length != inputFields.Length)
        {
            Debug.LogError("The number of sliders and input fields must be the same!");
            return;
        }

        // Subscribe each slider to update its corresponding TMP_InputField
        for (int i = 0; i < sliders.Length; i++)
        {
            int index = i; // Capture index to avoid closure issues
            sliders[i].onValueChanged.AddListener(value => UpdateInputField(index, value));
        }
    }

    void UpdateInputField(int index, float value)
    {
        if (index >= 0 && index < inputFields.Length)
        {
            inputFields[index].text = value.ToString("0.####"); // Update TMP_InputField
        }
    }
}
