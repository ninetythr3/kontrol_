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

    $sql = "SELECT `objects`.`id`, `objects`.`name` AS `Название объекта`, 
    `contracts`.`name` AS `Имя договора`, 
    `objects`.`address` AS `Адрес объекта`, 
    `contracts`.`number` AS `Номер договора`,
    DATE_FORMAT(`contracts`.`date`, '%d.%m.%Y') AS `Дата договора`
    FROM `objects` 
    LEFT JOIN `contracts` 
    ON `objects`.`contract_id` = `contracts`.`id`;";
    $result = $conn->query($sql);

    $data = array();
    while ($row = $result->fetch_assoc()) {
        $data[] = $row;
    }

    echo json_encode($data, JSON_UNESCAPED_UNICODE);


    $conn->close();
?>