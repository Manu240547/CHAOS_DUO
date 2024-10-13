using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // El objetivo que la c�mara seguir� (Ecko o Nova)
    public float smoothSpeed = 0.125f; // Velocidad de la transici�n suave de la c�mara
    public Vector3 offset; // Distancia entre la c�mara y el personaje

    private void LateUpdate()
    {
        if (target != null)
        {
            // La posici�n deseada de la c�mara basada en el personaje activo y el offset
            Vector3 desiredPosition = target.position + offset;

            // Mover la c�mara de forma suave usando interpolaci�n lineal
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Asignar la posici�n suavizada a la c�mara
            transform.position = smoothedPosition;
        }
    }

    // M�todo para actualizar el objetivo de la c�mara
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
