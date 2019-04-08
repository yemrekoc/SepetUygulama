const uri = "api/siparis";
let siparis = null;
function getCount(data) {
    const el = $("#counter");
    let name = "Sipariş";
    if (data) {
        if (data > 1) {
            name = "Siparişler";
        }
        el.text(data + " " + name);
    } else {
        el.text("No " + name);
    }
}

$(document).ready(function () {
    getData();
});

function getData() {
    $.ajax({
        type: "GET",
        url: uri,
        cache: false,
        success: function (data) {
            const tBody = $("#orders");

            $(tBody).empty();

            getCount(data.length);

            $.each(data, function (key, item) {
                const tr = $("<tr></tr>")
                    .append(
                        $("<td></td>").append(item.id)
                    )
                    .append($("<td></td>").text(item.date))
                    .append($("<td></td>").text(item.customer.name))
                    .append($("<td></td>").text(item.customer.surname))
                    .append($("<td></td>").text(item.customer.addres))
                    .append($("<td></td>").text(item.product.type))
                    .append($("<td></td>").text(item.product.printingArea))
                    .append($("<td></td>").text(item.product.printType))
                    //.append($("<td></td>").append($("<button>Edit</button>").on("click", function () {editItem(item.id);
                    //        })
                    //    )
                    //)
                    //.append(
                    //    $("<td></td>").append(
                    //        $("<button>Delete</button>").on("click", function () {
                    //            deleteItem(item.id);
                    //        })
                    //    )
                    //);

                tr.appendTo(tBody);
            });

            orders = data;
        }
    });
}

function addItem() {
    const item = {
        date: $("#add-date").val(),
        product: {
            type: $("#add-producttype").val(),
            printingArea: $("#add-productprintingarea").val(),
            printType: $("#add-productprinttype").val()
        },
        customer: {
            name: $("#add-customername").val(),
            surname: $("#add-customersurname").val(),
            addres: $("#add-customeraddres").val()

        }
        //isComplete: false
    };

    $.ajax({
        type: "POST",
        accepts: "application/json",
        url: uri,
        contentType: "application/json",
        data: JSON.stringify(item),
        error: function (jqXHR, textStatus, errorThrown) {
            alert("Something went wrong!");
        },
        success: function (result) {
            getData();
            $("#add-date").val("");
            $("#add-producttype").val("");
            $("#add-productprintingarea").val("");
            $("#add-productprinttype").val("");
            $("#add-customername").val("");
            $("#add-customersurname").val("");
            $("#add-customeraddres").val("");
        }
    });
}