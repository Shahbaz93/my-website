<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Allorder.aspx.cs" Inherits="Allorder" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <section class="content-header" >
        <h1 style="color:steelblue">All Oredr
            
        </h1>
    </section>
     <asp:UpdatePanel ID="uppanal" runat="server">
        <ContentTemplate>  
              
               
          <div class="container">
               <div class="row" style="padding-bottom:1%">
                                              <div class="col-lg-6"> 
                                              <asp:TextBox ID="txtOrderID" placeholder=" Order Id" runat="server" name="billing_last_name" CssClass=" form-control" />     
                                           </div>
                                                 <div class="col-lg-6"> 
                                                     <asp:Button ID="btnsherch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnsherch_Click" />
                                                     </div>
                                               </div> 
                
              <asp:Repeater ID="gvorder" runat="server">
                 <ItemTemplate>
                      <div class="box box-primary" style="padding-left: 3%; padding-bottom: 3%">
                    <div class="box-body ">
                                 <h3><%# Eval("TOT_ID") %></h3>
                                    <h4 style="color:green">Status:<%# Eval("TOT_STATUS") %></h4>
                                    <h5 style="color:steelblue"><%# Eval("TOT_CRT_DATE") %></h5>
                                    <div class="row" style="background-color:lightgrey;padding-left:5%">
                                    
                                        <div class="col-lg-4">
                                         <label class="" for="billing_country"> Total Amount <abbr title="required" class="required">*</abbr>
                                                  &nbsp; &#8377;  <asp:Label ID="TOTAL" Text='<%# Eval("TOT_AMOUNT") %>' runat="server" CssClass="input-text "  Enabled="false"></asp:Label>
                                                </label>
                                    </div>
                                               <div class="col-lg-4">
                                                <label class="" for="billing_country">Order ID <abbr title="required" class="required">*</abbr>
                                                  &nbsp;   <asp:Label ID="lblOrderID" Text='<%# Eval("TOT_ID") %>' runat="server" CssClass="input-text "  Enabled="false"></asp:Label>
                                                </label>
                                                  
                                               
                                            </div>
                                              <div class="col-lg-4">
                                                <label class="" for="billing_last_name">Track ID<abbr title="required" class="required">*</abbr>
                                                   &nbsp; <asp:Label ID="lblTrackId" Text='<%# Eval("TOT_CORER_ID") %>' runat="server" name="billing_last_name" CssClass="input-text " />
                                                </label>
                                                
                                           </div>
                                               <div class="col-lg-4">
                                                <label class="" for="billing_country">Country <abbr title="required" class="required">*</abbr>
                                                  &nbsp;   <asp:Label ID="contry" Text='<%# Eval("TOT_CONTRY") %>' runat="server" CssClass="input-text "  Enabled="false"></asp:Label>
                                                </label>
                                                  
                                               
                                            </div>
                                              <div class="col-lg-4">
                                                <label class="" for="billing_last_name">Contact Number<abbr title="required" class="required">*</abbr>
                                                   &nbsp; <asp:Label ID="txtcontact" Text='<%# Eval("TOT_PHONE") %>' runat="server" name="billing_last_name" CssClass="input-text " />
                                                </label>
                                                
                                           </div>
                                     <div class="col-lg-4">

                                          
                                                <label class="" for="billing_address_1">Address <abbr title="required" class="required">*</abbr>
                                                 &nbsp;    <asp:Label placeholder="Street address" Text='<%# Eval("TOT_ADDRESS") %>' ID="billing_address_1" runat="server" CssClass="input-text "></asp:Label>
                                                </label>
                                              
                                            </div>
                                                 <div class="col-lg-4">
                                            <label class="" for="billing_address_1">Apartment, suite, unit etc <abbr title="required" class="required">*</abbr>
                                                 &nbsp; <asp:Label runat="server" Text='<%# Eval("TOT_APPARTMENT") %>' placeholder="Apartment, suite, unit etc. (optional)" ID="billing_address_2"  CssClass="input-text "></asp:Label>
                                                </label>
                                                
                                           
                                                 </div>
                                     <div class="col-lg-4">
                                                <label class="" for="billing_city">Town / City <abbr title="required" class="required">*</abbr>
                                                    &nbsp; <asp:Label  Text='<%# Eval("TOT_CITY") %>' placeholder="Town / City" ID="billing_city" runat="server" CssClass="input-text "></asp:Label>
                                                </label>
                                              
                                            
                                         </div>
                                             <div class="col-lg-4">
                                                <label class="" for="billing_postcode">Postcode <abbr title="required" class="required">*</abbr>
                                                   &nbsp;  <asp:Label  Text='<%# Eval("TOT_PIN") %>' placeholder="Postcode / Zip" ID="billing_postcode" runat="server" CssClass="input-text "/>
                                                </label>
                                           </div>
                                     <div class="col-lg-4">
                                           
                                                <label class="" for="billing_email">Email Address <abbr title="required" class="required">*</abbr>
                                                    &nbsp; <asp:Label placeholder=""  Text='<%# Eval("TOT_EMAIL") %>' ID ="billing_email" runat="server" CssClass="input-text "/>
                                                </label>
                                         </div>
                                           <div class="col-lg-4">
                                                <label class="" for="billing_phone">Seconry Phone <abbr title="required" class="required">*</abbr>
                                                    &nbsp;  <asp:Label placeholder="" Text='<%# Eval("TOT_PHONE2") %>' ID="billing_phone" runat="server" CssClass="input-text "/>
                                                </label> 
                                           </div>
                                         <div class="col-lg-4">
                                            </div>
                                       
                                           <div class="col-lg-4">
                                           
                                                <label class="" for="billing_email">Delivery Boy <abbr title="required" class="required">*</abbr>
                                                    &nbsp; <asp:Label placeholder=""  Text='<%# Eval("TOT_D_BOY") %>' ID ="Label1" runat="server" CssClass="input-text "/>
                                                </label>
                                         </div>
                                        
                                           <div class="col-lg-4">
                                                <label class="" for="billing_phone"> Contact No. <abbr title="required" class="required">*</abbr>
                                                    &nbsp;  <asp:Label placeholder="" Text='<%# Eval("TOT_D_BOY_CONTACT") %>' ID="Label2" runat="server" CssClass="input-text "/>
                                                </label> 
                                          
                                        </div>
                                         
                                        <div class="row">
                                           <div class="col-lg-6">
                                            <asp:LinkButton ID="btnopen" OnClick="btnopen_Click"  runat="server" CssClass="btn btn-primary pull-right"  ToolTip="Click to Item details" Text="Expand" ></asp:LinkButton>
                                           </div>
                                           <div class="col-lg-6">
                                           <asp:LinkButton ID="btnclose" OnClick="btnclose_Click"  runat="server" CssClass="btn btn-warning pull-right"  ToolTip="Click to delete details" Text="Collaps" ></asp:LinkButton>
                                           </div>
                                       </div>
                                   
                        
                           
                    
                                     
                            <div class="col-lg-4" >
                                      <asp:GridView ID="childRpt" cssclass="table table-striped table-bordered table-hover datatable  table-responsiv" runat="server" Visible="false" AutoGenerateColumns="false" HeaderStyle-BackColor="steelblue">
                                          <Columns>
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

                                      </asp:GridView>
                               </div>    
                          </div>
                           </div> 
                     </div>   
              <br />
                              </ItemTemplate>
                           
                              </asp:Repeater>  
         </div>
    </div>
       
  </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

