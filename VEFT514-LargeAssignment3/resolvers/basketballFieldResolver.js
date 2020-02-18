const basketballFieldService = require('../services/basketballFieldService');
const pickupGameService = require('../services/pickupGameService');

module.exports = {
    Query: {
        allBasketballFields: async (parent, args) => {
            const allBasketballFields = await basketballFieldService.getAllBasketBallFields(args.status);
            return allBasketballFields;
        },
        basketballField: async (parent, args) => {
            const basketballField = await basketballFieldService.getBasketballFieldById(args.id);
            return basketballField;
        }
    },
    Type: {

    }
}
