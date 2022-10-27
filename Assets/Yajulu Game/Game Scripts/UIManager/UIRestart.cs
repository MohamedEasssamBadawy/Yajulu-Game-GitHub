using UnityEngine;
using TMPro;
using EndlessRunner.UiDistance;
using EndlessRunner.Player;
using EndlessRunner.UIscore;


namespace EndlessRunner
{
    namespace UIrestart
    {

        public class UIRestart : MonoBehaviour
        {
            PlayerMovement Player;
            public Canvas Canvesrestart;
            public Canvas CanvesPlayer;
            public TextMeshProUGUI FinalScore;
            public UIScore UIScore;

            // Start is called before the first frame update
            void Start()
            {
                Player = FindObjectOfType<PlayerMovement>();
                Canvesrestart.enabled = false;

            }

            // Update is called once per frame
            void Update()
            {

                if (Player.Pause)
                {
                    RestartGame();
                }


            }
            public void RestartGame()
            {

                Canvesrestart.enabled = true;
                CanvesPlayer.enabled = false;
                FinalScore.text = "Score   " + UIScore.score;
                if (Player.Ischeck)
                    Canvesrestart.enabled = false;
                    

                       
            }

        }
    }
}
