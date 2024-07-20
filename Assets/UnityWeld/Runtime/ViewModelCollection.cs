using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityWeld
{
    public class ViewModelCollection : MonoBehaviour
    {
        public int Count => _count;
        [SerializeField]
        private ViewModel baseViewModel;

        private List<ViewModel> _pool = new();
        private int _count = 0;

        private void Awake()
        {
            baseViewModel.gameObject.SetActive(false);
        }

        public void PrepareViewModels(int count)
        {
            if (_pool.Count < count)
            {
                for (int i = _pool.Count; i < count; i++)
                {
                    var viewModel = Instantiate(baseViewModel, transform);
                    _pool.Add(viewModel);
                }
            }
            for (int i = 0; i < count; i++)
            {
                _pool[i].gameObject.SetActive(true);
            }
            for(int i = count; i < _pool.Count; i++)
            {
                _pool[i].gameObject.SetActive(false);
            }
            _count = count;
        }
        
        public ViewModel GetViewModel(int index)
        {
            if(index < 0 || index >= Count)
                throw new IndexOutOfRangeException();
            return _pool[index];
        }
        public List<ViewModel> GetViewModels()
        {
            return _pool.GetRange(0, Count);
        }
    }
}
