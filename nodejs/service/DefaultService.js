'use strict';


/**
 * Find account by ID
 * Returns a single account
 *
 * id String ID of account to get
 * returns AccountsItem
 **/
exports.getAccountByID = function(id) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {"empty": false};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}

