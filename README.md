# Introduction
I developed this project by following a [tutorial](https://www.youtube.com/watch?v=HBBbv7avzs8) to gain hands-on experience with 
object-oriented programming, interfaces, generics, and software design patterns.

## Design Pattern 
>Design patterns are a toolkit of tried and tested solutions to common problems in software design.

This project has been structured according to the **MVC (Model-View-Controller)** design pattern.

In MVC:
* **Model**: Represents the application's data and business logic.
* **View**: Represents the UI components.
* **Controller**: Mediates between the Model and View components, handling user inputs and updating the model and view accordingly.

In MyATM_App:

1. **App**(Controller)
     - `Welcome()` —> Greets the user
     - `InitializeData()` —> Creates and initializes a list of UserAccount objects
     - `CheckUserCardNumAndPassword()` —> Verifies the correctness of the card number and PIN
2. **Domain**(Model)
     - `class UserAccount` —> The UserAccount type is defined in this section(But it will be initialized within the App class.).
3. **UI**(View)
     - `UserLoginForm()` —> Gets card number and pin as input
     - `LoginProgress()`   —> Shows a progress animation with ‘.’(dot)s
     - `PrintLockScreen()` —> Gives an error message if the account is locked
     - `GetSecretInput()`  —> Masks digits with '*' (asterisks) as the user enters their PIN.

## Interface

>An interface in C# is a contract that defines a set of methods, properties, events, and indexers that a class or struct must implement.

We implemented an interface named `IUserLogin`. 

```
public interface IUserLogin{
        void CheckUserCardNumAndPassword();
    }
```

In this project, the ATMApp class implements the IUserLogin interface,requiring it to include the CheckCardNumAndPassword() method implementation. 

```
public class ATMApp : IUserLogin
```

## Generics

>C# allows us to define generic classes, methods, properties, … using the type parameter and without the specific data type.

We utilize generics to validate user input.

Inside the Validator.cs, we implemented a generic method named `Converter`.


```
public static T Convert<T>(string prompt)
```


Within this method, it retrieves user input and attempts to convert it to the desired type if it is valid. If the conversion fails, it throws an error message.

```
userInput = Utility.GetUserInput(prompt);

                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    if (converter != null)
                    {
                        return (T)converter.ConvertFromString(userInput);
                    }
                    else
                    {
                        return default;
                    }
                }
                catch
                {
                    Utility.PrintMessage("Invalid input. Try again.", false);
                }
```

>[!NOTE]
>We implement this because `Console.ReadLine()` retrieves input as a **string**, whereas we need to store the card number as a **long** numeric type.
