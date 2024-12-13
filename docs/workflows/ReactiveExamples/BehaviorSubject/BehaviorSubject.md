# BehaviorSubject

## Summary
This example demonstrates how to get data from a stream that is already running using the [*BehaviorSubject*](https://bonsai-rx.org/docs/api/Bonsai.Reactive.BehaviorSubject.html) node. The subscribed subject only receives the last event generated before the subscriptions as well as all of those generated subsequently.

## Workflow

:::workflow
![Example](~/workflows/ReactiveExamples/BehaviorSubject/BehaviorSubject.bonsai)
:::

## Details
1. Creates a *Subject*, named *MySubject*, with the values of a counter that starts with value 0 gets incremented every 2s.
2. Subscribes *MySubject* 1s after the start of the program. Double-click on this node to visualize its content and compare it with that of the *Timer* node. You should see that the first value of the *Timer* (value 0) is received by the *DelaySubscription* even though the subscription was done after the value has been emitted. All subsequent values emitted by the *Timer* will reach the *DelaySubscription* node.

## Visualization
Vizualize the node outputs using the *ObjectTextVizualizer* with expanded windows to better compare their contents.


## Follow up
You can compare this with other *Subject* types:  [*PublishSubject*](../PublishSubject/PublishSubject.html) and [*ReplaySubject*](../ReplaySubject/ReplaySubject.html).

