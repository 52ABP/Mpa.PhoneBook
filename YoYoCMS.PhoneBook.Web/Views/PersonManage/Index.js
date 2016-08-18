var _personService = abp.services.app.person;


(function() {

    $(function() {

        var _$modal = $("#PersonCreateModal");

        var _$form = _$modal.find("form");

        _$form.validate();

        _$form.find('button[type="submit"]').click(function(e) {

            e.preventDefault();
            if (!_$form.valid()) {
                return;
            }

            var personEditDto = _$form.serializeFormToObject();
            abp.ui.setBusy(_$modal);
            console.log(personEditDto);
            _personService.createOrUpdatePersonAsync({ personEditDto }).done(function() {
                _$modal.modal("hide");

                location.reload(true); //reload page to see new person!
            }).always(function() {
                abp.ui.clearBusy(_$modal);
            });
        });
        _$modal.on("shown.bs.modal", function() {
            _$modal.find("input:not([type=hidden]):first").focus();
        });
    });
})();

function editPerson(id) {

    _personService.getPersonForEditAsync({ id: id }).done(function(data) {

        $("input[name=Name]").val(data.person.name);
        $("input[name=EmailAddress]").val(data.person.emailAddress);
        $("input[name=Id]").val(data.person.id);

    });


}


function deletePerson(id) {
    abp.message.confirm(
        "是否删除Id为"+id+"的联系人信息", function() {
            _personService.deletePersonAsync({ id: id }).done(function() {
                location.reload(true);
            });
        }
    );

}