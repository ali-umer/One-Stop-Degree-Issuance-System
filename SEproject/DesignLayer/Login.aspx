<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Login</title>
    <style>
        body,
        html {
            margin: 0;
            height: 100%;
        }

        .left {
            float: left;
            height: 100%;
            width: 40%;
            text-align: center;
        }

        .right {
            float: right;
            height: 100%;
            width: 60%;
            text-align: center;
        }

        .card-container {
            display: grid;
            justify-content: center;
            align-items: center;
            height: 100%;
            padding: 0 10px;
        }

        .card {
            border: 1px solid;
            width: 100%;
            max-width: 500px;
            height: auto;
            box-shadow: 4px 8px 30px white;
            background-color: white;
            border-radius: 20px;
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            padding: 30px;
        }

        .login-form {
            width: 100%;
            max-width: 400px;
            padding: 20px;
            border-radius: 10px;
            background-color: #f9f9f9;
        }

            .login-form input[type="text"],
            .login-form input[type="password"] {
                width: 90%;
                padding: 15px;
                margin-bottom: 20px;
                border: 1px solid #ccc;
                border-radius: 5px;
                font-size: 16px;
            }


        .loginButton {
            width: 98%;
            padding: 15px;
            border: none;
            border-radius: 5px;
            background-color: #333;
            color: white;
            font-size: 16px;
        }

            .loginButton:hover {
                background-color: #000;
                animation: glow 1s ease-in-out infinite alternate;
            }


        @keyframes glow {
            0% {
                box-shadow: 0 0 10px #333;
            }

            100% {
                box-shadow: 0 0 30px #000;
            }
        }

        .signup-btn {
            text-decoration: none;
            color: #333;
            font-weight: bold;
            font-size: 16px;
            transition: color 0.3s ease;
        }

            .signup-btn:hover {
                color: #0056b3;
            }
    </style>
</head>

<body>
    <div style="height: 100%; background-color: black;">

        <div class="left">
            <div style="height:50px">

            </div>
            <img src="../assets/One Stop Degree Issuance System.png" />
        </div>

        <div class="right">

            <div class="card-container">
                <div class="card">
                    <h1 style="margin-bottom: 80px;">Login</h1>
                    <form class="login-form" runat="server">
                        <input runat="server" type="text" id="username" placeholder="Username" required="required" autocomplete="off"/>
                        <input runat="server" type="password" id="password" placeholder="Password" required="required" autocomplete="off"/>
                        <asp:Button ID="btnLogin" class="loginButton" runat="server" Text="Login" OnClick="loginClicked" />

                    </form>
                    <a class="signup-btn" href="#">Sign Up</a>
                </div>
            </div>

        </div>
    </div>

    <script>
        // JavaScript for responsive design
        window.onresize = function () {
            var card = document.querySelector('.card');
            var cardContainer = document.querySelector('.card-container');
            var cardContainerWidth = cardContainer.offsetWidth;
            var cardWidth = card.offsetWidth;
            if (cardWidth > cardContainerWidth) {
                card.style.width = "100%";
            } else {
                card.style.width = "auto";
            }
        }
    </script>

</body>



</html>

