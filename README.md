# Event and Delegate Example 
    
This is a simple C# example that demonstrates the use of event and delegate to handle file processing.


 # Table of Contents
*-Introduction
*-Features
*-Usage
*-Contributing
*-License

## Introduction
The event and delegate pattern can be used in any system where events occur and there is a need for decoupling between the sender and the receiver of the events.
he basic idea is that the sender of the event doesn't need to know who or how many receivers are handling the event, and the receivers don't need to know who the sender is or how the event was triggered. This helps to create a more modular and maintainable system.
and sender called puplisher in this example "InfoFill" is publisher and classes like "StartProcess" and "FinshedProcess"  is subscribers  (and any other classes that subscribe to the event).

## Usage

To use this project, simply clone or download the code from this repository and open it in your preferred C# editor. You can run the code and see the output in the console window.

### Features
This example demonstrates the following features:

1-Implementation of event and delegate in C#
2-Subscription to events by multiple classes
3-Custom event arguments using FileProcessedEventArgs
4-Synchronous event handling

#### Contrbuting
If you find a bug or have a feature request, please open an issue in the repository. Pull requests are welcome for bug fixes or additional features.

##### License
No License 
