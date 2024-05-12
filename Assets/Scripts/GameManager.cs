using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text collectiblesNumberText;
    public TMP_Text totalCollectiblesNumberText;
    public AudioSource audioSource;
    private int collectiblesNumber;
    private int totalCollectiblesNumber;


    void Start()
    {
        totalCollectiblesNumber = transform.childCount;
        totalCollectiblesNumberText.text = totalCollectiblesNumber.ToString();
    }

    void Update()
    {
        if (transform.childCount <= 0)
        {
            Debug.Log("Win");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void AddCollectible()
    {
        audioSource.Play();
        collectiblesNumber++;
        collectiblesNumberText.text = collectiblesNumber.ToString();
    }
}
