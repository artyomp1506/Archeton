<b>Название проекта:</b> Archeton

<b>Команда:</b> АТ-123

<b>Формат системы:</b> 
Мобильное приложение

<b>Цель проекта:</b>  

Изучение темы «Скелет человека» в игровой форме

<b>Описание:</b>  
Игрок входит в команду археологов-кладоискателей . Изучает останки, найденные на местах раскопок, в древних храмах. За прохождение уровней получает очки,монеты, за которые может покупать части карты сокровищ.
Игрок входит в команду археологов-кладоискателей . Изучает останки, найденные на местах раскопок, в древних храмах. За прохождение уровней он получает очки, монеты, за которые может покупать части карты сокровищ, артефакты, с помощью которых игрок может собирать коллекции артефактов, также необходимых для прохождения игры.

<b>Целевая аудитория:</b>  
Школьники, планирующие поступление в медицинские вузы

<b>Основное преимущество:</b>  
Есть игровая составляющая, поддержка русского языка,понятный интерфейс,удобность
<b>Стек технологий:</b> 
Unity,CSharp

<b>Сценарий использования:</b>  
1) В нижней части экрана высвечивается название кости, необходимо на картинке найти и нажать на соответствующую кость (если выбор верный подсвечивается зеленым, неверный – красным) <br>
2) Задача обратная 1ой, т. е. выделяется на картинке цветом кость, а пользователь должен вписать в окно ввода название <br>
3) Дается название кости, нужно определить в каком отделе она находится(если выбор верный подсвечивается зеленым, неверный – красным) <br>
4) Дано название отдела, из перечня костей нужно выбрать те, которые входят в этот отдел(если выбор верный подсвечивается зеленым, неверный – красным)

<b>Результат / продукт:</b> 
Приложение,помогающее изучить скелет человека

<b>Основные требования к ПО для пользования:</b> 
 Unity v 2020.1.12.f1

//ОТРЕДАКТИРОВАТЬ!!!
<b>Порядок установки:</b> 
1) Установить на компьютер софт для запуска локального веб-сервера (например, Open Server), настроить его в соответствии с системными требованиями
2) Переместить файлы из репозитория в корневую папку сайта
3) Запустить веб-сервер
//ОТРЕДАКТИРОВАТЬ!!!!
<b>Структура приложения:</b> 
1) /index.php - основной файл, где происходит формирование страницы
2) /style.css - файл стилей для главной страницы
3) /scripts/js/consoleLog.js - скрипт, отвечающий за отправление запроса о добавлении пользователя на сервер
4) /scripts/php/main.php - серверный скрипт, отвечающий за подключение к БД, выборку данных из неё и формированию ответа для consoleLog.js
5) /assets - директория, содержащая медиа-данные (шрифты, фото и т.д.)
