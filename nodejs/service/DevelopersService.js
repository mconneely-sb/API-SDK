'use strict';


/**
 * searches accounts
 * By passing in the appropriate options, you can search for available accounts in the system 
 *
 * number_id Integer pass an optional search string for looking up accounts (optional)
 * numberId Integer pass an optional search string for looking up accounts (optional)
 * skip Integer number of records to skip for pagination (optional)
 * limit Integer maximum number of records to return (optional)
 * returns List
 **/
exports.searchaccounts = function(number_id,numberId,skip,limit) {
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

