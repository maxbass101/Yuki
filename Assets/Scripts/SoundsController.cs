using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//эта библиотека нужна для работы с интерфейсом
using UnityEngine.UI;

public class SoundsController : MonoBehaviour
{
    //ссылка на объект с изображением
    public GameObject ImageObject;

    //ссылка на компонент Image
    Image imageComponent;

    //картинки
    public Sprite sprite1, sprite2, sprite3, sprite4, sprite5;

    //переменная подсчёта подобранных звуков
    public int sounds;

    public AudioClip mySound1;
    public GameObject AudioSourse1, AudioSourse2, AudioSourse3, AudioSourse4, AudioSourse5;

    //анимация подбора
    public string nameTrigger1, nameTrigger2, nameTrigger3, nameTrigger4, nameTrigger5;
    public GameObject gameObjects;
    public GameObject Coin
        ;

    void Start()
    {
        AudioSourse1 = GameObject.FindGameObjectWithTag("AudioSourse1");
        AudioSourse2 = GameObject.FindGameObjectWithTag("AudioSourse2");
        AudioSourse3 = GameObject.FindGameObjectWithTag("AudioSourse3");

        //делаем линк на image компонент
        imageComponent = ImageObject.GetComponent<Image>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "MusicPoint1")
        {
            AudioSource.PlayClipAtPoint(mySound1, transform.position);
        }
        if (other.gameObject.tag == "MusicPoint2")
        {
            AudioSource.PlayClipAtPoint(mySound1, transform.position);
        }
        if (other.gameObject.tag == "MusicPoint3")
        {
            AudioSource.PlayClipAtPoint(mySound1, transform.position);
        }
        if (other.gameObject.tag == "MusicPoint4")
        {
            AudioSource.PlayClipAtPoint(mySound1, transform.position);
        }
        if (other.gameObject.tag == "MusicPoint5")
        {
            AudioSource.PlayClipAtPoint(mySound1, transform.position);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "MusicPoint1")
        {
            Destroy(other.gameObject);
            AudioSourse1.GetComponent<AudioSource>().mute = false;
            Handheld.Vibrate();

            //Дух анимация подбора звука
            gameObjects.GetComponent<Animator>().SetTrigger(nameTrigger1);

            //увеличить переменную подсчёта звуков
            sounds = sounds + 1;

            //в зависимости от значения sounds выставить картинку в UI
            if(sounds == 1)
            {
                //Монета анимация подбора звука
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger1);
                imageComponent.sprite = sprite1;
            }
            if(sounds == 2)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger2);
                imageComponent.sprite = sprite2;
            }
            if(sounds == 3)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger3);
                imageComponent.sprite = sprite3;
            }
            if (sounds == 4)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger4);
                imageComponent.sprite = sprite4;
            }
            if (sounds == 5)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger5);
                imageComponent.sprite = sprite5;
            }

        }
        if (other.gameObject.tag == "MusicPoint2")
        {
            Destroy(other.gameObject);
            AudioSourse2.GetComponent<AudioSource>().mute = false;
            Handheld.Vibrate();

            //анимация подбора звука
            gameObjects.GetComponent<Animator>().SetTrigger(nameTrigger2);

            sounds = sounds + 1;

            //в зависимости от значения sounds выставить картинку в UI
            if (sounds == 1)
            {
                //Монета анимация подбора звука
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger1);
                imageComponent.sprite = sprite1;
            }
            if (sounds == 2)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger2);
                imageComponent.sprite = sprite2;
            }
            if (sounds == 3)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger3);
                imageComponent.sprite = sprite3;
            }
            if (sounds == 4)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger4);
                imageComponent.sprite = sprite4;
            }
            if (sounds == 5)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger5);
                imageComponent.sprite = sprite5;
            }
        }
        if (other.gameObject.tag == "MusicPoint3")
        {
            Destroy(other.gameObject);
            AudioSourse3.GetComponent<AudioSource>().mute = false;
            Handheld.Vibrate();

            //анимация подбора звука
            gameObjects.GetComponent<Animator>().SetTrigger(nameTrigger3);

            sounds = sounds + 1;

            //в зависимости от значения sounds выставить картинку в UI
            if (sounds == 1)
            {
                //Монета анимация подбора звука
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger1);
                imageComponent.sprite = sprite1;
            }
            if (sounds == 2)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger2);
                imageComponent.sprite = sprite2;
            }
            if (sounds == 3)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger3);
                imageComponent.sprite = sprite3;
            }
            if (sounds == 4)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger4);
                imageComponent.sprite = sprite4;
            }
            if (sounds == 5)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger5);
                imageComponent.sprite = sprite5;
            }
        }
        if (other.gameObject.tag == "MusicPoint4")
        {
            Destroy(other.gameObject);
            AudioSourse4.GetComponent<AudioSource>().mute = false;
            Handheld.Vibrate();

            //анимация подбора звука
            gameObjects.GetComponent<Animator>().SetTrigger(nameTrigger4);

            //увеличить переменную подсчёта звуков
            sounds = sounds + 1;

            //в зависимости от значения sounds выставить картинку в UI
            if (sounds == 1)
            {
                //Монета анимация подбора звука
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger1);
                imageComponent.sprite = sprite1;
            }
            if (sounds == 2)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger2);
                imageComponent.sprite = sprite2;
            }
            if (sounds == 3)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger3);
                imageComponent.sprite = sprite3;
            }
            if (sounds == 4)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger4);
                imageComponent.sprite = sprite4;
            }
            if (sounds == 5)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger5);
                imageComponent.sprite = sprite5;
            }

        }
        if (other.gameObject.tag == "MusicPoint5")
        {
            Destroy(other.gameObject);
            AudioSourse5.GetComponent<AudioSource>().mute = false;
            Handheld.Vibrate();

            //анимация подбора звука
            gameObjects.GetComponent<Animator>().SetTrigger(nameTrigger5);

            //увеличить переменную подсчёта звуков
            sounds = sounds + 1;

            //в зависимости от значения sounds выставить картинку в UI
            if (sounds == 1)
            {
                //Монета анимация подбора звука
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger1);
                imageComponent.sprite = sprite1;
            }
            if (sounds == 2)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger2);
                imageComponent.sprite = sprite2;
            }
            if (sounds == 3)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger3);
                imageComponent.sprite = sprite3;
            }
            if (sounds == 4)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger4);
                imageComponent.sprite = sprite4;
            }
            if (sounds == 5)
            {
                Coin.GetComponent<Animator>().SetTrigger(nameTrigger5);
                imageComponent.sprite = sprite5;
            }

        }
    }
}
