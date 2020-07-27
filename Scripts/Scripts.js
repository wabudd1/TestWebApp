function jQueryAjaxPost(form)
{
  
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            success: function (response) {
                $("#viewAll").html(response);
            }
        );
    }

    return false;
};

function openTab(evt, name) {
    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }
    document.getElementById(name).style.display = "block";
    evt.currentTarget.className += " active";
}