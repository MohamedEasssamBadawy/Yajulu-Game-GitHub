using UnityEngine;
using EndlessRunner.Health;
using EndlessRunner.Buttonrestart;
using EndlessRunner.UIscore;


namespace EndlessRunner
{
    namespace Player
    {

        public class PlayerMovement : MonoBehaviour
        {
            public float Speed = 4;
            public bool IsFlip;
            public Vector3 zRotation;
            public Animator player;
            public Canvas CanvasScreen;
            public Canvas CanvesGame;
            public bool Ischeck;
            public bool Pause;
            private HealthBar PlayerHealth;
            private UIScore ScorePlayer;
            private ButtonRestart buttonRestart;
            
            // Update is called once per frame


            private void Start()
            {
                ScorePlayer = FindObjectOfType<UIScore>();
                PlayerHealth = FindObjectOfType<HealthBar>();
                buttonRestart = FindObjectOfType<ButtonRestart>();
                
            }

            void LateUpdate()
            {
                if (Ischeck == true)
                {
                    Move();
                    flip();
                    Bound();
                    ScorePlayer.GO = true;
                    buttonRestart.GoToPlay = false;
                    CanvesGame.enabled = true;
                }
               
            }


            public void Move()
            {
              
                
              float PosX = Input.GetAxis("Horizontal");
              PosX *= Time.deltaTime * Speed;
              transform.Translate(PosX, 0, 2 * Time.deltaTime * Speed);
              player.SetBool("Hit", false);
              CanvasScreen.enabled = false;
              Ischeck = true;
                
            }

            void flip()
            {
                if (Input.GetKeyDown(KeyCode.E) && IsFlip == false)
                {
                        transform.eulerAngles = zRotation;
                        Physics.gravity = new Vector2(0, 9.8f);
                        IsFlip = true;
                        player.SetBool("SkateRight", true);
                        
                }
                else if (Input.GetKeyDown(KeyCode.E) && IsFlip == true)
                { 
                        transform.eulerAngles = new Vector3(0, 0, -1);
                        Physics.gravity = new Vector2(0, -9.8f);
                        IsFlip = false;
                        player.SetBool("SkateRight", true);
                        
                }
                if (Input.GetKeyDown(KeyCode.Q) && IsFlip == false)
                {

                    transform.eulerAngles = -zRotation;
                    Physics.gravity = new Vector2(0, 9.8f);
                    IsFlip = true;
                    player.SetBool("SkateLeft", true);
                   
                }
                else if (Input.GetKeyDown(KeyCode.Q) && IsFlip == true)
                { 
                     transform.eulerAngles = new Vector3(0, 0, 1);
                     Physics.gravity = new Vector2(0, -9.8f);
                     IsFlip = false;
                     player.SetBool("SkateLeft", true);
                 

                }


            }

            private void OnCollisionEnter(Collision collision)
            {
                if(collision.transform.tag == "Ground")
                {
                    player.SetBool("SkateRight", false);
                    player.SetBool("SkateLeft", false);
                }
                
            }

            private void OnTriggerEnter(Collider other)
            {
                if (other.gameObject.transform.tag == "Enemy")
                {
                    PlayerHealth.CurrentHealth -= 25;
                    player.SetBool("Hit", true);
                    if (PlayerHealth.CurrentHealth == 0)
                    {
                        player.SetBool("Hit", false);
                        player.SetBool("Death", true);
                        Ischeck = false;
                        Pause = true;
                        ScorePlayer.GO = false;

                    }
                    
                }
            }
            void Bound()
            {
                if (transform.position.y > 20 || transform.position.y < -20)
                {
                    PlayerHealth.CurrentHealth -= 25;
                    player.SetBool("Hit", true);
                    if (PlayerHealth.CurrentHealth == 0)
                    {
                        
                        player.SetBool("Hit", false);
                        player.SetBool("Death", true);
                        player.SetBool("SkateRight", false);
                        player.SetBool("SkateLeft", false);
                        ScorePlayer.GO = false;
                        Ischeck = false;
                        Pause = true;
                        
                        
                        
                    }
                }
            }

        }
    }
}

