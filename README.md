# Логика работы алгоритма

Для старта работы с **Программой** (Выборки из строкового массива, строк короче 4 символов), необходимо:

* Перейти в рабочую директорию проекта;
* Запустить консоль Терминала командой: `Ctrl - Shift+`;

Ввести необходимое количество элементов для создаваемого массива.

Программа запустит процесс опроса пользователя на предмет заполнения строк массива.

Метод `UserMasAdd(int lenghtMas)` - Соберет массив по данным пользователя, вернув готовый массив строк.

## Обработка первичного массива

После заполнения первичного массива, программа запустит метод `FormattedStringArray`:

Внутри, метод разбит на две фазы

    - Фаза проверки количества нужных элементов;
    - Фаза загрузки обнаруженных элементов в новый укороченный массив.


Результатом работы первой фазы, будет получение количества значений, для создания нового массива нужной длины.

## Загрузка новых значений

* Для этого используется цикл `FOR`

     Внутри цикла, мы проверяем каждый элемент по условию.
     Если элемент подошел под условие, программа сохранит его в наш     новый массив.
        В противном случае, шаг пропустится.

По истечению элементов первого массива, программа вернет конечный массив с выбранными элементами.

---

## Вывод массивов на печать - `PrintArray`

После завершения работы метода `FormattedStringArray`, программа сформирует вывод каждого массива.