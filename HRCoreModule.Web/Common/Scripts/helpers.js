﻿var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('HRCoreModule');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);