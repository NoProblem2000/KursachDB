CREATE DEFINER = CURRENT_USER TRIGGER `lab1DB`.`tableGames_BEFORE_DELETE` BEFORE DELETE ON `tableGames` FOR EACH ROW
BEGIN
delete from tableconnsup
    where tableGames_idGame = OLD.idGame;
delete from tableconnclient
    where tableGames_idGame = OLD.idGame;
END