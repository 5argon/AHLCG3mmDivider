using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace E7.AhLcgMiniDivider
{
    internal class Runner : MonoBehaviour
    {
        [SerializeField] private Applier applier;
        [SerializeField] private GenSpec[] specs;

        private void Awake()
        {
            StartCoroutine(CaptureRoutine());
        }

        IEnumerator CaptureRoutine()
        {
            for (var i = 0; i < 3; i++)
            {
                yield return null;
            }

            foreach (var v in specs)
            {
                var scene = SceneManager.CreateScene(v.name);
                SceneManager.SetActiveScene(scene);
                applier.Gen(v);
                yield return null;
            }
        }
    }
}