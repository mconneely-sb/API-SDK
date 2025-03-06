'use strict';

var utils = require('../utils/writer.js');
var Admins = require('../service/AdminsService');

module.exports.addaccounts = function addaccounts (req, res, next) {
  var accountsItem = req.swagger.params['accountsItem'].value;
  Admins.addaccounts(accountsItem)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};
