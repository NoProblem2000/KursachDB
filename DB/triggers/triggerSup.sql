CREATE DEFINER = CURRENT_USER TRIGGER `lab1DB`.`tableSupplier_BEFORE_DELETE` BEFORE DELETE ON `tableSupplier` FOR EACH ROW
BEGIN
delete from tableconnsup
    where tablesupplier_idSupplier = OLD.idSupplier;
END