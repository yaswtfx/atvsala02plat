using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    public string doorID;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EventChannels.AbrirPorta(doorID);
        }
    }
}
