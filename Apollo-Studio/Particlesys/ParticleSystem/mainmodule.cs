using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    private ParticleSystem ps;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();

        var main = ps.main;
        main.cullingMode = ParticleSystemCullingMode.AlwaysSimulate;
    }
}