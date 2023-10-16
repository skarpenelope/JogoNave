using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerEnergyUIController : MonoBehaviour
{
   private Slider energySlider;

   private void OnEnable()
   {
      Observer.OnEnergyChanged += UpdateEnergy;
   }

   private void OnDisable()
   {
      Observer.OnEnergyChanged -= UpdateEnergy;
   }

   private void Awake()
   {
      energySlider = GetComponent<Slider>();
   }

   private void UpdateEnergy(float value)
   {
      energySlider.value = value;
   }
}
