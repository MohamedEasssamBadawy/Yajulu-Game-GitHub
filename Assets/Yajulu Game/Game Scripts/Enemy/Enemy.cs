using UnityEngine;


namespace EndlessRunner
{
    namespace Enemy
    {

        public class Enemy : MonoBehaviour
        {

            public Animator HitPlayer;

            private void Update()
            {
                
            }

            private void OnTriggerEnter(Collider other)
            {
                if (other.gameObject.transform.tag == "Player")
                {
                    Destroy(gameObject);
                    HitPlayer.SetBool("Hit", true);
                    HitPlayer.SetBool("SkateRight", false);
                    HitPlayer.SetBool("SkateLeft", false);
                }
                
                

                





            }

        }
    }
}
