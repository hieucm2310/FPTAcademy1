//Load dữ liệu tỉnh thành theo vùng miền của user
//function LoadDataProvince(url) {
//    //Lấy data append vào seleted
//    $('#IdProvince').empty();
//    $('#IdProvince').append('<option>Chọn...</option>');
//    $.ajax({
//        type: "GET",
//        url: url,
//        data: { id: $('#regionMangager').val() },
//        dataType: "json",
//        success: function (res) {
//            $.each(res, function (key, data) {
//                $('#IdProvince').append('<option value="' + data.value + '">' + data.text + '</option>');
//            });
//        },
//        error: function (req, status, error) {
//            console.log('req :' + req + 'status :' + status + 'error :' + error);
//            //Lấy data Offline (Nếu có)
//            new Dexie(INDEXED_DB_NAME).open().then(function (db) {
//                // 
//                db.table('provinces').each(function (data) {
//                    $('#IdProvince').append('<option value="' + data.id + '">' + data.name + '</option>');
//                });
//            }).catch('NoSuchDatabaseError', function (e) {
//                // Database with that name did not exist
//                console.error("Database not found");
//            }).catch(function (e) {
//                console.error("Oh uh: " + e);
//            });
//        }
//    });
//}

//Lấy dữ liệu cho Huyện/Quận khi tỉnh/thành phố thay đổi
function ProvinceOnChange() {
    showLoading();
    $('span[data-valmsg-for="IdProvince"]').text("");
    //Clear data cho quận huyện và xã khi chọn tỉnh mới
    $('#IdDistrict').empty();
    $('#IdDistrict').append('<option>Chọn...</option>');

    $('#IdWard').empty();
    $('#IdWard').append('<option>Chọn...</option>');
    var url = '/Profile/GetDataDistric';
    //Lấy data append vào seleted
    $.ajax({
        type: "GET",
        url: url,
        data: { id: $('#IdProvince').val() },
        dataType: "json",
        success: function (res) {
            $.each(res, function (key, data) {
                $('#IdDistrict').append('<option value="' + data.value + '">' + data.text + '</option>');
            })
            hideLoading();
        },
        error: function (req, status, error) {
            //Lấy data Offline (Nếu có)
            new Dexie(INDEXED_DB_NAME).open().then(function (db) {
                // 
                db.table('districts').each(function (data) {
                    if (data.provinceId == parseInt($('#IdProvince').val()))
                        $('#IdDistrict').append('<option value="' + data.id + '">' + data.name + '</option>');
                });
            }).catch('NoSuchDatabaseError', function (e) {
                // Database with that name did not exist
                console.error("Database not found");
            }).catch(function (e) {
                console.error("Oh uh: " + e);
            });
            hideLoading();
        }
    });
}
//
function DistrictOnClick() {
    $('span[data-valmsg-for="IdDistrict"]').text("");
    if ($('#IdProvince').val() == "Chọn..." || $('#IdProvince').val() == "") {
        $('span[data-valmsg-for="IdProvince"]').text("Bạn chưa chọn Tỉnh/Thành phố");
        return;
    }
    else {
        $('span[data-valmsg-for="IdProvince"]').text("");
    }

}
//
function DistrictOnChange() {
    showLoading();
    $('#IdWard').empty();
    $('#IdWard').append('<option>Chọn...</option>');
    var url = '/Profile/GetDataWards'
    //Lấy data append vào seleted
    $.ajax({
        type: "GET",
        url: url,
        data: { id: $('#IdDistrict').val() },
        dataType: "json",
        success: function (res) {
            $.each(res, function (key, data) {
                $('#IdWard').append('<option value="' + data.value + '">' + data.text + '</option>');
            })
            hideLoading();
        },
        error: function (req, status, error) {
            hideLoading();
            //Lấy data Offline (Nếu có)
            new Dexie(INDEXED_DB_NAME).open().then(function (db) {
                // 
                db.table('wards').each(function (data) {
                    if (data.districtId == parseInt($('#IdDistrict').val()))
                        $('#IdWard').append('<option value="' + data.id + '">' + data.name + '</option>');
                });
            }).catch('NoSuchDatabaseError', function (e) {
                // Database with that name did not exist
                console.error("Database not found");
            }).catch(function (e) {
                console.error("Oh uh: " + e);
            });
        }
    });
}
//
function WardOnClick() {
    $('span[data-valmsg-for="IdWard"]').text("");
    if ($('#IdDistrict').val() == "Chọn..." || $('#IdDistrict').val() == "") {
        $('span[data-valmsg-for="IdDistrict"]').text("Bạn chưa chọn Huyện Quận");
        return;
    }
    else {
        $('span[data-valmsg-for="IdDistrict"]').text("");
    }
}
//for receiveInfo
//
//function PostLoadDataProvince(url) {
//    //Lấy data append vào seleted
//    $.ajax({
//        type: "GET",
//        url: url,
//        data: { id: $('#regionMangager').val() },
//        dataType: "json",
//        success: function (res) {
//            $.each(res, function (key, data) {
//                $('#PostIdProvince').append('<option value="' + data.value + '">' + data.text + '</option>');
//            });
//        },
//        error: function (req, status, error) {
//            console.log('req :' + req + 'status :' + status + 'error :' + error);
//            //Lấy data Offline (Nếu có)
//            new Dexie(INDEXED_DB_NAME).open().then(function (db) {
//                // 
//                db.table('provinces').each(function (data) {
//                    $('#PostIdProvince').append('<option value="' + data.id + '">' + data.name + '</option>');
//                });
//            }).catch('NoSuchDatabaseError', function (e) {
//                // Database with that name did not exist
//                console.error("Database not found");
//            }).catch(function (e) {
//                console.error("Oh uh: " + e);
//            });
//        }
//    });
//}

