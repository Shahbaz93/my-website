<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
	  <div class="slider-area">
			<!-- Slider -->
			<div class="block-slider block-slider4">
				<ul class="" id="bxslider-home4">
					<li>
						<img src="img/h4-slide.png" alt="Slide">
						<%--<div class="caption-group">
							<h2 class="caption title">
								iPhone <span class="primary">6 <strong>Plus</strong></span>
							</h2>--%>
							<%--<h4 class="caption subtitle">Dual SIM</h4>
							<a class="caption button-radius" href="#"><span class="icon"></span>Shop now</a>
						</div>--%>
					</li>
					<li><img src="img/h4-slide2.png" alt="Slide">
						<%--<div class="caption-group">
							
							<h4 class="caption subtitle">school supplies & backpacks.*</h4>
							<a class="caption button-radius" href="#"><span class="icon"></span>Shop now</a>
						</div>--%>
					</li>
					<li><img src="img/h4-slide3.png" alt="Slide">
						<%--<div class="caption-group">
							
							<h4 class="caption subtitle">Select Item</h4>
							<a class="caption button-radius" href="#"><span class="icon"></span>Shop now</a>
						</div>--%>
					</li>
					<li><img src="img/h4-slide4.png" alt="Slide">
						<%--<div class="caption-group">
						  
							<h4 class="caption subtitle">& Phone</h4>
							<a class="caption button-radius" href="#"><span class="icon"></span>Shop now</a>
						</div>--%>
					</li>
				</ul>
			</div>
			<!-- ./Slider -->
	</div> <!-- End slider area -->
	
	<div class="promo-area">
		<div class="zigzag-bottom"></div>
		<div class="container">
			<div class="row">
				<div class="col-md-3 col-sm-6">
					<div class="single-promo promo1" style="background-color:#D2AB99">
						<%----%>
						<p><i class="fa fa-refresh"></i> &nbsp;7 Days return</p>
					</div>
				</div>
				<div class="col-md-3 col-sm-6">
					<div class="single-promo promo2" style="background-color:#D2AB99">
						<%----%>
						<p><i class="fa fa-truck"></i>&nbsp;Free shipping</p>

					</div>
				</div>
				<div class="col-md-3 col-sm-6">
					<div class="single-promo promo3" style="background-color:#D2AB99">
						<%----%>
						<p><i class="fa fa-lock"></i>&nbsp;Secure payments</p>
					</div>
				</div>
				<div class="col-md-3 col-sm-6">
					<div class="single-promo promo4" style="background-color:#D2AB99">
						<%----%>
						<p><i class="fa fa-gift"></i>&nbsp;New products</p>
					</div>
				</div>
			</div>
		</div>
       
	</div> <!-- End promo area -->
    
	<div class="maincontent-area" style="padding:2%">
		<div class="zigzag-bottom"></div>
		<div class="container">
			<div class="row">
				<div class="col-md-12">
					<div class="latest-product">
						<h6 class="section-title" style="padding:1%" ><b style="color:steelblue">Shop Our Best</b></h6>
                       
                                    <div class="row" style="padding:2%">
						<div class="product-carousel"  >
                            
                                        
                          <asp:Repeater ID="RptItem" runat="server">
                                         
                                <ItemTemplate>
                                     <asp:UpdatePanel ID="updt1" runat="server">
                                <ContentTemplate>
                                    <div class="single-product" >
                                        <span class="badge bg-danger" style="background-color:red" > NEW </span>
								<div class="product-f-image "  >
                                   
                                    
									<img src='<%# Eval("ITM_IMAGE") %>'  alt=""   />

									<div class="product-hover">
                                        
                                       
										
                                           <asp:LinkButton ID="btndetails" runat="server"  Text="See details" CssClass="view-details-link btn btn-sm" BackColor="LightSteelBlue" ForeColor="Black" OnClick="btndetails_Click" CommandArgument='<%# Eval("ITM_ID")%>'><i class="fa fa-search-plus"></i>Quick view</asp:LinkButton>	
                                        
										<%--<a href="single-product.html" class="view-details-link"><i class="fa fa-link"></i> See details</a>--%>
                                          
									</div>
								</div>
							
								<h2><a href="#" style="color:steelblue;padding-left:2%"><%# Eval("ITM_NAME") %></a></h2>
								
								<div class="product-carousel-price" style="color:steelblue;padding-left:2%">
									<ins>&#8377;<%# Eval("ITM_PRICE") %></ins><%-- <del>$100.00</del>--%>
								</div> 
                                        <asp:LinkButton ID="btncart" runat="server"  Text="Add to cart" CssClass="btn btn-block btn-primary" OnClick="Click_btncart" CommandArgument='<%# Eval("ITM_ID")%>'><i class="fa fa-shopping-cart">&nbsp;</i>Add to cart</asp:LinkButton>	
							</div>

                                   </ContentTemplate>
                            </asp:UpdatePanel>     
                                </ItemTemplate>
                                              
                            </asp:Repeater>
                                        </div>
                               
                          
							
							
						</div>
                                     
					</div>
				</div>
			</div>
		</div>
	</div> 

    <!-- End main content area -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     <script type="text/javascript">
        function showModalWarn(message, header) {
            $('#WarnModal').modal({           
            });
        }
        function showModalSuccess(message, header) {
            $('#modalsuccess').modal({ 
                
            });
        }
    </script>
</asp:Content>

