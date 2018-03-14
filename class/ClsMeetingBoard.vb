Imports System.Data.SqlClient
Imports ConnectBookingRoomDB
Imports System.Data

Public Class ClsGetData

    Public RoomName As String
    Public CurBookingNo As String
    Public CurSubject As String
    Public CurBookDate As String
    Public CurStartTime As String
    Public CurEndTime As String
    Public CurReservationName As String
    Public CurDeptID As String
    Public CurTelephone As String
    Public PrevSubject As String
    Public PrevBookDate As String
    Public PrevStartTime As String
    Public PrevEndTime As String
    Public PrevReservationName As String
    Public PrevDeptID As String
    Public PrevTelephone As String
    Public PrevCheckin As String
    Public PrevCheckout As String
    Public NextSubject As String
    Public NextBookDate As String
    Public NextStartTime As String
    Public NextEndTime As String
    Public NextReservationName As String
    Public NextDeptID As String
    Public NextTelephone As String

    Public Action As String
    Public BookingNo As String
    Public CheckIn As String
    Public CheckOut As String
    Public CurDate As String
    Public errormsg As String
    Public StrReturn As String


#Region "GetMeetingRoom"
    Public Sub GetMeetingRoom()

        Dim obj As New ClassConBookingRoomDB
        Dim Conn As New SqlConnection
        Dim cmd As New SqlCommand


        Try
            obj.SqlConnBookingRoomDB(Conn)

            cmd.Connection = Conn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Sp_GetMeetingBoard"
            cmd.CommandTimeout = 0
            cmd.Parameters.Clear()


            If RoomName <> "" Then
                cmd.Parameters.Add(New SqlParameter("@RoomName", Data.SqlDbType.NVarChar)).Value = RoomName
            Else
                cmd.Parameters.Add(New SqlParameter("@RoomName", Data.SqlDbType.NVarChar)).Value = DBNull.Value
            End If

            cmd.Parameters.Add("@CurBookingNo", SqlDbType.VarChar, 500)
            cmd.Parameters("@CurBookingNo").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@CurSubject", SqlDbType.VarChar, 500)
            cmd.Parameters("@CurSubject").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@CurBookDate", SqlDbType.VarChar, 500)
            cmd.Parameters("@CurBookDate").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@CurStartTime", SqlDbType.VarChar, 500)
            cmd.Parameters("@CurStartTime").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@CurEndTime", SqlDbType.VarChar, 500)
            cmd.Parameters("@CurEndTime").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@CurReservationName", SqlDbType.VarChar, 500)
            cmd.Parameters("@CurReservationName").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@CurDeptID", SqlDbType.VarChar, 500)
            cmd.Parameters("@CurDeptID").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@CurTelephone", SqlDbType.VarChar, 500)
            cmd.Parameters("@CurTelephone").Direction = ParameterDirection.Output


            'cmd.Parameters.Add("@PrevSubject", SqlDbType.VarChar, 500)
            'cmd.Parameters("@PrevSubject").Direction = ParameterDirection.Output

            'cmd.Parameters.Add("@PrevBookDate", SqlDbType.VarChar, 500)
            'cmd.Parameters("@PrevBookDate").Direction = ParameterDirection.Output

            'cmd.Parameters.Add("@PrevStartTime", SqlDbType.VarChar, 500)
            'cmd.Parameters("@PrevStartTime").Direction = ParameterDirection.Output

            'cmd.Parameters.Add("@PrevEndTime", SqlDbType.VarChar, 500)
            'cmd.Parameters("@PrevEndTime").Direction = ParameterDirection.Output

            'cmd.Parameters.Add("@PrevReservationName", SqlDbType.VarChar, 500)
            'cmd.Parameters("@PrevReservationName").Direction = ParameterDirection.Output

            'cmd.Parameters.Add("@PrevDeptID", SqlDbType.VarChar, 500)
            'cmd.Parameters("@PrevDeptID").Direction = ParameterDirection.Output

            'cmd.Parameters.Add("@PrevTelephone", SqlDbType.VarChar, 500)
            'cmd.Parameters("@PrevTelephone").Direction = ParameterDirection.Output

            'cmd.Parameters.Add("@PrevCheckin", SqlDbType.VarChar, 500)
            'cmd.Parameters("@PrevCheckin").Direction = ParameterDirection.Output

            'cmd.Parameters.Add("@PrevCheckout", SqlDbType.VarChar, 500)
            'cmd.Parameters("@PrevCheckout").Direction = ParameterDirection.Output


            cmd.Parameters.Add("@NextSubject", SqlDbType.VarChar, 500)
            cmd.Parameters("@NextSubject").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@NextBookDate", SqlDbType.VarChar, 500)
            cmd.Parameters("@NextBookDate").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@NextStartTime", SqlDbType.VarChar, 500)
            cmd.Parameters("@NextStartTime").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@NextEndTime", SqlDbType.VarChar, 500)
            cmd.Parameters("@NextEndTime").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@NextReservationName", SqlDbType.VarChar, 500)
            cmd.Parameters("@NextReservationName").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@NextDeptID", SqlDbType.VarChar, 500)
            cmd.Parameters("@NextDeptID").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@NextTelephone", SqlDbType.VarChar, 500)
            cmd.Parameters("@NextTelephone").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@CheckIn", SqlDbType.VarChar, 500)
            cmd.Parameters("@CheckIn").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@CheckOut", SqlDbType.VarChar, 500)
            cmd.Parameters("@CheckOut").Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()

            CurBookingNo = cmd.Parameters("@CurBookingNo").Value
            CurSubject = cmd.Parameters("@CurSubject").Value
            CurBookDate = cmd.Parameters("@CurBookDate").Value
            CurStartTime = cmd.Parameters("@CurStartTime").Value
            CurEndTime = cmd.Parameters("@CurEndTime").Value
            CurReservationName = cmd.Parameters("@CurReservationName").Value
            CurDeptID = cmd.Parameters("@CurDeptID").Value
            CurTelephone = cmd.Parameters("@CurTelephone").Value
            'PrevSubject = cmd.Parameters("@PrevSubject").Value
            'PrevBookDate = cmd.Parameters("@PrevBookDate").Value
            'PrevStartTime = cmd.Parameters("@PrevStartTime").Value
            'PrevEndTime = cmd.Parameters("@PrevEndTime").Value
            'PrevReservationName = cmd.Parameters("@PrevReservationName").Value
            'PrevDeptID = cmd.Parameters("@PrevDeptID").Value
            'PrevTelephone = cmd.Parameters("@PrevTelephone").Value
            'PrevCheckin = cmd.Parameters("@PrevCheckin").Value
            'PrevCheckout = cmd.Parameters("@PrevCheckout").Value
            NextSubject = cmd.Parameters("@NextSubject").Value
            NextBookDate = cmd.Parameters("@NextBookDate").Value
            NextStartTime = cmd.Parameters("@NextStartTime").Value
            NextEndTime = cmd.Parameters("@NextEndTime").Value
            NextReservationName = cmd.Parameters("@NextReservationName").Value
            NextDeptID = cmd.Parameters("@NextDeptID").Value
            NextTelephone = cmd.Parameters("@NextTelephone").Value
            CheckIn = cmd.Parameters("@CheckIn").Value
            CheckOut = cmd.Parameters("@CheckOut").Value



            cmd.Dispose()
        Catch ex As Exception

            Throw ex
        Finally
            obj.CloseSqlConn(Conn)
            Conn.Dispose()
        End Try
    End Sub
