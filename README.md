# Sorted Delegates
Sorted Delegates enable you to manage delegates and callbacks in specific orders
instead of the default behaviour which is the subscription order and is often unreliable.
While relying on a specific order of execution is generally discouraged in code design,
this code may help to address situations where such a requirement arises and no other suitable alternatives are available online.

## Features
The repository offers the following delegate types:

- `SortedFunc<TResult>`
- `SortedFunc<T1, TResult>`
- `SortedFunc<T1, T2, TResult>`

Additionally, it includes the following action types:

- `SortedAction`
- `SortedAction<T>`
- `SortedAction<T1, T2>`

The repository does not provide a specific `Predicate` type, as it can be implemented using the `SortedFunc<T1, TResult>` type.

## Pros
- It is not dependent on Unity, can be used in regular C# projects.
- Prevents chaining delegates and callbacks.
- It is open source.

## Cons
- This approach may and likely will lead to bad code design.
- Performance is generally lower than regular delegates. However, with higher listener counts, it tends to catch up and can even surpass regular delegates for some reason.

## Usage
To use the Sorted Delegates, follow these steps:

1. Include the necessary script files in your project.
2. Create an sorted delegate instance.
3. To register a listener with a specific call priority, use the `AddListener(listener, callPriority = 0)` method. The call priority is an integer value,
 where lower numbers indicate higher priority.
4. The order of the callbacks will be updated only after a new listener has been added and when the event has been invoked.

## License
The Sorted-Delegates repository is released under the [MIT License](LICENSE.md).
