const request = require('request');
const { InternalServerError } = require('../errors');


const basketballFieldService = () => {

    let url = 'https://basketball-fields.herokuapp.com/api/basketball-fields';

    const getAllBasketBallFields = status => {
        const route = status === undefined ? url : `${ url }?status=${ status }`;
        return new Promise((res) => {
            request(route, function(error, response, body) {
                if (error) { throw new InternalServerError }
                let jsonObj = JSON.parse(body);
                console.log("HERE")
                console.log(jsonObj);
                res(jsonObj);
            });
        });
    };

    // Should return a specific basketball field by id
    const getBasketballFieldById = (id) => {
        const route = `${url}/${id}`;
        return new Promise((res) => {
            request(route, function(error, response, body) {
                if (error) { error(new InternalServerError); }
                let jsonObj = JSON.parse(body);
                res(jsonObj);
            })
        })
    };
 
    return {
        getAllBasketBallFields,
        getBasketballFieldById,
    };
};
module.exports = basketballFieldService();

