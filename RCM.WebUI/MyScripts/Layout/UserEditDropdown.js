//------------------------------Edit and Change Scripts----------------------------
//---------------------------------------------------------------------------------

//----------------------------------Change User Profile--------------

var UserId = document.getElementById("activeUserInfo").getAttribute("userid");
var UserName = "";
var Email = "";
var Password = "";

var newBranchName = "";

//---set current user info to modal
$("#btnupdate").click(function (e) {
    e.preventDefault();
    $('#userEditMenu').hide();

    $.ajax({
        method: 'post',
        url: "/UserInfo/GetActiveUserInfo/" + UserId,
        async: true,
        success: function (response) {
            if (response.Result) {
                $("#txtProfileUserName").val(response.UserName);
                $("#txtProfileEmail").val(response.Email);
                $("#txtProfilePassword").val(response.Passwd);

                $("#divChangeUserProfile").modal('show');

                UserName = response.UserName;
                Email = response.Email;
                Password = response.Passwd;
            }
            else {
                Swal.fire({
                    icon: 'warning',
                    title: response.Title,
                    html: response.Message
                })
            }
        }
    });
});

//----------update new value----
$("#btnUpdateUser").click(function (e) {
    e.preventDefault();

    var mdlUserInfoForm = $("#mdlUserInfoForm");
    if (mdlUserInfoForm.valid()) {

        if ($("#txtProfileUserName").val() != UserName || $("#txtProfileEmail").val() != Email || $("#txtProfilePassword").val() != Password) {

            //------------to need old password for accept changes------------------------------------
            (async function () {
                const { value: password } = await Swal.fire({
                    title: 'Eski Şifre ?',
                    input: 'password',
                    inputLabel: 'Değişikliklerin onaylanması için eski şifrenizi girmelisiniz',
                    inputPlaceholder: 'şifre..',
                    inputAttributes: {
                        maxlength: 10,
                        autocapitalize: 'off',
                        autocorrect: 'off'
                    },
                });
                if (password == Password) {
                    //Swal.fire(`Entered password: ${password}`)

                    var vm =
                    {
                        Id: UserId,
                        UserName: $("#txtProfileUserName").val(),
                        Email: $("#txtProfileEmail").val(),
                        Password: $("#txtProfilePassword").val()
                    }
                    $.ajax({
                        method: 'post',
                        url: "/UserInfo/UpdateUserProfile/",
                        async: true,
                        data: vm,
                        success: function (response) {
                            if (response.Result) {
                                Swal.fire({
                                    icon: 'success',
                                    title: 'İşlem Başarılı',
                                    text: response.Message
                                }).then((result) => {
                                    //document.getElementById("activeUserInfo").innerText = $("#txtProfileFullName").val();
                                    //document.getElementById("currentUserName").innerText = $("#txtProfileFullName").val();
                                    //document.getElementById("smallEmail").innerText = $("#txtProfileEmail").val();
                                    $("#mdlUserInfoForm")[0].reset();
                                    $("#divChangeUserProfile").modal('hide');
                                    window.location.href = "/DashBoard/Index";
                                });
                            }
                            else {

                                Swal.fire({
                                    icon: 'error',
                                    title: response.Title,
                                    html: response.Message
                                })
                            }
                        }
                    });
                }
                else {
                    Swal.fire(`Eski Şifrenizi Hatalı Girdiniz !`)
                }
            })();

            //-----------/--------------------

        }
        else {
            $("#mdlUserInfoForm")[0].reset();
            $("#divChangeUserProfile").modal('hide');
    }


    }
    else {
        result = mdlUserInfoForm.validate();
        var htmlMessage = "";

        for (var i = 0; i < result.errorList.length; i++) {
            htmlMessage += result.errorList[i].message + "<br />";
            //result.errorList[i].element.style.border = "1px solid #f00";
        }

        Swal.fire({
            icon: 'error',
            //title: 'Lütfen Bilgileri Eksiksiz ve Doğru Girin',
            html: htmlMessage
        });
    }



});
//-----------------------------------------/user profile----------------------------------

