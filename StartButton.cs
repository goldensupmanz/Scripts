using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    private int timesClicked = 0;
    public GameObject Title;
    public GameObject Lore;

    public void OnClick()
    {
        timesClicked++;
        if (timesClicked == 1)
        {
            Title.SetActive(false);
            Lore.SetActive(true);
        } else if  (timesClicked == 2)
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
