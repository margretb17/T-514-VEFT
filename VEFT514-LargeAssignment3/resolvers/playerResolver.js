const playerService = require('../services/playerService');
const pickupGameService = require('../services/pickupGameService');
const {NotFoundError} = require('../errors');

module.exports = {
    Query: {
        allPlayers: async () => {
            const players = await playerService.getAllPlayers();
            if (players === null) {throw new NotFoundError;}
            return players;
        },
        player: async (parent, args) => {
            let player = await playerService.getPlayerById(args.id);
            if (player === null) {throw new NotFoundError;}
            return player;
        },
    },
    Mutation: {
        createPlayer: async (parent, args) => {
            const newPlayer = await playerService.createPlayer(args.input);
            return newPlayer;
        }
    },
    Type: {

    }
};
