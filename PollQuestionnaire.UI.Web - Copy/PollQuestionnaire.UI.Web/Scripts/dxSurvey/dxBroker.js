function dxBroker() {
    this._urlBase = 'http://dxsurvey.com/api/MySurveys/';
    this._tempAccessKey = '12df74da0f5843fab34ae2655ca0d06c';

    this.getActiveSurveys = function (callback) {
        $.ajax({
            url: this._urlBase + 'getActive',
            method: 'GET',
            async: true,
            data: { accessKey: this._tempAccessKey },
            success: function (data, textStatus, jqXHR) {
                if (callback != undefined) {
                    callback(data, textStatus, jqXHR);
                }
            }
        });
    }

    this.regenerateAccessKey = function (callback) {
        $.ajax({
            url: this._urlBase + 'generateAccessKey',
            method: 'GET',
            async: true,
            data: { accessKey: this._tempAccessKey },
            success: function (data, textStatus, jqXHR) {
                if (callback != undefined) {
                    callback(data, textStatus, jqXHR);
                }
            }
        })
        .ajaxSuccess(function (data, textStatus, jqXHR) {
            alert('New Access key is: ' + data)
        });
    }

    this.createNewSurvey = function (surveyName, callback) {
        var survey = null;

        $.ajax({
            url: this._urlBase + 'create',
            method: 'GET',
            async: true,
            data: { accessKey: this._tempAccessKey, name: surveyName },
            success: function (data, textStatus, jqXHR) {
                if (callback != undefined) {
                    callback(data, textStatus, jqXHR);
                }
            }
        })

        return this;
    }

    this.changeSurvey = function (id, survey, callback) {
        $.ajax({
            url: this._urlBase + 'changeJson?accessKey=__accessKey__'.replace('__accessKey__', this._tempAccessKey),
            method: 'POST',
            async: true,
            crossDomain: true,
            data: { Id: id, Text: survey },
            dataType: 'json',
            complete: function (jqXHR, textStatus) {
                if (callback != undefined) {
                    callback(jqXHR, textStatus);
                }
            }
        });
    }
}