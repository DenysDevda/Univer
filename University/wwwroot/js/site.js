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
    $("#addprofessor").on('click', function () {
        var firstname = prompt("Add first name");
        var lastname = prompt("Add last name");
        var coursename = prompt("Add course name")
        var coursenumber = prompt("Add course number")
        var subjectname = prompt("Add subject name")
        var bribeprice = prompt("Add Bribe Price")
        $.ajax({
            url: '/Teacher/AddNewTeacher',
            data: {
                FirstName: firstname,
                LastName: lastname,
                TeachersType: "Professor",
                CourseName: coursename,
                CourseNumber: coursenumber,
                SubjectName: subjectname,
                BribePrice: bribeprice
            },
            type: 'POST',
            success: function () {
                alert("Professor added successfully!")
            },
            error: function () {
                alert("Professor not added,try again!")
            }
        });
    });
});

$(document).ready(function () {
    $("#removeprofessor").on('click', function () {
        var id = prompt("Add id");

        $.ajax({
            url: '/Teacher/RemoveTeacher',
            data: {
                teacherid: id
            },
            type: 'POST',
            success: function () {
                alert("Professor remove successfully!")
            },
            error: function () {
                +
                    alert("Professor not remove,try again!")
            }
        });
    });
});

$(document).ready(function () {
    $("#addcandidat").on('click', function () {
        var firstname = prompt("Add Firstname");
        var lastname = prompt("Add Lastname");
        var coursename = prompt("Add course name")
        var coursenumber = prompt("Add course number")
        var subjectname = prompt("Add subject name")
        var bribeprice = prompt("Add Bribe Price")
        $.ajax({
            url: '/Teacher/AddNewTeacher',
            data: {
                FirstName: firstname,
                LastName: lastname,
                TeachersType: "Science Candidate",
                CourseName: coursename,
                CourseNumber: coursenumber,
                SubjectName: subjectname,
                BribePrice: bribeprice
            },
            type: 'POST',
            success: function () {
                alert("Science Candidate added successfully!")
            },
            error: function () {
                alert("Science Candidate not added,try again!")
            }
        });
    });
});

$(document).ready(function () {
    $("#removecandidat").on('click', function () {
        var id = prompt("Add id");

        $.ajax({
            url: '/Teacher/RemoveTeacher',
            data: {
                teacherid: id
            },
            type: 'POST',
            success: function () {
                alert("Science Cadidate remove successfully!")
            },
            error: function () {
                +
                    alert("Science Cadidate not remove,try again!")
            }
        });
    });
});

$(document).ready(function () {
    $("#addaspirant").on('click', function () {
        var firstname = prompt("Add Firstname");
        var lastname = prompt("Add Lastname");
        var coursename = prompt("Add course name")
        var coursenumber = prompt("Add course number")
        var subjectname = prompt("Add subject name")
        var bribeprice = prompt("Add Bribe Price")
        $.ajax({
            url: '/Teacher/AddNewTeacher',
            data: {
                FirstName: firstname,
                LastName: lastname,
                TeachersType: "Aspirant",
                CourseName: coursename,
                CourseNumber: coursenumber,
                SubjectName: subjectname,
                BribePrice: bribeprice
            },
            type: 'POST',
            success: function () {
                alert("Aspirant added successfully!")
            },
            error: function () {
                alert("Aspirant not added,try again!")
            }
        });
    });
});

$(document).ready(function () {
    $("#removeaspirant").on('click', function () {
        var id = prompt("Add id");

        $.ajax({
            url: '/Teacher/RemoveTeacher',
            data: {
                teacherid: id
            },
            type: 'POST',
            success: function () {
                alert("Aspirant remove successfully!")
            },
            error: function () {
                +
                    alert("Aspirant not remove,try again!")
            }
        });
    });
});

$(document).ready(function () {

    $("#pchangecoursename").on('click', function () {
        var coursename = prompt("Enter course name");
        var id = $(this).data("id");
        $.ajax({
            url: '/Teacher/ChangeCourseName',
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

    $("#changecoursenumber").on('click', function () {
        var coursenumber = prompt("Enter course number");
        var id = $(this).data("id");
        $.ajax({
            url: '/Teacher/ChangeCourseNumber',
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

