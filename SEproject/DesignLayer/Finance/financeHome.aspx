<%@ Page Language="C#" AutoEventWireup="true" CodeFile="financeHome.aspx.cs" Inherits="DesignLayer_Finance_financeHome" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Home</title>
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
            margin-bottom: 40px;
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
            height: 250px;
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

        .logout-btn {
            position: absolute;
            top: 30px;
            right: 80px;
            color: #fff;
            font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
            background-color: #333;
            border: none;
            padding: 10px 20px;
            font-size: 16px;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

            .logout-btn:hover {
                background-color: #c82333;
            }
    </style>
</head>
<body>
    <div class="left">
        <div class="navbar">
            <img src="../../assets/logo.png">
            <a style="color: skyblue;" href="/DesignLayer/Finance/financeHome.aspx">Home</a>
            <a href="/DesignLayer/Finance/financeOutstandingDues.aspx">Outstanding Dues</a>
            <a href="/DesignLayer/Finance/financeDegreeFee.aspx">Degree Issuance Fee Status</a>
            <a href="/DesignLayer/Finance/financeRequestLog.aspx">Request Log</a>
        </div>
    </div>

    <div class="right">
        <a class="logout-btn" href="/DesignLayer/Login.aspx">Logout</a>

        <div class="card-container">
            <div style="height: 10px"></div>

            <div class="card">
                <div style="background-color: #333; color: white; width: 100%; border-top-left-radius: 15px; border-top-right-radius: 15px; text-align: left">
                    <h1>&nbsp;&nbsp;PERSONAL DETAILS</h1>
                </div>
                <div>
                    <br />
                    <p runat="server" id="name"></p>
                    <p runat="server" id="DOB"></p>
                    <p runat="server" id="CNIC"></p>
                    <p runat="server" id="campus"></p>

                    <br />

                    <p runat="server" id="bloodGroup"></p>
                    <p runat="server" id="gender"></p>
                    <p runat="server" id="nationality"></p>
                    <p runat="server" id="contact"></p>
                </div>
            </div>

        </div>

    </div>

</body>
</html>


