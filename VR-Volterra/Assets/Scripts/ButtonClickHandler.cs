using UnityEngine;
using TMPro;
using UnityEngine.UI; // Required for Toggle

public class ButtonClickHandler : MonoBehaviour
{
    public TMP_InputField depredadores, presas; // Reference to the TextMeshPro Input Field
    public Slider alphaSlider, betaSlider, gammaSlider, deltaSlider;
    public Toggle submitButton; // UI Set button (which is actually a Toggle)

    void Start()
    {
        Debug.Log("Inicia");
        if ((submitButton != null) && (alphaSlider != null) && (betaSlider != null) && (gammaSlider != null) && (deltaSlider != null))
        {
            // Subscribe to the Toggle event
            submitButton.onValueChanged.AddListener(OnSubmitButtonToggled);
        }
        else
        {
            Debug.LogError("Submit button (Toggle) is not assigned!");
        }


    }

    void OnSubmitButtonToggled(bool isOn)
    {
        Debug.Log("EVENT LANZADO -------");
        if (isOn) // Only trigger when the toggle is set to ON
        {
            if ((depredadores != null) && (presas != null) && (alphaSlider != null) && (betaSlider != null) && (gammaSlider != null) && (deltaSlider != null))
            {
                int.TryParse(depredadores.text, out int predators);
                int.TryParse(presas.text, out int preys);
                float alpha = alphaSlider.value;
                float beta = betaSlider.value;
                float gamma = gammaSlider.value;
                float delta = deltaSlider.value;
                Debug.Log("Predators: " + predators + "; Preys: " + preys);
                Debug.Log("Slider: " + alpha + "-" + beta + "-" + gamma + "-" + delta);
            }
            else
            {
                Debug.LogError("Input Field is not assigned!");
            }
        }
    }
}