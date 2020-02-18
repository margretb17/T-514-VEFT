const pickupGameService = require('../services/pickupGameService');
const basketballFieldService = require('../services/basketballFieldService');
const playerService = require('../services/playerService')
const {NotFoundError} = require('../errors');
const Schema = require('mongoose').Schema;

module.exports = {
    Query: {
        allPickupGames: async () => {
            const pickupGames = await pickupGameService.getAllPickupGames();
            if (pickupGames === null) {throw new NotFoundError;}
            //console.log(pickupGames);
            return pickupGames;
        },
        pickupGame: async (parnet, args) => {
            const pickupGame = await pickupGameService.getPickupGameById(args.id);
            if (pickupGame === null) {throw new NotFoundError;}
            //console.log(pickupGame);
            return pickupGame;
        },
    },
    Mutation: {

    },
    Type: {
        PickupGame: {
            host: async parent => {
                const output = await playerService.getPlayerById(host)
                console.log("Output: ", output);
                return output;
            }
        }
    }

};