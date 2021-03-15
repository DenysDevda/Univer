$(document).ready(function () {

    $("#search").on('click', function () { 
        var subjectname = prompt("Add new subject");
        var subjectmark = prompt("Add mark");
        var studentid = $(this).data("id");
        $.ajax({
            url: '/Student/AddSubject',
            data: {
                SubjectName: subjectname,
                SubjectMark: subjectmark,
                StudentId: studentid
            },
            type: 'POST',
            success: function (data) {
                alert(data)
            },
            error: function (data) {
                alert(data)
            }
        });
    });

});

$(document).ready(function () {

    $("#change").on('click', function () {
        var subjectname = prompt("Enter subject");
        var subjectmark = prompt("change mark");
        var studentid = $(this).data("id");
        $.ajax({
            url: '/Student/ChangeMark',
            data: {
                SubjectName: subjectname,
                SubjectMark: subjectmark,
                StudentId: studentid
            },
            type: 'POST',
            success: function () {
                alert("Mark changed successfully!")
            },
            error: function () {
                alert("Mark not changed,try again!")
            }
        });
    });

});



$(document).ready(function () {

    $("#changecourse").on('click', function () {
        var coursenumber = prompt("Enter course number");
        var id = $(this).data("id");
        $.ajax({
            url: '/Student/ChangeCourseNumber',
            data: {
                CourseNumber: coursenumber,
                id: id
            },
            type: 'POST',
            success: function () {
                alert("Course changed successfully!")
            },
            error: function () {
                alert("Course not changed,try again!")
            }
        });
    });

});


$(document).ready(function () {

    $("#changecoursename").on('click', function () {
        var coursename = prompt("Enter course name");
        var id = $(this).data("id");
        $.ajax({
            url: '/Student/ChangeCourseName',
            data: {
                CourseName: coursename,
                id: id
            },
            type: 'POST',
            success: function () {
                alert("Course name changed successfully!")
            },
            error: function () {
                alert("Course name not changed,try again!")
            }
        });
    });

});

$(document).ready(function () {
    $("#addstudent").on('click', function () {
        var firstname = prompt("Add Firstname");
        var lastname = prompt("Add Lastname");
        var coursename = prompt("Add Coursename");
        var coursenumber = prompt("Add Coursenumber");
        $.ajax({
            url: '/Student/AddNewStudent',
            data: {
                FirstName: firstname,
                LastName: lastname,
                CourseName: coursename,
                CourseNumber: coursenumber
            },
            type: 'POST',
            success: function () {
                alert("Student added successfully!")
            },
            error: function () {
                alert("Student not added,try again!")
            }
        });
    });
});

$(document).ready(function () {
    $("#remstudent").on('click', function () {
        var id = prompt("Add id");

        $.ajax({
            url: '/Student/RemoveStudent',
            data: {
                studentid: id
            },
            type: 'POST',
            success: function () {
                alert("Student remove successfully!")
            },
            error: function () {
                +
                alert("Student not remove,try again!")
            }
        });
    });
});

$(document).ready(function () {

    $("#remove").on('click', function () {
        var subjectname = prompt("Enter subject");
        var studentid = $(this).data("id");
        $.ajax({
            url: '/Student/RemoveSubject',
            data: {
                SubjectName: subjectname,
                StudentId: studentid
            },
            type: 'POST',
            success: function () {
                alert("Subject remove successfully!")
            },
            error: function () {
                +
                    alert("Subject not remove,try again!")
            }
        });
    });

});

$(document).ready(function () {
    $("#addteacher").on('click', function () {
        var firstname = prompt("Add Firstname");
        var lastname = prompt("Add Lastname");
        var subject = prompt("Add Subject");
        $.ajax({
            url: '/Teacher/AddNewTeacher',
            data: {
                FirstName: firstname,
                LastName: lastname,
                Subject: subject
            },
            type: 'POST',
            success: function () {
                alert("Teacher added successfully!")
            },
            error: function () {
                alert("Teacher not added,try again!")
            }
        });
    });
});