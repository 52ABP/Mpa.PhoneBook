$(function () {
    // logo = document.getElementById("logo");
    //logo.setAttribute("href", "https://www.baidu.com/img/baidu_jgylogo3.gif");

    $("#logo").text("yoyocms");
    $("#explore").text("查询");
    //  $("#logo").attr("href", "http://o97drvonf.bkt.clouddn.com/yoyocms_logo.jpg");

    $(".options .toggleEndpointList").each(function () {
        $(this).text("展开/隐藏");
    });
    $(".options .collapseResource").each(function () {
        $(this).text("显示资源列表");
    });

    $(".options .expandResource").each(function () {
        $(this).text("显示资源明细");
    });

    $(".operations .description-link").each(function () {
        $(this).text("实体模型");
    });

    $(".operations .snippet-link").each(function () {
        $(this).text("实体类型");
    });

    $(".operations .response-content-type label").each(function () {
        $(this).text("请求方式");
    });
    $(".operations .sandbox h4").each(function () {
        $(this).text("参数列表");
    });

    $(".operations .response_hider").each(function () {
        $(this).text("隐藏响应界面");
    });
    $(".operations .response .curl").each(function () {
        $(this).text("请求头");
    });

    $(".operations .response .curl").each(function () {
        $(this).next().text("请求路径");
    });

    $(".response_body").each(function () {
        $(this).prev().text("响应正文");
    });

    $("[class='block response_code']").each(function () {
        $(this).prev().text("响应代码");
    });

    $("[class='block response_headers']").each(function () {
        $(this).prev().text("响应标头");
    });

    $(".parameter-content-type div label").each(function () {
        $(this).text("参数的内容类型︰");
    });

    $("small.notice").each(function () {
        $(this).text("单击要设置为参数值");
    });

    $(".body-textarea").each(function () {
        var op = $(this).attr("placeholder");

        if (op === "(required)") {
            $(this).attr("placeholder", "(不可为空)");
        }
    });

    $(".body-textarea required");

    $(".fullwidth thead tr th").each(function () {
        var key = $(this).text();
        switch (key) {
            case "Parameter":
                $(this).text("参数名");
                break;
            case "Value":
                $(this).text("参数值");
                break;
            case "Description":
                $(this).text("描述");
                break;
            case "Parameter Type":
                $(this).text("参数类型");
                break;
            case "Data Type":
                $(this).text("数据类型");
                break;

            default:
                break;
        }
    });

    //$(".operations .response .block curl").each(function () {
    //    $(this).text("请求路径");
    //});

    $("input[type='submit']").val("测试");
})