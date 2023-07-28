using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {
    [SerializeField] private string CLevelName = "Prototype";
    [SerializeField] private string NLevelName = "Prototype";

    private void Update() {
        if (Input.GetKey("r")) {
            SceneManager.LoadScene(CLevelName);
        }
    }
}
