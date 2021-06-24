// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your JavaScript code.

type = ['primary', 'info', 'success', 'warning', 'danger'];

site = {
    initPickColor: function () {
        $('.pick-class-label').click(function () {
            var new_class = $(this).attr('new-class');
            var old_class = $('#display-buttons').attr('data-class');
            var display_div = $('#display-buttons');
            if (display_div.length) {
                var display_buttons = display_div.find('.btn');
                display_buttons.removeClass(old_class);
                display_buttons.addClass(new_class);
                display_div.attr('data-class', new_class);
            }
        });
    },

    checkFullPageBackgroundImage: function () {
        $page = $('.full-page');
        image_src = $page.data('image');

        if (image_src !== undefined) {
            image_container = '<div class="full-page-background" style="background-image: url(' + image_src + ') "/>';
            $page.append(image_container);
        }
    },

    initDateTimePicker: function () {
        if ($(".datetimepicker").length !== 0) {
            $('.datetimepicker').datetimepicker({
                icons: {
                    time: "fa fa-clock-o",
                    date: "fa fa-calendar",
                    up: "fa fa-chevron-up",
                    down: "fa fa-chevron-down",
                    previous: 'fa fa-chevron-left',
                    next: 'fa fa-chevron-right',
                    today: 'fa fa-screenshot',
                    clear: 'fa fa-trash',
                    close: 'fa fa-remove'
                }
            });
        }

        if ($(".datepicker").length !== 0) {
            $('.datepicker').datetimepicker({
                format: 'MM/DD/YYYY',
                icons: {
                    time: "fa fa-clock-o",
                    date: "fa fa-calendar",
                    up: "fa fa-chevron-up",
                    down: "fa fa-chevron-down",
                    previous: 'fa fa-chevron-left',
                    next: 'fa fa-chevron-right',
                    today: 'fa fa-screenshot',
                    clear: 'fa fa-trash',
                    close: 'fa fa-remove'
                }
            });
        }

        if ($(".timepicker").length !== 0) {
            $('.timepicker').datetimepicker({
                //          format: 'H:mm',    // use this format if you want the 24hours timepicker
                format: 'h:mm A', //use this format if you want the 12hours timpiecker with AM/PM toggle
                icons: {
                    time: "fa fa-clock-o",
                    date: "fa fa-calendar",
                    up: "fa fa-chevron-up",
                    down: "fa fa-chevron-down",
                    previous: 'fa fa-chevron-left',
                    next: 'fa fa-chevron-right',
                    today: 'fa fa-screenshot',
                    clear: 'fa fa-trash',
                    close: 'fa fa-remove'
                }
            });
        }
    },

    initFullCalendar: function () {
        $calendar = $('#fullCalendar');

        today = new Date();
        y = today.getFullYear();
        m = today.getMonth();
        d = today.getDate();

        $calendar.fullCalendar({
            viewRender: function (view, element) {
                // We make sure that we activate the perfect scrollbar when the view isn't on Month
                if (view.name !== 'month') {
                    $(element).find('.fc-scroller').perfectScrollbar();
                }
            },
            header: {
                left: 'title',
                center: 'month,agendaWeek,agendaDay',
                right: 'prev,next,today'
            },
            defaultDate: today,
            selectable: true,
            selectHelper: true,
            views: {
                month: { // name of view
                    titleFormat: 'MMMM YYYY'
                    // other view-specific options here
                },
                week: {
                    titleFormat: " MMMM D YYYY"
                },
                day: {
                    titleFormat: 'D MMM, YYYY'
                }
            },

            select: function (start, end) {

                // on select we show the Sweet Alert modal with an input
                swal({
                    title: 'Create an Event',
                    html: '<div class="form-group">' +
                        '<input class="form-control" placeholder="Event Title" id="input-field">' +
                        '</div>',
                    showCancelButton: true,
                    confirmButtonClass: 'btn btn-success',
                    cancelButtonClass: 'btn btn-danger',
                    buttonsStyling: false
                }).then(function (result) {

                    var eventData;
                    event_title = $('#input-field').val();

                    if (event_title) {
                        eventData = {
                            title: event_title,
                            start: start,
                            end: end
                        };
                        $calendar.fullCalendar('renderEvent', eventData, true); // stick? = true
                    }

                    $calendar.fullCalendar('unselect');

                });
            },
            editable: true,
            eventLimit: true, // allow "more" link when too many events


            // color classes: [ event-blue | event-azure | event-green | event-orange | event-red ]
            events: [{
                title: 'All Day Event',
                start: new Date(y, m, 1),
                className: 'event-default'
            },
            {
                title: 'Meeting',
                start: new Date(y, m, d - 1, 10, 30),
                allDay: false,
                className: 'event-green'
            },
            {
                title: 'Lunch',
                start: new Date(y, m, d + 7, 12, 0),
                end: new Date(y, m, d + 7, 14, 0),
                allDay: false,
                className: 'event-red'
            },
            {
                title: 'Nud-pro Launch',
                start: new Date(y, m, d - 2, 12, 0),
                allDay: true,
                className: 'event-azure'
            },
            {
                title: 'Birthday Party',
                start: new Date(y, m, d + 1, 19, 0),
                end: new Date(y, m, d + 1, 22, 30),
                allDay: false,
                className: 'event-azure'
            },
            {
                title: 'Click for Creative Tim',
                start: new Date(y, m, 21),
                end: new Date(y, m, 22),
                url: 'http://www.creative-tim.com/',
                className: 'event-orange'
            },
            {
                title: 'Click for Google',
                start: new Date(y, m, 21),
                end: new Date(y, m, 22),
                url: 'http://www.creative-tim.com/',
                className: 'event-orange'
            }
            ]
        });
    },

    showSwal: function (type) {
        if (type === 'basic') {
            swal({
                title: "Here's a message!",
                buttonsStyling: false,
                confirmButtonClass: "btn btn-success"
            }).catch(swal.noop);

        } else if (type === 'title-and-text') {
            swal({
                title: "Here's a message!",
                text: "It's pretty, isn't it?",
                buttonsStyling: false,
                confirmButtonClass: "btn btn-info"
            }).catch(swal.noop);

        } else if (type === 'success-message') {
            swal({
                title: "Good job!",
                text: "You clicked the button!",
                buttonsStyling: false,
                confirmButtonClass: "btn btn-success",
                type: "success"
            }).catch(swal.noop);

        } else if (type === 'warning-message-and-confirmation') {
            swal({
                title: 'Are you sure?',
                text: "You won't be able to revert this!",
                type: 'warning',
                showCancelButton: true,
                confirmButtonClass: 'btn btn-success',
                cancelButtonClass: 'btn btn-danger',
                confirmButtonText: 'Yes, delete it!',
                buttonsStyling: false
            }).then(function () {
                swal({
                    title: 'Deleted!',
                    text: 'Your file has been deleted.',
                    type: 'success',
                    confirmButtonClass: "btn btn-success",
                    buttonsStyling: false
                });
            }).catch(swal.noop);
        } else if (type === 'warning-message-and-cancel') {
            swal({
                title: 'Are you sure?',
                text: 'You will not be able to recover this imaginary file!',
                type: 'warning',
                showCancelButton: true,
                confirmButtonText: 'Yes, delete it!',
                cancelButtonText: 'No, keep it',
                confirmButtonClass: "btn btn-success",
                cancelButtonClass: "btn btn-danger",
                buttonsStyling: false
            }).then(function () {
                swal({
                    title: 'Deleted!',
                    text: 'Your imaginary file has been deleted.',
                    type: 'success',
                    confirmButtonClass: "btn btn-success",
                    buttonsStyling: false
                }).catch(swal.noop);
            }, function (dismiss) {
                // dismiss can be 'overlay', 'cancel', 'close', 'esc', 'timer'
                if (dismiss === 'cancel') {
                    swal({
                        title: 'Cancelled',
                        text: 'Your imaginary file is safe :)',
                        type: 'error',
                        confirmButtonClass: "btn btn-info",
                        buttonsStyling: false
                    }).catch(swal.noop);
                }
            }).catch(swal.noop);

        } else if (type === 'custom-html') {
            swal({
                title: 'HTML example',
                buttonsStyling: false,
                confirmButtonClass: "btn btn-success",
                html: 'You can use <b>bold text</b>, ' +
                    '<a href="http://github.com">links</a> ' +
                    'and other HTML tags'
            }).catch(swal.noop);

        } else if (type === 'auto-close') {
            swal({
                title: "Auto close alert!",
                text: "I will close in 2 seconds.",
                timer: 2000,
                showConfirmButton: false
            }).catch(swal.noop);
        } else if (type === 'input-field') {
            swal({
                title: 'Input something',
                html: '<div class="form-group">' +
                    '<input id="input-field" type="text" class="form-control" />' +
                    '</div>',
                showCancelButton: true,
                confirmButtonClass: 'btn btn-success',
                cancelButtonClass: 'btn btn-danger',
                buttonsStyling: false
            }).then(function (result) {
                swal({
                    type: 'success',
                    html: 'You entered: <strong>' +
                        $('#input-field').val() +
                        '</strong>',
                    confirmButtonClass: 'btn btn-success',
                    buttonsStyling: false

                }).catch(swal.noop);
            }).catch(swal.noop);
        }
    },

    initWizard: function () {
        // Code for the Validator
        var $validator = $('.card-wizard form').validate({
            rules: {
                firstname: {
                    required: true,
                    minlength: 3
                },
                lastname: {
                    required: true,
                    minlength: 3
                },
                email: {
                    required: true,
                    minlength: 3
                }
            },
            highlight: function (element) {
                $(element).closest('.input-group').removeClass('has-success').addClass('has-danger');
            },
            success: function (element) {
                $(element).closest('.input-group').removeClass('has-danger').addClass('has-success');
            }
        });

        // Wizard Initialization
        $('.card-wizard').bootstrapWizard({
            'tabClass': 'nav nav-pills',
            'nextSelector': '.btn-next',
            'previousSelector': '.btn-previous',

            onNext: function (tab, navigation, index) {
                var $valid = $('.card-wizard form').valid();
                if (!$valid) {
                    $validator.focusInvalid();
                    return false;
                }
            },

            onInit: function (tab, navigation, index) {
                //check number of tabs and fill the entire row
                var $total = navigation.find('li').length;
                var $wizard = navigation.closest('.card-wizard');

                first_li = navigation.find('li:first-child a').html();
                $moving_div = $("<div class='moving-tab'></div>");
                $moving_div.append(first_li);
                $('.card-wizard .wizard-navigation').append($moving_div);



                refreshAnimation($wizard, index);

                $('.moving-tab').css('transition', 'transform 0s');
            },

            onTabClick: function (tab, navigation, index) {
                var $valid = $('.card-wizard form').valid();

                if (!$valid) {
                    return false;
                } else {
                    return true;
                }
            },

            onTabShow: function (tab, navigation, index) {
                var $total = navigation.find('li').length;
                var $current = index + 1;

                var $wizard = navigation.closest('.card-wizard');

                // If it's the last tab then hide the last button and show the finish instead
                if ($current >= $total) {
                    $($wizard).find('.btn-next').hide();
                    $($wizard).find('.btn-finish').show();
                } else {
                    $($wizard).find('.btn-next').show();
                    $($wizard).find('.btn-finish').hide();
                }

                button_text = navigation.find('li:nth-child(' + $current + ') a').html();

                setTimeout(function () {
                    $('.moving-tab').html(button_text);
                }, 150);

                var checkbox = $('.footer-checkbox');

                if (!index === 0) {
                    $(checkbox).css({
                        'opacity': '0',
                        'visibility': 'hidden',
                        'position': 'absolute'
                    });
                } else {
                    $(checkbox).css({
                        'opacity': '1',
                        'visibility': 'visible'
                    });
                }

                refreshAnimation($wizard, index);
            }
        });


        // Prepare the preview for profile picture
        $("#wizard-picture").change(function () {
            readURL(this);
        });

        $('[data-toggle="wizard-radio"]').click(function () {
            wizard = $(this).closest('.card-wizard');
            wizard.find('[data-toggle="wizard-radio"]').removeClass('active');
            $(this).addClass('active');
            $(wizard).find('[type="radio"]').removeAttr('checked');
            $(this).find('[type="radio"]').attr('checked', 'true');
        });

        $('[data-toggle="wizard-checkbox"]').click(function () {
            if ($(this).hasClass('active')) {
                $(this).removeClass('active');
                $(this).find('[type="checkbox"]').removeAttr('checked');
            } else {
                $(this).addClass('active');
                $(this).find('[type="checkbox"]').attr('checked', 'true');
            }
        });

        $('.set-full-height').css('height', 'auto');

        //Function to show image before upload

        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();

                reader.onload = function (e) {
                    $('#wizardPicturePreview').attr('src', e.target.result).fadeIn('slow');
                }
                reader.readAsDataURL(input.files[0]);
            }
        }

        $(window).resize(function () {
            $('.card-wizard').each(function () {
                $wizard = $(this);

                index = $wizard.bootstrapWizard('currentIndex');
                refreshAnimation($wizard, index);

                $('.moving-tab').css({
                    'transition': 'transform 0s'
                });
            });
        });

        function refreshAnimation($wizard, index) {
            $total = $wizard.find('.nav li').length;
            $li_width = 100 / $total;

            total_steps = $wizard.find('.nav li').length;
            move_distance = $wizard.width() / total_steps;
            index_temp = index;
            vertical_level = 0;

            mobile_device = $(document).width() < 600 && $total > 3;

            if (mobile_device) {
                move_distance = $wizard.width() / 2;
                index_temp = index % 2;
                $li_width = 50;
            }

            $wizard.find('.nav li').css('width', $li_width + '%');

            step_width = move_distance;
            move_distance = move_distance * index_temp;

            $current = index + 1;

            // if($current == 1 || (mobile_device == true && (index % 2 == 0) )){
            //     move_distance -= 8;
            // } else if($current == total_steps || (mobile_device == true && (index % 2 == 1))){
            //     move_distance += 8;
            // }

            if (mobile_device) {
                vertical_level = parseInt(index / 2);
                vertical_level = vertical_level * 38;
            }

            $wizard.find('.moving-tab').css('width', step_width);
            $('.moving-tab').css({
                'transform': 'translate3d(' + move_distance + 'px, ' + vertical_level + 'px, 0)',
                'transition': 'all 0.5s cubic-bezier(0.29, 1.42, 0.79, 1)'

            });
        }
    },

    initSliders: function () {
        // Sliders for demo purpose in refine cards section
        var slider = document.getElementById('sliderRegular');

        noUiSlider.create(slider, {
            start: 40,
            connect: [true, false],
            range: {
                min: 0,
                max: 100
            }
        });

        var slider2 = document.getElementById('sliderDouble');

        noUiSlider.create(slider2, {
            start: [20, 60],
            connect: true,
            range: {
                min: 0,
                max: 100
            }
        });
    },

    //color 1: blue, 2: green, 3: yellow, 4: red 
    showNotification: function (from, align, color, comment) {
        if (color === "blue") {
            colorType = 1;
        }
        else if (color === "green") {
            colorType = 2;
        }
        else if (color === "yellow") {
            colorType = 3;
        }
        else if (color === "red") {
            colorType = 4;
        }

        $.notify({
            message: comment

        }, {
            type: type[colorType],
            timer: 5000,
            placement: {
                from: from,
                align: align
            }
        });
    },

    showNotificationRandom: function (from, align, comment) {
        color = Math.floor((Math.random() * 4) + 1);

        $.notify({
            message: color

        }, {
            type: type[color],
            timer: 5000,
            placement: {
                from: from,
                align: align
            }
        });
    }

};

