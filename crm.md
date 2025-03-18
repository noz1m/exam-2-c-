# Бо забони точики

### **Вазифа 1: Создани Класси `Car` (Мошин) бо Конструктор ва Method**

**Тавсифи вазифа:**  
Як класс `Car` созед, ки дорои тағйирёбандаҳои `make`, `model`, ва `year` бошад. Тағйирёбандаҳо бояд хусусияти private дошта бошанд. Конструктори класс бояд барои инициализатсия кардани ин тағйирёбандаҳо ва методи `DisplayDetails()` барои чоп кардани маълумот дар бораи мошинро илова кунед.

#### Тавсифи Тағйирёбандаҳо:
- `make` (string) — маркаи мошин (private).
- `model` (string) — модели мошин (private).
- `year` (int) — соли истеҳсоли мошин (private).

#### Тавсифи Методи:
- `DisplayDetails()` — чоп кардани маълумоти мошин дар формати: `make model, year`.

#### Конструктор:
- Конструктор барои инициализатсия кардани `make`, `model`, ва `year`.

#### Воридот:
```csharp
Car car1 = new Car("Toyota", "Corolla", 2020);
car1.DisplayDetails();

Car car2 = new Car("Honda", "Civic", 2018);
car2.DisplayDetails();
```

#### Баромад:
```
Toyota Corolla, 2020  
Honda Civic, 2018
```

---

### **Вазифа 2: сохтани методҳои иловагӣ**  
**Тавсифи вазифа:**  
Класси `Calculator` созед, ки методҳои `Add`, `Subtract`, `Multiply` ва `Divide` дошта бошад. Ҳар метод бояд ду параметр гирад ва натиҷа диҳад.  

**Воридот:**  
```csharp
Calculator calc = new Calculator();
Console.WriteLine(calc.Add(10, 5));       // 15
Console.WriteLine(calc.Subtract(10, 5)); // 5
Console.WriteLine(calc.Multiply(10, 5)); // 50
Console.WriteLine(calc.Divide(10, 5));   // 2
```

**Баромад:**  
```
15  
5  
50  
2
```

---

### **Вазифа 3: сохтани Properties**  
**Тавсифи вазифа:**  
Класси `Student` созед, ки property-ҳои зеринро дошта бошад:

- `Name` (read/write): Ном бояд ҳадди ақал 3 ҳарф дошта бошад. Агар ном кӯтоҳ бошад, онро ба Unknown иваз кунед.
- `Grade` (write-only): Танҳо арзишҳои аз 0 то 100 қабул карда шаванд. Агар арзиш берун аз ин диапазон бошад, онро ба 0 иваз кунед.
- `ID` (read-only): ID бояд ҳангоми сохтани объект бо истифода аз конструктор таъин карда шавад.
- Метод `GetStudentInfo()` илова кунед, ки номи донишҷӯ ва ID-и ӯро баргардонад.
- Метод `IsPassed()` илова кунед, ки санҷад, ки донишҷӯ дар асоси grade аз 60 гузашт ё не.

**Воридот:**  
```csharp
Student student1 = new Student(101);
student1.Name = "Ali";
student1.Grade = 85;
Console.WriteLine(student1.GetStudentInfo());
Console.WriteLine($"Passed: {student1.IsPassed()}");

Student student2 = new Student(102);
student2.Name = "An";
student2.Grade = 150; // Нодуруст, бояд 0 гузошта шавад.
Console.WriteLine(student2.GetStudentInfo());
Console.WriteLine($"Passed: {student2.IsPassed()}");

```

**Баромад:**  
```
Name: Ali, ID: 101  
Passed: True  

Name: Unknown, ID: 102  
Passed: False  
```

---

### **Вазифа 4: истифодаи Records**  
**Тавсифи вазифа:**  
Рекорди `Employee` созед, ки `Name`, `ID` ва `Salary` дошта бошад. Экземпляри рекорд созед ва онро чоп кунед.  

**Воридот:**  
```csharp
Employee emp1 = new Employee("Ali", 101, 50000);
Console.WriteLine(emp1);
```

