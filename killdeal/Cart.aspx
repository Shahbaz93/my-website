<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="body" runat="server">
     <div class="product-big-title-area">
       <%-- <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="product-bit-title text-center">
                        <h2>Shopping Cart</h2>
                    </div>
                </div>
            </div>
        
    </div>--%>
         <div class="col-sm-12"  style="color:white;background-color:#FCBF49">
         <div class="col-sm-4" style="color:white;background-color:#FCBF49;padding-top:1%;padding-bottom:1%;text-align:center"><a href="#" style="color:white" ></a></div>
<div class="col-sm-4" style="color:white;background-color:#FCBF49;padding-top:1%;padding-bottom:1%;text-align:center"><h3>Shopping Cart</h3></div>
<div class="col-sm-4" style="color:white;background-color:#FCBF49;padding-top:1%;padding-bottom:1%;text-align:center"><a href="#" style="color:white" ></a></div>
         </div></div>
    <div class="single-product-area">
        <div class="zigzag-bottom"></div>
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="product-content-right">
                        <div class="woocommerce"> 
                             <asp:UpdatePanel ID="updt1" runat="server">
                                <ContentTemplate>                             
                          <asp:gridview  id="gvcart" runat="server" cssclass="shop_table cart" autogeneratecolumns="false">
                                <Columns>                                     
                                    <asp:TemplateField ItemStyle-Width="2%">
                                         <HeaderTemplate>
                                           #
                                        </HeaderTemplate>
                                    <ItemTemplate>
                                      <asp:LinkButton ID="btnremove" runat="server" Text="Remove" OnClick="btnremove_Click" CommandArgument='<%# Eval("ITM_ID")%>'><i class="fa fa-bitbucket" style="color:red"></i></asp:LinkButton>  
                                    </ItemTemplate>
                                         </asp:TemplateField>
                                    <asp:TemplateField>
                                         <HeaderTemplate>
                                           Image
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                    
                                                <a href="#"><img width="145" height="145" alt="poster_1_up" class="shop_thumbnail" src='<%# Eval("ITM_IMAGE") %>'></a>
                                         
                                         </ItemTemplate>
                                         </asp:TemplateField>
                                     <asp:TemplateField>
                                         <HeaderTemplate>
                                           Product
                                        </HeaderTemplate>
                                    <ItemTemplate>
                                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("ITM_NAME") %>'  />
                                        </ItemTemplate>
                                         </asp:TemplateField>
                                      <asp:TemplateField>
                                         <HeaderTemplate>
                                           Price
                                        </HeaderTemplate>
                                    <ItemTemplate>
                                       <asp:Label ID="lblprice" runat="server" Text='<%# Eval("ITM_PRICE") %>'  />
                                        </ItemTemplate>
                                          </asp:TemplateField>
                                    <asp:TemplateField ItemStyle-Width="10%"  >
                                        <HeaderTemplate>
                                            Quntity
                                        </HeaderTemplate>                                                    
                                             <ItemTemplate >                                            
                                            <input type="button" id="btnplus" class="btn btn-primary"   value="+" onclick="return Calculate(this);"/>
                                                
                                             <asp:TextBox ID="txbQty" Enabled="false" Text='<%# Eval("Quantity") %>'  class="calculate" runat="server" CssClass="form-control " />  
                                                                                          
                                                  <input type="button"  id="btnminus" class="btn btn-danger"  value="-" onclick="return Calculate1(this);" />
                                                </ItemTemplate>
                                               
                                             </asp:TemplateField>
                                      <asp:TemplateField ItemStyle-Width="10%"  >
                                           <HeaderTemplate>
                                            Total
                                        </HeaderTemplate>                                                    
                                             <ItemTemplate >  
                                                <asp:Label ID="labtotal" runat="server" Text='<%# Eval("ITM_TOTAL_PRICE") %>'></asp:Label>
                                                 <asp:HiddenField ID="ID" runat="server" Value='<%# Eval("ITM_ID") %>'></asp:HiddenField>
                                               </ItemTemplate>
                                         </asp:TemplateField>                                                                                                               
                                </Columns>
                            </asp:gridview> 
                                    <div class="row">
                                        <div class="col-lg-4">

                                        </div>
                                       
                                       <div class="col-lg-2">
                                            <asp:Button ID="btncheckout" runat="server" Text="Checkout" CssClass="btn btn-success" OnClick="btncheckout_Click" />
                                        </div>
                                         <div class="col-lg-2"> 
                                            <asp:Button ID="btnContinue" runat="server" Text="Continue shoping" CssClass="btn btn-warning" OnClick="btnContinue_Click" />
                                        </div>
                                    </div>
                                    </ContentTemplate>
                                 </asp:UpdatePanel>                          
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
  
    <h2> <input type="hidden" id="array_store" name = "ArrayStore" value = '<%=this.ArrayStore %>' /></h2>
        </div>
    <div id="body2" runat="server" visible="false" style="color:white;">
         <h1><asp:Label CssClass="alert-warning" Text="First add the item into cart" ID="lbl" runat="server"></asp:Label></h1>
         </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<%--     <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>--%>
    <script type="text/javascript">


        function Calculate1(xyz) {

            var rowIndex = xyz.parentNode.parentNode;

            var message = "Row Index: " + (rowIndex.rowIndex - 1);

            var disQtyTotal = 0;
            $('[id*=gvcart] tr').each(function () {

                var row = $(this);
                if (rowIndex.rowIndex == row.index()) {
                    var qty1 = $('[id*=txbQty]', row).html();
                    var qty = $('[id*=txbQty]', row).val();
                    var total = $('[id*=labtotal]', row).html();
                    var unitprice = parseInt(total)/ parseInt(qty)
                    if (qty > 1) {
                        var newqty = parseInt(qty) - 1;
                        var newTotal = parseInt(unitprice) * parseInt(newqty);
                        $('[id*=txbQty]', row).val(newqty);
                        $('[id*=labtotal]', row).html(newTotal);
                        debugger;
                        var arr = [];
                        var item = ['ID', 'NAME', 'PRICE', 'QTY', 'TOTAL'];
                        arr.push(item);
                        $('[id*=gvcart] tr').each(function () {
                            var row = $(this);
                            if (row.index() > 0) {
                                item = [$('[id*=ID]', row).val(), $('[id*=lblName]', row).html(), $('[id*=lblprice]', row).html(),
                                               $('[id*=txbQty]', row).val(), $('[id*=labtotal]', row).html()];


                                arr.push(item);
                            }



                        })
                       
                        //  arr =  JSON.stringify(Object.assign({}, arr));
                        var r = arrayToJSONObject(arr);
                        array_store.value = r;
                        __doPostBack('', '');
                    }
                }
               
            })

        }
        function Calculate(xyz) {
            var rowIndex = xyz.parentNode.parentNode;
            debugger;
            var message = "Row Index: " + (rowIndex.rowIndex - 1);
            var disQtyTotal = 0;
            $('[id*=gvcart] tr').each(function () {
                var row = $(this);
                if (rowIndex.rowIndex == row.index()) {
                    debugger;
                    var qty1 = $('[id*=txbQty]', row).html();
                    var qty = $('[id*=txbQty]', row).val();
                    var total = $('[id*=labtotal]', row).html();
                    var unitprice = parseInt(total) / parseInt(qty)
                    var newqty = parseInt(qty) + 1;
                    var newTotal = parseInt(unitprice) * parseInt(newqty);
                    $('[id*=txbQty]', row).val(newqty);
                    $('[id*=labtotal]', row).html(newTotal);
                    var arr = [];
                    var item = ['ID', 'NAME', 'PRICE', 'QTY', 'TOTAL'];
                    arr.push(item);
                    $('[id*=gvcart] tr').each(function () {
                        var row = $(this);
                        if (row.index() > 0) {
                             item = [$('[id*=ID]', row).val(), $('[id*=lblName]', row).html(), $('[id*=lblprice]', row).html(),
                                           $('[id*=txbQty]', row).val(), $('[id*=labtotal]', row).html()];
                            arr.push(item);
                        }



                    })

                   // arr = JSON.stringify(Object.assign({}, arr));
                    var r = arrayToJSONObject(arr);
                    array_store.value = r;
                    __doPostBack('', '');
                }
              
            })

        }
        function fatchGv() {
            debugger;
            var arr = [];
            $('[id*=gvcart] tr').each(function ()
            {
                var row = $(this);
                if (row.index() > 0)
                {
                    var item = [$('[id*=ID]', row).val(), $('[id*=lblName]', row).html(), $('[id*=lblprice]', row).html(),
                                   $('[id*=txbQty]', row).val(), $('[id*=labtotal]', row).html()];
                    arr.push(item);
                }
             
                
             
            })
           
            arr = JSON.stringify(arr);
            array_store.value = arr;
            __doPostBack('', '');
           // window.location.href = 'checkout.aspx';
        }
        function arrayToJSONObject(arr) {
            debugger;
            var keys = arr[0];
            var keys2 = arr[1];
            var keys3 = arr[2];
            //vacate keys from main array
            var newArr = arr.slice(1, arr.length);

            var formatted = [],
            data = newArr,
            cols = keys,
            l = cols.length;
            for (var i = 0; i < data.length; i++) {
                var d = data[i],
                        o = {};
                for (var j = 0; j < l; j++)
                    o[cols[j]] = d[j];
                formatted.push(o);
            }
           var result= JSON.stringify(formatted);
           return result;
        }
    </script>
</asp:Content>

