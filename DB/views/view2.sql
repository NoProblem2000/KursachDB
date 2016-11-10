CREATE VIEW `view2` AS
    SELECT 
        c.firstNameClient,
        c.secondNameClient,
        c.mail,
        a.nameAccessory,
        g.nameGame,
        w.firstNameWorker,
        w.secondNameWorker,
        a.price + g.price
    FROM
        tableconnclient cc
            LEFT OUTER JOIN
        tableaccessory a ON cc.tableAccessory_idAccessory = a.idAccessory
            LEFT OUTER JOIN
        tablegames g ON cc.tableGames_idGame = g.idGame
            LEFT OUTER JOIN
        tableclient c ON cc.tableClient_idClient = c.idClient
            LEFT OUTER JOIN
        tableworkers w ON cc.tableWorkers_idWorker = w.idWorker
    GROUP BY (a.price + g.price)