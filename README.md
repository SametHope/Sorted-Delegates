# Sorted Delegates
Sorted Delegates is a helpful tool that allows you to manage delegates and callbacks with precision unlike the default behavior. Relying on a specific order of execution is generally discouraged but there are times it may come to use. 

Additionally, I couldn't find any online implementations of sorted/ordered delegates that didn't involve costly techniques like using attributes and reflection. That's why now having Sorted Delegates available online is great. It provides a simple and direct solution without the need for convoluted workarounds, making it accessible to anyone who stumbles upon it.

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
- Does not bloat your project, it lives on its own assembly definition.
- It is open source.
- Fun to use.

## Cons
- This approach may and likely will lead to bad code design.
- Performance is generally lower than regular delegates. However, with higher listener counts, it tends to catch up and can even surpass regular delegates for some reason (needs more testing, it is probably JIT compiler messing with my tests).

## Usage
To use the Sorted Delegates, follow these steps:

1. Include the necessary script files in your project.
2. Create an sorted delegate instance.
3. To register a listener with a specific call priority, use the `AddListener(listener, callPriority = 0)` method. The call priority is an integer value,
 where lower numbers indicate higher priority.
4. The order of the callbacks will be updated only after a new listener has been added and when the event has been invoked.

## License
The Sorted-Delegates repository is released under the [MIT License](LICENSE.md).
