using UnityEngine;

public class CharacterSwitching : MonoBehaviour
{
    public GameObject ecko; // Player1
    public GameObject nova; // Player2
    private GameObject activeCharacter; // Personaje activo
    public CameraController cameraController; // Referencia al script de la c�mara

    private void Start()
    {
        // Verificar que los personajes est�n asignados
        if (ecko == null || nova == null)
        {
            Debug.LogError("Ecko o Nova no est�n asignados en el Inspector.");
            return;
        }

        // Asignar Ecko como personaje activo al inicio
        activeCharacter = ecko;
        SetActiveCharacter(ecko);

        // Establecer la c�mara para seguir a Ecko al inicio
        cameraController.SetTarget(ecko.transform);
    }

    private void Update()
    {
        // Alternar entre personajes cuando se presione la tecla Tab
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (activeCharacter == ecko)
            {
                SetActiveCharacter(nova);
            }
            else
            {
                SetActiveCharacter(ecko);
            }
        }
    }

    // M�todo para cambiar el personaje activo
    private void SetActiveCharacter(GameObject characterToActivate)
    {
        // Desactivar los controles del personaje actual
        if (activeCharacter != null)
        {
            if (activeCharacter == ecko && activeCharacter.GetComponent<PlayerController1>() != null)
            {
                activeCharacter.GetComponent<PlayerController1>().enabled = false;
            }
            else if (activeCharacter == nova && activeCharacter.GetComponent<PlayerController2>() != null)
            {
                activeCharacter.GetComponent<PlayerController2>().enabled = false;
            }
        }

        // Cambiar el personaje activo
        activeCharacter = characterToActivate;

        // Activar los controles del nuevo personaje
        if (activeCharacter == ecko && activeCharacter.GetComponent<PlayerController1>() != null)
        {
            activeCharacter.GetComponent<PlayerController1>().enabled = true;
        }
        else if (activeCharacter == nova && activeCharacter.GetComponent<PlayerController2>() != null)
        {
            activeCharacter.GetComponent<PlayerController2>().enabled = true;
        }

        // Actualizar el target de la c�mara
        cameraController.SetTarget(activeCharacter.transform);
    }
}