**Баромад:**  
```
Employee { Name = Ali, ID = 101, Salary = 50000 }
```

---

### **Вазифа 5: Муқоисаи Records**  
**Тавсифи вазифа:**  
Рекорди `Person` созед. Экземплярҳои он созед, нусхаи тағйирёфта созед ва ду экземплярро муқоиса кунед.  

**Воридот:**  
```csharp
------ //коди шумо бояд якбор false барорад ва якбори дигар true
```

**Баромад:**  
```
False or True
```

---
# На русском
### **Задача 1: Создание класса `Car` (Машина) с конструктором и методом**

**Описание задачи:**  
Создайте класс `Car`, который будет содержать приватные поля `make`, `model`, и `year`. Конструктор этого класса должен инициализировать эти поля, а метод `DisplayDetails()` должен выводить информацию о машине.

#### Пример входных данных:
```csharp
Car car1 = new Car("Toyota", "Corolla", 2020);
car1.DisplayDetails();

Car car2 = new Car("Honda", "Civic", 2018);
car2.DisplayDetails();
```

#### Ожидаемый вывод:
```
Toyota Corolla, 2020  
Honda Civic, 2018
```

---

### **Задача 2: Создание дополнительных методов в классе `Calculator`**

**Описание задачи:**  
Создайте класс `Calculator`, который будет содержать методы `Add`, `Subtract`, `Multiply` и `Divide`. Каждый метод должен принимать два параметра и возвращать результат.

#### Пример входных данных:
```csharp
Calculator calc = new Calculator();
Console.WriteLine(calc.Add(10, 5));       // 15
Console.WriteLine(calc.Subtract(10, 5)); // 5
Console.WriteLine(calc.Multiply(10, 5)); // 50
Console.WriteLine(calc.Divide(10, 5));   // 2
```

#### Ожидаемый вывод:
```
15  
5  
50  
2
```

---

### **Задача 3: Создание Properties в классе `Student`**

**Описание задачи:**  
Создайте класс `Student`, который будет содержать следующие свойства:

- `Name` (read/write): Имя должно содержать хотя бы 3 символа. Если имя короче, замените его на "Unknown".
- `Grade` (write-only): Должны приниматься значения от 0 до 100. Если значение выходит за этот диапазон, установите 0.
- `ID` (read-only): ID должен задаваться при создании объекта через конструктор.
- Метод `GetStudentInfo()` должен возвращать имя и ID студента.
- Метод `IsPassed()` должен проверять, сдал ли студент на основе его оценки (если `Grade >= 60`).

#### Пример входных данных:
```csharp
Student student1 = new Student(101);
student1.Name = "Ali";
student1.Grade = 85;
Console.WriteLine(student1.GetStudentInfo());
Console.WriteLine($"Passed: {student1.IsPassed()}");

Student student2 = new Student(102);
student2.Name = "An";
student2.Grade = 150; // Неправильно, должно быть 0
Console.WriteLine(student2.GetStudentInfo());
Console.WriteLine($"Passed: {student2.IsPassed()}");
```

#### Ожидаемый вывод:
```
Name: Ali, ID: 101  
Passed: True  

Name: Unknown, ID: 102  
Passed: False  
```

---

### **Задача 4: Использование Records для класса `Employee`**

**Описание задачи:**  
Создайте рекорд `Employee`, который будет содержать `Name`, `ID`, и `Salary`. Создайте экземпляр этого рекорда и выведите его.

#### Пример входных данных:
```csharp
Employee emp1 = new Employee("Ali", 101, 50000);
Console.WriteLine(emp1);
```

#### Ожидаемый вывод:
```
Employee { Name = Ali, ID = 101, Salary = 50000 }
```

---

### **Задача 5: Сравнение Records**

**Описание задачи:**  
Создайте рекорд `Person`. Создайте экземпляры этого рекорда, измените один из экземпляров и сравните два экземпляра.

#### Пример входных данных:
```csharp
---- 
```

#### Ожидаемый вывод:
```
False  
True
```

---