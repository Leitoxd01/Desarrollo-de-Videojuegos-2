using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    private int counter = 0;
    public int requiredAmount = 5;

    void Awake()
    {
        instance = this;
    }

    public void AddCollectible()
    {
        counter++;
        Debug.Log("Objetos recogidos: " + counter);

        if (counter >= requiredAmount)
        {
            Debug.Log("Cantidad completada. Reiniciando...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
