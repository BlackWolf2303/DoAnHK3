jQuery(function ($) {

    var show = parseInt(@ViewBag.Show);
var sort = parseInt(@ViewBag.Sort);
var currentPage = parseInt(@ViewBag.CurrentPage);
var bestSellerCurrentPage = currentPage;
var newProductsCurrentPage = currentPage;
var totalPage = parseInt(parseInt(@ViewBag.TotalProduct) / show) + 1;

$("#BestSeller").load('@(Url.Action("ProductList", "Product", null, Request.Url.Scheme))?sort=' + sort + '&show=' + show + '&currentPage=' + currentPage);
$("#NewProducts").load('@(Url.Action("ProductList", "Product", null, Request.Url.Scheme))?sort=' + sort + '&show=' + show + '&currentPage=' + currentPage);


ChangeBestSellerPage(bestSellerCurrentPage, totalPage);
ChangeNewProductsPage(newProductsCurrentPage, totalPage);

// BestSeller
$("#bestSellerPaging a").click(function () {
    event.preventDefault();

    if ($(this).parent().hasClass("end")) {
        bestSellerCurrentPage = totalPage;
    } else if ($(this).parent().hasClass("first")) {
        bestSellerCurrentPage = 1;
    } else {
        bestSellerCurrentPage = parseInt($(this).text());
    }

    $("#bestSellerPaging li").removeClass("active");
    ChangeBestSellerPage(bestSellerCurrentPage, totalPage);

    $("#BestSeller").load('@(Url.Action("ProductList", "Product", null, Request.Url.Scheme))?sort=' + sort + '&show=' + show + '&currentPage=' + bestSellerCurrentPage);
});
$("#BestSellerShow").change(function () {
    show = $("#BestSellerShow").val();
    $("#BestSeller").load('@(Url.Action("ProductList", "Product", null, Request.Url.Scheme))?sort=' + sort + '&show=' + show);
});
$("#BestSellerSortBy").change(function () {
    sort = $("#BestSellerSortBy").val();
    $("#BestSeller").load('@(Url.Action("ProductList", "Product", null, Request.Url.Scheme))?sort=' + sort + '&show=' + show);
});

// NewProducts
$("#newProductsPaging a").click(function () {
    event.preventDefault();

    if ($(this).parent().hasClass("end")) {
        newProductsCurrentPage = totalPage;
    } else if ($(this).parent().hasClass("first")) {
        newProductsCurrentPage = 1;
    } else {
        newProductsCurrentPage = parseInt($(this).text());
    }

    $("#newProductsPaging li").removeClass("active");
    ChangeNewProductsPage(newProductsCurrentPage, totalPage);
    $("#NewProducts").load('@(Url.Action("ProductList", "Product", null, Request.Url.Scheme))?sort=' + sort + '&show=' + show + '&currentPage=' + newProductsCurrentPage);
});
$("#NewProSortBy").change(function () {
    sort = $("#NewProSortBy").val();
    $("#NewProducts").load('@(Url.Action("ProductList", "Product", null, Request.Url.Scheme))?sort=' + sort + '&show=' + show);
});
$("#NewProShow").change(function () {
    show = $("#NewProShow").val();
    $("#NewProducts").load('@(Url.Action("ProductList", "Product", null, Request.Url.Scheme))?sort=' + sort + '&show=' + show);
});

function ChangeBestSellerPage(currentPage, totalPage) {
    if (currentPage == 1) {
        $("#bestSellerPaging .firstPage a").html(currentPage);
        $("#bestSellerPaging .firstPage").addClass("active");
        $("#bestSellerPaging .midPage a").html(parseInt(currentPage) + 1);
        $("#bestSellerPaging .lastPage a").html(currentPage + 2);
    } else if (currentPage == totalPage) {
        $("#bestSellerPaging .firstPage a").html(currentPage - 2);
        $("#bestSellerPaging .midPage a").html(currentPage - 1);
        $("#bestSellerPaging .lastPage a").html(currentPage);
        $("#bestSellerPaging .lastPage").addClass("active");
    } else {
        $("#bestSellerPaging .firstPage a").html(currentPage - 1);
        $("#bestSellerPaging .midPage a").html(currentPage);
        $("#bestSellerPaging .midPage").addClass("active");
        $("#bestSellerPaging .lastPage a").html(currentPage + 1);
    }

    if (currentPage < 3) {
        $("#bestSellerPaging .first").hide();
        $("#bestSellerPaging .end").show();
    } else if (currentPage > (totalPage - 2)) {
        $("#bestSellerPaging .first").show();
        $("#bestSellerPaging .end").hide();
    } else {
        $("#bestSellerPaging .first").show();
        $("#bestSellerPaging .end").show();
    }
}

function ChangeNewProductsPage(currentPage, totalPage) {
    if (currentPage == 1) {
        $("#newProductsPaging .firstPage a").html(currentPage);
        $("#newProductsPaging .firstPage").addClass("active");
        $("#newProductsPaging .midPage a").html(currentPage + 1);
        $("#newProductsPaging .lastPage a").html(currentPage + 2);
    } else if (currentPage == totalPage) {
        $("#newProductsPaging .firstPage a").html(currentPage - 2);
        $("#newProductsPaging .midPage a").html(currentPage - 1);
        $("#newProductsPaging .lastPage a").html(currentPage);
        $("#newProductsPaging .lastPage").addClass("active");
    } else {
        $("#newProductsPaging .firstPage a").html(currentPage - 1);
        $("#newProductsPaging .midPage a").html(currentPage);
        $("#newProductsPaging .midPage").addClass("active");
        $("#newProductsPaging .lastPage a").html(currentPage + 1);
    }

    if (currentPage < 3) {
        $("#newProductsPaging .first").hide();
        $("#newProductsPaging .end").show();
    } else if (currentPage > (totalPage - 2)) {
        $("#newProductsPaging .first").show();
        $("#newProductsPaging .end").hide();
    } else {
        $("#newProductsPaging .first").show();
        $("#newProductsPaging .end").show();
    }
}
    });