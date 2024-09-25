using UnityEngine;

public class SphereManager : MonoBehaviour
{
    public GameObject[] spheres;
    public GameObject[] buttons;
    public Animator fadeAnimator;
    public InfoBoxController infoBoxController;

    void Start()
    {
        buttons[0].SetActive(false);
    }

    public void SwitchSphere(int targetIndex)
    {
        fadeAnimator.SetTrigger("Fade");

        foreach (GameObject button in buttons)
        {
            button.SetActive(true);
        }

        foreach (GameObject sphere in spheres)
        {
            sphere.SetActive(false);
        }

        buttons[targetIndex].SetActive(false);
        spheres[targetIndex].SetActive(true);

        infoBoxController.SetCurrentSphereIndex(targetIndex);
        infoBoxController.HideInfoBox();
    }
}
