using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelloWorld
{
    public class HelloWorld : MonoBehaviour
    {
        [SerializeField]
        private Vector2 _testVec2;
        [SerializeField]
        private Vector3 _testVec3;
        [SerializeField]
        private int _testInt;
        [SerializeField]
        private float _testFloat;
        [SerializeField]
        private char _testChar;
        [SerializeField]
        private bool _testBool;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Heyyyyyy");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}