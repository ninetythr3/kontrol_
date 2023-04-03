<?php
    $servername = "localhost";
    $username = "root";
    $password = "wampserver";
    $dbname = "kontrol_db";

    //Создаем соединение

    $conn = new mysqli($servername, $username, $password, $dbname);
    mysqli_set_charset($conn, 'utf8');

    //Проверяем соединение
    if ($conn->connect_error) {
        die("Соединение не установлено" . $conn->connect_error);
    }

    $sql = "SELECT `objects`.`id`, `objects`.`name`, `objects`.`address`
    FROM `objects`";
    $result = $conn->query($sql);

    $data = array();
    while ($row = $result->fetch_assoc()) {
        $data[] = $row;
    }

    echo json_encode($data, JSON_UNESCAPED_UNICODE);

    $conn->close();
?>