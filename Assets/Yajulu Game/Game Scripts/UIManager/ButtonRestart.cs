using UnityEngine;
using EndlessRunner.Player;
using EndlessRunner.Health;
using EndlessRunner.UiDistance;
using EndlessRunner.UIscore;


namespace EndlessRunner {
    namespace Buttonrestart
    {


        public class ButtonRestart : MonoBehaviour
        {
            public Vector3 Player;
            public PlayerMovement PlayerInposition;
            public Animator PlayerAnimator;
            public Canvas CanvesBeginning;
            public Canvas CanvesRestart;
            public bool GoToPlay;
            private HealthBar healthBar;
            private UIDistance uIDistance;
            private UIScore uIscore;

            private void Start()
            {
                healthBar = FindObjectOfType<HealthBar>();
                uIDistance = FindObjectOfType<UIDistance>();
                uIscore = FindObjectOfType<UIScore>();
            }
            void Update()
            {
                if (GoToPlay)
                {
                    RestartScene();
                   
                }

            }

            public void RestartScene()
            {


                
                PlayerAnimator.SetBool("Death", false);
                CanvesBeginning.enabled = true;
                CanvesRestart.enabled = false;
                
                Physics.gravity = new Vector2(0, -9.8f);
                GoToPlay = true;
                PlayerInposition.transform.position = Player;
                PlayerInposition.transform.rotation = Quaternion.identity;
                healthBar.CurrentHealth = 100f;
                uIDistance.Distance = 0;
                uIscore.score = 0;
                
            }

        }

    }
}

