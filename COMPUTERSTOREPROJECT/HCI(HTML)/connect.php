<?php

    if(isset($_POST['Submit'])){
        $fname = $_POST['fname'];
        $Mname = $_POST['Mname'];
        $Lname = $_POST['Lname'];
        $Email = $_POST['Email'];
        $Address = $_POST['Address'];
        $Phone_num = $_POST['Phone_num'];
        $Zipnum = $_POST['Zipnum'];

        include_once("config.php");

        $result = mysqli_query($mysqli, "INSERT INTO reciept_table(fname, Mname, Lname, Email, Address, Phone_num, Zipnum) VALUES('$fname','$Mname','$Lname','$Email','$Address','$Phone_num','$Zipnum')");


        echo "Submitted Successfully. <a href='buy.html'>Go to Home Page</a>";
    }
?>