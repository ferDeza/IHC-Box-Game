using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeColorOnGrab : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Color originalColor;
    public Color grabColor = Color.red;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalColor = meshRenderer.material.color;

        // Obtiene el componente XRGrabInteractable del objeto
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();

        // Eventos al agarrar y soltar
        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        meshRenderer.material.color = grabColor;
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        meshRenderer.material.color = originalColor;
    }
}
