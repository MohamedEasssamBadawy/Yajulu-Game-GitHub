using UnityEngine.UI;
using UnityEngine;
using EndlessRunner.Player;


namespace EndlessRunner
{
    namespace Health
    {
        public class HealthBar : MonoBehaviour
        {

            public Image healthbar;
            private float Maxhealth = 100f;
            public float CurrentHealth = 100f;
            

            private void Start()
            {
                
            }
            
            void Update()
            {

                healthbar.fillAmount = CurrentHealth / Maxhealth;

            }

          
        }
    }
}
