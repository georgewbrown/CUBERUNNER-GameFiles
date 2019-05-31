using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;

    void Update() {
        for (int i = 0; i < popUps.length; i++){
        if(i == popUpIndex) {
                popUps[popUpIndex].SetActive(true);
            }else {
                popUps[popUpIndex].SetActive(false);
            }
        }

        if(popUpIndex == 0){
            if (Input.GetKeyDown(KeyCode.Space)) {
                popUpIndexIndex++;
            }
        } else if (Input.GetKeyDown(KeyCode.LeftArrow) || (Input.GetKeyDown(KeyCode.RightArrrow)) {
         popUpIndexIndex++;

        }
    }

}
