using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld;
using UnityWeld.Binding;

namespace UnityWeld_Demo
{
    [Binding]
    public class DemoViewModel : ViewModel
    {
        private int _count;

        [Binding]
        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged(nameof(Count));
            }
        }

        [Binding]
        public void OnClickAdd()
        {
            Count++;
        }
        [Binding]
        public void OnClickSubtract()
        {
            Count--;
        }
    }
}
