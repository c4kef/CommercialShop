<?PHP
include 'Components/db_connect.php';
include 'Components/security.php';

if (empty($_POST['KeyActivation']) || empty($_POST['Software']))
{
	die("Not enough data to work");
}

$Software = $_POST['Software'];
$KeyActivation = Decrypt($_POST['KeyActivation'], $Software);

$link = GetLink();

$check = $link->query("SELECT * FROM KeysActivation WHERE `KeyActivation`='".$KeyActivation."'");

if ($check->num_rows == 0)
{
	printf(Encrypt("Err", $Software));
	$check->close();
	$link->close();
	exit();
}
else
{
	while($row = $check->fetch_assoc())
	{
		$timeKey = $timeNow = new DateTime(date("d.m.Y H:i:s"));

		$ip = GetUserIP();
		$fp = fopen("data_connect.txt", "a");
		$test = fwrite($fp, "[{$timeNow->format("d.m.Y H:i:s")}] {$ip} - {$KeyActivation}\n");
		fclose($fp);

		if ($row['Date'] == "-")
		{
			$timeNow->add(new DateInterval('P1D'));
			$link->query("UPDATE KeysActivation SET Date='".$timeNow->format("d.m.Y H:i:s")."' WHERE `KeyActivation`='".$KeyActivation."'");
		}
		else
		{
			$timeKey = new DateTime($row['Date']);
		}

		if ($row['Software'] == "-")
		{
			$sql = "UPDATE KeysActivation SET Software='".$Software."' WHERE `KeyActivation`='".$KeyActivation."'";
			$link->query($sql);
			goto end_task;
		}

		mysqli_query($link, "set names utf8");

		if ($Software != $row['Software'])
		{
			printf(Encrypt("Err", $Software));
			$link->close();
			exit();
		}

		if ($timeNow > $timeKey && $row['Magazine'] != "Microsoft")
		{
			printf(Encrypt("Err", $Software));
			$link->close();
			exit();
		}

		end_task:
		mysqli_query($link, "set names utf8");
		printf(Encrypt("{$timeKey->format("d.m.Y H:i:s")}|{$row['Login']}|{$row['Password']}|{$row['Magazine']}|{$row['MLogin']}|{$row['MPass']}|{$row['MServ']}", $Software));
		$check->close();
		$link->close();
		exit();
	}
}
?>