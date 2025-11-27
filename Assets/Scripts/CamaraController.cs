using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoothSpeed = 10f;

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;

        // RAYCAST PARA EVITAR QUE LA CAMARA SE META EN LA PARED
        RaycastHit hit;
        if (Physics.Raycast(player.position, offset.normalized, out hit, offset.magnitude))
        {
            // Si la cámara iba a chocar con algo, la acerco
            desiredPosition = hit.point - offset.normalized * 0.3f;
        }

        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.LookAt(player);
    }
}
