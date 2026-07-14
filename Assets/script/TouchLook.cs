using UnityEngine;
using UnityEngine.EventSystems;

public class TouchLook : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    public Transform player;
    public Transform holdPos;

    public float sensitivity = 0.15f;

    private Vector2 lastPosition;
    private float xRotation = 0f;

    public void OnPointerDown(PointerEventData eventData)
    {
        lastPosition = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 delta = eventData.position - lastPosition;
        lastPosition = eventData.position;

        // Putar player kiri-kanan
        player.Rotate(Vector3.up * delta.x * sensitivity);

        // Putar kamera atas-bawah
        xRotation -= delta.y * sensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        holdPos.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}