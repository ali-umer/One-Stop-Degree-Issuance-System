<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studentComplaints.aspx.cs" Inherits="DesignLayer_Student_studentComplaints" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <title>My Complaints</title>
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
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100%;
        }

        .card {
            width: 600px;
            height: 400px;
            box-shadow: 4px 8px 30px white;
            border-radius: 15px;
            justify-content: center;
            align-items: center;
            background-color: white;
            display: flex;
            flex-direction: column;
            justify-content: flex-start;
            margin: 30px;
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
                height: 60px;
            }

            .form-container select {
                width: 100%;
                padding: 15px;
                margin-bottom: 20px;
                border: 1px solid #ccc;
                border-radius: 5px;
                font-size: 16px;
                background-color: rgba(255, 255, 255, 0.8);
                transition: background-color 0.3s ease;
            }

                .form-container select:focus,
                .form-container input[type="text"]:focus {
                    background-color: #fff;
                    outline: none;
                    border-color: #007bff;
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



        .table-container {
            width: 100%;
            height: auto;
            overflow-y: auto;
        }

        table {
            font-family: arial, sans-serif;
            border-collapse: collapse;
            width: 100%;
        }

        td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 8px;
            width: 33%;
        }

        th {
            background-color: #333;
            color: white;
        }

        tr:nth-child(even) {
            background-color: #ddd;
        }

        tr:hover {
            background-color: #f2f2f2;
        }
    </style>
</head>

<body>
    <div class="left">
        <div class="navbar">
            <img src="../../logo.png">
            <a href="/DesignLayer/Student/studentHome.aspx">Home</a>
            <a href="/DesignLayer/Student/studentDegreeForm.aspx">Degree Form</a>
            <a href="/DesignLayer/Student/studentComplaintForm.aspx">Complaint Form</a>
            <a style="color: black;" href="/DesignLayer/Student/studentComplaints.aspx">My Complaints</a>
            <a href="/DesignLayer/Student/studentTrackActivity.aspx">Track Activity</a>
            <a href="/DesignLayer/Student/studentDataChangeForm.aspx">Data Change Form</a>
            <a href="/DesignLayer/Student/studentFeedbackForm.aspx">Feedback</a>
        </div>
    </div>

    <div class="right">
        <div class="card-container">
            <div class="card">
                <div style="background-color: #333; color: white; width: 100%; border-top-left-radius: 15px; border-top-right-radius: 15px;">
                    <h1>&nbsp;&nbsp;MY COMPLAINTS</h1>
                </div>
                <div class="table-container">
                    <asp:Table ID="dataTable" runat="server">
                        <asp:TableHeaderRow>
                            <asp:TableHeaderCell>Complaint</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Department</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Status</asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                    </asp:Table>
                </div>

            </div>
        </div>
    </div>
</body>
</html>
