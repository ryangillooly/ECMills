MyJS = {
    initSidebar: function () {
        $(document).ready(function () {
            jQuery.each(jQuery('.nav').find('li'), function () {
                jQuery(this).toggleClass('active',
                    jQuery(this).find('a').attr('href') == window.location.pathname);
                jQuery('.active').closest('li.dropdown').addClass('active');
                //jQuery('.active').closest('ul').css('display', 'block');
            });

            $sidebar = $('.sidebar');
            $sidebar_img_container = $sidebar.find('.sidebar-background');
            $full_page = $('.full-page');
            $sidebar_responsive = $('body > .navbar-collapse');
            window_width = $(window).width();
            fixed_plugin_open = $('.sidebar .sidebar-wrapper .nav li.active a p').html();
            if (window_width > 767 && fixed_plugin_open == 'Dashboard') {
                if ($('.fixed-plugin .dropdown').hasClass('show-dropdown')) {
                    $('.fixed-plugin .dropdown').addClass('open');
                }
            }
            $('.fixed-plugin a').click(function (event) {
                // Alex if we click on switch, stop propagation of the event, so the dropdown will not be hide, otherwise we set the  section active
                if ($(this).hasClass('switch-trigger')) {
                    if (event.stopPropagation) {
                        event.stopPropagation();
                    } else if (window.event) {
                        window.event.cancelBubble = true;
                    }
                }
            });
            $('.fixed-plugin .active-color span').click(function () {
                $full_page_background = $('.full-page-background');
                $(this).siblings().removeClass('active');
                $(this).addClass('active');
                var new_color = $(this).data('color');
                if ($sidebar.length != 0) {
                    $sidebar.attr('data-color', new_color);
                }
                if ($full_page.length != 0) {
                    $full_page.attr('filter-color', new_color);
                }
                if ($sidebar_responsive.length != 0) {
                    $sidebar_responsive.attr('data-color', new_color);
                }
            });
            $('.fixed-plugin .background-color .badge').click(function () {
                $(this).siblings().removeClass('active');
                $(this).addClass('active');
                var new_color = $(this).data('background-color');
                if ($sidebar.length != 0) {
                    $sidebar.attr('data-background-color', new_color);
                }
            });
            $('.fixed-plugin .img-holder').click(function () {
                $full_page_background = $('.full-page-background');
                $(this).parent('li').siblings().removeClass('active');
                $(this).parent('li').addClass('active');
                var new_image = $(this).find("img").attr('src');
                if ($sidebar_img_container.length != 0 && $('.switch-sidebar-image input:checked').length != 0) {
                    $sidebar_img_container.fadeOut('fast', function () {
                        $sidebar_img_container.css('background-image', 'url("' + new_image + '")');
                        $sidebar_img_container.fadeIn('fast');
                    });
                }
                if ($full_page_background.length != 0 && $('.switch-sidebar-image input:checked').length != 0) {
                    var new_image_full_page = $('.fixed-plugin li.active .img-holder').find('img').data('src');
                    $full_page_background.fadeOut('fast', function () {
                        $full_page_background.css('background-image', 'url("' + new_image_full_page + '")');
                        $full_page_background.fadeIn('fast');
                    });
                }
                if ($('.switch-sidebar-image input:checked').length == 0) {
                    var new_image = $('.fixed-plugin li.active .img-holder').find("img").attr('src');
                    var new_image_full_page = $('.fixed-plugin li.active .img-holder').find('img').data('src');
                    $sidebar_img_container.css('background-image', 'url("' + new_image + '")');
                    $full_page_background.css('background-image', 'url("' + new_image_full_page + '")');
                }
                if ($sidebar_responsive.length != 0) {
                    $sidebar_responsive.css('background-image', 'url("' + new_image + '")');
                }
            });
            $('.switch-sidebar-image input').change(function () {
                $full_page_background = $('.full-page-background');
                $input = $(this);
                if ($input.is(':checked')) {
                    if ($sidebar_img_container.length != 0) {
                        $sidebar_img_container.fadeIn('fast');
                        $sidebar.attr('data-image', '#');
                    }
                    if ($full_page_background.length != 0) {
                        $full_page_background.fadeIn('fast');
                        $full_page.attr('data-image', '#');
                    }
                    background_image = true;
                } else {
                    if ($sidebar_img_container.length != 0) {
                        $sidebar.removeAttr('data-image');
                        $sidebar_img_container.fadeOut('fast');
                    }
                    if ($full_page_background.length != 0) {
                        $full_page.removeAttr('data-image', '#');
                        $full_page_background.fadeOut('fast');
                    }
                    background_image = false;
                }
            });
            $('.switch-sidebar-mini input').change(function () {
                $body = $('body');
                $input = $(this);
                if (md.misc.sidebar_mini_active == true) {
                    $('body').removeClass('sidebar-mini');
                    md.misc.sidebar_mini_active = false;
                    $('.sidebar .sidebar-wrapper, .main-panel').perfectScrollbar();
                } else {
                    $('.sidebar .sidebar-wrapper, .main-panel').perfectScrollbar('destroy');
                    setTimeout(function () {
                        $('body').addClass('sidebar-mini');
                        md.misc.sidebar_mini_active = true;
                    }, 300);
                }
                // we simulate the window Resize so the charts will get updated in realtime.
                var simulateWindowResize = setInterval(function () {
                    window.dispatchEvent(new Event('resize'));
                }, 180);
                // we stop the simulation of Window Resize after the animations are completed
                setTimeout(function () {
                    clearInterval(simulateWindowResize);
                }, 1000);
            });
        });
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
                if (view.name != 'month') {
                    $(element).find('.fc-scroller').perfectScrollbar();
                }
            },
            header: {
                left: 'title',
                center: 'Month,Week,Day',
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
            events: [
                {
                    title: 'All Day Event',
                    start: new Date(y, m, 1),
                    className: 'CalendarItem-Cremation'
                },
                {
                    title: 'Meeting',
                    start: new Date(y, m, d - 1, 10, 30),
                    allDay: false,
                    className: 'CalendarItem-Funeral'
                },
                {
                    title: 'Lunch',
                    start: new Date(y, m, d + 7, 12, 0),
                    end: new Date(y, m, d + 7, 14, 0),
                    allDay: false,
                    className: 'CalendarItem-Cremation'
                },
                {
                    title: 'Nud-pro Launch',
                    start: new Date(y, m, d - 2, 12, 0),
                    allDay: true,
                    className: 'CalendarItem-Funeral'
                },
                {
                    title: 'Birthday Party',
                    start: new Date(y, m, d + 1, 19, 0),
                    end: new Date(y, m, d + 1, 22, 30),
                    allDay: false,
                    className: 'CalendarItem-Funeral'
                },
                {
                    title: 'Click for Creative Tim',
                    start: new Date(y, m, 21),
                    end: new Date(y, m, 22),
                    url: 'http://www.creative-tim.com/',
                    className: 'CalendarItem-Cremation'
                },
                {
                    title: 'Click for Google',
                    start: new Date(y, m, 21),
                    end: new Date(y, m, 22),
                    url: 'http://www.creative-tim.com/',
                    className: 'CalendarItem-Cremation'
                }
            ]
        });
    },

    initMaterialDatatables: function () {
        $('.datatables').DataTable({
            "pagingType": "full_numbers",
            "lengthMenu": [
                [10, 25, 50, -1],
                [10, 25, 50, "All"]
            ],
            responsive: true,
            language: {
                search: "_INPUT_",
                searchPlaceholder: "Search records",
            }
        });

        var table = $('.datatables').DataTable();

        // Edit record
        table.on('click', '.edit', function () {
            $tr = $(this).closest('tr');
            var data = table.row($tr).data();
            alert('You press on Row: ' + data[0] + ' ' + data[1] + ' ' + data[2] + '\'s row.');
        });

        // Delete a record
        table.on('click', '.remove', function (e) {
            $tr = $(this).closest('tr');
            table.row($tr).remove().draw();
            e.preventDefault();
        });
    },

    initCalculateMapRoute: function() {
    
        /********************* Single Map *********************
        var to = new google.maps.LatLng(51.525471, 0.016910);
        var mapOptions = {
            zoom: 15,
            center: to,
            scrollwheel: false,
        }

        var map = new google.maps.Map(document.getElementById("destinationMap"), mapOptions);
        var marker = new google.maps.Marker({
            position: to,
            title: "Destination"
        });

        marker.setMap(map);
        */
        //********************* Route Calculation Map *********************//
        var from = new google.maps.LatLng(51.508469, -0.267600);
        var to = new google.maps.LatLng(51.525471, 0.016910);
        var directionsDisplay = new google.maps.DirectionsRenderer;
        var directionsService = new google.maps.DirectionsService;
        var map = new google.maps.Map(document.getElementById('estimatedRouteMap'), {
            zoom: 10,
            center: from,
            scrollwheel: false
        });

        directionsDisplay.setMap(map);

        calculateAndDisplayRoute(directionsService, directionsDisplay);

        function calculateAndDisplayRoute(directionsService, directionsDisplay) {
            directionsService.route({
                origin: from,
                destination: to,
                travelMode: 'DRIVING'
            },
            function (response, status) {
                if (status === 'OK') {
                    directionsDisplay.setDirections(response);
                    directionsDisplay.setPanel(document.getElementById('right-panel'));
                } else {
                    window.alert('Directions request failed due to ' + status);
                }
            });
        }
    },

    GetDeceasedContactsDetails: function(ContactType, Relationship, Name, DOB, Occupation, AccountsModerator, Address, Notes)
    {
        $("#ContactType").empty();
        $("#Relationship").empty();
        $("#Name").empty();
        $("#DOB").empty();
        $("#Occupation").empty();
        $("#AccountsModerator").empty();
        $("#Address").empty();
        $("#Notes").empty();

        $('#ContactType').append(ContactType);
        $("#Relationship").append(Relationship);
        $("#Name").append(Name);
        $("#DOB").append(DOB);
        $("#Occupation").append(Occupation);
        $('#AccountsModerator').append(AccountsModerator);
        $('#Address').append(Address);
        $('#Notes').append(Notes);
    },

    GetDeceasedAddressDetails: function(AddressType, AddressLine1, AddressLine2, City, PostCode, ContactName, ContactNo)
     {
        $("#AddressType").empty();
        $("#AddressLine1").empty();
        $("#AddressLine2").empty();
        $("#City").empty();
        $("#PostCode").empty();
        $("#ContactName").empty();
        $("#ContactPoints").empty();

        $('#AddressType').append(AddressType);
        $("#AddressLine1").append(AddressLine1);
        $("#AddressLine2").append(AddressLine2);
        $("#City").append(City);
        $("#PostCode").append(PostCode);
        $('#ContactName').append(ContactName);
        $('#ContactPoints').append(ContactNo);
    },
}

