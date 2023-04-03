<?php
// if ($_SERVER['REQUEST_METHOD'] == 'POST') {
//     // получаем данные из формы
//     $username = $_POST['username'];
//     $password = $_POST['password'];

//     // хешируем пароль
//     $hash = password_hash($password, PASSWORD_DEFAULT);

//     // подключаемся к базе данных
//     $pdo = new PDO('mysql:host=localhost;dbname=bidworks_db', 'root', 'wampserver');

//     // формируем запрос на добавление пользователя в базу данных
//     $stmt = $pdo->prepare("INSERT INTO users (username, password) VALUES (:username, :password)");
//     $stmt->execute(array(':username' => $username,':password' => $hash));

//     // закрываем соединение с базой данных
//     $pdo = null;
// }

$host = 'localhost';
$database = 'kontrol_db';
$user = 'root';
$password = 'wampserver';

$link = mysqli_connect($host, $user, $password, $database)
    or die("Ошибка " . mysqli_error($link));

// получаем данные из формы C#
$username = $_POST['username'];
$password = $_POST['password'];

// шифруем пароль
$password = hash('sha256', $password);

// проверяем совпадение логина
$sql_check = "SELECT * FROM users WHERE username='$username'";
$result_check = $link->query($sql_check);

if ($result_check->num_rows > 0) {
    echo "false"; // логин занят
}else { 
    //добавление пользователя
    $sql_insert = "INSERT INTO users VALUES(NULL, '$username','$password')";

    if ($link->query($sql_insert) === TRUE) {
        echo "true"; // данные пользователя добавлены
    }else {
        echo "Error: " . $sql_insert . "" . $link->error;
    }
}

// закрываем подключение
mysqli_close($link);

?>