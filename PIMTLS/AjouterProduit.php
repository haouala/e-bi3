<?php 

if($_SERVER["REQUEST_METHOD"]=="POST")
{
	require 'connection.php';
	createStudent();
}

function createStudent(){
	
	global $connect;
	$name=$_POST["name"];
	$quantity=$_POST["quantity"];
	$price=$_POST["price"];
	$category=$_POST["category"];
	$date=$_POST["date"];
	$description=$_POST["description"];
	$SubCategory=$_POST["SubCategory"];
	$owner=$_POST["owner"];	
	$ProductImage1=$_POST["ProductImage1"];	
$query ="Insert into product(name,quantity,price,category,date,description,SubCategory,ProductImage1,owner)values('$name','$quantity','$price','$category','$date','$description','$SubCategory','$ProductImage1','$owner');";
	$result=mysqli_query($connect, $query);

if (!$result) {
	echo '<p>Unable to query the database: ' . mysqli_error($connect) . ' .</p>';
	} else {
		echo '<p>Added!</p>';
		}
		mysqli_close($connect);
}

?>