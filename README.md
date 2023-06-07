# Patterns_pr2
# О программе

Данное приложение демонстрирует работу продуктового магазина, используя порождающий паттерн "Прототип" и поведенческий паттерн "Посетитель".

В приложении есть классы, связанные с паттерном "Прототип":

- Абстрактный класс ProductPrototype определяет общий интерфейс для создания копий продуктов.
- Конкретные классы-прототипы BookPrototype и ToyPrototype наследуются от абстрактного класса ProductPrototype и реализуют методы Clone(), который создает копию объекта, и Accept(), который позволяет посетителю взаимодействовать с конкретным прототипом.

В приложении также есть классы, связанные с паттерном "Посетитель":

- Интерфейс Visitor определяет методы для каждого типа продукта, которые посетитель будет использовать.
- Конкретный класс CustomerVisitor реализует интерфейс Visitor и определяет операции, которые выполняются при посещении каждого типа продукта.

Класс ProductStore представляет продуктовый магазин и использует хранилище прототипов (prototypes) для добавления и получения копий продуктов. Он также имеет метод AcceptVisitor(), который позволяет посетителю взаимодействовать с конкретным продуктом.

В основной функции Main() создается магазин, добавляются прототипы продуктов (книга и игрушка), затем получается копия продукта и используется посетитель для взаимодействия с продуктами.

Цель данного приложения - показать, как паттерны "Прототип" и "Посетитель" могут быть применены в контексте продуктового магазина. Паттерн "Прототип" позволяет создавать копии продуктов без привязки к их конкретным классам, а паттерн "Посетитель" позволяет добавлять новые операции для взаимодействия с продуктами без изменения самих классов продуктов. Это делает магазин гибким и расширяемым при добавлении новых типов продуктов или операций.

# Посетитель

Паттерн "Посетитель" позволяет добавлять новые операции к объектам без изменения их классов. В коде применяется интерфейс Visitor, который определяет методы для каждого конкретного прототипа (VisitBrick() и VisitWoodenBoard()). Класс CustomerVisitor реализует этот интерфейс и определяет операции, которые выполняются при посещении каждого типа строительного материала.

# Прототип

Паттерн "Прототип" позволяет создавать копии объектов, не зависимо от их конкретных классов. В коде применяется абстрактный класс BuildingMaterialPrototype, от которого наследуются конкретные прототипы строительных материалов (BrickPrototype и WoodenBoardPrototype). В каждом прототипе определены методы Clone(), который создает глубокую копию объекта, и Accept(), который позволяет посетителю взаимодействовать с конкретным прототипом.

# UML
![image](https://github.com/Rados27/Patterns_pr2/assets/135820145/b97ff1de-1c78-43dc-a007-f161d292ce9a)

