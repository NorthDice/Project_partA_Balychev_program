# Project_partA_Balychev_program
## Інформація про проект (частина А)
За поставленним завданням, було обрано предметну область StoreInventory.
Предметна область простий магазин, де є різні товари (навушники, миша, клавіатура, портативний зарядний пристрій) з певними характеристиками. Класи StoreItem та StoreInventory надають базову функціональність для роботи з товарами та інвентарем магазину.
### Клас StoreItem
Цей клас надає базову структуру для зберігання інформації про товар у магазині, такий як ціна, кількість та тип товару. Він також надає деякі методи та властивості для роботи з цією інформацією
### Клас StoreInventory
Цей клас визначає структуру для управління товаром в магазині. Клас реалізує два інтерфейси: ICollection та IEnumerable<StoreItem>, що дозволяє використовувати його в циклах та надає базовий функціонал для колекції. Він містить методи для додавання товару, очищення інвентарю, перевірки присутності товару, сортування за ціною, видалення товару, а також інші методи для роботи з інвентарем.
### Перелічення Items
Цей enum надає розуміння, що цей магазин обмежується продажом тільки певних товарів, а саме - комп'ютерної переферії.
## Діаграма класів області StoreInventory
![Діиграма классів області](https://github.com/NorthDice/Project_partA_Balychev_program/blob/master/Project_partA_Balychev_program/Project_partA_Balychev_diagram.png)
