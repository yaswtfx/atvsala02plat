using UnityEngine;

public class Door : MonoBehaviour
{
    public string triggerID;

    private void OnEnable()
    {
        EventChannels.OnButtonPressed += HandleButtonPressed;
    }

    private void OnDisable()
    {
        EventChannels.OnButtonPressed -= HandleButtonPressed;
    }

    private void HandleButtonPressed(string id)
    {
        if (id == triggerID)
        {
            Destroy(gameObject);
        }
    }
}
