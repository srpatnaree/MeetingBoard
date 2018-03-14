Imports System.Globalization

Public Class _Default
    Inherits System.Web.UI.Page
    Dim obj As New ClsGetData

    Dim ds As New DataSet
    Dim StepProgress As Double



#Region "BindData"
    Private Sub BindData(roomname)

        obj.RoomName = roomname
        obj.GetMeetingRoom()

        If roomname = "221Leelawadee" Then
            lblRoomName.Text = "221 Leelawadee"
        ElseIf roomname = "222Intanin" Then
            lblRoomName.Text = "222 Intanin"
        ElseIf roomname = "223Hangnokyoong" Then
            lblRoomName.Text = "223 Hangnokyoong"
        ElseIf roomname = "224Jamjuree" Then
            lblRoomName.Text = "224 Jamjuree"
        ElseIf roomname = "225Luangpreeyatorn" Then
            lblRoomName.Text = "225 Luangpreeyatorn"
        ElseIf roomname = "226Fuangfa" Then
            lblRoomName.Text = "226 Fuangfa"
        ElseIf hfRoomName.Value = "227Ratchapruak" Then
            lblRoomName.Text = "227 Ratchapruak"
        ElseIf roomname = "111Puttaraksa" Then
            lblRoomName.Text = "111 Puttaraksa"

        ElseIf roomname = "112Lotus" Then
            lblRoomName.Text = "112 Lotus"
        ElseIf roomname = "113Chompoopantip" Then
            lblRoomName.Text = "113 Chompoopantip"
        ElseIf roomname = "114Sunflower" Then
            lblRoomName.Text = "114 Sunflower"
        ElseIf roomname = "141Jasmine" Then
            lblRoomName.Text = "141 Jasmine"
        ElseIf roomname = "131Thong-Kwaow" Then
            lblRoomName.Text = "131 Thong-Kwaow"
        ElseIf roomname = "132Orchid Then" Then
            lblRoomName.Text = "132 Orchid"
        Else
            lblRoomName.Text = roomname
        End If

        hfBookingNo.Value = obj.CurBookingNo
        lblCurSubject.Text = obj.CurSubject
        lblCurTime.Text = obj.CurStartTime & " - " & obj.CurEndTime & " ( " & GettimeDiff(obj.CurStartTime, obj.CurEndTime) & " )"

        If obj.CurStartTime = String.Empty Then

            divTime.Visible = False

            divRemark.Visible = False
            divConductor.Visible = False
            btnCheckin.Visible = False
            btnCheckout.Visible = False
            lblCountDown.Visible = False
            progressbar.Visible = False


        Else

            divTime.Visible = True
            lblCountDown.Visible = True

            divRemark.Visible = True

        End If

        lblCurConductor1.Text = obj.CurReservationName
        lblCurConductor2.Text = obj.CurDeptID & " Ext. " & obj.CurTelephone

        If obj.CurDeptID = String.Empty Then
            divConductor.Visible = False
        Else
            divConductor.Visible = True
        End If

        lblNextSubject.Text = obj.NextSubject
        lblNextBookDate.Text = String.Format("{0:dddd, MMMM d yy}", obj.NextBookDate)
        lblNextTime.Text = obj.NextStartTime & " - " & obj.NextEndTime
        lblNextInterval.Text = "( " & GettimeDiff(obj.NextStartTime, obj.NextEndTime) & " )"

        If lblNextBookDate.Text = String.Empty Then
            divNextBookDate.Visible = False
        Else
            divNextBookDate.Visible = True
        End If

  

        lblNextConductor1.Text = obj.NextReservationName
        lblNextConductor2.Text = obj.NextDeptID & " Ext. " & obj.NextTelephone

        If lblNextConductor1.Text = String.Empty Then
            divNextConductor.Visible = False
        Else
            divNextConductor.Visible = True
        End If



   

        'lblPrevSubject.Text = obj.PrevSubject
        'lblPrevBookDate.Text = obj.PrevBookDate
        'lblPrevTime.Text = obj.PrevStartTime & " - " & obj.PrevEndTime & " ( " & GettimeDiff(obj.PrevStartTime, obj.PrevEndTime) & " )"

        'If lblPrevBookDate.Text = String.Empty Then
        '    divprevDate.Visible = False

        'End If


        'lblPrevConductor1.Text = obj.PrevReservationName
        'lblPrevConductor2.Text = " ( " & obj.PrevDeptID & " : Tel. " & obj.PrevTelephone & " )"

        'If lblPrevConductor1.Text = String.Empty Then
        '    divPrevConductor.Visible = False
        'End If



        'lblPrevCheckin.Text = "Check in " & obj.PrevCheckin
        'lblPrevCheckout.Text = "Check out " & obj.PrevCheckout

        'Dim timeDiff As String
        'timeDiff = GettimeDiff(obj.PrevEndTime, obj.PrevCheckout)

        'If timeDiff.IndexOf("-") = -1 And timeDiff <> "0" And timeDiff <> "" Then
        '    lblLate.Text = "Over time " & timeDiff
        'End If


        'If obj.PrevCheckin = String.Empty Then
        '    divprevCheckin.Visible = False

        'End If





    End Sub

