CREATE DEFINER = CURRENT_USER TRIGGER `lab1DB`.`tableClient_BEFORE_DELETE` BEFORE DELETE ON `tableClient` FOR EACH ROW
BEGIN
delete from tableconnclient
    where tableClient_idClient = OLD.idClient;

END
