CREATE DEFINER = CURRENT_USER TRIGGER `lab1DB`.`tableAccessory_BEFORE_DELETE` BEFORE DELETE ON `tableAccessory` FOR EACH ROW
BEGIN
delete from tableconnsup
    where tableAccessory_idAccessory = OLD.idAccessory;
delete from tableconnclient
    where tableAccessory_idAccessory = OLD.idAccessory;
END