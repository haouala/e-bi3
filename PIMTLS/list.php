<?php
  
	//$objConnect = mysql_connect("localhost","root","");
	//$objDB = mysql_select_db("tutorial");
	$link = mysqli_connect('localhost', 'root', '', 'pocketveterinary ');


  
  //$id = $_GET['id'];
  
 // $result = mysql_query("SELECT * FROM student where age=20") or die(mysql_error());
  $result =mysqli_query($link, 'SELECT * FROM publication where email like "'.$_GET['email'].'"');
//$result = $mysqli->query("SELECT name FROM product WHERE id =2")->fetch_object()->name;  
	//$strSQL = "SELECT * FROM pim_productdeal WHERE customer_id = 1 ";

	//$objQuery = mysql_query($result);
	/*$intNumField = mysql_num_fields($result);
	$resultArray = array();
	while($obResult = mysql_fetch_array($result))
	{
		$arrCol = array();
		for($i=0;$i<$intNumField;$i++)
		{
			$arrCol[mysql_field_name($result,$i)] = $obResult[$i];
		}
		array_push($resultArray,$arrCol);
	}
	
	mysql_close($objConnect);
	
	echo json_encode($resultArray);*/
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