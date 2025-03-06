'use strict';


/**
 * adds an accounts item
 * Adds an item to the system
 *
 * accountsItem AccountsItem accounts item to add (optional)
 * returns List
 **/
exports.addaccounts = function(accountsItem) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}

