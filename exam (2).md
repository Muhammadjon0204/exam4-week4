# Exam

### Task 1 

* What is Interface ?
* What is the difference between Interface and Abstract Class ?
---
* Что такое интерфейс?
* В чем разница между интерфейсом и абстрактным классом?

##

### Task 2 

 * What is Static Class ?
---
 * Что такое статический класс?

##

### Task 3

- What is Generics ?
---
- Что такое Generics?

##

### Task 4

- What is Enum ?
---
- Что такое Enum?

##

### Task 5

Generic classes allow us to write a single implementation that can be used with different data types.

- In this case, we are implementing a generic class `Stack<T>`. The generic type `T` will be used to define the type of elements stored in the stack. This way, we can create a stack of integers, strings, or any other data type.                                      

- The `Push(T item)` method adds an element to the stack. We pass an element of type `T` as an argument and add it to the list *`_list`*.                                                         
- The `Pop()` method removes and returns the last added element from the stack. We check that the stack is not empty, otherwise, we throw an exception. Then, we retrieve the last element from *`_list`*, remove it from the list, and return it.                                                     
- The `Peek()` method returns the last added element without removing it from the stack. It checks that the stack is not empty, throws an exception if needed, and returns the last element from *`_list`*.                                  

By using the generic class `Stack<T>`, we can create a stack of integers and a stack of strings by specifying the corresponding.

Also do not forget using exeption handling *`try`* and *`catch`*.

---

Обобщенные классы позволяют нам написать одну реализацию, которая может быть использована с разными типами данных.

* В данном случае мы реализуем обобщенный класс `Stack<T>`. Обобщенный тип `T` будет использоваться для определения типа элементов, хранящихся в стеке. Таким образом, мы можем создать стек целых чисел, строк или любого другого типа данных.              

* Метод `Push(T item)` добавляет элемент в стек. Мы передаем элемент типа `T` в качестве аргумента и добавляем его во внутренний список *`_list`*.

* Метод `Pop()` удаляет и возвращает последний добавленный элемент из стека. Мы проверяем, что стек не пустой, иначе выбрасываем исключение. Затем мы извлекаем последний элемент из *`_list`*, удаляем его из списка и возвращаем его.                     

* Метод `Peek()` возвращает последний добавленный элемент, но не удаляет его из стека. Он проверяет, что стек не пустой, выбрасывает исключение при необходимости, и возвращает последний элемент из *`_list`*.                               

Используя обобщенный класс `Stack<T>`, мы можем создать стек целых чисел и стек строк, указав соответствующий тип при создании экземпляра класса.

Также не забывайте использовать обработку исключений *`try`* и *`catch`*.

---

* Мо класси умумии `Stack<T>`-ро амалӣ карда истодаем. Навъи умумии `T` барои муайян кардани навъи элементҳои дар стек захирашуда истифода мешавад. Бо ин роҳ мо метавонем як стеки ададҳо, сатрҳо ё ҳама гуна намуди дигари маълумотро созем.

* Методи *`Push(T item)`* ашёро ба стек илова мекунад. Мо элементи навъи `T`-ро ҳамчун аргумент мегузорем ва онро ба рӯйхати дохилии *`_list`* илова мекунем.

* Усули *`Pop()`* элементи охирини иловашударо аз стек хориҷ ва бармегардонад. Мо тафтиш мекунем, ки стек холӣ нест, вагарна мо истисно мегузорем. Сипас, мо элементи охиринро аз *`_list`* мегирем, онро аз рӯйхат хориҷ мекунем ва баргардонем.

* Усули *`Peek()`* элементи охирини иловашударо бармегардонад, аммо онро аз стек хориҷ намекунад. Он тафтиш мекунад, ки стек холӣ нест, дар ҳолати зарурӣ истисно мегузорад ва элементи охиринро аз *`_list`* бармегардонад.

Бо истифода аз синфи умумӣ `Stack<T>`, мо метавонем як стек ададҳои бутун ва стеки сатрҳоро тавассути муайян кардани навъи мувофиқ ҳангоми эҷоди синф эҷод кунем.

Инчунин истифода бурдани *`try`* ва *`catch`*-ро фаромӯш накунед.

##

### Task 6

Develop a console-based `Library Management System` in C# that allows users to perform `CRUD` (Create, Read, Update, Delete) operations on books within a library.

**Requirements:**

**`Book Class:`**

* Create a *`Book`* class with the following properties:

    * *`Id`* (integer): Unique identifier for each book.
    * *`Title`* (string): Title of the book.
    * *`Author`* (string): Author of the book.

**`ILibrary Interface:`**

* Create an interface named *`ILibrary`* that contains methods for managing books in the library:
    * *`AddBook:`* Adds a new book to the library.
    * *`DisplayBooks:`* Displays the details of all books in the library.
    * *`UpdateBook:`* Updates the details of an existing book.
    * *`DeleteBook:`* Deletes a book from the library.
    * *`SearchByTitle:`* Searches for a book by title and returns a single matching book or null.
    * *`SearchByAuthor:`* Searches for books by author and returns a list of matching books.

