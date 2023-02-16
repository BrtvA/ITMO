<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="SummaryBD.aspx.cs" Inherits="ITMO.ASP.WEB.Lab08.RSVP.SummaryBD"
    MasterPageFile="~/Site.master"%>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Имя"
                                ReadOnly="True" SortExpression="Name" />
                <asp:BoundField DataField="Email" HeaderText="Электронный адрес"
                                ReadOnly="True" SortExpression="Email" />
                <asp:BoundField DataField="Phone" HeaderText="Телефон"
                                ReadOnly="True" SortExpression="Phone" />
                <asp:CheckBoxField DataField="WillAttend" HeaderText="Наличие доклада"
                                   ReadOnly="True" SortExpression="WillAttend" />
                <asp:BoundField DataField="Rdata" DataFormatString="{0:d}" HeaderText="Дата регистрации"
                                ReadOnly="True" SortExpression="Rdata" />
            </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server"
                            ContextTypeName="ITMO.ASP.WEB.Lab08.RSVP.SampleContext"
                            EntityTypeName="" Select="new (Name, Email, Phone, WillAttend, Rdata, Reports)"
                            TableName="GuestResponses">
        </asp:LinqDataSource>
    </div>
</asp:Content>
