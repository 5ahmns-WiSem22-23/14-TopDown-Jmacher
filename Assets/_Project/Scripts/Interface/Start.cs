using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void Play() => SceneManager.LoadScene(1);
    public void Quit() => Application.Quit();
}