/* POTENTIALLY NOT USED. EXCLUDING UNTIL CONFIRMED TO DELETE - 07/07/19
   EditDeceasedProfile: function(Name, Known_As, Gender, Age, DOB, TimeOfDeath, MaritalStatus, Occupation, Religion, ReligiousDenomination)
   {
       // Redo this section by passing an array as the variable with all the values
       // Then loop through the array values and run dynamic JS to replace the div's
       $('#ReadOnlyInput-Name').replaceWith('<input name="Name"            id="ReadWriteInput-Name"          type="text" class="form-control" placeholder="' + Name + '" />');
       $('#ReadOnlyInput-Known_As').replaceWith('<input name="Known_As"        id="ReadWriteInput-Known_As"      type="text" class="form-control" placeholder="' + Known_As + '" />');
       $('#ReadOnlyInput-Gender').replaceWith('<input name="Gender"          id="ReadWriteInput-Gender"        type="text" class="form-control" placeholder="' + Gender + '" />');
       $('#ReadOnlyInput-Age').replaceWith('<input name="Age"             id="ReadWriteInput-Age"           type="text" class="form-control" placeholder="' + Age + '" />');
       $('#ReadOnlyInput-DOB').replaceWith('<input name="DOB"             id="ReadWriteInput-DOB"           type="text" class="form-control datetimepicker" placeholder="' + DOB + '" />');
       $('#ReadOnlyInput-TimeOfDeath').replaceWith('<input name="TimeOfDeath"     id="ReadWriteInput-TimeOfDeath"   type="text" class="form-control datetimepicker" placeholder="' + TimeOfDeath + '" />');
       $('#ReadOnlyInput-MaritalStatus').replaceWith('<input name="MaritalStatus"   id="ReadWriteInput-MaritalStatus" type="text" class="form-control" placeholder="' + MaritalStatus + '" />');
       $('#ReadOnlyInput-Occupation').replaceWith('<input name="Occupation"      id="ReadWriteInput-Occupation"    type="text" class="form-control" placeholder="' + Occupation + '" />');
       $('#ReadOnlyInput-Religion').replaceWith('<input name="Religion"        id="ReadWriteInput-Religion"      type="text" class="form-control" placeholder="' + Religion + '" />');
       $('#ReadOnlyInput-RelDom').replaceWith('<input name="RelDom"          id="ReadWriteInput-RelDom"        type="text" class="form-control" placeholder="' + ReligiousDenomination + '" />');

       $('#EditProfile_Button').replaceWith('<button type="button" id="CancelDeceasedProfileEdit_Button" class="btn btn-primary pull-left col-md-3" onclick="CancelDeceasedProfileEdit(\'' + Name + '\',\'' + Known_As + '\',\'' + Gender + '\',\'' + Age + '\',\'' + DOB + '\',\'' + TimeOfDeath + '\',\'' + MaritalStatus + '\',\'' + Occupation + '\',\'' + Religion + '\',\'' + ReligiousDenomination + '\')">Cancel</button>');

       $('#UpdateProfileDiv').append('<input type="submit" class="btn btn-primary pull-right col-md-3" />')

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
   },

   CancelDeceasedProfileEdit: function (Name, Known_As, Gender, Age, DOB, TimeOfDeath, MaritalStatus, Occupation, Religion, ReligiousDenomination)
   {
       // backslash + quote is an escape character for single quote (e.g  \' )
       $('#ReadWriteInput-Name').replaceWith('<div class="form-control" id="ReadOnlyInput-Name">' + Name + '</div>');
       $('#ReadWriteInput-Known_As').replaceWith('<div class="form-control" id="ReadOnlyInput-Known_As">' + Known_As + '</div>');
       $('#ReadWriteInput-Gender').replaceWith('<div class="form-control" id="ReadOnlyInput-Gender">' + Gender + '</div>');
       $('#ReadWriteInput-Age').replaceWith('<div class="form-control" id="ReadOnlyInput-Age">' + Age + '</div>');
       $('#ReadWriteInput-DOB').replaceWith('<div class="form-control" id="ReadOnlyInput-DOB">' + DOB + '</div>');
       $('#ReadWriteInput-TimeOfDeath').replaceWith('<div class="form-control" id="ReadOnlyInput-TimeOfDeath">' + TimeOfDeath + '</div>');
       $('#ReadWriteInput-MaritalStatus').replaceWith('<div class="form-control" id="ReadOnlyInput-MaritalStatus">' + MaritalStatus + '</div>');
       $('#ReadWriteInput-Occupation').replaceWith('<div class="form-control" id="ReadOnlyInput-Occupation">' + Occupation + '</div>');
       $('#ReadWriteInput-Religion').replaceWith('<div class="form-control" id="ReadOnlyInput-Religion">' + Religion + '</div>');
       $('#ReadWriteInput-RelDom').replaceWith('<div class="form-control" id="ReadOnlyInput-RelDom">' + ReligiousDenomination + '</div>');

       $('#CancelDeceasedProfileEdit_Button').replaceWith('<button type="button" id="EditProfile_Button" class="btn btn-primary pull-left col-md-3" onclick="EditDeceasedProfile(\'' + Name + '\',\'' + Known_As + '\',\'' + Gender + '\',\'' + Age + '\',\'' + DOB + '\',\'' + TimeOfDeath + '\',\'' + MaritalStatus + '\',\'' + Occupation + '\',\'' + Religion + '\',\'' + ReligiousDenomination + '\')">Edit Profile</button>');
       $('#UpdateProfileDiv').empty();
   }
   */