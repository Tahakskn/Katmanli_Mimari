<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

     <form  runat="server">

         <div class ="form-group">
             <div>
             <asp:Label for ="Textad" runat="server" Text="Öğrenci Adı" style="font-weight: bold"></asp:Label>
             <asp:TextBox ID="Textad" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
             <br />
             <div>
             <asp:Label for ="Textsoyad" runat="server" Text="Öğrenci Soyadı" style="font-weight: bold"></asp:Label>
             <asp:TextBox ID="Textsoyad" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
             <div>
             <asp:Label for ="Textno" runat="server" Text="Öğrenci Numara" style="font-weight: bold"></asp:Label>
             <asp:TextBox ID="Textno" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
             <br />
             <div>
             <asp:Label for ="Textpass" runat="server" Text="Öğrenci Şifre" style="font-weight: bold"></asp:Label>
             <asp:TextBox ID="Textpass" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
              <br />
             <div>
             <asp:Label for ="Textfoto" runat="server" Text="Öğrenci Fotoğraf" style="font-weight: bold"></asp:Label>
             <asp:TextBox ID="Textfoto" runat="server" CssClass="form-control"></asp:TextBox>
             </div>

         </div>

    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" CssClass="btn btn-info"/>
</form>
</asp:Content>

