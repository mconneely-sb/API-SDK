'use strict';

var utils = require('../utils/writer.js');
var Developers = require('../service/DevelopersService');

module.exports.searchaccounts = function searchaccounts (req, res, next) {
  var number_id = req.swagger.params['number_id'].value;
  var numberId = req.swagger.params['NumberId'].value;
  var skip = req.swagger.params['skip'].value;
  var limit = req.swagger.params['limit'].value;
  Developers.searchaccounts(number_id,numberId,skip,limit)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};
