# Adapter pattern in C#

In this challenge, we applied the Adapter pattern to integrate two existing classes, Celular and Tablet, into a unified interface IProduto.

The Adapter pattern acts as a bridge between incompatible interfaces, allowing objects with different interfaces to work together seamlessly.

We started by defining a common interface IProduto that declares methods for obtaining product information such as model, price, and specifications.

Then, we created two adapters, AdaptadorCelular and AdaptadorTablet, each adapting the methods of its corresponding class to match the IProduto interface. These adapters encapsulate the logic needed to convert calls to Celular and Tablet methods into calls to the common interface methods.

By using adapters, we achieved the goal of listing all available products in a consistent manner, regardless of their specific implementation details. This demonstrates how the Adapter pattern enables the integration of disparate systems and promotes code reusability and maintainability.
