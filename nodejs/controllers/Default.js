'use strict';

var utils = require('../utils/writer.js');
var Default = require('../service/DefaultService');

module.exports.getAccountByID = function getAccountByID (req, res, next) {
  var id = req.swagger.params['id'].value;
  Default.getAccountByID(id)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};
