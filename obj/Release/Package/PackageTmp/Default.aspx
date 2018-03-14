<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="MeetingBoard._Default" %>

<!DOCTYPE html>
<html lang="en">

  <head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Meeting Board</title>

    <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="vendor/bootstrap/css/bootstrap-grid.css" rel="stylesheet">
    <!-- Custom styles for this template -->
    <link href="css/blog-post.css" rel="stylesheet">


  </head>

  <body class="bg" >
      

      <form id="form1" runat="server">
          
     <asp:ScriptManager runat="server" id="ScriptManager1">
            </asp:ScriptManager> 
          <asp:Timer runat="server" id="Timer1" Interval="5000" ></asp:Timer>
          <asp:Timer runat="server" id="Timer2" Interval="1000" ></asp:Timer>
            <asp:UpdatePanel runat="server" id="UpdatePanel1">
                   <Triggers>
             <asp:AsyncPostBackTrigger ControlID="Timer1" eventname="Tick"/>
             <asp:AsyncPostBackTrigger ControlID="Timer2" eventname="Tick"/>
        </Triggers>   
            <ContentTemplate>
           

    <!-- Page Content -->
    <div class="container">

      <div class="row">

        <!-- Post Content Column -->
        <div class="col-lg-12">
          <div class="header-shadow">
          <div class="col-55"><asp:Label ID="lblRoomName" runat="server" Font-Size="60px" Font-Bold="true" ></asp:Label>
              <asp:HiddenField ID="hfBookingNo" runat="server" />
              <asp:HiddenField ID="hfRoomName" runat="server" />
              </div>
   <div class="col-45">
          <asp:Label ID="lblCurCountTime" runat="server" Font-Size="54px"></asp:Label>
       <br/>
        <asp:Label ID="lblCurDate" runat="server" Font-Size="20px"></asp:Label>
            </div>
</div>
          <hr>

        
         
        </div>
       
            <div class="col-lg-7" >

          <!-- Post Content -->
              
              <div style="height:130px" >
                  <h2><asp:Label ID="lblCurSubject" runat="server"  Font-Size="56px"></asp:Label>
                      
                  </h2></div>
                    <br />

  <div runat="server" id="divTime"><asp:Label ID="lblCurTime" runat="server" Font-Size="36px" Font-Bold="true"></asp:Label></div>
               
                <br />
                  

   <div class="progress" style="width:90%" id="progressbar" runat="server" visible ="false">
   <div id="progress1" runat="server"  class="progress-bar progress-bar-striped progress-bar-animated bg-transparent" role="progressbar"></div>
  <div id="progress2" runat="server" class="progress-bar progress-bar-striped progress-bar-animated bg-success" role="progressbar"  ></div>
  <div id="progress3" runat="server"  class="progress-bar progress-bar-striped progress-bar-animated bg-danger" role="progressbar" ></div>

              
    
  </div>
          <asp:Label runat="server" id="lblCountDown">
            </asp:Label>
                <br /> 
                 <br />  
                   <div runat="server" id="divConductor" >
                  <div class="col-25" style="font-size:20px"  >Conductor : </div>
                  <div class="col-75"  ><asp:Label runat="server" id="lblCurConductor1"  Font-Size="20px"> </asp:Label></div>
                      <div class="col-25"  ></div>
                  <div class="col-75"  ><asp:Label runat="server" id="lblCurConductor2"  Font-Size="20px">
            </asp:Label></div>
              
                </div>
            
                
    
                <br /> 
      
               <br />   
                   <br /> 
                    <br /> 
                <div style="height:100px" >
                
                    <asp:Button ID="btnCheckin" runat="server" Text="Check In" class="btn btn-success" Height="70px" Width="40%" Font-Size="30px"  />
                    <asp:Button ID="btnCheckout" runat="server" Text="Check Out" class="btn btn-warning" Height="70px" Width="40%" Visible="false" Font-Size="30px" />
                   
                </div>
                 <div  runat="server" id="divRemark" >
                          <asp:Label ID="Label1" runat="server" CssClass="text-danger" Font-Size="18px" Text="* Please check in with in 15 minutes, otherwise you will miss the reservation."></asp:Label>  
                 </div>
                     <hr />
                <asp:Image ID="Image1" runat="server" ImageUrl="~/img/phone-icon.png" />
                &nbsp;General Affair - Bangpoo : 0-2324-6600&nbsp; Ext. 6180</div>
          
                

        <!-- Sidebar Widgets Column -->
        <div class="col-lg-5">


          <!-- Side Widget -->

          <div class="card my-4" style="height:450px">
            <h5 class="card-header"><asp:Label ID="Label2" runat="server" Text="Next Meeting >>" Font-Bold="true"></asp:Label></h5>
            <h6 class="card-body">
                 <div style="height:60px" >
                  <h5><asp:Label ID="lblNextSubject" runat="server" Font-Size="28px"></asp:Label></h5>
         
                  
                </div>
                <br />
                <div runat="server" id="divNextBookDate">
             
                            <div class="col-25" style="font-size:20px">Date : </div>
                  <div class="col-75"><asp:Label ID="lblNextBookDate" runat="server"  Font-Size="20px"></asp:Label></div>
                    <br />   <br />
                   <div class="col-25" style="font-size:20px">Time : </div>
                  <div class="col-75"><asp:Label ID="lblNextTime" runat="server"  Font-Size="20px"></asp:Label></div>
                         <div class="col-25"></div>
                  <div class="col-75"><asp:Label ID="lblNextInterval" runat="server"  Font-Size="20px"></asp:Label></div>
                     </div>  
                
                <br /> <br /><br /><br />
           
            
             <div runat="server" id="divNextConductor">
                  <div class="col-25" style="font-size:18px">Conductor : </div>
                  <div class="col-75"><asp:Label ID="lblNextConductor1" runat="server"  Font-Size="20px"></asp:Label></div>
                     <div class="col-25" ></div>
                  <div class="col-75"><asp:Label ID="lblNextConductor2" runat="server"  Font-Size="20px"></asp:Label></div>
                </div>

               
            </div><br /> <asp:Label ID="Label3" runat="server"  Font-Size="14px" Text="Powered by IT Development." ></asp:Label>
          </div>
           
        </div>

      </div>


        </div>

      </ContentTemplate>
            </asp:UpdatePanel>
          
   
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
	<script type='text/javascript' src="vendor/bootstrap/js/bootstrap-progressbar.js"></script>

         
      </form>

  </body>

</html>

