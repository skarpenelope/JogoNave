using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Observer
{

    public static Action<int> OnPointsChanged;

    public static void PointsChanged(int points)
    {
        OnPointsChanged?.Invoke(points);
    }


    public static Action<float> OnEnergyChanged;

    public static void EnergyChanged(float energy)
    {
        OnEnergyChanged?.Invoke(energy);
    }
}
