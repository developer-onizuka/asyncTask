# asyncTask

```
$ dotnet run
Start Program
Run Child process
Thread 1 -----> ChildAsync process #1
Thread 1 -----> Main Heavy process #1 *
Thread 4 -----> ChildAsync process #2
Thread 4 -----> ChildAsync process #3
Thread 5 -----> ChildAsync process #4
Thread 1 -----> Main Heavy process #2 *
Thread 5 -----> ChildAsync process #5
Thread 4 -----> ChildAsync process #6
Thread 6 -----> ChildAsync process #7
All of Main Heavy processes completed
Thread 4 -----> ChildAsync process #8
Thread 5 -----> ChildAsync process #9
Thread 5 -----> ChildAsync process #10
Confirm all of child processes completed after Main processes finished
```
