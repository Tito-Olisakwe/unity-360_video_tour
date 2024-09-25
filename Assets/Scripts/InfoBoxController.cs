using UnityEngine;
using TMPro;

public class InfoBoxController : MonoBehaviour
{
    public GameObject infoBox;
    public TMP_Text infoText;
    public string[] sphereDescriptions;

    private bool isInfoBoxActive = false;
    private int currentSphereIndex = 0;

    public void SetCurrentSphereIndex(int sphereIndex)
    {
        currentSphereIndex = sphereIndex;
    }

    public void ShowInfoBox()
    {
        infoText.text = sphereDescriptions[currentSphereIndex];

        isInfoBoxActive = true;
        infoBox.SetActive(true);
    }

    public void HideInfoBox()
    {
        isInfoBoxActive = false;
        infoBox.SetActive(false);
    }

    public void ToggleInfoBox()
    {
        if (isInfoBoxActive)
        {
            HideInfoBox();
        }
        else
        {
            ShowInfoBox();
        }
    }
}
