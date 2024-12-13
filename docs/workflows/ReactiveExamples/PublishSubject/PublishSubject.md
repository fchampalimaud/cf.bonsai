# PublishSubject

## Summary
This example demonstrates how to get data from a stream that is already running using the [*PublishSubject*](https://bonsai-rx.org/docs/api/Bonsai.Reactive.PublishSubject.html) node. The subscribed subject only receives events that are generated after subscription.

## Workflow

:::workflow
![Example](~/workflows/ReactiveExamples/PublishSubject/PublishSubject.bonsai)
:::

## Details
1. Creates a *Subject*, named *MySubject*, with the values of a counter that starts with value 0 gets incremented every 0.2s.
2. Subscribes *MySubject* 1s after the start of the program. Double-click on this node to visualize its content and compare it with that of the *Timer* node. You should see that the first value of the *Timer* (value 0) is skipped by the *DelaySubscription* because the subject subscription occurs after that value has been emitted. All subsequent values emitted by the *Timer* will reach the *DelaySubscription* node.



## Visualization
Vizualize the node outputs using the *ObjectTextVizualizer* with expanded windows to better compare their contents.



## Follow up
You can compare this with other *Subject* types: [*BehaviorSubject*](../BehaviorSubject/BehaviorSubject.html) and [*ReplaySubject*](../ReplaySubject/ReplaySubject.html).



