// Here the web service should be setup and routes declared
const artService = require('./services/artService');
const artistService = require('./services/artistService');
const auctionService = require('./services/auctionService');
const customerService = require('./services/customerService');

const express = require('express');
const bodyParser = require('body-parser');
const app = express();


// Tekur req body og umbreytir yfir i json
app.use(bodyParser.json());

/***** ARTS *****/

// http://localhost:3000/api/arts   [GET]
// Gets all arts
app.get('/api/arts', function (req, res) {
    artService.getAllArts(function (arts) {
        return res.json(arts);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

// http://localhist:3000/api/1   [GET]
// Gets an art by id
app.get('/api/arts/:artId', function (req, res) {
    const artId = req.params.artId;
    artService.getArtById(artId, function (art) {
        return res.send(art);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

// http://localhost:3000/api/arts   [POST]
// Creates a new art
app.post('/api/arts', function (req, res) {
    artService.createArt(req.body, function (art) {
        return res.status(201).json(art);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

/***** ARTISTS *****/

// http://localhost:3000/api/artists   [GET]
// Gets all artists
app.get('/api/artists', function (req, res) {
    artistService.getAllArtists(function (artists) {
        return res.json(artists);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

// http://localhost:3000/api/artists/1   [GET]
// Gets an artist by id
app.get('/api/artists/:artistId', function (req, res) {
    const artistId = req.params.artistId;
    artistService.getArtistById(artistId, function (artist) {
        return res.send(artist);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

// http://localhost:3000/api/artists   [POST]
// Creates a new artist
app.post('/api/artists', function (req, res) {
    artistService.createArtist(req.body, function (artist) {
        return res.status(201).json(artist);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

/***** CUSTOMERS *****/

// http://localhost:3000/api/customers   [GET]
// Gets all customers
app.get('/api/customers', function (req, res) {
    customerService.getAllCustomers(function (customers) {
        return res.json(customers);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

// http://localhost:3000/api/customers/1   [GET]
// Gets a customer by id
app.get('/api/customers/:customerId', function (req, res) {
    const customerId = req.params.customerId;
    customerService.getCustomerById(customerId, function (customer) {
        return res.send(customer);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

// http://localhost:3000/api/customers   [POST]
// Creates a new customer
app.post('/api/customers', function (req, res) {
    customerService.createCustomer(req.body, function (customer) {
        return res.status(201).json(customer);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

// http://localhost:3000/api/customers/1/auction-bids   [GET]
// Gets all auction bids associated with a customer
app.get('/api/customers/:customerId/auction-bids', function (req, res) {
    const customerId = req.params.customerId;
    customerService.getCustomerAuctionBids(customerId, function (auctionBids) {
        return res.send(auctionBids);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

/***** AUCTIONS *****/

// http://localhost:3000/auctions/1   [GET]
// Gets all auctions
app.get('/api/auctions', function (req, res) {
    auctionService.getAllAuctions(function (auctions) {
        return res.json(auctions);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

// http://localhost:3000/api/auctions/1   [GET]
// Gets an auction by id
app.get('/api/auctions/:auctionId', function (req, res) {
    const auctionId = req.params.auctionId;
    auctionService.getAuctionById(auctionId, function (auction) {
        return res.send(auction);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

// http://localhost:3000/api/auctions/1/winner   [GET]
//  Gets the winner of the auction
app.get('/api/auctions/:auctionId/winner', function (req, res) {
    const auctionId = req.params.auctionId;
    auctionService.getAuctionWinner(auctionId, function (customer) {
        return res.status(200).send(customer);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

// http://localhost:3000/api/auctions   [POST]
// Create a new auction
app.post('/api/auctions', function (req, res) {
    auctionService.createAuction(req.body, function (auction) {
        return res.status(201).json(auction);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

// http://localhost:3000/api/auctions/1/bids   [GET]
// Gets all auction bids associated with an auction
app.get('/api/auctions/:auctionId/bids', function (req, res) {
    const auctionId = req.params.auctionId;
    auctionService.getAuctionBidsWithinAuction(auctionId, function (auctionBids) {
        return res.send(auctionBids);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

// http://localhost:3000/api/auctions/1/bids   [POST]
// Creates a new auction bid
app.post('/api/auctions/:auctionId/bids', function (req, res) {
    const auctionId = req.params.auctionId;
    auctionService.placeNewBid(auctionId, req.body.customerId, req.body.price, function (bid) {
        return res.status(201).json(bid);
    }, function (status, message) {
        return res.status(status).send(message);
    });
});

// http://localhost:3000
app.listen(3000, function () {
    console.log('Server is listening on port 3000');
});

