<?php 

if($_SERVER["REQUEST_METHOD"]=="POST")
{
	require 'connection.php';
	createStudent();
}

function createStudent(){
	
	global $connect;
	$id_raiter=$_POST["id_raiter"];
	$id_raited=$_POST["id_raited"];
    $nombre=$_POST["nombre"];
    $id_product=$_POST["id_product"];

		
$query ="Insert into raiting(id_raiter,nombre,id_raited)values($id_raiter,$nombre,$id_raited);";
	$result=mysqli_query($connect, $query);

if (!$result) {
	echo '<p>Unable to query the database: ' . mysqli_error($connect) . ' .</p>';
	} else {
		echo '<p>Added!</p>';
		}
		mysqli_close($connect);
}

?>