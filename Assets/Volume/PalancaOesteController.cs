using UnityEngine;
using UnityEngine.InputSystem;

public class PalancaOesteController : MonoBehaviour
{
    [Header("Configuración de Input")]
    [SerializeField] private InputActionReference palancaOesteAction;

    private void OnEnable()
    {
        if (palancaOesteAction == null || palancaOesteAction.action == null) return;

        // Buena práctica: Habilitar el mapa de acciones completo al que pertenece esta acción
        palancaOesteAction.action.actionMap.Enable();

        // Suscripción a eventos
        palancaOesteAction.action.started += OnPalancaPresionada;
        palancaOesteAction.action.canceled += OnPalancaSuelta;
    }

    private void OnDisable()
    {
        if (palancaOesteAction == null || palancaOesteAction.action == null) return;

        palancaOesteAction.action.started -= OnPalancaPresionada;
        palancaOesteAction.action.canceled -= OnPalancaSuelta;
    }

    private void OnPalancaPresionada(InputAction.CallbackContext context)
    {
        Debug.Log("boton presionado (Por Evento)");
    }

    private void OnPalancaSuelta(InputAction.CallbackContext context)
    {
        Debug.Log("boton suelto (Por Evento)");
    }

    // PRUEBA DE FUEGO: Si el evento falla pero el input llega, esto imprimirá en consola
    private void Update()
    {
        if (palancaOesteAction != null && palancaOesteAction.action.IsPressed())
        {
            Debug.Log("Manteniendo palanca presionada (Por Polling en Update)");
        }
    }
}