$(document).ready(function () {
    $('#datatable').DataTable({
        "order": [[0, "asc"]],
        "pagingType": "numbers",
        "lengthMenu": [
            [25, 50, 75, -1],
            [25, 50, 75, "All"]
        ],
        responsive: true,
        language: {
            search: "_INPUT_",
            searchPlaceholder: "Search records"
        }

    });

    var table = $('#datatable').DataTable();
});


$(document).ready(function () {
    $('#datatablestring').DataTable({
        "pagingType": "numbers",
        "lengthMenu": [
            [25, 50, 75, -1],
            [25, 50, 75, "All"]
        ],
        responsive: true,
        language: {
            search: "_INPUT_",
            searchPlaceholder: "Search records"
        }

    });

    var table = $('#datatablestring').DataTable();
});

// OnLoadMessageBox
$(document).ready(function () {

    var parameter = $("#msgCode").val();

    if (parameter === "1001") {
        site.showNotification('top', 'center', 'blue', '가입이 완료되었습니다.');
    }
    if (parameter === "1002") {
        site.showNotification('top', 'center', 'blue', '정보 변경이 완료되었습니다.');
    }
    if (parameter === "2001") {
        site.showNotification('top', 'center', 'green', '인증이 완료되었습니다. 생성한 계정으로 로그인해주세요.');
    }
    if (parameter === "3001") {
        site.showNotification('top', 'center', 'green', '이메일 변경이 완료되었습니다. 인증을 위해 메일을 확인하세요.');
    }
    if (parameter === "3002") {
        site.showNotification('top', 'center', 'green', '이메일 발송이 완료되었습니다. 인증을 위해 메일을 확인하세요.');
    }
    if (parameter === "3003") {
        site.showNotification('top', 'center', 'green', '비밀번호 변경이 완료되었습니다. 다시 로그인 해주세요.');
    }
    if (parameter === "4002") {
        site.showNotification('top', 'center', 'red', '이메일 발송이 완료되었습니다. 암호 변경을 위해 메일을 확인하세요.');
    }
    if (parameter === "9001") {
        site.showNotification('top', 'center', 'red', '회원 탈퇴처리가 완료되었습니다. 사용해주셔서 감사합니다.');
    }
});

