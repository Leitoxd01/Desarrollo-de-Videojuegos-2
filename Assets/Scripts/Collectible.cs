using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Algo entró al trigger: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Es el jugador, destruyendo...");
            GameController.instance.AddCollectible();
            Destroy(gameObject);
        }
    }
}
