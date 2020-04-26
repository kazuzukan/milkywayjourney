using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteStar : MonoBehaviour
{
    public Transform tx;
    private ParticleSystem.Particle[] points;
    // public ParticleSystem.SetParticles particles;
    public ParticleSystem particleSystem;

    public int starMax = 100;
    public float startSize = 1;
    public float starDistance = 10;
    public float starDistanceSqr;

    // Start is called before the first frame update
    void Start()
    {
        tx = transform;
        starDistanceSqr = starDistance * starDistance;
    }

    private void createStars()
    {
        points = new ParticleSystem.Particle[starMax];

        for (int i = 0; i < starMax; i++)
        {
            points[i].position = Random.insideUnitSphere * starDistance + tx.position;
            points[i].color = new Color(1, 1, 1, 1);
            points[i].size = startSize;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (points == null) createStars();

        for (int i=0; i<starMax; i++){
            if((points[i].position - tx.position).sqrMagnitude>starDistanceSqr){
                points[i].position = Random.insideUnitSphere * starDistance + tx.position;
            }
        }
        // particles = new ParticleSystem.SetParticles(points, points.Length);
        // ParticleSystem.SetParticles(points, points.Length);
        GetComponent<ParticleSystem>().SetParticles(points, points.Length);  
    }
}