// initialise Datetimepicker and Sliders
$(document).ready(function () {
    site.initDateTimePicker();
    if ($('.slider').length !== 0) {
        site.initSliders();
    }
});


// AutoComplete TextBox 
//$(document).ready(function () {
//    $("search").autocomplete({
//        source: function (request, response) {
//            $.ajax({
//                url: "/Product/ContentSearch",
//                type: "POST",
//                dataType: "json",
//                data: { Prefix: request.term },
//                success: function (data) {
//                    response($.map(data, function (item) {
//                        return { label: item.title, value: item.title };
//                    }))
//                }
//            })
//        },
//        message: {
//            noResult: "", result: ""
//        }
//    }); 
//});

// Trumbowyg Textarea 
//$(".trumbo").trumbowyg({
//    btns: [
//        ['viewHTML'],
//        ['undo', 'redo'], // Only supported in Blink browsers
//        ['formatting'],
//        ['strong', 'em', 'del'],
//        ['superscript', 'subscript'],
//        ['link'],
//        ['insertImage'],
//        ['uploadImage'],
//        ['justifyLeft', 'justifyCenter', 'justifyRight', 'justifyFull'],
//        ['unorderedList', 'orderedList'],
//        ['horizontalRule'],
//        ['removeformat'],
//        ['fullscreen']
//    ]
//});

$('textarea').each(function () {
    this.setAttribute('style', 'height:' + (this.scrollHeight) + 'px;overflow-y:hidden;');
}).on('input', function () {
    this.style.height = 'auto';
    this.style.height = (this.scrollHeight) + 'px';
});