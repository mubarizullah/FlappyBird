using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject _Panel;
    [SerializeField] private GameObject addTree;
    [SerializeField] private GameObject addPipe;
    [SerializeField]private GameObject bird;
    [SerializeField]public TextMeshProUGUI endScore;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highestScore;
    [SerializeField]private GameObject scoreOnPlay;
    [SerializeField]private GameObject collideSound;
    private Rigidbody2D rb;
    private Animator anim;
    
    private int point = 0;
    private int highScore = 0;
    public float flyingForce = 5f;
    public PlayerInputActions playerInputActions;

    void Awake()
    {
       playerInputActions = new PlayerInputActions();
       playerInputActions.Bird.Fly.performed += Fly;
       playerInputActions.Bird.Fly.canceled += NotFlying;
       playerInputActions.Bird.Enable();

       highScore = PlayerPrefs.GetInt("HighScore", 0);
        highestScore.text = highScore.ToString();
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
            rb = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();   
    }

    public void Fly(InputAction.CallbackContext context)
    {
      
         rb.velocity = Vector2.up*flyingForce ;
         anim.SetBool("IsClicked" , true);
       
    }

    public void NotFlying(InputAction.CallbackContext context)
    {
       anim.SetBool("IsClicked" , false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      _Panel.SetActive(true);
      collideSound.SetActive(true);
      addPipe.SetActive(false);
      addTree.SetActive(false);
      bird.SetActive(false);
      scoreOnPlay.SetActive(false);
      

            GameObject[] pipes = GameObject.FindGameObjectsWithTag("PipeScore");
            GameObject[] trees = GameObject.FindGameObjectsWithTag("tree");

            // Destroy all the found game objects
            foreach (GameObject pipe in pipes)
            {
                Destroy(pipe);
            }

            foreach (GameObject tree in trees)
            {
                Destroy(tree);
            }

            
            if (point>highScore)
            {
                highScore = point;
                PlayerPrefs.SetInt("HighScore",highScore);
                highestScore.text = highScore.ToString();
                
            }

             endScore.text = point.ToString();
           
        }
    


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="PipeScore")
    {
        //incrementing score
        point++;
        scoreText.text = point.ToString();

    }
    
    }
}

