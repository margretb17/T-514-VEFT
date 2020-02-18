const mongoose = require('mongoose');
const playerSchema = require('../schema/schemas/player');
const pickupGameSchema = require('../schema/schemas/pickupGame');
const basketballFieldSchema = require('../schema/schemas/basketballField');

const connection = mongoose.createConnection('mongodb+srv://Anna:Abc1234@cluster0-hkoga.mongodb.net/hoop_dreams', {useNewUrlParser: true});


module.exports = {
    Player: connection.model('Player', playerSchema),
    PickupGame: connection.model('Games', pickupGameSchema),
    BasketballField: connection.model('BasketballField', basketballFieldSchema),
};



