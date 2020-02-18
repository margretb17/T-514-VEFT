
const pickupGames = [
    {
        id: 1,
        start: Date,
        end: Date,
        fieldLocationId: "",
        registeredPlayersIds: [1, 2, 4], // Array af Players
        hostId: 1
    },
    {
        id: 2,
        start: Date,
        end: Date,
        fieldLocationId: "",
        registeredPlayersIds: [1, 2, 3], // Array af Players
        hostId: 2
    },
    {
        id: 3,
        start: Date,
        end: Date,
        fieldLocationId: "",
        registeredPlayersIds: [6, 7, 8], // Array af Players
        hostId: 3
    },
    {
        id: 4,
        start: Date,
        end: Date,
        fieldLocationId: "",
        registeredPlayersIds: [4, 5, 6], // Array af Players
        hostId: 4
    },
    {
        id: 5,
        start: Date,
        end: Date,
        fieldLocationId: "",
        registeredPlayersIds: [1, 7, 8], // Array af Players
        hostId: 5
    },
];

const players = [
    {
        id: 1,
        name: 'Micheal Jordan',
        playedGamesIds: [1, 2, 5] // Array af pickupGames
    },
    {
        id: 2,
        name: 'Lebron James',
        playedGamesIds: [1, 2] // Array af pickupGames
    },
    {
        id: 3,
        name: 'Allen Iverson',
        playedGamesIds: [2] // Array af pickupGames
    },
    {
        id: 4,
        name: 'Fox',
        playedGamesIds: [1, 4] // Array af pickupGames
    },
    {
        id: 5,
        name: 'Mobi',
        playedGamesIds: [4] // Array af pickupGames
    },

    {
        id: 6,
        name: 'Kobi Bryant',
        playedGamesIds: [3, 4] // Array af pickupGames
    },

    {
        id: 7,
        name: 'Shaq',
        playedGamesIds: [3, 5] // Array af pickupGames
    },

    {
        id: 8,
        name: 'Rose',
        playedGamesIds: [3, 5] // Array af pickupGames
    },
];

module.exports = {
    pickupGames,
    players
};
