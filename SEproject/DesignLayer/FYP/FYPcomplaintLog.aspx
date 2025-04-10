<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FYPcomplaintLog.aspx.cs" Inherits="DesignLayer_FYP_FYPcomplaintLog" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Complaint Log</title>
    <style>
        body,
        html {
            margin: 0;
            height: 100%;
            background-image: url('../../FAST_Islamabad.jpg');
            background-size: cover;
            background-position: center;
        }

        .card p {
            display: inline-block;
            margin-right: 50px;
            font-size: 15px;
            font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
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
                margin-top: 13%;
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
            padding: 0 10px;
        }

        .card {
            width: 800px;
            height: 400px;
            box-shadow: 4px 8px 30px white;
            border-radius: 15px;
            justify-content: center;
            align-items: center;
            background-color: white;
            display: flex;
            flex-direction: column;
            justify-content: flex-start;
            overflow: hidden;
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
            width: 25%;
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
    </style>
</head>
<body>
    <div class="left">
        <div class="navbar">
            <img src="../../assets/logo.png">
            <a href="/DesignLayer/FYP/FYPhome.aspx">Home</a>
            <a href="/DesignLayer/FYP/FYPrequestLog.aspx">Request Log</a>
            <a href="/DesignLayer/FYP/FYPrequestStats.aspx">Request Stats</a>
            <a href="/DesignLayer/FYP/FYPineligible.aspx">Ineligible Students</a>
            <a style="color: skyblue;" href="/DesignLayer/FYP/FYPcomplaintLog.aspx">Complaint Log</a>
        </div>
    </div>

    <div class="right">
        <div class="card-container">
            <div style="height: 10px"></div>

            <div class="card">
                <div style="background-color: #333; color: white; width: 100%; border-top-left-radius: 15px; border-top-right-radius: 15px;">
                    <h1>&nbsp;&nbsp;COMPLAINT LOG</h1>
                </div>
                <div class="table-container">
                    <form runat="server">
                        <asp:Table ID="dataTable" runat="server">
                            <asp:TableHeaderRow>
                                <asp:TableHeaderCell>ID</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Complaint</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Status</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Action</asp:TableHeaderCell>

                            </asp:TableHeaderRow>
                        </asp:Table>
                    </form>
                </div>
            </div>
        </div>
    </div>


</body>
</html>


