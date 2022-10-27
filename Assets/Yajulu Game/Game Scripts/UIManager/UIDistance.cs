using UnityEngine;
using EndlessRunner.Player;
using TMPro;

namespace EndlessRunner
{
    namespace UiDistance
    {
        public class UIDistance : MonoBehaviour
        {
            public TextMeshProUGUI TextDistance;
            public int Distance = 0;
            public Canvas CanvesPlayer;
            public Canvas CanvesRestart;
            PlayerMovement Player;
            public bool GOTo = true;
            private void Start()
            {
                Player = FindObjectOfType<PlayerMovement>();
                CanvesPlayer.enabled = false;
                
            }
            private void FixedUpdate()
            {
                if (Player.Ischeck)
                {
                    DistanceCount();
                    CanvesPlayer.enabled = true;
                   
                }
            }


             void DistanceCount()
            {
               
                
                TextDistance.text = "Distance   " + Distance++;
                   
                
            }

        }
    }
}

