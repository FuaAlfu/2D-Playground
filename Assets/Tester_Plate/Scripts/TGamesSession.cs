using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/// <summary>
/// 2022.11.17
/// </summary>
public class TGamesSession : MonoBehaviour
{
    public static TGamesSession Instance { get; private set; }

    //[SerializeField]
    //int hitsToShowOnBoard = Mathf.Max(0, 1000);  //0

    [SerializeField]
    float hitsToShowOnBoard = 10f;

    [SerializeField]
    TextMeshProUGUI text;

    [SerializeField]
    GameObject loseConditionsUI;

    [SerializeField]
    AudioClip blob;

    AudioSource audioSource;

     void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //  text.text = "track: " + hitsToShowOnBoard.ToString();
        text.text =  hitsToShowOnBoard.ToString();

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //PlusHitCounter();
    }

   public void PlusHitCounter(float hit)
    {
         hitsToShowOnBoard += hit;
        // text.text = "track: " + hitsToShowOnBoard.ToString();
        // text.text = "track: " + hitsToShowOnBoard.ToString();
        text.text = hitsToShowOnBoard.ToString();
    }

    public void SubstractHitCounter(float hit)
    {
        //if(hit == 0 && hit < 0)
        //{
        // && Mathf.Clamp(0, Mathf.Infinity)
        //   hitsToShowOnBoard = 0;
        //}
        //else if(hit > 0 && hit != 0)
        //{
        // hitsToShowOnBoard -= hit;
        // text.text = "track: " + hitsToShowOnBoard.ToString();
        // text.text = "track: " + hitsToShowOnBoard.ToString();
        // text.text = hitsToShowOnBoard.ToString();
        //   }
        hitsToShowOnBoard -= hit;
        // text.text = "track: " + hitsToShowOnBoard.ToString();
        // text.text = "track: " + hitsToShowOnBoard.ToString();
        text.text = hitsToShowOnBoard.ToString();

        if (hitsToShowOnBoard <= 0)
        {
            hitsToShowOnBoard = 0;
            loseConditionsUI.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void BlobSFX()
    {
        audioSource.PlayOneShot(blob);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        loseConditionsUI.gameObject.SetActive(false);
        Time.timeScale = 1;
        hitsToShowOnBoard = 2;
        text.text = hitsToShowOnBoard.ToString();
    }
}
