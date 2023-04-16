$(".js-addorupdate").click((ev) => {
    $(".modal-AddorUpdate").html("");
    var id = ev.currentTarget.getAttribute("data-id")
    if (id != null) {
        $("#exampleModalLabel").html("Sửa thể loại tin tức")
        $.get("/admin/CategoryBook/_Update/" + id, (ev) => {
            $(".modal-AddorUpdate").append(ev);
        })
    } else {
        $("#exampleModalLabel").html("Thêm thể loại tin tức")
        $.get("/admin/CategoryBook/_AddCategoryBook", (ev) => {
            $(".modal-AddorUpdate").append(ev);
        })
    }
})

$(".js-postdata").click(() => {
    var data = $(".id-category").val()
    console.log(data)
    if (data == "") {
        var model = $("form").serialize();
        $.post("/admin/CategoryBook/_AddCategoryBook", model, (res) => {
            if (res == true) {
                window.location.reload();
            }
        })
    } else {
        var model = $("form").serialize();
        $.post("/admin/CategoryBook/_Update", model, (res) => {
            if (res == true) {
                window.location.reload();
            }
        })
    }

})