#End Region

#Region "UpdateData"
    Public Sub UpdateData()

        Dim obj As New ClassConBookingRoomDB
        Dim Conn As New SqlConnection
        Dim cmd As New SqlCommand


        Try
            obj.SqlConnBookingRoomDB(Conn)

            cmd.Connection = Conn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Sp_MeetingBoardUpdate"
            cmd.CommandTimeout = 0
            cmd.Parameters.Clear()



            If BookingNo <> "" Then
                cmd.Parameters.Add(New SqlParameter("@BookingNo", Data.SqlDbType.NVarChar)).Value = BookingNo

            Else
                cmd.Parameters.Add(New SqlParameter("@BookingNo", Data.SqlDbType.NVarChar)).Value = DBNull.Value
            End If
            If CurDate <> "" Then
                cmd.Parameters.Add(New SqlParameter("@CurDate", Data.SqlDbType.NVarChar)).Value = CurDate

            Else
                cmd.Parameters.Add(New SqlParameter("@CurDate", Data.SqlDbType.NVarChar)).Value = DBNull.Value
            End If

            If Action <> "" Then
                cmd.Parameters.Add(New SqlParameter("@Action", Data.SqlDbType.NVarChar)).Value = Action
            Else
                cmd.Parameters.Add(New SqlParameter("@Action", Data.SqlDbType.NVarChar)).Value = DBNull.Value
            End If




            cmd.Parameters.Add("@errormsg", SqlDbType.VarChar, 500)
            cmd.Parameters("@errormsg").Direction = ParameterDirection.Output

            cmd.Parameters.Add("@StrReturn", SqlDbType.VarChar, 50)
            cmd.Parameters("@StrReturn").Direction = ParameterDirection.Output




            cmd.ExecuteNonQuery()

            errormsg = cmd.Parameters("@errormsg").Value
            StrReturn = cmd.Parameters("@StrReturn").Value



            cmd.Dispose()
        Catch ex As Exception

            Throw ex
        Finally
            obj.CloseSqlConn(Conn)
            Conn.Dispose()
        End Try
    End Sub
#End Region

End Class
