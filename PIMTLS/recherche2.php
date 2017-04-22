<?php 
if ($_SERVER["REQUEST_METHOD"]=="POST"){
	
	include 'connection.php';
	recherche();
}
function recherche()
{
	global $connect;

	$name = $_POST['name'];
     
    $minprice=$_POST['minprice'];
	$maxprice = $_POST['maxprice'];
	$category = $_POST['category'];
	$place = $_POST['place'];  
	$sub_category = $_POST['sub_category'];

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

 
 
$mysql_result = mysqli_query($connect,$query);
$result = array();

while ($row = mysqli_fetch_assoc($mysql_result)) {
   $result[] = $row;
}
echo json_encode(array("recherche"=>$result));

	
mysqli_close($connect);

}


?>