//--------------------------change branch---------------------------------
$("#btnAcceptBranch").click(function (e) {
    e.preventDefault();
    var selectedValue = $('select[name=mySelection] option').filter(':selected').val();
    var selectedText = $('select[name=mySelection] option').filter(':selected').text();
    //var selectedactiveauthrtyId = $('select[name=mySelection] option').filter(':selected').get().entries(1, HTMLElement);
    //var activeauthrtyId = selectedactiveauthrtyId.values();
    var selectedActiveauthrtyId = $('#branchList').find('option:selected').attr('authrtyid')
    var activeBrnchId = document.getElementById("activeUserInfo").getAttribute("userBrnchId");
    newBranchName = selectedText;

    if (selectedValue != 0 && selectedValue != activeBrnchId) {
        var vm =
        {
            ActiveBranchId: selectedValue,
            ActiveBranchName: selectedText,
            ActiveAuthorityId: selectedActiveauthrtyId
        }
        $.ajax({
            method: 'post',
            url: "/UserInfo/ChangeActiveBranchInfo/",
            async: true,
            data: vm,
            success: function (response) {
                if (response.Result) {
                    //document.getElementById("activeUserInfo").setAttribute("userBrnchId", selectedValue);
                    //document.getElementById("activeUserInfo").setAttribute("authrtyTypid", selectedActiveauthrtyId);
                    //document.getElementById("currentBrnchName").textContent = selectedText;
                    //document.getElementById("dashPage").innerHTML = "";

                    $('#userEditMenu').hide();

                    window.location.href = "/DashBoard/Index";
                    //processToast();
                }
                else {

                    Swal.fire({
                        icon: 'error',
                        title: response.Title,
                        html: response.Message
                    })
                }
            }
        });
    }
});

//---------------- to triger toast-------------
function processToast() {
    var Toast = Swal.mixin({
        toast: true,
        //position: 'top-left',
        showConfirmButton: true,
        //timer: 2500
    });
    Toast.fire({
        icon: 'warning',
        title: 'İşlemlerinize ' + newBranchName + ' şubesi ile devam edilecek!'
    }).then((result) => {
        window.location.href = "/DashBoard/Index";
    });
    
}
//--------------------------------------------------------------------------------------------
//---------------------------- / Edit and Change Scripts--------------------------------------



//------------------to Use Dropdown in DropdwnList Working Properly (hide/show change/attributes ..etc)----------
var clicked;
var clickedClassName;

$("#inputID").on('click', function (e) {
    e.stopPropagation();

    setDefaultMyDropDownList();

    changeAcceptButtonStyle();

    var userDiv = document.getElementById("userEditMenu");
    $(userDiv).is(":hidden") ? $(userDiv).show() : $(userDiv).hide();
});

$(document).click(function (event) {
    event.stopPropagation();

    var el = document.getElementById("inputID");
    var myel = document.querySelector("[dir='ltr']");
    var classname = $(myel)[0].className;
    var spanClassName = "select2 select2-container select2-container--bootstrap4 select2-container--below select2-container--open";

    var $target = $(event.target);
    if (!$target.closest('#userEditMenu').length && (clicked != el) && $('#userEditMenu').is(":visible") && (classname != spanClassName)) {
        $('#userEditMenu').hide();
    }
});

document.addEventListener('click', (e) => clicked = e.target);

document.querySelectorAll('.select2').forEach(item => {
    item.setAttribute("onclick", "setClass($(this).attr('class'));");
});

function setClass(className) {
    clickedClassName = className;
};

$(function () {
    $("#branchList").change(function (e) {
        e.preventDefault();
        changeAcceptButtonStyle();
    });
});

function changeAcceptButtonStyle() {
    var selectedValue = $('select[name=mySelection] option').filter(':selected').val();
    var activeBrnchId = document.getElementById("activeUserInfo").getAttribute("userBrnchId");

    selectedValue != 0 && selectedValue != activeBrnchId ? $("#btnAcceptBranch").attr("style", "color: white; background-color:#17a2b8") : $("#btnAcceptBranch").attr("style", "color: lightslategrey; background-color:white");
}

function setDefaultMyDropDownList() {
    $("#branchList").val($("#branchList option:first").val());
    document.getElementById("select2-branchList-container").innerHTML = "Şube Değiştir";
}

//--------------------------------/-------------------------------------



