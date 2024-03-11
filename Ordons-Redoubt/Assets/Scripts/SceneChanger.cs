    using UnityEngine;
    using UnityEngine.SceneManagement;
     
    public class SceneChanger : MonoBehaviour
    {
        [SerializeField]
        private string target;
        
        public void NextScene()
        {
            
            SceneManager.LoadScene(target);
        }
    }
