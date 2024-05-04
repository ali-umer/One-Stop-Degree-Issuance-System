<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studentDegreeForm.aspx.cs" Inherits="DesignLayer_Student_studentDegreeForm" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <title>Degree Generation Form</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <style>
        body,
        html {
            margin: 0;
            height: 100%;
            background-image: url('../../FAST_Islamabad.jpg');
            background-size: cover;
            background-position: center;
        }


        .left {
            float: left;
            height: 100%;
            width: 15%;
            text-align: center;
            position: relative;
        }

        .right {
            float: right;
            height: 100%;
            width: 85%;
            text-align: center;
        }

        .navbar {
            position: absolute;
            left: 0;
            top: 0;
            bottom: 0;
            width: 100%;
            background-color: #333;
            padding: 10%;
            overflow-y: auto;
            z-index: 100;
            box-shadow: 2px 2px 40px rgba(255, 255, 255, 0.5);
        }

            .navbar a {
                display: block;
                color: white;
                text-decoration: none;
                border-radius: 10px;
                padding: 5% 0;
                margin-top: 7%;
                font-size: x-large;
                font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
                position: relative;
                overflow: hidden;
                transition: all 0.3s ease-in-out;
            }


                .navbar a:hover {
                    transform: translateY(-10px);
                    background-color: rgba(128, 128, 128, 0.5);
                    border-radius: 20px;
                }

        .card-container {
            display: grid;
            justify-content: center;
            align-items: center;
            height: 100%;
        }

        .card {
            width: 500px;
            height: 450px;
            box-shadow: 4px 8px 30px white;
            border-radius: 15px;
            justify-content: center;
            align-items: center;
            background-color: white;
            display: flex;
            flex-direction: column;
            justify-content: flex-start;
        }


        @keyframes glow {
            0% {
                box-shadow: 0 0 10px #333;
            }

            100% {
                box-shadow: 0 0 30px #000;
            }
        }

        img {
            height: 21%;
            width: 70%;
        }

        .form-container {
            width: 100%;
            height: auto;
            max-width: 400px;
            padding: 15%;
            border-radius: 10px;
        }


            .form-container input[type="text"] {
                width: 92%;
                padding: 15px;
                margin-bottom: 20px;
                border: 1px solid #ccc;
                border-radius: 5px;
                font-size: 16px;
            }

        .submitButton {
            width: 100%;
            padding: 15px;
            border: none;
            border-radius: 5px;
            background-color: #333;
            color: white;
            font-size: 16px;
            cursor: pointer;
        }

            .submitButton:hover {
                background-color: #000;
            }


        h1 {
            font-size: 26px;
        }
    </style>
</head>
<body>
    <div class="left">
        <div class="navbar">
            <img src="../../logo.png">
            <a href="/DesignLayer/Student/studentHome.aspx">Home</a>
            <a style="color: skyblue;" href="/DesignLayer/Student/studentDegreeForm.aspx">Degree Form</a>
            <a href="studentComplaintForm.aspx">Complaint Form</a>
            <a href="/DesignLayer/Student/studentComplaints.aspx">My Complaints</a>
            <a href="/DesignLayer/Student/studentTrackActivity.aspx">Track Activity</a>
            <a href="/DesignLayer/Student/studentDataChangeForm.aspx">Data Change Form</a>
            <a href="/DesignLayer/Student/studentFeedbackForm.aspx">Feedback</a>
        </div>
    </div>

    <div class="right">
        <div class="card-container">
            <div class="card">
                <div style="background-color: #333; color: white; width: 100%; border-top-left-radius: 15px; border-top-right-radius: 15px;">
                    <h1>&nbsp;&nbsp;DEGREE ISSUANCE FORM</h1>
                </div>
                <div class="form-container">
                    <form runat="server">
                        <input runat="server" type="text" id="name" placeholder="Name" required disabled>
                        <input runat="server" type="text" id="roll" placeholder="Roll no" required disabled>
                        <input runat="server" type="text" id="batch" placeholder="Batch" required disabled>
                        <asp:Button class="submitButton" runat="server" Text="Initiate Request" OnClick="RequestInitiated"></asp:Button>

                    </form>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
