using UnityEngine;
using UnityEngine.EventSystems;

public class CursorChanger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Texture2D cursorTexture;
    [SerializeField] private Vector2 hotSpot = Vector2.zero;
    [SerializeField] private CursorMode cursorMode = CursorMode.Auto;

    private void Start()
    {
        if (cursorTexture == null)
        {
            Debug.LogError("Cursor texture is not assigned on " + gameObject.name);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Cursor entered " + gameObject.name);
        if (cursorTexture != null)
        {
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Cursor exited " + gameObject.name);
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
} 