//function PostProvinceOnClick() {
//}
//Lấy dữ liệu cho Huyện Quận khi tỉnh/thành phố thay đổi
function PostProvinceOnChange() {
    showLoading();
    $('span[data-valmsg-for="PostIdProvince"]').text("");
    //Clear data cho quận huyện và xã khi chọn tỉnh mới
    $('#PostIdDistrict').empty();
    $('#PostIdDistrict').append('<option>Chọn...</option>');

    $('#PostIdWard').empty();
    $('#PostIdWard').append('<option>Chọn...</option>');

    var url = '/Profile/GetDataDistric';
    //Lấy data append vào seleted
    $.ajax({
        type: "GET",
        url: url,
        data: { id: $('#PostIdProvince').val() },
        dataType: "json",
        success: function (res) {
            $.each(res, function (key, data) {
                $('#PostIdDistrict').append('<option value="' + data.value + '">' + data.text + '</option>');
            })
            hideLoading();
        },
        error: function (req, status, error) {
            hideLoading();
            //Lấy data Offline (Nếu có)
            new Dexie(INDEXED_DB_NAME).open().then(function (db) {
                // 
                db.table('districts').each(function (data) {
                    if (data.provinceId == parseInt($('#PostIdProvince').val()))
                        $('#PostIdDistrict').append('<option value="' + data.id + '">' + data.name + '</option>');
                });
            }).catch('NoSuchDatabaseError', function (e) {
                // Database with that name did not exist
                console.error("Database not found");
            }).catch(function (e) {
                console.error("Oh uh: " + e);
            });
        }
    });
}


function PostDistrictOnClick() {
    $('span[data-valmsg-for="PostIdDistrict"]').text("");
    if ($('#PostIdProvince').val() == "Chọn..." || $('#PostIdProvince').val() == "0") {
        $('span[data-valmsg-for="PostIdProvince"]').text("Bạn chưa chọn Tỉnh/Thành phố");
        return;
    }
    else {
        $('span[data-valmsg-for="PostIdProvince"]').text("");
    }
}
//
function PostDistrictOnChange() {
    showLoading();
    $('#PostIdWard').empty();
    $('#PostIdWard').append('<option>Chọn...</option>');
    var url = '/Profile/GetDataWards'
    //Lấy data append vào seleted
    $.ajax({
        type: "GET",
        url: url,
        data: { id: $('#PostIdDistrict').val() },
        dataType: "json",
        success: function (res) {
            $.each(res, function (key, data) {
                $('#PostIdWard').append('<option value="' + data.value + '">' + data.text + '</option>');
            })
            hideLoading();
        },
        error: function (req, status, error) {
            hideLoading();
            //Lấy data Offline (Nếu có)
            new Dexie(INDEXED_DB_NAME).open().then(function (db) {
                // 
                db.table('wards').each(function (data) {
                    if (data.districtId == parseInt($('#PostIdDistrict').val()))
                        $('#PostIdWard').append('<option value="' + data.id + '">' + data.name + '</option>');
                });
            }).catch('NoSuchDatabaseError', function (e) {
                // Database with that name did not exist
                console.error("Database not found");
            }).catch(function (e) {
                console.error("Oh uh: " + e);
            });
        }
    });
}
//
function PostWardOnClick() {
    $('span[data-valmsg-for="PostIdWard"]').text("");
    if ($('#PostIdDistrict').val() == "Chọn..." || $('#PostIdDistrict').val() == "0") {
        $('span[data-valmsg-for="PostIdDistrict"]').text("Bạn chưa chọn Huyện Quận");
        return;
    }
    else {
        $('span[data-valmsg-for="PostIdDistrict"]').text("");
    }
}

