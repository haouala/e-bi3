<?php 

$link = mysqli_connect('localhost', 'root', '', 'pimtls');
	$name = $_GET['name'];
     
    $minprice=$_GET['minprice'];
	$maxprice = $_GET['maxprice'];
	$category = $_GET['category'];
	$place = $_GET['place'];  
	$sub_category = $_GET['sub_category'];

	if( $place == "AllTunisia") 
{
if (empty($minprice) AND !empty($maxprice)) {
$query = "SELECT product.*,user.Id,user.nom,user.prenom,user.Description,user.adresse,user.tel,user.email,user.ImagePath from product LEFT JOIN user ON product.owner = user.id
 where name LIKE '$name%' and  price < '$maxprice' AND category = '$category'  "; }

 else if (empty($maxprice) AND !empty($minprice)){
$query = "SELECT product.*,user.Id,user.nom,user.prenom,user.Description,user.adresse,user.tel,user.email,user.ImagePath from product LEFT JOIN user ON product.owner = user.id
 where name LIKE '$name%' and price > '$minprice' AND category = '$category'  "; }

 else if (empty($maxprice) AND empty($minprice)){
$query = "SELECT product.*,user.Id,user.nom,user.prenom,user.Description,user.adresse,user.tel,user.email,user.ImagePath from product LEFT JOIN user ON product.owner = user.id
 where name LIKE '$name%'  AND category = '$category' "; }

 else {
 	$query = "SELECT product.*,user.Id,user.nom,user.prenom,user.Description,user.adresse,user.tel,user.email,user.ImagePath from product LEFT JOIN user ON product.owner = user.id
 where name LIKE '$name%' and price BETWEEN '$minprice' AND '$maxprice' AND category = '$category'  "; }
}

	else if($place != "AllTunisia")
{
if (empty($minprice) AND !empty($maxprice)){
$query = "SELECT product.*,user.Id,user.nom,user.prenom,user.Description,user.adresse,user.tel,user.email,user.ImagePath from product LEFT JOIN user ON product.owner = user.id
 where name LIKE '$name%' and  price < '$maxprice' AND category = '$category' AND place = '$place' "; }

 else if (empty($maxprice) AND !empty($minprice)){
$query = "SELECT product.*,user.Id,user.nom,user.prenom,user.Description,user.adresse,user.tel,user.email,user.ImagePath from product LEFT JOIN user ON product.owner = user.id
 where name LIKE '$name%' and price > '$minprice' AND category = '$category' AND place = '$place' "; }
 
 else if (empty($maxprice) AND empty($minprice)){
$query = "SELECT product.*,user.Id,user.nom,user.prenom,user.Description,user.adresse,user.tel,user.email,user.ImagePath from product LEFT JOIN user ON product.owner = user.id
 where name LIKE '$name%'  AND category = '$category' AND place = '$place' "; }

 else {
 	$query = "SELECT product.*,user.Id,user.nom,user.prenom,user.Description,user.adresse,user.tel,user.email,user.ImagePath from product LEFT JOIN user ON product.owner = user.id
 where name LIKE '$name%' and price BETWEEN '$minprice' AND '$maxprice' AND category = '$category' AND place = '$place' "; }
}

 $result=mysqli_query($link,$query);
 $number_of_rows=mysqli_num_rows($result);
	$temp_array =array();
	if($number_of_rows> 0)
	{
		while ($row = mysqli_fetch_assoc($result)){
			
			$temp_array[]=$row;
		
		}
	}
	//header('Content-Type: application/json');
	echo json_encode($temp_array);




?>