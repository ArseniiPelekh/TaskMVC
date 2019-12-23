var currentBooks = {};

function createAddBook() {
    currentBooks.items = new Array();

    $("#createBook").show();
}

function AddBook() {
    var book = {};
    if (!($("#idAthor").val() == "0")) {
        book.name = $("#nameBook").val();
        book.genre = $("#genreBook").val();
        book.PageNumber = $("#PageNumberBook").val();
        book.idAuthor = $("#idAuthorBook").val();
        currentBooks.items.push(book);
    }
    drawItems();
}

function drawItems() {
    var $list = $("#BookListItems").empty();

    for (var i = 0; i < currentBooks.items.length; i++) {
        var curentItem = currentBooks.items[i];
        var $li = $("<div id='rectangle'></div><br />").html("<pre>" + "     Название:  " + curentItem.name +
            "<br />     Жанр:      " + curentItem.genre +
            "<br />Кол-во страниц: " + curentItem.PageNumber + "</pre>");
        $li.appendTo($list);
    }
    console.info(currentBooks.items);
}

function SaveBook() {
    var item = JSON.stringify(currentBooks.items);

    $.ajax({
        url: "/api/Author",
        type: "POST",
        data: JSON.stringify(item),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function (response) {
            alert(response.responseText);
        },
        success: function (response) {
            alert(response);
        }
    });
  };



