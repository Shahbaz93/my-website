<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="checkout.aspx.cs" Inherits="checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="body" runat="server">
     <div class="product-big-title-area">
       <%-- <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="product-bit-title text-center">
                        <h2>Place Your Order</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>--%>
          <div class="col-sm-12"  style="color:white;background-color:#FCBF49">
         <div class="col-sm-4" style="color:white;background-color:#FCBF49;padding-top:1%;padding-bottom:1%;text-align:center"><a href="#" style="color:white" ></a></div>
<div class="col-sm-4" style="color:white;background-color:#FCBF49;padding-top:1%;padding-bottom:1%;text-align:center"><h3>Place Your Order</h3></div>
<div class="col-sm-4" style="color:white;background-color:#FCBF49;padding-top:1%;padding-bottom:1%;text-align:center"><a href="#" style="color:white" ></a></div>
         </div></div>
    <div class="single-product-area">
        <div class="zigzag-bottom"></div>
        <div class="container">
            <div class="row"style="padding:5%">
             
                
                <div class="col-md-12">
                    
                        <div class="woocommerce">
                                <div id="customer_details" class="col2-set">
                                    
                                            <h3>Billing Details</h3>
                                           <div class="row" >
                                               <div class="col-lg-5">
                                                <label class="" for="billing_country">Country <abbr title="required" class="required">*</abbr>
                                                </label>
                                                    <asp:RequiredFieldValidator BackColor="red"  ID="reqword" ControlToValidate="contry" ValidationGroup="LoginFrame" runat="server" ErrorMessage="Please fill this*"></asp:RequiredFieldValidator>
                                                   <asp:TextBox ID="contry" runat="server" CssClass="input-text "  ValidationGroup="LoginFrame" Text="India" Enabled="false"></asp:TextBox>
                                              
                                            </div>
                                              <div class="col-lg-5">
                                                <label class="" for="billing_last_name">Contact Number<abbr title="required" class="required">*</abbr>
                                                </label>
                                                  <asp:RequiredFieldValidator BackColor="red" ForeColor="white" ID="RequiredFieldValidator1" ControlToValidate="txtcontact" ValidationGroup="LoginFrame" runat="server" ErrorMessage="Please fill this*"></asp:RequiredFieldValidator>
                                                <asp:TextBox ID="txtcontact" ValidationGroup="LoginFrame" runat="server" name="billing_last_name" CssClass="input-text " />
                                                  
                                           </div>
                                                 
                                               </div>
                                             <div class="row" >
                                     <div class="col-lg-5">
                                           
                                                <label class="" for="billing_first_name">First Name <abbr title="required" class="required">*</abbr>
                                                </label>
                                          <asp:RequiredFieldValidator BackColor="red" ForeColor="white" ID="RequiredFieldValidator2" ControlToValidate="billing_first_name" ValidationGroup="LoginFrame" runat="server" ErrorMessage="Please fill this*"></asp:RequiredFieldValidator>
                                               <asp:TextBox runat="server" ValidationGroup="LoginFrame"  ID="billing_first_name"   CssClass ="input-text "></asp:TextBox>
                                        
                                           </div>
                                                 <div class="col-lg-5">
                                                <label class="" for="billing_last_name">Last Name <abbr title="required" class="required">*</abbr>
                                                </label>
                                                      <asp:RequiredFieldValidator BackColor="red" ForeColor="white" ID="RequiredFieldValidator3" ControlToValidate="billing_last_name" ValidationGroup="LoginFrame" runat="server" ErrorMessage="Please fill this*"></asp:RequiredFieldValidator>
                                                <asp:TextBox ID="billing_last_name" ValidationGroup="LoginFrame" runat="server" name="billing_last_name" CssClass="input-text " />
                                                    
                                           </div>
                                                 </div>
                                            <div class="clear"></div>

                                           
                                               
                                             <div class="row">
                                     <div class="col-lg-5">

                                          
                                                <label class="" for="billing_address_1">Address <abbr title="required" class="required">*</abbr>
                                                </label>
                                          <asp:RequiredFieldValidator BackColor="red" ForeColor="white" ID="RequiredFieldValidator4" ControlToValidate="billing_address_1" ValidationGroup="LoginFrame" runat="server" ErrorMessage="Please fill this*"></asp:RequiredFieldValidator>
                                                <asp:TextBox placeholder="Street address" ValidationGroup="LoginFrame" ID="billing_address_1" runat="server" CssClass="input-text "></asp:TextBox>
                                        
                                            </div>
                                                 <div class="col-lg-5">
                                            <label class="" for="billing_address_1">Apartment, suite, unit etc. <abbr title="required" class="required">*</abbr>
                                                </label>
                                                      <asp:RequiredFieldValidator BackColor="red" ForeColor="white"  ID="RequiredFieldValidator5" ControlToValidate="billing_address_2" ValidationGroup="LoginFrame" runat="server" ErrorMessage="Please fill this*"></asp:RequiredFieldValidator>
                                                <asp:TextBox runat="server" ValidationGroup="LoginFrame" placeholder="Apartment, suite, unit etc." ID="billing_address_2"  CssClass="input-text "></asp:TextBox>
                                          


                                                 </div>
                                           </div>
                                       <div class="row">
                                     <div class="col-lg-5">
                                                <label class="" for="billing_city">Town / City <abbr title="required" class="required">*</abbr>
                                                </label>
                                          <asp:RequiredFieldValidator BackColor="red" ForeColor="white" ID="RequiredFieldValidator6" ControlToValidate="billing_city" ValidationGroup="LoginFrame" runat="server" ErrorMessage="Please fill this*"></asp:RequiredFieldValidator>
                                                <asp:TextBox ValidationGroup="LoginFrame" placeholder="Town / City" ID="billing_city" runat="server" CssClass="input-text "></asp:TextBox>
                                           
                                         </div>
                                           
                                                
                                             <div class="col-lg-5">
                                           
                                                <label class="" for="billing_postcode">Postcode <abbr title="required" class="required">*</abbr>
                                                </label>
                                                  <asp:RequiredFieldValidator  BackColor="red" ForeColor="white" ID="RequiredFieldValidator7" ControlToValidate="billing_postcode" ValidationGroup="LoginFrame" runat="server" ErrorMessage="Please fill this*"></asp:RequiredFieldValidator>
                                               <asp:TextBox ValidationGroup="LoginFrame"  placeholder="Postcode / Zip" ID="billing_postcode" runat="server" CssClass="input-text "/>
                                           
                                                 </div>
                                           </div>
                                            <div class="clear"></div>
                                      <div class="row">
                                     <div class="col-lg-5">
                                           
                                                <label class="" for="billing_email">Email Address <abbr title="required" class="required">*</abbr>
                                                </label>
                                          <asp:RequiredFieldValidator BackColor="red" ForeColor="white" ID="RequiredFieldValidator8" ControlToValidate="billing_email" ValidationGroup="LoginFrame" runat="server" ErrorMessage="Please fill this*"></asp:RequiredFieldValidator>
                                                <asp:TextBox ValidationGroup="LoginFrame" placeholder="" ID="billing_email" runat="server" CssClass="input-text "/>
                                          
                                         </div>
                                           <div class="col-lg-5">
                                                <label class="" for="billing_phone">Seconry Phone <abbr title="required" class="required">*</abbr>
                                                </label>
                                                <asp:RequiredFieldValidator BackColor="red" ForeColor="white" ID="RequiredFieldValidator9" ControlToValidate="billing_phone" ValidationGroup="LoginFrame" runat="server" ErrorMessage="Please fill this*"></asp:RequiredFieldValidator>
                                                <asp:TextBox ValidationGroup="LoginFrame" placeholder="" ID="billing_phone" runat="server" CssClass="input-text "/>
                                              
                                           </div>
                                            <div class="clear"></div>


                                        

                                        </div>
                                    </div>


                                </div>

                                <h3 id="order_review_heading">Your order</h3>

                                <div id="order_review" style="position: relative;">
                                    <table class="shop_table">
                                        <thead>
                                            <tr>
                                                <th class="product-name">Product</th>
                                                <th class="product-total">Total</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr class="cart_item">
                                                <td class="product-name">
                                                    <asp:Label ID="Name" runat="server"></asp:Label>  </td>
                                                <td class="product-total">
                                                    <span class="amount"><asp:Label ID="amount" runat="server"></asp:Label></span> </td>
                                            </tr>
                                        </tbody>
                                        <tfoot>

                                            <tr class="cart-subtotal">
                                                <th>Cart Subtotal</th>
                                                <td><span class="amount"><asp:Label ID="subtotal" runat="server"></asp:Label></span>
                                                </td>
                                            </tr>

                                            <tr class="shipping">
                                                <th>Shipping and Handling</th>
                                                <td>

                                                    Free Shipping
                                                    <input type="hidden" class="shipping_method" value="free_shipping" id="shipping_method_0" data-index="0" name="shipping_method[0]">
                                                </td>
                                            </tr>


                                            <tr class="order-total">
                                                <th>Order Total</th>
                                                <td><strong><span class="amount"><asp:Label ID="GrandTotal" runat="server"></asp:Label></span></strong> </td>
                                            </tr>

                                        </tfoot>
                                    </table>


                                   
                                    <asp:Button ID="btnsubmit" ValidationGroup="LoginFrame" runat="server" Text="Place order" CssClass="button alt" OnClick="btnsubmit_Click" />
                                   
                                      
                                </div>
                           

                        
        </div>
    </div>
            </div>
        </div>
        </div>
     <div id="body2" runat="server" visible="false" style="color:white;">
         <h1><asp:Label CssClass="alert-warning" Text="First add the item into cart" ID="lbl" runat="server"></asp:Label></h1>
         </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

