const { gql } = require('apollo-server');
const types = require('./types');
const input = require('./input');
const scalar = require('./scalar');
const enums = require('./enums');
const queries = require('./queries');
const mutations = require('./mutations');

module.exports = gql`
    ${types}
    ${input}
    ${scalar}
    ${enums}
    ${queries}
    ${mutations}
`;