function RequireValidate(lstID) {
    var flgChk = true;
    var idArr = lstID.split(',');
    idArr.forEach((element) => {
        if ($('#' + element).val() == "" || $('#' + element).val() == undefined || $('#' + element).val() == "null") {
            flgChk = false;
            $('span[data-valmsg-for="' + element + '"]').text("Bạn chưa nhập giá trị cho trường này.");
        }
        else if ($('#' + element + ' option:selected').text() == "Chọn...") {
            flgChk = false;
            $('span[data-valmsg-for="' + element + '"]').text("Bạn chưa chọn giá trị cho trường này.");
        }
        else {
            $('span[data-valmsg-for="' + element + '"]').text("");
        }
    })
    return flgChk;
}

function ActiveMenu(className) {
    $('.' + className).addClass("active");
}
function UnActiveMenu(className) {
    $('.' + className).removeClass("active");
}
function phonenumberValid(id) {
    var flgChk = true;
    var rgx = /^[0-9]{8,11}$/;
    if (!rgx.test($('#' + id).val())) {
        flgChk = false;
        $('span[data-valmsg-for="' + id + '"]').text("Số điện thoại không hợp lệ.");
    }
    return flgChk;
}

function ageValid(id) {
    var flgChk = true;
    var rgx = /^[0-9]{1,3}$/;
    if (!rgx.test($('#' + id).val())) {
        flgChk = false;
        $('span[data-valmsg-for="' + id + '"]').text("Tuổi bạn nhập không hợp lệ.");
    }
    if (parseInt($('#' + id).val()) > 150 || parseInt($('#' + id).val()) < 1) {
        flgChk = false;
        $('span[data-valmsg-for="' + id + '"]').text("Tuổi bạn nhập phải từ 1 đến 150.");
    }
    return flgChk;
}

function birthYearValid(id) {
    var flgChk = true;
    var rgx = /^[0-9]{4}$/;
    if (!rgx.test($('#' + id).val())) {
        flgChk = false;
        $('span[data-valmsg-for="' + id + '"]').text("Năm bạn nhập không hợp lệ.");
    }
    var d = new Date();
    var n = d.getFullYear();

    if (parseInt($('#' + id).val()) > n || parseInt($('#' + id).val()) < 1900) {
        flgChk = false;
        $('span[data-valmsg-for="' + id + '"]').text("Năm bạn nhập phải từ 1900 đến năm hiện tại.");
    }
    return flgChk;
}

function monneyValid(id) {
    var flgChk = true;

    var rgx = /^[0-9]{1,15}$/;
    if (!rgx.test($('#' + id).val())) {
        flgChk = false;
        $('span[data-valmsg-for="' + id + '"]').text("Số tiền nhập không hợp lệ.");
    }
    if (parseInt($('#' + id).val()) < 0) {
        flgChk = false;
        $('span[data-valmsg-for="' + id + '"]').text("Số tiền bạn nhập không được âm.");
    }
    return flgChk;
}

function pointValid(id) {
    var flgChk = true;
    if (parseInt($('#' + id).val()) < 0 || parseInt($('#' + id).val()) > 10) {
        flgChk = false;
        $('span[data-valmsg-for="' + id + '"]').text("Số điểm phải từ 0 đến 10.");
    }
    return flgChk;
}

function birthDayValid(id) {
    $('span[data-valmsg-for="' + id + '"]').text("");
    var curDate = new Date();
    var validDate = new Date($('#' + id).val() + ' 23:59');
    if (curDate < validDate) {
        $('#' + id).val("");
        $('span[data-valmsg-for="' + id + '"]').text("Ngày bạn nhập không hợp lệ.");
    }
}

