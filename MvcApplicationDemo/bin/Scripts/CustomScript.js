
$(document).ready(function () {
    $("#btnSearch").on("click", function () {
        var url = "/Home/index";
        var searchTerm = $('#txtSearch').val();

        var SearchModel = { "SearchTerm": searchTerm };


        $.ajax({
            url: url,
            data: JSON.stringify(SearchModel),
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            success: function (data) {
                if (data != null) {
                    $("#divRestaurantList").html(data);
                }
            }
        });
        return false;
    });
});
