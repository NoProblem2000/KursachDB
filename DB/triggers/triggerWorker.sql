CREATE DEFINER = CURRENT_USER TRIGGER `lab1DB`.`tableWorkers_BEFORE_DELETE` BEFORE DELETE ON `tableWorkers` FOR EACH ROW
BEGIN
delete from tableconnsup
    where tableWorkers_idWorker = OLD.idWorker;
delete from tableconnclient
    where tableWorkers_idWorker = OLD.idWorker;
END