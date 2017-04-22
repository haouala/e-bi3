<?php
  
	//$objConnect = mysql_connect("localhost","root","");
	//$objDB = mysql_select_db("tutorial");
	$link = mysqli_connect('localhost', 'root', '', 'pimtls');


  
  //$id = $_GET['id'];
  
  $result =mysqli_query($link, 'SELECT * FROM commentaire where commented='.$_GET['id']);

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