#End Region

#Region "GettimeDiff"

    Public Function GettimeDiff(StartTime, EndTime) As String

        Dim diff As String = String.Empty
        Dim dateFirst, dateSecond As DateTime
        Dim sDateFrom As String = StartTime
        Dim sDateTo As String = EndTime
        If DateTime.TryParse(sDateFrom, dateFirst) AndAlso DateTime.TryParse(sDateTo, dateSecond) Then
            Dim timespan As TimeSpan = dateSecond - dateFirst
            Dim hour As Integer = timespan.Hours
            Dim mins As Integer = timespan.Minutes

            If hour > 0 Then
                diff = hour.ToString("0") & " hours "
            End If

            If mins > 0 Then

                diff += mins.ToString("0") & " minutes"
            End If


        End If

        Return diff
    End Function

#End Region

#Region "GettimeDiff_Sec"
    Public Function GettimeDiff_Sec(StartTime, EndTime) As String

        Dim diff As String = String.Empty
        Dim dateFirst, dateSecond As DateTime
        Dim sDateFrom As String = StartTime
        Dim sDateTo As String = EndTime
        If DateTime.TryParse(sDateFrom, dateFirst) AndAlso DateTime.TryParse(sDateTo, dateSecond) Then
            Dim timespan As TimeSpan = dateSecond - dateFirst
            Dim hour As Integer = timespan.Hours
            Dim mins As Integer = timespan.Minutes
            Dim sec As Integer = timespan.Seconds

            If hour > 0 Then
                diff = hour.ToString("0") & " hours "
            End If
            If mins > 0 Then
                diff += mins.ToString("0") & " minutes "
            End If

            If sec > 0 Then
                diff += sec.ToString("0") & " seconds"
            End If


        End If



        Return diff
    End Function

#End Region

