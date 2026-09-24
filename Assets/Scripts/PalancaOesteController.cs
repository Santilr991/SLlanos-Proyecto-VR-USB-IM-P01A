using UnityEngine;
using UnityEngine.InputSystem;

public class PalancaOesteController : MonoBehaviour
{
    [Header("Configuración de Input")]
    [SerializeField] private InputActionReference palancaOesteAction;

    private void OnPalancaPresionada(InputAction.CallbackContext context)
    {
        Debug.Log("sector oeste presionado");
    }

    private void OnPalancaSuelta(InputAction.CallbackContext context)
    {
        Debug.Log("sector oeste suelto");
    }

    private void OnEnable()
    {
        palancaOesteAction.action.performed += OnPalancaPresionada;
        palancaOesteAction.action.canceled += OnPalancaSuelta;
    }

    private void OnDisable()
    {
        palancaOesteAction.action.performed -= OnPalancaPresionada;
        palancaOesteAction.action.canceled -= OnPalancaSuelta;
    }

}