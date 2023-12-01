using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIButtonNavigation : MonoBehaviour
{
    private Selectable selectable;

    private void Start()
    {
        // Ensure the GameObject has a Selectable component
        selectable = GetComponent<Selectable>();
        if (selectable == null)
        {
            Debug.LogError("UIButtonNavigation requires a Selectable component.");
            return;
        }
    }

    private void Update()
    {
        // Check for navigation input (e.g., arrow keys)
        NavigateUI();
    }

    private void NavigateUI()
    {
        if (selectable == null)
            return;

        // Check for horizontal input
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            // Move to the next selectable in the specified direction
            if (horizontalInput > 0)
                selectable.FindSelectableOnRight()?.Select();
            else
                selectable.FindSelectableOnLeft()?.Select();
        }

        // Check for vertical input
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput != 0)
        {
            // Move to the next selectable in the specified direction
            if (verticalInput > 0)
                selectable.FindSelectableOnUp()?.Select();
            else
                selectable.FindSelectableOnDown()?.Select();
        }
    }
}