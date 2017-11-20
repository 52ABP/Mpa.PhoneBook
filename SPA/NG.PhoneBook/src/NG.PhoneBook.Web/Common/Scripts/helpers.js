var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('PhoneBook');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);