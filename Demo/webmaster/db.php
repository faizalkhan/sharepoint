<?php
 
class db
{
  
	//protected $db_name = 'cre8tive_tamil';
	//protected $db_user = 'cre8tive_tamil';
	//protected $db_pass = 'welcome97892@';
	//protected $db_host = 'localhost';
	
    protected $db_name = 'cre8tive_tamil';
	protected $db_user = 'root';
	protected $db_pass = '';
	protected $db_host = '';
	public $link='';
	public $sql='';
	public $data='';
	public $cou='';
	public $error='';
	public $url='';
	
	
	public function connect() {
	
		$this->link = mysqli_connect( $this->db_host, $this->db_user, $this->db_pass, $this->db_name );
		
		if ( mysqli_connect_errno() ) {
			printf("Connection failed: %s\
", mysqli_connect_error());
			exit();
		}
		return true;
		
	}


public function __construct()
{
    $this->link = mysqli_connect( $this->db_host, $this->db_user, $this->db_pass, $this->db_name );
	$this->url='http://localhost/projects/10-2017/silambam/webmaster/';
}
	

}
 
?>