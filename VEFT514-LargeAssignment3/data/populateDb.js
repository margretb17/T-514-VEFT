const collections = require('./collection')
const mongoDb = require('mongodb');
const MongoClient = mongoDb.MongoClient;

const arguments = process.argv.slice(2);
const connectionString = arguments[0];

const dbName = connectionString.split('/').slice(-1)[0];

(async () => {
    const client = await MongoClient.connect(connectionString, {
        useNewUrlParser: true,
        useUnifiedTopology: true
    });
    const database = client.db(dbName);

    const players = database.collection('players');
    const pickupGames = database.collection('pickupGames');

    if (true) {
        console.log(await players.find({}).toArray());
        console.log(await pickupGames.find({}).toArray());
    }

    if (await pickupGames.countDocuments() === 0) {
        const result = await pickupGames.insertMany(await Promise.all(collections.pickupGames.map(async pickupGame => {
            const player = collections.players.find(c => c.id === pickupGames.playedGamesIds);

            const pickupGameResult = await pickupGames.insertOne({
                start: pickupGame.start,
                end: pickupGame.end,
                fieldLocationId: pickupGame.fieldLocationId,
                registeredPlayersIds: playerResult.insertedId,
                hostId: pickupGame.hostId
            });

            const playerResult = await players.insertOne({
                name: player.name,
                playedGamesIds: pickupGameResult.insertedId
            });

            return {
                start: pickupGame.start,
                end: pickupGame.end,
                fieldLocationId: pickupGame.fieldLocationId,
                registeredPlayersIds: playerResult.insertedId,
                hostId: pickupGame.hostId
            };
        })));

        console.log(result);
    }
})();