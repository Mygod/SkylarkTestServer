<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
         Inherits="Mygod.Skylark.TestServer.Default" %>
<%=string.Format("{0} / {1} ({2:0.00} %)", GetSize(CurrentDrive.AvailableFreeSpace), GetSize(CurrentDrive.TotalSize),
                                           100.0 * CurrentDrive.AvailableFreeSpace / CurrentDrive.TotalSize) %>