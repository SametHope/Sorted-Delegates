using System;
using System.Collections.Generic;
using System.Linq;

namespace SametHope.SortedDelegates
{
    public class SortedFunc<TResult>
    {
        public List<KeyValuePair<Func<TResult>, int>> Listeners => _listeners;
        private List<KeyValuePair<Func<TResult>, int>> _listeners = new List<KeyValuePair<Func<TResult>, int>>();
        public bool IsSorted { get; private set; } = true;
        public void AddListener(Func<TResult> listener, int callPriority = 0)
        {
            _listeners.Add(new KeyValuePair<Func<TResult>, int>(listener, callPriority));
            IsSorted = false;
        }
        public void RemoveListener(Func<TResult> listener)
        {
            _listeners.RemoveAll(kvp => kvp.Key.Equals(listener));
        }
        public void RemoveListener(Func<TResult> listener, int callPriority = 0)
        {
            _listeners.RemoveAll(kvp => kvp.Key.Equals(listener) && kvp.Value == callPriority);
        }
        public TResult Invoke()
        {
            if (!IsSorted) Sort();

            TResult temp = default;
            for (int i = 0; i < _listeners.Count; i++)
            {
                temp = _listeners[i].Key.Invoke();
            }

            return temp;
        }
        public void Clear()
        {
            _listeners.Clear();
        }
        public void Sort()
        {
            _listeners = _listeners.OrderBy(kvp => kvp.Value).ToList();
            IsSorted = true;
        }

        public static SortedFunc<TResult> operator +(SortedFunc<TResult> left, Func<TResult> right)
        {
            left.AddListener(right);
            return left;
        }

        public static SortedFunc<TResult> operator -(SortedFunc<TResult> left, Func<TResult> right)
        {
            left.RemoveListener(right);
            return left;
        }
    }

    public class SortedFunc<T1, TResult>
    {
        public List<KeyValuePair<Func<T1, TResult>, int>> Listeners => _listeners;
        private List<KeyValuePair<Func<T1, TResult>, int>> _listeners = new List<KeyValuePair<Func<T1, TResult>, int>>();
        public bool IsSorted { get; private set; } = true;
        public void AddListener(Func<T1, TResult> listener, int callPriority = 0)
        {
            _listeners.Add(new KeyValuePair<Func<T1, TResult>, int>(listener, callPriority));
            IsSorted = false;
        }
        public void RemoveListener(Func<T1, TResult> listener)
        {
            _listeners.RemoveAll(kvp => kvp.Key.Equals(listener));
        }
        public void RemoveListener(Func<T1, TResult> listener, int callPriority = 0)
        {
            _listeners.RemoveAll(kvp => kvp.Key.Equals(listener) && kvp.Value == callPriority);
        }
        public TResult Invoke(T1 param)
        {
            if (!IsSorted) Sort();

            TResult temp = default;
            for (int i = 0; i < _listeners.Count; i++)
            {
                temp = _listeners[i].Key.Invoke(param);
            }

            return temp;
        }
        public void Clear()
        {
            _listeners.Clear();
        }
        public void Sort()
        {
            _listeners = _listeners.OrderBy(kvp => kvp.Value).ToList();
            IsSorted = true;
        }

        public static SortedFunc<T1, TResult> operator +(SortedFunc<T1, TResult> left, Func<T1, TResult> right)
        {
            left.AddListener(right);
            return left;
        }

        public static SortedFunc<T1, TResult> operator -(SortedFunc<T1, TResult> left, Func<T1, TResult> right)
        {
            left.RemoveListener(right);
            return left;
        }
    }

    public class SortedFunc<T1, T2, TResult>
    {
        public List<KeyValuePair<Func<T1, T2, TResult>, int>> Listeners => _listeners;
        private List<KeyValuePair<Func<T1, T2, TResult>, int>> _listeners = new List<KeyValuePair<Func<T1, T2, TResult>, int>>();
        public bool IsSorted { get; private set; } = true;
        public void AddListener(Func<T1, T2, TResult> listener, int callPriority = 0)
        {
            _listeners.Add(new KeyValuePair<Func<T1, T2, TResult>, int>(listener, callPriority));
            IsSorted = false;
        }
        public void RemoveListener(Func<T1, T2, TResult> listener)
        {
            _listeners.RemoveAll(kvp => kvp.Key.Equals(listener));
        }
        public void RemoveListener(Func<T1, T2, TResult> listener, int callPriority = 0)
        {
            _listeners.RemoveAll(kvp => kvp.Key.Equals(listener) && kvp.Value == callPriority);
        }
        public TResult Invoke(T1 param1, T2 param2)
        {
            if (!IsSorted) Sort();

            TResult temp = default;
            for (int i = 0; i < _listeners.Count; i++)
            {
                temp = _listeners[i].Key.Invoke(param1, param2);
            }

            return temp;
        }
        public void Clear()
        {
            _listeners.Clear();
        }
        public void Sort()
        {
            _listeners = _listeners.OrderBy(kvp => kvp.Value).ToList();
            IsSorted = true;
        }

        public static SortedFunc<T1, T2, TResult> operator +(SortedFunc<T1, T2, TResult> left, Func<T1, T2, TResult> right)
        {
            left.AddListener(right);
            return left;
        }

        public static SortedFunc<T1, T2, TResult> operator -(SortedFunc<T1, T2, TResult> left, Func<T1, T2, TResult> right)
        {
            left.RemoveListener(right);
            return left;
        }
    }
}
