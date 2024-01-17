$('.lang').on('change', '', function (e) {
    $("#lang-hid").remove();
    var lang = $('.lang').find(":selected").val();
    $(".lang").val(`${lang}`);



    $('.langandcon').trigger("submit");
});

$('.con').on('change', '', function (e) {
    $("#con-hid").remove();
    var cont = $('.con').find(":selected").val();
    $(".con").val(`${cont}`);



    $('.langandcon').trigger("submit");
});

