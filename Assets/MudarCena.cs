using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour
{
    public Animator animator;
    private int leveltoLoad;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){ //com click do botão esquerdo do mouse, irá fazer o que têm abaixo
            FadeToNextLevel();
        }
    }

    public void FadeToNextLevel(){ //chamar para o próximo nível
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel(int levelIndex){
        leveltoLoad = levelIndex;
        animator.SetTrigger("Fade_Out");
    }

    public void OnFadeComplete(){
        SceneManager.LoadScene(leveltoLoad);
    }
}
