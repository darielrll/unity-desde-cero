using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager musicManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (musicManager == null)
        {
            musicManager = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
