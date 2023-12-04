<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="UTF-8" />
		<meta http-equiv="X-UA-Compatible" content="IE=edge" />
		<meta name="viewport" content="width=device-width, initial-scale=1.0" />
		<title>Document</title>
		<link rel="stylesheet" href="recieptstyle.css" />
	</head>
	<body>
		<div class="content">
			<form action="" method="">
				<div class="labels">
					<h3>RECIEPT FORM</h3>
					<br />

					<div class="firstname">
						<label for="fname">First Name</label>
						<input
							type="text"
							id="fname"
							name="fname"
							class="fname"
						/>
						<br />
					</div>

					<div class="midname">
						<label for="Mname">Middle Name</label>
						<input
							class="mname"
							type="text"
							id="Mname"
							name="Mname"
						/>
						<br />
					</div>
					<div class="lastname">
						<label for="Lname">Last Name</label>
						<input
							class="lname"
							type="text"
							id="Lname"
							name="Lname"
						/>
						<br />
					</div>
					<div class="email">
						<label for="Email" id="Email">Email</label>
						<input
							class="E_mail"
							type="text"
							id="Email"
							name="Email"
						/>
					</div>

					<div class="address">
						<label for="Address">Address</label>
						<input
							class="add"
							type="text"
							id="Address"
							name="Address"
						/>
						<br />
					</div>
					<div class="phonenum">
						<label for="Phone_num" id="Phone">Phone Number</label>
						<input
							class="pnum"
							type="text"
							id="Phone_num"
							name="Phone_num"
						/>
						<br />
					</div>

					<div class="Zipnum">
						<label for="Zipnum" id="Zipnum">Zip Code</label>
						<input
							class="Zip"
							type="text"
							id="Zipnum"
							name="Zipnum"
						/>
						<br />
					</div>
					<br />
					<br />
					<a href="">
						<input type="submit" class="submit_btn" name="Submit" value="add" />
					</a>
				</div>
			</form>
		</div>

<?php

    if(isset($_POST['Submit'])) {
        $fname = $_POST['fname'];
        $Mname = $_POST['Mname'];
        $Lname = $_POST['Lname'];
        $Email = $_POST['Email'];
        $Address = $_POST['Address'];
        $Phone_num = $_POST['Phone_num'];
        $Zipnum = $_POST['Zipnum'];

        //include database connection file
        include_once("config.php");

        //insert user data into table
        $result = mysqli_query($mysqli, "INSERT INTO users(fname, Mname, Lname, Email, Address, Phone_num, Zipnum) VALUES('$fname','$Mname','$Lname','$Email','$Address','$Phone_num','$Zipnum')");

        //show message when user added
        echo "Submitted Successfully.";
    }

?>
	</body>
</html>
