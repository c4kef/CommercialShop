<?PHP
include 'Components/db_connect.php';

$link = GetLink();
$ip = GetUserIP();

$check = $link->query("SELECT * FROM SessionActivation WHERE `Session`='".$ip."'");

if ($check->num_rows == 0)
{
    $link->query("INSERT INTO SessionActivation (`Session`) VALUES ('".$ip."')");
	$check->close();
	$link->close();
}

if (empty($_POST['Version']))
    die("Vers_2.0.0S");
else 
{
    $Version = $_POST['Version'];

    if ($Version == "PacksLanguage")
        die("Vers_1.0.0R");
}
?>