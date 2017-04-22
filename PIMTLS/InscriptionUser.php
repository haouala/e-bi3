<?php 

if($_SERVER["REQUEST_METHOD"]=="POST")
{
	require 'connection.php';
	createStudent();
}

function createStudent(){
	
	global $connect;
	$nom=$_POST["nom"];
	$prenom=$_POST["prenom"];
	$tel=$_POST["tel"];
	$adresse=$_POST["adresse"];
	$password=$_POST["password"];
	$description=$_POST["description"];
	$mail=$_POST["mail"];
	$pseudo=$_POST["pseudo"];	
	$ImagePath=$_POST["ImagePath"];
$query ="Insert into user(nom,prenom,tel,adresse,Description,password,email,username,ImagePath)values('$nom','$prenom','$tel','$adresse','$description','$password','$mail','$pseudo','$ImagePath');";
	$result=mysqli_query($connect, $query);

if (!$result) {
	echo '<p>Unable to query the database: ' . mysqli_error($connect) . ' .</p>';
	} else {
		echo '<p>Added!</p>';
		}
		mysqli_close($connect);
}

?>