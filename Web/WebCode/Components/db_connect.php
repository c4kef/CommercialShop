<?php
  function GetLink() 
  {
    $link = new mysqli("localhost", "username", "password", "database");
      
    if (mysqli_connect_errno()) 
    {
      printf("Соединение не удалось: %s\n", mysqli_connect_error());
      exit();
    }

    return $link;
  }

  function GetUserIP() 
  {
    $keys = ['HTTP_CLIENT_IP', 'HTTP_X_FORWARDED_FOR', 'REMOTE_ADDR'];
    foreach ($keys as $key)
    {
      if (!empty($_SERVER[$key])) 
      {
        $explod = explode(',', $_SERVER[$key]);
        $e = end($explod);
        $ip = trim($e);
        if (filter_var($ip, FILTER_VALIDATE_IP))
        {
          return $ip;
        }
      }
    }
  }
?>