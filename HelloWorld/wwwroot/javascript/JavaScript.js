/*$(function() {
    $(".ajaxCall a").on("click", function () {
        const url = this.href + "?page=" + this.id;
        $.get(url, function (html) {
            $(".content").html(html);
        })
        return false;
    })
})*/

function sendRequest(link) {
    const http = new XMLHttpRequest();
    http.onload = function () {
        $(".content").html(http.responseText);
    }
    http.open("Get", link.href + "?page=" + link.id);
    http.setRequestHeader("AjaxRequest", "XMLHttpRequest");
    http.send();
    return false;
}