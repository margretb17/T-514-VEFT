const {PickupGame} = require('../data/db.js');
const {InternalServerError} = require('../errors');

const pickupGameService = () => {
    const getAllPickupGames = () => {
        const allPickupGames = PickupGame.find({}, function(error) {
            if (error) {error(new InternalServerError);}
        })
        console.log(allPickupGames);
        return allPickupGames;
    };

    const getPickupGameById = (id) => {
        const pickupGame = PickupGame.findById(id, function(error) {
            if (error) {error(new InternalServerError);}
        })
        return pickupGame;
    };


    return {
        getAllPickupGames,
        getPickupGameById
    };
};

module.exports = pickupGameService();