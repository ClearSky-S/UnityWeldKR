using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityWeld.Binding;

namespace UnityWeld
{
    [Binding]
    public abstract class ViewModel : MonoBehaviour, INotifyPropertyChanged
    {
        protected virtual void Awake()
        {
            var bindings = GetComponentsInChildren<AbstractMemberBinding>(true);
            foreach (var binding in bindings)
            {
                binding.Init();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