#Region "CalProgressBar"
    Private Sub CalProgressBar()

        If obj.CurStartTime <> String.Empty Then




            Dim starttime As DateTime = Convert.ToDateTime(obj.CurStartTime)
            Dim endtime As DateTime = Convert.ToDateTime(obj.CurEndTime)
            Dim span As TimeSpan = endtime.Subtract(starttime)
            Dim datetime = New DateTime(span.Ticks).ToString("H:mm")
            Dim Plantime As String = datetime.ToString().Replace(":", ".")
            Dim CalPlantime As Double = Double.Parse(Plantime, CultureInfo.InvariantCulture)

            Dim Curspan As TimeSpan = System.DateTime.Now.Subtract(starttime)
            Dim Curdatetime = New DateTime(Curspan.Ticks).ToString("H:mm")
            Dim Actualtime As String = Curdatetime.ToString().Replace(":", ".")
            Dim CalActualtime As Double = Double.Parse(Actualtime, CultureInfo.InvariantCulture)


            StepProgress = (100 / CalPlantime) * CalActualtime


            progress1.Attributes.Add("style", "width: 5%;")


            If Math.Round(StepProgress, 2) < 100 Then
                progress2.Attributes.Add("style", "width: " & Math.Round(StepProgress, 2) & "%;")
                progressbar.Attributes.Add("style", "width: 90%;")

            ElseIf Math.Round(StepProgress, 2) >= 100 And Math.Round(StepProgress, 2) < 110 Then

                progress2.Attributes.Add("style", "width: 100%;")
                progress3.Attributes.Add("style", "width: " & Math.Round(StepProgress, 2) - 100 & "%;")
                progressbar.Attributes.Add("style", "width: " & 90 + (Math.Round(StepProgress, 2) - 100) & "%;")

            ElseIf Math.Round(StepProgress, 2) >= 110 Then
                progress2.Attributes.Add("style", "width: 100%;")
                progress3.Attributes.Add("style", "width: 10%;")
                progressbar.Attributes.Add("style", "width: 100%;")
            End If
        End If
    End Sub

#End Region

#Region "UpdateData"
    Private Sub UpdateData(BookingNo, CurDate, Action)

        obj.BookingNo = BookingNo
        obj.CurDate = CurDate
        obj.Action = Action
        obj.UpdateData()


        If obj.StrReturn = 2 Then

            ScriptManager.RegisterStartupScript(Me, Me.[GetType](), "alertMessage", "alert('" & obj.errormsg & "');", True)

        Else
            Response.Redirect("Default.aspx?room=" & Request.QueryString("room"))

        End If


    End Sub

#End Region



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        hfRoomName.Value = Request.QueryString("room")
       

        If hfRoomName.Value <> String.Empty Then
            BindData(hfRoomName.Value)

            If obj.CheckIn <> String.Empty Then

                lblCountDown.Text = "Check in at " & obj.CheckIn & ", You have " & GettimeDiff_Sec(DateTime.Now(), obj.CurEndTime) & " to go. "
                progressbar.Visible = True

                btnCheckout.Visible = True
                btnCheckin.Visible = False

            Else

                btnCheckout.Visible = False

                If lblCurSubject.Text <> "Room Avaliable" Then

                    btnCheckin.Visible = True
                End If

            End If
        Else

            lblRoomName.Text = "Avaliable"
            divTime.Visible = False
            divConductor.Visible = False
            'divprevDate.Visible = False
            'divprevCheckin.Visible = False
            'divPrevConductor.Visible = False
            divNextBookDate.Visible = False
            divNextConductor.Visible = False
            btnCheckin.Visible = False
            btnCheckout.Visible = False
            divRemark.Visible = False
            progressbar.Visible = False
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick


       CalProgressBar()
        BindData(hfRoomName.Value)

    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        lblCurDate.Text = String.Format("{0:dddd, MMMM d}", DateTime.Now())
        lblCurCountTime.Text = String.Format("{0:HH:mm:ss}", DateTime.Now())

        ' 15 minutes = rejectbyadmin


        If obj.CheckIn = String.Empty And lblCurSubject.Text <> "Room Avaliable" Then


            If GettimeDiff(obj.CurStartTime, DateTime.Now()) = "15 minutes" Then

                UpdateData(hfBookingNo.Value, DateTime.Now(), "OverTime15")
            End If

        End If

    End Sub

    Protected Sub btnCheckin_Click(sender As Object, e As EventArgs) Handles btnCheckin.Click

        Timer1.Enabled = True
        btnCheckout.Visible = True
        btnCheckin.Visible = False
        progressbar.Visible = True
        UpdateData(hfBookingNo.Value, DateTime.Now(), "CheckIn")


    End Sub

    Protected Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click

        Timer1.Enabled = False
        btnCheckout.Visible = False

        UpdateData(hfBookingNo.Value, DateTime.Now(), "CheckOut")

    End Sub


End Class