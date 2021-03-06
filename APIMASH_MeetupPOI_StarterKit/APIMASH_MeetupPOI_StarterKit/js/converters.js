﻿(function () {

    /*
     * LICENSE: http://opensource.org/licenses/ms-pl) 
     */

    WinJS.Namespace.define('Converters', {
        friendlyDate: WinJS.Binding.converter(parseDate),
        parseDate: parseDate,
    });

    function parseDate(dateval) {
        if (dateval) {
            var d = new Date(parseInt(dateval.toString())).toLocaleDateString();
            return d;
        }
    }

})();