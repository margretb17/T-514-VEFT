const Schema = require('mongoose').Schema;

module.exports = new Schema({
    basketballFieldId: {type: String, required: true},
    pickupGames: [Schema.Types.ObjectId]
});