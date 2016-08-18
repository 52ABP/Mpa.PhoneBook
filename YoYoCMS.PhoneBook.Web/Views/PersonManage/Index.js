(function() {
    $(function() {
        var _personService = abp.services.app.person;

        var _$modal = $('#PersonCreateModal');

        var _$form = _$modal.find("form");

        _$form.validate();

        _$form.find('button[type="submit"]').click(function (e) {

            e.preventDefault();
            if (!_$form.valid()) {
                return;
            }

            var person = _$form.serializeFormToObject();
            abp.ui.setBusy(_$modal);
            console.log(person);
            _personService.createPersonAsync(person).done(function () {
                _$modal.modal("hide");
                location.reload(true); //reload page to see new person!
            }).always(function() {
                abp.ui.clearBusy(_$modal);
            });
            });


     










        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });
    });
})();