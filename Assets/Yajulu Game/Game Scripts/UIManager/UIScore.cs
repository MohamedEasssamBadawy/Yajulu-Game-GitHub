using UnityEngine;
using TMPro;
using EndlessRunner.UiDistance;
using EndlessRunner.Player;


namespace EndlessRunner {
    namespace UIscore
    {

        public class UIScore : MonoBehaviour
        {

            public UIDistance DistanceValue;
            public TextMeshProUGUI TextScore;
            private PlayerMovement Player;
            public int score;
            public bool GO;
            private void Awake()
            {
                Player = FindObjectOfType<PlayerMovement>();
                TextScore.text = "Score           " + score;

                InvokeRepeating("Score", 1.8f, 1.8f);
            }

            private void Update()
            {
              
            }
             void Score()
            {
                if (GO)
                {
                    
                   
                    TextScore.text = "Score           " + score;
                    score += 1000;
                    GO = false;
                      
                    
                }    

            }

        }
    }
}
