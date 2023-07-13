using System;
using System.Collections.Generic;
using System.Linq;

namespace SametHope.SortedDelegates
{
    public class SortedAction
    {
        private List<KeyValuePair<Action, int>> _listeners = new List<KeyValuePair<Action, int>>();
        public bool IsOrdered { get; private set; } = true;
        public void AddListener(Action listener, int callPriority = 0)
        {
            _listeners.Add(new KeyValuePair<Action, int>(listener, callPriority));
            IsOrdered = false;
        }
        public void RemoveListener(Action listener, int callPriority = 0)
        {
            _listeners.RemoveAll(kvp => kvp.Key.Equals(listener) && kvp.Value == callPriority);
        }
        public void Invoke()
        {
            if (!IsOrdered)
            {
                _listeners = _listeners.OrderBy(kvp => kvp.Value).ToList();
                IsOrdered = true;
            }

            for (int i = 0; i < _listeners.Count; i++)
            {
                _listeners[i].Key.Invoke();
            }
        }
        public void Clear()
        {
            _listeners.Clear();
        }
    }

    public class SortedAction<T>
    {
        private List<KeyValuePair<Action<T>, int>> _listeners = new List<KeyValuePair<Action<T>, int>>();
        public bool IsOrdered { get; private set; } = true;
        public void AddListener(Action<T> listener, int callPriority = 0)
        {
            _listeners.Add(new KeyValuePair<Action<T>, int>(listener, callPriority));
            IsOrdered = false;
        }
        public void RemoveListener(Action<T> listener, int callPriority = 0)
        {
            _listeners.RemoveAll(kvp => kvp.Key.Equals(listener) && kvp.Value == callPriority);
        }
        public void Invoke(T param)
        {
            if (!IsOrdered)
            {
                _listeners = _listeners.OrderBy(kvp => kvp.Value).ToList();
                IsOrdered = true;
            }

            for (int i = 0; i < _listeners.Count; i++)
            {
                _listeners[i].Key.Invoke(param);
            }
        }
        public void Clear()
        {
            _listeners.Clear();
        }
    }

    public class SortedAction<T1, T2>
    {
        private List<KeyValuePair<Action<T1, T2>, int>> _listeners = new List<KeyValuePair<Action<T1, T2>, int>>();
        public bool IsOrdered { get; private set; } = true;
        public void AddListener(Action<T1, T2> listener, int callPriority = 0)
        {
            _listeners.Add(new KeyValuePair<Action<T1, T2>, int>(listener, callPriority));
            IsOrdered = false;
        }
        public void RemoveListener(Action<T1, T2> listener, int callPriority = 0)
        {
            _listeners.RemoveAll(kvp => kvp.Key.Equals(listener) && kvp.Value == callPriority);
        }
        public void Invoke(T1 param1, T2 param2)
        {
            if (!IsOrdered)
            {
                _listeners = _listeners.OrderBy(kvp => kvp.Value).ToList();
                IsOrdered = true;
            }

            for (int i = 0; i < _listeners.Count; i++)
            {
                _listeners[i].Key.Invoke(param1, param2);
            }
        }
        public void Clear()
        {
            _listeners.Clear();
        }
    }
}