<?php 
$uploaddir = 'Image/';
$uploadfile = $uploaddir . basename($_FILES['fileToUpload']['name']);
echo '<pre>';
if (move_uploaded_file($_FILES['fileToUpload']['tmp_name'], $uploadfile)) {
    echo "File is valid, and was successfully uploaded.\n";
} else {
    echo "Possible file upload attack!\n";
}

echo 'Here is some more debugging info:';
print_r($_FILES);

if($_SERVER["REQUEST_METHOD"]=="POST")
{
	require 'connection.php';
	createStudent();
}

function createStudent(){
	
	global $connect;
	$img=$_POST["img"];
	
$query ="Insert into imagetable(img)values('$img');";
	
	$result=mysqli_query($connect, $query);

if (!$result) {
	echo '<p>Unable to query the database: ' . mysqli_error($connect) . ' .</p>';
	} else {
		echo '<p>Added!</p>';
		}
		mysqli_close($connect);
}

?>