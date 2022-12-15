using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// 2022.11.17
/// </summary>
public class TGamesSession : MonoBehaviour
{
    public static TGamesSession Instance { get; private set; }

    [SerializeField]
    int hitsToShowOnBoard = Mathf.Max(0, 1000);  //0

    [SerializeField]
    TextMeshProUGUI text;

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

   public void PlusHitCounter(int hit)
    {
         hitsToShowOnBoard += hit;
        // text.text = "track: " + hitsToShowOnBoard.ToString();
        // text.text = "track: " + hitsToShowOnBoard.ToString();
        text.text = hitsToShowOnBoard.ToString();
    }

    public void SubstractHitCounter(int hit)
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

        if (hit == -10)
        {
            hitsToShowOnBoard = 0;
        }
    }

    public void BlobSFX()
    {
        audioSource.PlayOneShot(blob);
    }
}
