﻿var MAINMODULE = (function () {
    "use strict";

    var spinner = '<div class="spinner flex-square rectangle bg-transparent"><div class="flex-square-inner"><div class="flex-square-inner-content text-dark"><i class="fa fa-spinner fa-3x fa-spin"></i></div></div></div>';

    var spinner2 = '<div class="bg-transparent"><div class="flex-square-inner"><div class="flex-square-inner-content text-dark"><i class="fa fa-spinner fa-3x fa-spin"></i></div></div></div>';

    var selectors = {};

    function init() {

        cacheSelectors();

        bindAll();

        setGlobalAjax();

        loadNotifications();

        $('[data-toggle="tooltip"]').tooltip();
    }

    function cacheSelectors() {
        selectors.notificationsMenu = $("#notificationsMenu");
    }

    function bindAll() {
        bindNotImplemented();
    }

    function setGlobalAjax() {
        $(document).ajaxStart(function () { Pace.restart(); });
    }

    function bindNotImplemented() {
        $("body").on("click", ".notimplemented", function (e) {
            e.preventDefault();

            ALERTSYSTEM.Alert.ShowWarning('KEEP CALM AND READ THIS', 'The feature you clicked is not implemented yet.');

            return false;
        });
    }


    function loadNotifications() {
        $.get("/home/notifications", function (data) { selectors.notificationsMenu.html(data); });
    }

    return {
        Init: init,
        Default: {
            Spinner: spinner,
            Spinner2: spinner2
        }
    };
}());


$(function () {
    MAINMODULE.Init();
});