**`Library Class:`**

* Create a class named *`Library`* that implements the *`ILibrary`* interface.
* Include the following methods in the class:
    * AddBook
    * DisplayBooks
    * UpdateBook
    * DeleteBook
    * SearchByTitle
    * SearchByAuthor
* Also do not forget using exeption handling `try` and `catch`.

**`User Interface (Main Program):`**

* Implement a user interface in the main program that continuously presents a menu to the user.
* The menu should include the following options:
    * Add a Book
    * Display All Books
    * Update a Book
    * Delete a Book
    * Search by Title
    * Search by Author
    * Exit

---

Разработать консольную систему управления библиотекой на C# с использованием интерфейса, предоставляющего методы для выполнения `CRUD` (Create, Read, Update, Delete) операций с книгами в библиотеке.

**Требования:**

**`Класс Book:`**

* Создать класс Book со свойствами:

    * *`Id`* (целое число): Уникальный идентификатор для каждой книги.
    * *`Title`* (строка): Название книги.
    * *`Author`* (строка): Автор книги.

**`Интерфейс ILibrary:`**

* Создать интерфейс *`ILibrary`*, который будет содержать методы для управления книгами в библиотеке:
    * *`AddBook:`* Добавляет новую книгу в библиотеку.
    * *`DisplayBooks:`* Отображает детали всех книг в библиотеке.
    * *`UpdateBook:`* Обновляет информацию о существующей книге.
    * *`DeleteBook:`* Удаляет книгу из библиотеки.
    * *`SearchByTitle:`* Ищет книгу по названию и возвращает её или null.
    * *`SearchByAuthor:`* Ищет книги по автору и возвращает список соответствующих книг.

**`Класс Library:`**

* Создать класс *`Library`*, который будет реализовывать интерфейс *`ILibrary`*.

* Включить в класс следующие методы:
    * AddBook
    * DisplayBooks
    * UpdateBook
    * DeleteBook
    * SearchByTitle
    * SearchByAuthor
* Также не забывайте использовать обработку исключений *`try`* и *`catch`*.
    
**`Основная программа (Program.cs):`**

* Реализовать пользовательский интерфейс в основной программе, который непрерывно предоставляет пользователю меню.
* Меню должно включать следующие опции:
    * Добавить книгу
    * Показать все книги
    * Обновить книгу
    * Удалить книгу
    * Поиск по названию
    * Поиск по автору
    * Выход

---

Таҳияи системаи идоракунии китобхонаи консолӣ дар C# бо истифода аз интерфейсе, ки усулҳои иҷрои амалиёти `CRUD` (Эҷод, Хондан, Навсозӣ, Нест кардан) бо китобҳо дар китобхонаро таъмин мекунад.

**Талабот:**

**`Класс Book:`**

* Бо хосиятҳои зерин эҷод кунед:

    * *`Id`* (бутун): Идентификатори ягона барои ҳар як китоб.
    * *`Title`* (сатр): Номи китоб.
    * *`Author`* (сатр): Муаллифи китоб.

**`Интерфейси ILibrary:`**

* Интерфейси *`ILibrary`* созед, ки дорои усулҳои идоракунии китобҳо дар китобхона мебошад:
    * *`AddBook:`* Ба китобхона китоби нав илова мекунад.
    * *`DisplayBooks:`* Тафсилоти ҳамаи китобҳои китобхонаро нишон медиҳад.
    * *`UpdateBook:`* Маълумотро дар бораи китоби мавҷуда навсозӣ мекунад.
    * *`DeleteBook:`* Китобро аз китобхона нест мекунад.
    * *`SearchByTitle:`* Китобро аз рӯи ном ҷустуҷӯ мекунад ва онро бар мегардонад.
    * *`SearchByAuthor:`* Китобҳоро аз рӯи муаллиф ҷустуҷӯ мекунад ва рӯйхати китобҳои мувофиқро бармегардонад.

**`Класс Library:`**

* Класси *`Library`* эҷод кунед, ки интерфейси *`ILibrary`*-ро амалӣ мекунад.

* Усулҳои зеринро ба класс дохил кунед:
    * AddBook
    * DisplayBooks
    * UpdateBook
    * DeleteBook
    * SearchByTitle
    * SearchByAuthor
* Инчунин истифода бурдани *`try`* ва *`catch`*-ро дар хотир доред.

**`Барномаи асосӣ (Program.cs):`**

* Интерфейси корбарро дар барномаи асосӣ татбиқ кунед, ки пайваста ба корбар меню пешниҳод мекунад.
* Меню бояд имконоти зеринро дар бар гирад:
    * Китоб илова кунед
    * Ҳама китобҳоро нишон диҳед
    * Навсозии китоб
    * Китобро нест кунед
    * Ҷустуҷӯ аз рӯи ном
    * Ҷустуҷӯ аз рӯи муаллиф
    * Баромадгоҳ