# Patterns_pr2
# О программе

Данное приложение, которое использует порождающий паттерн "Прототип" и поведенческий паттерн "Посетитель", имеет целью симулировать работу магазина строительных материалов. Ниже приведены причины, по которым такое приложение может быть полезным:

1. Создание и управление прототипами: Паттерн "Прототип" позволяет создавать и хранить прототипы различных строительных материалов, таких как кирпичи и дерево. Приложение позволяет добавлять новые материалы и хранить их в магазине строительных материалов. Это упрощает создание новых объектов, так как клиенты могут получить копии прототипов без необходимости явно создавать новые объекты.

2. Клиентский доступ к строительным материалам: Приложение позволяет клиентам получать копии строительных материалов из магазина. Клиенты могут использовать эти копии для выполнения операций или анализа свойств материалов, например, для выбора подходящего материала для строительного проекта.

3. Операции с материалами: Паттерн "Посетитель" позволяет добавлять новые операции, выполняемые над строительными материалами, без изменения самих материалов. В приложении присутствует класс "Builder" (Строитель), который представляет посетителя и определяет операции, выполняемые при посещении конкретных материалов. Это может быть полезно, например, для вывода информации о материалах, применения различных обработок или выполнения специализированных операций с материалами.

4. Гибкость и расширяемость: Применение паттернов "Прототип" и "Посетитель" обеспечивает гибкость и расширяемость приложения. Магазин может легко добавлять новые типы строительных материалов и операции, выполняемые над ними, без изменения существующего кода. Это позволяет легко адаптировать приложение к различным требованиям и изменениям в бизнес-логике.

В целом, данное приложение демонстрирует использование паттернов проектирования для организации работы с прототипами строительных материалов и операциями над ними, обеспечивая гибкость, повторное использование и расширяемость кода.

# Посетитель

Паттерн "Посетитель" (Visitor) позволяет добавлять новые операции к объектам без изменения самих объектов. Он позволяет разделить алгоритмы и структуры данных, на которых они оперируют, и добавлять новые операции, не изменяя классы этих объектов.

   В приведенном коде есть интерфейс Visitor, который представляет посетителя (в данном случае, покупателя) и определяет методы для посещения конкретных прототипов. Класс Builder (Строитель) реализует интерфейс Visitor и определяет операции, которые будут выполнены при посещении каждого конкретного прототипа. В данном случае, Builder выводит информацию о том, какой строительный материал используется.

# Прототип

Паттерн "Прототип" (Prototype) позволяет создавать объекты на основе существующего прототипа, не связываясь с их конкретными классами. Он используется для создания копий объектов, чтобы избежать сложностей при создании новых объектов вручную.

   В приведенном коде есть абстрактный класс BuildingMaterialPrototype, который представляет прототип строительного материала. Классы Brick (Кирпич) и Wood (Дерево) являются конкретными прототипами, которые наследуются от BuildingMaterialPrototype. В этих классах реализуется метод Clone(), который создает копию объекта. Когда объекты Brick и Wood добавляются в магазин стройматериалов (BuildingMaterialsStore), они клонируются перед добавлением, чтобы клиенты могли получить копии для использования.

# UML
![image](https://github.com/Rados27/Patterns_pr2/assets/135820145/83f23eb0-54a4-4ce7-add2-3f98180c4f31)


