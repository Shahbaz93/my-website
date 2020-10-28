<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="conformatio.aspx.cs" Inherits="conformatio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="product-big-title-area">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="product-bit-title text-center">
                        <h2>Order Details</h2>
                    </div>
                </div>
            </div>
        
    </div>
         </div>

  





    <div class="single-product-area">
        <div class="zigzag-bottom"></div>
        <div class="container">
             <div class="row"style="padding:5%">
             
                
                <div class="col-md-12">
                    
                        <div class="woocommerce">
                                <div id="customer_details" class="col2-set">
                                   
                                            <h3>Order Details</h3>
                                    <div class="row">
                                        <div class="col-lg-6">
                                         <label class="" for="billing_country"> Total Amount <abbr title="required" class="required">*</abbr>
                                                  &nbsp; &#8377;  <asp:Label ID="TOTAL" runat="server" CssClass="input-text "  Enabled="false"></asp:Label>
                                                </label>
                                    </div>
                                        </div>
                                      <div class="row" >
                                               <div class="col-lg-6">
                                                <label class="" for="billing_country">Order ID <abbr title="required" class="required">*</abbr>
                                                  &nbsp;   <asp:Label ID="lblOrderID" runat="server" CssClass="input-text "  Enabled="false"></asp:Label>
                                                </label>
                                                  
                                               
                                            </div>
                                              <div class="col-lg-6">
                                                <label class="" for="billing_last_name">Track ID<abbr title="required" class="required">*</abbr>
                                                   &nbsp; <asp:Label ID="lblTrackId" runat="server" name="billing_last_name" CssClass="input-text " />
                                                </label>
                                                
                                           </div>
                                                 
                                               </div>

                                     <div class="clear"></div>
                                     <div class="row" >
                                               <div class="col-lg-6">
                                                <label class="" for="billing_country">Country <abbr title="required" class="required">*</abbr>
                                                  &nbsp;   <asp:Label ID="contry" runat="server" CssClass="input-text " Text="India" Enabled="false"></asp:Label>
                                                </label>
                                                  
                                               
                                            </div>
                                              <div class="col-lg-6">
                                                <label class="" for="billing_last_name">Contact Number<abbr title="required" class="required">*</abbr>
                                                   &nbsp; <asp:Label ID="txtcontact" runat="server" name="billing_last_name" CssClass="input-text " />
                                                </label>
                                                
                                           </div>
                                                 
                                               </div>
                                     <div class="clear"></div>

                                     <div class="row" >
                                     <div class="col-lg-6">
                                           
                                                <label class="" for="billing_first_name">First Name <abbr title="required" class="required">*</abbr>
                                                   &nbsp; <asp:Label runat="server"  ID="billing_first_name"   CssClass ="input-text "></asp:Label>
                                                </label>
                                               
                                           </div>
                                                 <div class="col-lg-6">
                                                <label class="" for="billing_last_name">Last Name <abbr title="required" class="required">*</abbr>
                                                   &nbsp;  <asp:Label ID="billing_last_name" runat="server" name="billing_last_name" CssClass="input-text " />
                                                </label>
                                               
                                           </div>
                                                 </div>
                                            <div class="clear"></div>
                                     <div class="row">
                                     <div class="col-lg-6">

                                          
                                                <label class="" for="billing_address_1">Address <abbr title="required" class="required">*</abbr>
                                                 &nbsp;    <asp:Label placeholder="Street address" ID="billing_address_1" runat="server" CssClass="input-text "></asp:Label>
                                                </label>
                                              
                                            </div>
                                                 <div class="col-lg-6">
                                            <label class="" for="billing_address_1">Apartment, suite, unit etc <abbr title="required" class="required">*</abbr>
                                                 &nbsp; <asp:Label runat="server" placeholder="Apartment, suite, unit etc. (optional)" ID="billing_address_2"  CssClass="input-text "></asp:Label>
                                                </label>
                                                
                                           
                                                 </div>
                                           </div>
                                    <div class="clear"></div>
                                      <div class="row">
                                     <div class="col-lg-6">
                                                <label class="" for="billing_city">Town / City <abbr title="required" class="required">*</abbr>
                                                    &nbsp; <asp:Label placeholder="Town / City" ID="billing_city" runat="server" CssClass="input-text "></asp:Label>
                                                </label>
                                              
                                            
                                         </div>
                                           
                                                
                                             <div class="col-lg-6">
                                           
                                                <label class="" for="billing_postcode">Postcode <abbr title="required" class="required">*</abbr>
                                                   &nbsp;  <asp:Label  placeholder="Postcode / Zip" ID="billing_postcode" runat="server" CssClass="input-text "/>
                                                </label>
                                              
                                            
                                                 </div>
                                           </div>
                                            <div class="clear"></div>
                                      <div class="row">
                                     <div class="col-lg-6">
                                           
                                                <label class="" for="billing_email">Email Address <abbr title="required" class="required">*</abbr>
                                                    &nbsp; <asp:Label placeholder="" ID="billing_email" runat="server" CssClass="input-text "/>
                                                </label>
                                               
                                           
                                         </div>
                                           <div class="col-lg-6">
                                                <label class="" for="billing_phone">Seconry Phone <abbr title="required" class="required">*</abbr>
                                                    &nbsp;  <asp:Label placeholder="" ID="billing_phone" runat="server" CssClass="input-text "/>
                                                </label>
                                               
                                           </div>
                                            <div class="clear"></div>


                                        

                                        </div>
                                    </div>
                            </div>
                    </div>
                </div>
            <div class="row" style="overflow:auto">
                <div class="col-md-12">
                    <div class="product-content-right">
                        <div class="woocommerce"> 
                                                          
                          <asp:gridview  id="gvorder" runat="server" cssclass="shop_table cart" AutoGenerateColumns="false" >
                                <Columns>    
                                       <asp:TemplateField>
                                         <HeaderTemplate>
                                           Image
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                    
                                                <a href="#"><img width="145" height="145" alt="poster_1_up" class="shop_thumbnail" src='<%# Eval("TOD_IMAGE") %>'></a>
                                         
                                         </ItemTemplate>
                                         </asp:TemplateField>                                 
                                        <asp:TemplateField>
                                         <HeaderTemplate>
                                           Product
                                        </HeaderTemplate>
                                    <ItemTemplate>
                                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("TOD_NAME") %>'  />
                                        </ItemTemplate>
                                         </asp:TemplateField>
                                      <asp:TemplateField>
                                         <HeaderTemplate>
                                           Price
                                        </HeaderTemplate>
                                    <ItemTemplate>
                                       <asp:Label ID="lblprice" runat="server" Text='<%# Eval("TOD_PRICE") %>'  />
                                        </ItemTemplate>
                                          </asp:TemplateField>
                                    <asp:TemplateField ItemStyle-Width="10%"  >
                                        <HeaderTemplate>
                                            Quntity
                                        </HeaderTemplate>                                                    
                                             <ItemTemplate >                                            
                                           
                                                
                                             <asp:Label ID="txbQty" Enabled="false" Text='<%# Eval("TOD_QTY") %>'  runat="server"  />  
                                                                                          
                                                 
                                                </ItemTemplate>
                                               
                                             </asp:TemplateField>
                                      <asp:TemplateField ItemStyle-Width="10%"  >
                                           <HeaderTemplate>
                                            Total
                                        </HeaderTemplate>                                                    
                                             <ItemTemplate >  
                                                <asp:Label ID="labtotal" runat="server" Text='<%# Eval("TOD_TOTAL_PRICE") %>'></asp:Label>
                                                 <asp:HiddenField ID="ID" runat="server" Value='<%# Eval("TOD_ORDER_ID") %>'></asp:HiddenField>
                                               </ItemTemplate>
                                         </asp:TemplateField>                                                                                                    
                                </Columns>
                            </asp:gridview> 
                                    <div class="row">
                                        <div class="col-lg-5">

                                        </div>
                                       </div>
                                        
                                    </div>
                                    
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

