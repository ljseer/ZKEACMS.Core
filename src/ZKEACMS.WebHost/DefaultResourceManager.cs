/*!
 * http://www.zkea.net/
 * Copyright 2017 ZKEASOFT
 * http://www.zkea.net/licenses
 */

using Easy.Mvc.Resource;
using System;

namespace ZKEACMS.WebHost
{
    public class DefaultResourceManager : ResourceManager
    {
        const string LibraryPath = "~/lib";
        const string ScriptPath = "~/js";
        const string StylePath = "~/css";
        protected override void InitScript(Func<string, ResourceHelper> script)
        {

            script("jQuery")
                .Include($"{LibraryPath}/jquery/dist/jquery.js", $"{LibraryPath}/jquery/dist/jquery.min.js").RequiredAtHead();

            script("bootStrap")
                .Include($"{LibraryPath}/bootstrap/dist/js/bootstrap.js", $"{LibraryPath}/bootstrap/dist/js/bootstrap.min.js").RequiredAtFoot();

            script("jQueryUi")
                .Include($"{LibraryPath}/jquery-ui/jquery-ui.js", $"{LibraryPath}/jquery-ui/jquery-ui.min.js");

            script("Easy")
                .Include($"{ScriptPath}/EasyPlug/Easy.js", $"{ScriptPath}/EasyPlug/Easy.min.js").RequiredAtHead();

            script("lightBox")
                .Include($"{LibraryPath}/lightbox2/dist/js/lightbox.js", $"{LibraryPath}/lightbox2/dist/js/lightbox.min.js");

            script("validate")
                .Include($"{LibraryPath}/jquery-validation/dist/jquery.validate.js", $"{LibraryPath}/jquery-validation/dist/jquery.validate.min.js")
                .Include($"{LibraryPath}/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js", $"{LibraryPath}/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js");

            script("jsTree")
                .Include($"{LibraryPath}/jstree/dist/jstree.js", $"{LibraryPath}/jstree/dist/jstree.min.js");


            script("OWL.Carousel")
                .Include($"{ScriptPath}/OwlCarousel/owl.carousel.min.js", $"{ScriptPath}/OwlCarousel/owl.carousel.min.js")
                .Include($"{ScriptPath}/Owl.Carousel.js", $"{ScriptPath}/Owl.Carousel.min.js");

            script("LayoutDesign")
                .Include($"{ScriptPath}/LayoutDesign.js", $"{ScriptPath}/LayoutDesign.min.js");

            script("PageDesign")
                .Include($"{ScriptPath}/PageDesign.js", $"{ScriptPath}/PageDesign.min.js");

            script("admin")
                .Include($"{ScriptPath}/admin.js", $"{ScriptPath}/admin.min.js")
                .Include($"{LibraryPath}/CryptoJS/components/core.js", $"{LibraryPath}/CryptoJS/components/core-min.js")
                .Include($"{LibraryPath}/CryptoJS/components/enc-base64.js", $"{LibraryPath}/CryptoJS/components/enc-base64-min.js")
                .Include($"{LibraryPath}/slimscroll/jquery.slimscroll.min.js", $"{LibraryPath}/slimscroll/jquery.slimscroll.min.js");

            script("tinymce")
                .Include($"{ScriptPath}/tinymce/tinymce.min.js")
                .Include($"{ScriptPath}/tinymce/tinymce.config.js", $"{ScriptPath}/tinymce/tinymce.config.min.js");

            script("dataTable")
                .Include($"{LibraryPath}/datatables/media/js/jquery.dataTables.js", $"{LibraryPath}/datatables/media/js/jquery.dataTables.min.js")
                .Include($"{LibraryPath}/datatables/media/js/dataTables.bootstrap.js", $"{LibraryPath}/datatables/media/js/dataTables.bootstrap.min.js")
                .Include($"{ScriptPath}/dataTable.js", $"{ScriptPath}/dataTable.min.js");

            script("datepicker")
                .Include($"{LibraryPath}/bootstrap-datepicker/dist/js/bootstrap-datepicker.js", $"{LibraryPath}/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js")
                .Include($"{LibraryPath}/bootstrap-datepicker/dist/locales/bootstrap-datepicker.zh-CN.min.js");

            script("pjax")
                .Include($"{LibraryPath}/jquery-pjax/jquery.pjax.js");

            script("FileUploader")
                .Include($"{ScriptPath}/FileUploader.js");

            script("angular")
                .Include($"{LibraryPath}/angular/angular.js", $"{LibraryPath}/angular/angular.min.js");
        }

        protected override void InitStyle(Func<string, ResourceHelper> style)
        {
            style("bootStrap")
                .Include($"{LibraryPath}/bootstrap/dist/css/bootstrap.css", $"{LibraryPath}/bootstrap/dist/css/bootstrap.min.css")
                .Include($"{LibraryPath}/bootstrap/dist/css/bootstrap-theme.css", $"{LibraryPath}/bootstrap/dist/css/bootstrap-theme.min.css");

            style("Site")
                .Include($"{StylePath}/site.css", $"{StylePath}/site.min.css").RequiredAtFoot();

            style("jQueryUi")
                .Include($"{LibraryPath}/jquery-ui/themes/base/jquery-ui.css", $"{LibraryPath}/jquery-ui/themes/base/jquery-ui.min.css");

            style("Easy")
                .Include($"{ScriptPath}/EasyPlug/Css/Easy.css", $"{ScriptPath}/EasyPlug/Css/Easy.min.css");

            style("lightBox")
                .Include($"{LibraryPath}/lightbox2/dist/css/lightbox.css", $"{LibraryPath}/lightbox2/dist/css/lightbox.min.css");

            style("Layout")
                .Include($"{StylePath}/Layout.css", $"{StylePath}/Layout.min.css");

            style("Login")
                .Include($"{StylePath}/Login.css", $"{StylePath}/Login.min.css");

            style("Customer")
                .Include($"{StylePath}/Customer.css", $"{StylePath}/Customer.min.css");

            style("OWL.Carousel")
                .Include($"{ScriptPath}/OwlCarousel/owl.carousel.css", $"{ScriptPath}/OwlCarousel/owl.carousel.min.css")
                .Include($"{ScriptPath}/OwlCarousel/owl.transitions.css", $"{ScriptPath}/OwlCarousel/owl.transitions.min.css");

            style("admin")
                .Include($"{StylePath}/admin.css", $"{StylePath}/admin.min.css")
                .Include($"{ScriptPath}/EasyPlug/Css/Easy.css", $"{ScriptPath}/EasyPlug/Css/Easy.min.css");

            style("jsTree")
               .Include($"{LibraryPath}/jstree/dist/themes/default/style.css", $"{LibraryPath}/jstree/dist/themes/default/style.min.css");

            style("dataTable")
                .Include($"{LibraryPath}/datatables/media/css/dataTables.bootstrap.css", $"{LibraryPath}/datatables/media/css/dataTables.bootstrap.min.css");

            style("datepicker")
                .Include($"{LibraryPath}/bootstrap-datepicker/dist/css/bootstrap-datepicker3.css", $"{LibraryPath}/bootstrap-datepicker/dist/css/bootstrap-datepicker3.min.css");
        }
    }
}