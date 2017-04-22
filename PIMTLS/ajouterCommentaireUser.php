<?php 

if($_SERVER["REQUEST_METHOD"]=="POST")
{
	require 'connection.php';
	createStudent();
}

function createStudent(){
	
	global $connect;
	$descriptionUser=$_POST["descriptionUser"];
	$dateCommentUser=$_POST["dateCommentUser"];
	$fkcommentuser=$_POST["fkcommentuser"];
	$fk_idUser=$_POST["fk_idUser"];
	
	
	
	
	
	
$query ="Insert into commentaire(corps,owner,commented)values('$descriptionUser','$fkcommentuser','$fk_idUser');";

	
	
	
	
	$result=mysqli_query($connect, $query);

if (!$result) {
	echo '<p>Unable to query the database: ' . mysqli_error($connect) . ' .</p>';
	} else {
		echo '<p>Added!</p>';
		}
		mysqli_close($connect);
}

?>