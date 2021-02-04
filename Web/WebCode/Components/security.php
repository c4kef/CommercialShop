<?php
function Decrypt($text, $pass){
    $method = 'aes-256-cbc';
    
    $key = substr(hash('sha256', $pass, true), 0, 32);
    $iv = chr(0x1) . chr(0x7) . chr(0x0) . chr(0x6) . chr(0x2) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x1) . chr(0x6) . chr(0x1) . chr(0x7) . chr(0x1) . chr(0x8) . chr(0x1) . chr(0x9);
    $decrypted = openssl_decrypt(base64_decode(hex2bin($text)), $method, $key, OPENSSL_RAW_DATA, $iv);
    return $decrypted;
}

function Encrypt($text, $pass){
    $method = 'aes-256-cbc';

    $key = substr(hash('sha256', $pass, true), 0, 32);
    $iv = chr(0x1) . chr(0x7) . chr(0x0) . chr(0x6) . chr(0x2) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x1) . chr(0x6) . chr(0x1) . chr(0x7) . chr(0x1) . chr(0x8) . chr(0x1) . chr(0x9);
    $encode = bin2hex(base64_encode(openssl_encrypt($text, $method, $key, OPENSSL_RAW_DATA, $iv)));
    return $encode;
}
?>