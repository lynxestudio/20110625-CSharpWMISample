<%@ Page Language="C#" %>
<%@ Import Namespace="PCProperties.Lib"%>
<!DOCTYPE html>
<script runat="server">
    protected PC pc = null;
    protected void Page_Load(object sender,EventArgs e)
    {
        try
        {
            pc = new PCManager().Select();
        }
        catch(Exception ex)
        {
            lblStatus.Text = ex.Message;
        }
    }
 </script>
<html>
<head runat="server">
	<title>Windows Manager Instrumentation Example</title>
</head>
<body>
	<form id="form1" runat="server">
	<table width="66%">
<tr>
<td><strong>Ram Memory</strong></td>
<td><%=pc.RamMemory%></td>
</tr>
<tr>
<td><strong>Main processor</strong></td>
<td><%=pc.Processor%></td>
</tr>
<tr>
<td><strong>IP Address</strong></td>
<td><%=pc.IPAddress%></td>
</tr>
<tr>
<td><strong>Operating System</strong></td>
<td><%=pc.OperatingSystem%></td>
</tr>
<tr>
<td><strong>Hard Disk</strong></td>
<td><%=pc.HardDisk%></td>
</tr>
<tr>
<td><strong>Monitor</strong></td>
<td><%=pc.Monitor%></td>
</tr>
<tr>
<td><strong>Monitor Type</strong></td>
<td><%=pc.MonitorType%></td>
</tr>
<tr>
<td><strong>Cdrom</strong></td>
<td><%=pc.CdRom%></td>
</tr>
<tr>
<td><strong>Processor Speed</strong></td>
<td><%=pc.ProcessorSpeed%></td>
</tr>
</table>
<asp:Label id="lblStatus" runat="server"></asp:Label>
	</form>
</body>
</html>