function positiveNumbers(id) {
    if (parseInt($('#' + id).val()) < 0) {
        $('#' + id).val('0');
        $('span[data-valmsg-for="' + id + '"]').text("Số bạn nhập không được âm.");
    } else {
        $('span[data-valmsg-for="' + id + '"]').text('');
    }
}

function isMobile() {
    let check = false;
    (function (a) { if (/(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino|android|ipad|playbook|silk/i.test(a) || /1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(a.substr(0, 4))) check = true; })(navigator.userAgent || navigator.vendor || window.opera);
    return check;
};

$('a[data-toggle="collapse"]').click(function () {
    var id = this.getAttribute('aria-controls');
    var i = $(this).find('i');
    //if (i.hasClass('ft-chevrons-down')) {
    if ($('#' + id).hasClass('show')) {
        i.removeClass('ft-chevrons-up');
        i.addClass('ft-chevrons-down');
    } else {
        i.removeClass('ft-chevrons-down');
        i.addClass('ft-chevrons-up');
    }
});

function appendPagination(totalRecord, pageIdx) {
    var pageLength = $('#pageSize').val();
    appendPaginationAdvance(totalRecord, pageIdx, parseInt(pageLength), "pagination", "prof-page", "drawDataTable");
    //return;
    //var next = 0;
    //var prev = 0;
    //var totalPage = 0;
    //if ((totalRecord / pageLength) > parseInt(totalRecord / pageLength))
    //    totalPage = parseInt(totalRecord / pageLength) + 1;
    //else
    //    totalPage = parseInt(totalRecord / pageLength)
    ////
    //if ((pageIdx + 1) > totalPage)
    //    next = pageIdx;
    //else
    //    next = (pageIdx + 1);
    ////
    //if ((pageIdx - 1) == 0)
    //    prev = pageIdx;
    //else
    //    prev = (pageIdx - 1);
    ////
    //var html = '';

    //$('.pagination li').remove();
    //if (totalRecord < pageLength && totalRecord >= 0) {
    //    html += '<li class="page-item"><a class="page-link" id="prof-page-1" href="#">1</a></li>';
    //}
    //else if (totalPage < 6 && totalPage > 1) {
    //    html += '<li class="page-item"><a class="page-link" href="#" aria-label="Previous" onclick="drawDataTable(1)"><i class="ft-chevrons-left"></i></a></li>';
    //    html += '<li class="page-item"><a class="page-link" href="#" aria-label="Previous" onclick="drawDataTable(' + prev + ')"><i class="ft-chevron-left"></i></a></li>';
    //    for (var i = 1; i <= totalPage; i++) {
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-' + i + '" href="#" onclick="drawDataTable(' + i + ')">' + i + '</a></li>';
    //    }
    //    html += '<li class="page-item"><a class="page-link" href="#" aria-label="Next" onclick="drawDataTable(' + next + ')"><i class="ft-chevron-right"></i></a></li>';
    //    html += '<li class="page-item"><a class="page-link" href="#" aria-label="Next" onclick="drawDataTable(' + totalPage + ')"><i class="ft-chevrons-right"></i></a></li>';
    //}
    //else {
    //    if (pageIdx == 1 || pageIdx == 2 || pageIdx == 3) {

    //        html += '<li class="page-item"><a class="page-link" href="#" aria-label="Previous" onclick="drawDataTable(1)"><i class="ft-chevrons-left"></i></a></li>';
    //        html += '<li class="page-item"><a class="page-link" href="#" aria-label="Previous" onclick="drawDataTable(' + prev + ')"><i class="ft-chevron-left"></i></a></li>';
    //        //
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-1" href="#" onclick="drawDataTable(1)">1</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-2" href="#" onclick="drawDataTable(2)">2</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-3" href="#" onclick="drawDataTable(3)">3</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-4" href="#" onclick="drawDataTable(4)">4</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-5" href="#" onclick="drawDataTable(5)">5</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page">...</a></li>';
    //        //
    //        html += '<li class="page-item"><a class="page-link" href="#" aria-label="Next" onclick="drawDataTable(' + next + ')"><i class="ft-chevron-right"></i></a></li>';
    //        html += '<li class="page-item"><a class="page-link" href="#" aria-label="Next" onclick="drawDataTable(' + totalPage + ')"><i class="ft-chevrons-right"></i></a></li>';
    //    } else if (pageIdx == totalPage || pageIdx == (totalPage - 1) || pageIdx == (totalPage - 2)) {

    //        html += '<li class="page-item"><a class="page-link" href="#" aria-label="Previous" onclick="drawDataTable(1)"><i class="ft-chevrons-left"></i></a></li>';
    //        html += '<li class="page-item"><a class="page-link" href="#" aria-label="Previous" onclick="drawDataTable(' + prev + ')"><i class="ft-chevron-left"></i></a></li>';
    //        //
    //        html += '<li class="page-item"><a class="page-link" id="prof-page">...</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-' + (totalPage - 4) + '" href="#" onclick="drawDataTable(' + (totalPage - 4) + ')">' + (totalPage - 4) + '</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-' + (totalPage - 3) + '" href="#" onclick="drawDataTable(' + (totalPage - 3) + ')">' + (totalPage - 3) + '</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-' + (totalPage - 2) + '" href="#" onclick="drawDataTable(' + (totalPage - 2) + ')">' + (totalPage - 2) + '</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-' + (totalPage - 1) + '" href="#" onclick="drawDataTable(' + (totalPage - 1) + ')">' + (totalPage - 1) + '</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-' + totalPage + '" href="#" onclick="drawDataTable(' + totalPage + ')">' + totalPage + '</a></li>';
    //        //
    //        html += '<li class="page-item"><a class="page-link" href="#" aria-label="Next" onclick="drawDataTable(' + next + ')"><i class="ft-chevron-right"></i></a></li>';
    //        html += '<li class="page-item"><a class="page-link" href="#" aria-label="Next" onclick="drawDataTable(' + totalPage + ')"><i class="ft-chevrons-right"></i></a></li>';
    //    } else {
    //        html += '<li class="page-item"><a class="page-link" href="#" aria-label="Previous" onclick="drawDataTable(1)"><i class="ft-chevrons-left"></i></a></li>';
    //        html += '<li class="page-item"><a class="page-link" href="#" aria-label="Previous" onclick="drawDataTable(' + prev + ')"><i class="ft-chevron-left"></i></a></li>';
    //        //
    //        html += '<li class="page-item"><a class="page-link" id="prof-page">...</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-' + (pageIdx - 2) + '" href="#" onclick="drawDataTable(' + (pageIdx - 2) + ')">' + (pageIdx - 2) + '</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-' + (pageIdx - 1) + '" href="#" onclick="drawDataTable(' + (pageIdx - 1) + ')">' + (pageIdx - 1) + '</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-' + pageIdx + '" href="#" onclick="drawDataTable(' + pageIdx + ')">' + pageIdx + '</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-' + (pageIdx + 1) + '" href="#" onclick="drawDataTable(' + (pageIdx + 1) + ')">' + (pageIdx + 1) + '</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page-' + (pageIdx + 2) + '" href="#" onclick="drawDataTable(' + (pageIdx + 2) + ')">' + (pageIdx + 2) + '</a></li>';
    //        html += '<li class="page-item"><a class="page-link" id="prof-page">...</a></li>';
    //        //
    //        html += '<li class="page-item"><a class="page-link" href="#" aria-label="Next" onclick="drawDataTable(' + next + ')"><i class="ft-chevron-right"></i></a></li>';
    //        html += '<li class="page-item"><a class="page-link" href="#" aria-label="Next" onclick="drawDataTable(' + totalPage + ')"><i class="ft-chevrons-right"></i></a></li>';
    //    }
    //}
    //$('.pagination').append(html);
    //$('#prof-page-' + pageIdx).closest('li').addClass('active');
}
function appendPaginationSituation(totalRecord, pageIdx) {
    var pageLength = $('#pageSizeSituation').val();
    appendPaginationAdvance(totalRecord, pageIdx, parseInt(pageLength), "paginationSituation", "prof-page-situation", "drawDataTableSituation");
}

$('input').click(function () {
    var id = $(this).attr('id');
    $('span[data-valmsg-for="' + id + '"]').text("");
});

$('select').click(function () {
    var id = $(this).attr('id');
    $('span[data-valmsg-for="' + id + '"]').text("");
});

$('textarea').click(function () {
    var id = $(this).attr('id');
    $('span[data-valmsg-for="' + id + '"]').text("");
});

$('#chkAll').click(function () {
    var chk = document.getElementById("chkAll").checked;
    $('#profileTbl tbody tr input:checkbox').each(function (i) {
        this.checked = chk;
    });
})

function RequireValidateById(lstID) {
    var flgChk = true;
    var idArr = lstID.split(',');
    idArr.forEach((element) => {
        var value = $('#' + element).val();
        if (value == "" || value == undefined) {
            flgChk = false;
            $('span[id="' + element + '"]').text("Bạn chưa nhập giá trị cho trường này.");
        }
        else if ($('#' + element + ' option:selected').text() == "Chọn...") {
            flgChk = false;
            $('span[id="' + element + '"]').text("Bạn chưa chọn giá trị cho trường này.");
        }
        //else if ($('#' + element).val() < 0) {
        //    flgChk = false;
        //    $('span[data-valmsg-for="' + element + '"]').text("Bạn chưa nhập giá trị lớn hơn 0.");
        //}
        else {
            $('span[id="' + element + '"]').text("");
        }
    })
    return flgChk;
}

function blockPage() {
    $("body").append('<div id="blockPage" class="modal-backdrop text-center fade show" style="z-index:999998;"><div class="spinner-border" role="status" style="color: #ff0000 !important; width: 5rem; height: 5rem; margin-top: 10rem; z-index:999999;"></i><span class="sr-only">Loading...</span></div></div>');
}
function unblockPage() {
    $("body #blockPage").remove();
}

$.fn.currency = function (callback) {
    $(this).on({
        keyup: function () {
            formatCurrency($(this));
            if (callback != undefined)
                callback();
        },
        blur: function () {
            formatCurrency($(this), "blur");
            if (callback != undefined)
                callback();
        }
    });
}
function formatNumber(n) {
    return n.replace(/\D/g, "").replace(/\B(?=(\d{3})+(?!\d))/g, ".")
}


function formatCurrency(input, blur) {
    // appends $ to value, validates decimal side
    // and puts cursor back in right position.

    // get input value
    var input_val = input.val();

    // don't validate empty input
    if (input_val === "") { return; }

    // original length
    var original_len = input_val.length;

    // initial caret position 
    var caret_pos = input.prop("selectionStart");

    // check for decimal
    if (input_val.indexOf(",") >= 0) {

        // get position of first decimal
        // this prevents multiple decimals from
        // being entered
        var decimal_pos = input_val.indexOf(",");

        // split number by decimal point
        var left_side = input_val.substring(0, decimal_pos);
        var right_side = input_val.substring(decimal_pos);

        // add commas to left side of number
        left_side = formatNumber(left_side);

        // validate right side
        right_side = formatNumber(right_side);

        // On blur make sure 2 numbers after decimal
        if (blur === "blur") {
            right_side += "";
        }

        // Limit decimal to only 2 digits
        right_side = right_side.substring(0, 2);

        // join number by .
        input_val = "" + left_side + "," + right_side;

    } else {
        // no decimal entered
        // add commas to number
        // remove all non-digits
        input_val = formatNumber(input_val);
        input_val = "" + input_val;

        // final formatting
        if (blur === "blur") {
            input_val += "";
        }
    }

    // send updated string to input
    input.val(input_val);

    // put caret back in the right position
    var updated_len = input_val.length;
    caret_pos = updated_len - original_len + caret_pos;
    input[0].setSelectionRange(caret_pos, caret_pos);
}

function validCurrency(id, vldf = 2147483647) {
    var data = $("#" + id).val();
    data = getValueFromCurrency(data);
    if (data.includes('-')) {
        $('span[data-valmsg-for="' + id + '"]').text("Giá trị nhập vào phải lớn hơn 0.");
        return false;
    }
    if (data.includes(',')) {
        $('span[data-valmsg-for="' + id + '"]').text("Giá trị nhập vào chứa dấu phẩy.");
        return false;
    }
    if (isNaN(data)) {
        $('span[data-valmsg-for="' + id + '"]').text("Dữ liệu nhập vào phải là kiểu số.");
        return false;
    }
    var maxInt = vldf;
    if (parseInt(data) > maxInt) {
        $('span[data-valmsg-for="' + id + '"]').text("Dữ liệu nhập vào quá lớn");
        return false;
    }
    $('span[data-valmsg-for="' + id + '"]').text("");
    return true;
}

function getValueFromCurrency(data) {
    data = data.replace(/\./g, "");
    return data;
}

function appendPaginationAdvance(totalRecord, pageIdx, pageSize, cPagination, cProfPage, onClickFunction) {
    var range = 2;
    var totalPage = 0;
    if (totalRecord / pageSize > parseInt(totalRecord / pageSize))
        totalPage = parseInt(totalRecord / pageSize) + 1;
    else
        totalPage = parseInt(totalRecord / pageSize);
    if (pageIdx > totalPage)
        pageIdx = totalPage;
    if (pageIdx < 1)
        pageIdx = 1;
    var queeTempLeft = [];
    var queeTempRight = [];
    var queeTotal = [];
    var left = pageIdx;
    var right = pageIdx;
    //left
    while (left > 1) {
        left--;
        var link = getLinkFromIndex(left, undefined, cProfPage, onClickFunction);
        queeTempLeft.push(link);
        if (pageIdx - left == range) {
            if (left > 1) {
                var more = getLinkFromIndex(".", undefined, cProfPage, onClickFunction);
                queeTempLeft.push(more);
            }
            break;
        }
    }
    //right
    while (right < totalPage) {
        right++;
        var link = getLinkFromIndex(right, undefined, cProfPage, onClickFunction);
        queeTempRight.push(link);
        if (right - pageIdx == range) {
            if (right < totalPage) {
                var more = getLinkFromIndex(".", undefined, cProfPage, onClickFunction);
                queeTempRight.push(more);
            }
            break;
        }
    }
    if (totalPage > 1) {
        queeTotal.push(getLinkFromIndex(1, "ft-chevrons-left", cProfPage, onClickFunction));
        queeTotal.push(getLinkFromIndex(pageIdx > 1 ? pageIdx - 1 : 1, "ft-chevron-left", cProfPage, onClickFunction));
    }

    for (var j = queeTempLeft.length - 1; j >= 0; --j) {
        queeTotal.push(queeTempLeft[j]);
    }
    var pageIndex = getLinkFromIndex(pageIdx, undefined, cProfPage, onClickFunction);
    queeTotal.push(pageIndex);

    for (var j = 0; j < queeTempRight.length; ++j) {
        queeTotal.push(queeTempRight[j]);
    }
    if (totalPage > 1) {
        queeTotal.push(getLinkFromIndex(pageIdx < totalPage ? pageIdx + 1 : pageIdx, "ft-chevron-right", cProfPage, onClickFunction));
        queeTotal.push(getLinkFromIndex(totalPage, "ft-chevrons-right", cProfPage, onClickFunction));
    }
    var html = '';
    for (var j = 0; j < queeTotal.length; ++j) {
        html += queeTotal[j];
    }
    $('.' + cPagination + ' li').remove();
    $('.' + cPagination + '').append(html);
    $('#' + cProfPage + '-' + pageIdx).closest('li').addClass('active');
}
function getLinkFromIndex(index, sClass, cProfPage, onClickFunction) {
    if (!isNaN(index)) {
        if (sClass == undefined) {
            return '<li class="page-item"><a class="page-link" href="#"  id="' + cProfPage + '-' + index + '"  onclick="' + onClickFunction + '(' + index + ')">' + index + '</a></li>';
        }
        else
            return '<li class="page-item"><a class="page-link" href="#"  onclick="' + onClickFunction + '(' + index + ')"><i class="' + sClass + '"></i></a></li>';
    }
    else
        return '<li class="page-item"><a class="page-link" id="' + cProfPage + '">...</a></li>';
}


function callAjax(url, method, data, callback) {
    $.ajax({
        type: method,
        url: url,
        data: data,
        contentType: false,
        processData: false,
        dataType: "json",
        success: function (rs) {
            if (rs.code != 401)
                callback(rs);
            else if (rs.code == 401) {
                location.href = "/";
            }
        }
    });
}
function postAjax(url, data, callback) {
    callAjax(url, "POST", data, callback);
}
function getAjax(url, callback) {
    callAjax(url, "GET", null, callback);
}
function postTable(url, data, callback, customCallback) {
    data.__RequestVerificationToken = _token;
    $.ajax({
        type: "POST",
        url: url,
        data: data,
        dataType: "json",
        success: function (rs) {
            if (customCallback)
                customCallback();
            if (rs.code != 401)
                callback(rs);
            else if (rs.code == 401) {
                location.href = "/";
            }
        }
    });
}