<?php
include 'Components/db_connect.php';

$link = GetLink();
$ip = GetUserIP();

$check = $link->query("SELECT * FROM SessionActivation WHERE `Session`='".$ip."'");

if ($check->num_rows == 0)
{
	printf("You do not have access to this page.");
	exit();
}

$doc = new DOMDocument();
libxml_use_internal_errors(true);
$doc->loadHTML
(
"
<html>  
<head>  
   <title>C4ke Store</title>  
   <link rel=\"stylesheet\" type=\"text/css\" href=\"Style/style.css\"/>  
</head>  
<body>  
	<canvas id=\"canvas\">
		<script src=\"Style/dots.js\"></script>
	</canvas>
	<div id=\"container\">
		<h1>Welcome to the download page</h1>
		<h2>archive password: {pass}</h2>
		<div id=\"buttons\">
		  <a class=\"button\" href=\"https://github.com/c4kef\">Download</a>
		</div>
	</div>
</body>  
</html>
"
);
echo $doc->saveHTML();
?>