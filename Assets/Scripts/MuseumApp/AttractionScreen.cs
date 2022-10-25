using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace MuseumApp
{
    public class AttractionScreen : MonoBehaviour
    {
        public Color likeColor;
        public Color dislikeColor;

        public Image[] stars;
        public string attractionID;

        private void Start()
        {
            attractionID = GetComponent<AttractionGraphicsSetup>().config.id;

            if (PlayerPrefs.HasKey(attractionID))
                ColorStars(PlayerPrefs.GetInt(attractionID));
            else
                ColorStars(0);
        }

        public void OnClickStar(int starNumber)
        {
            ColorStars(starNumber);

            PlayerPrefs.SetInt(attractionID, starNumber);
        }

        private void ColorStars(int starNumber)
        {
            for (int i = 0; i < stars.Length; i++)
            {
                if (i < starNumber)
                    stars[i].color = likeColor;
                else
                    stars[i].color = dislikeColor;
            }
        }

        public void OnClickBack()
        {
            SceneManager.LoadScene(0);
        }
    }
}