using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1QuestionScript : MonoBehaviour
{
    public GameObject falseImage;

    public void False()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        falseImage.SetActive(true);
        yield return new WaitForSeconds(3);
        Application.LoadLevel(1);
    }
}

