CREATE VIEW `view1` AS
    SELECT 
        nameGame, COUNT(*)
    FROM
        tableGames
    GROUP BY nameGame