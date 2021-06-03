# AbstractClass
C# Abstract Classes - What They Are and How to Use Them

## What is an abstract Class ?
An abstract class is something in between and interface and a class.
It is a blend of interface and base class
- Class - can have props,methods and can be instanciated. It can define and implement methods.
- Interface - here the methods are defined but cannot be implemented
- Abstract class - it can define and implement methods but cannot be instanciated. (we cannot create and instance using new keyword)

Syntax : 
```
  public abstract class <classname>
  {
    
  }
```
we use an abstract keyword before class

## Benifits of Abstract Classes
- Can declare and implement methods 
- Cannot be instanciated.
- It can have abstract methods
Syntax :
```
  public abstract <MethodName>();
```
- To implement an abstract method in a class, we need to override the method
Syntax :
```
  public override void <MethodName>()
  {
    //Implementation...
  }
```
- Only abstract methods can be overrided. The methods with implementation in the abstract class cannot be overrided in Class.
- However if you want to override the method implemented in abstract class, we have to make that method virtual.
Syntax :
```
  // In abstract Class :
  public virtual void <MethodName>()
  {
    // implementaiton
  }
  // in class :
  public override void <MethodName>()
  {
    // different implementation
  }
```
