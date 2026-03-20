using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    private int timesClicked = 0;
    public GameObject Text1;
    public GameObject Text2;

    public void OnClick()
    {
        timesClicked++;
        if (timesClicked == 1)
        {
            Text1.SetActive(false);
            Text2.SetActive(true);
        } else if  (timesClicked == 2)
        {
            int sceneNumber = SceneManager.GetActiveScene().buildIndex;
            
            SceneManager.LoadScene(sceneNumber + 1);
        }
    }
}