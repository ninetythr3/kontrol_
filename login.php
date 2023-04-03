<?php

//Подключение к базе
    $con = new mysqli("localhost", "root", "wampserver", "kontrol_db");

    if (!$con) {
        die ("Нет соединения");
    }

    $username = "";
    $password = "";

    //РОST запрос логина и пароля к базе
    if (isset($_POST['username']) && !empty($_POST['username']) && isset($_POST['password']) && !empty($_POST['password'])) {
        $username = $con->real_escape_string($_POST['username']);
        $password = $con->real_escape_string($_POST['password']);
        $password = hash('sha256', $password);
        // $password = password_hash($password, PASSWORD_DEFAULT);
    }else {
        die ("Ошибка запроса к базе");
    }


    // if (isset($_POST['username']) && !empty($_POST['username']) && isset($_POST['password']) && !empty($_POST['password'])) {
    //     $username = $con->real_escape_string($_POST['username']);
    //     $password = $con->real_escape_string($_POST['password']);
    //     $hash = password_hash($password);
    //     // Check the password using password_verify()
    //     if (password_verify($password, $hash)) {
    //         echo "Пароль верный";
    //     } else {
    //         echo "Пароль неверный!";
    //     }
    // } else {
    //     die ("Ошибка запроса к базе");
    // }

    
    $query_username = $con->Query("SELECT * FROM users WHERE username = '$username' LIMIT 1");

    if (!$query_username) {

        die ("nodata"); //База недоступна (неверный запрос)

    }else if ($query_username->num_rows != 1) {

        die ("loginnotfound"); //Пользователь не найден

    }else {
        $query_result = $query_username->fetch_assoc();

        if ($password != $query_result['password']) {

            die ("wrongpass"); //Неверный пароль

        }else {

            die ("OK"); //Есть соединение

        }
    }
?>