<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ImportDataFromExcel._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   

    <div class="row">
        <asp:Table runat="server" Width="70%" style="margin-top:2%">
            <asp:TableRow>
                <asp:TableCell>

                </asp:TableCell>
                 <asp:TableCell>

                </asp:TableCell>
            </asp:TableRow>
<asp:TableRow>
                <asp:TableCell>

                </asp:TableCell>
                 <asp:TableCell>

                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>

                </asp:TableCell>
                 <asp:TableCell>

                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    <label runat="server">Upload File : </label>
                </asp:TableCell>
                 <asp:TableCell>
                     <asp:FileUpload runat="server" ID="FileUpload" />
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                  
                </asp:TableCell>

                 <asp:TableCell>
                       <asp:Button runat="server" ID="btnsubmit" Text="Upload File" style="margin-top:20px" OnClick="btnsubmit_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <grid
                </asp:TableCell>
                 <asp:TableCell>
                      <label runat="server" id="label1"></label>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
   
    </div>
    <div class="row">
        <asp:GridView ID="grid1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >  
     <AlternatingRowStyle BackColor="White" />  
     <columns >  
         <asp:TemplateField HeaderText="Bank Name" >  
             <ItemTemplate>  
                 <asp:Label ID="LblCompanyId" style="margin-right:100px;margin-top:50px" runat="server" Text='<%#Bind("Bank_Name") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField HeaderText="Risk Rating">  
             <ItemTemplate>  
                 <asp:Label ID="LblCompanyName" style="margin-right:100px;margin-top:50px" runat="server" Text='<%#Bind("Rating") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField HeaderText="Total Assets">  
             <ItemTemplate>  
                 <asp:Label ID="LblCompanyAddress" style="margin-right:100px;margin-top:50px" runat="server" Text='<%#Bind("Assets") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField HeaderText="Daily Limit">  
             <ItemTemplate>  
                 <asp:Label ID="Label3" runat="server" style="margin-right:100px;margin-top:50px" Text='<%#Bind("DailyLimit") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField HeaderText="Date">  
             <ItemTemplate>  
                 <asp:Label ID="LblDate" runat="server" style="margin-right:100px;margin-top:50px" Text='<%#Bind("Date") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  
     </columns>  
     <EditRowStyle BackColor="#2461BF" />  
     <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />  
     <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />  
     <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />  
     <RowStyle BackColor="#EFF3FB" />  
     <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />  
     <SortedAscendingCellStyle BackColor="#F5F7FB" />  
     <SortedAscendingHeaderStyle BackColor="#6D95E1" />  
     <SortedDescendingCellStyle BackColor="#E9EBEF" />  
     <SortedDescendingHeaderStyle BackColor="#4870BE" />  
 </asp:GridView> 
    </div>

</asp:Content>
