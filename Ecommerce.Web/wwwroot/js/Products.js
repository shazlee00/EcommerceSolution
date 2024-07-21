var datatable;

$(document).ready(function () {
    loaddata();
});

function loaddata() {
    datatable = $('#productstable').DataTable({
        "ajax": {
            "url": "/Admin/Product/GetProducts",
            "type": "GET",
            "datatype": "json",
            "error": function (xhr, error, thrown) {
                console.error('Error: ', xhr.responseText);
            }
        },
        "columns": [
            { "data": "name" },
            { "data": "description" },
            { "data": "price" },
            { "data": "category" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="text-center">
                            <a href="/Admin/Product/Edit/${data}" class="btn btn-success text-white" style="cursor:pointer">Edit</a>
                            <a onClick="delete_product('/Admin/Product/Delete/${data}')" class="btn btn-danger text-white" style="cursor:pointer">Delete</a>                        </div>`
                }
            }
        ]
    });
}

function delete_product(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: "DELETE",
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        datatable.ajax.reload();
                        Swal.fire({
                            title: "Deleted!",
                            text: "Your file has been deleted.",
                            icon: "success"
                        });
                    } else {
                        toastr.error(data.message);
                    }
                },
                error: function (xhr, status, error) {
                    toastr.error("An error occurred while deleting the product.");
                    console.error('Error:', xhr.responseText);
                }
            });
        }
    });
}