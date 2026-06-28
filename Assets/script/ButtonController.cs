using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour,
IPointerDownHandler,
IPointerUpHandler
{
    public enum ButtonType
    {
        Forward,
        Backward,
        Left,
        Right,
        Jump
    }

    public ButtonType buttonType;

    public void OnPointerDown(PointerEventData eventData)
    {
        SetValue(true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        SetValue(false);
    }

    void SetValue(bool value)
    {
        switch(buttonType)
        {
            case ButtonType.Forward:
                GameInput.Forward = value;
                break;

            case ButtonType.Backward:
                GameInput.Backward = value;
                break;

            case ButtonType.Left:
                GameInput.Left = value;
                break;

            case ButtonType.Right:
                GameInput.Right = value;
                break;

            case ButtonType.Jump:
                GameInput.Jump = value;
                break;
        }
    }
}