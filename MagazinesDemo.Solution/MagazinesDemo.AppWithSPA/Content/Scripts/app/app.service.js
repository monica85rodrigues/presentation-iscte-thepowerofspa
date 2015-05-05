window.app = window.app || {};

window.app.service = (function () {

    var baseUri = '/api/magazines/';

    var serviceUrls = {
        magazinesByYear: function (year) { return baseUri + "GetMagazinesByYear?year=" + year; },
        addMagazine: function (magazine) { return baseUri + "AddMagazine" }
    }

    function ajaxRequest(type, url, data) {
        var options = {
            url: url,
            headers: {
                Accept: "application/json"
            },
            contentType: "application/json",
            cache: false,
            type: type,
            data: data ? ko.toJSON(data) : null
        };
        return $.ajax(options);
    }

    return {
        magazinesByYear: function (year) {
            return ajaxRequest('GET', serviceUrls.magazinesByYear(year));
        },
        addMagazine: function (magazine) {
            return ajaxRequest('POST', serviceUrls.addMagazine(), magazine);
        }
    };

})();