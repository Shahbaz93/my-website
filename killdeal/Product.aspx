<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Product" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="product-big-title-area">
     <%--   <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="product-bit-title text-center">
                        <h2>Prduct Description</h2>
                    </div>
                </div>
            </div>
        
    </div>
         </div>--%>
            <div class="col-sm-12"  style="color:white;background-color:#FCBF49">
         <div class="col-sm-4" style="color:white;background-color:#FCBF49;padding-top:1%;padding-bottom:1%;text-align:center"><a href="#" style="color:white" ></a></div>
<div class="col-sm-4" style="color:white;background-color:#FCBF49;padding-top:1%;padding-bottom:1%;text-align:center"><h3>Prduct Description</h3></div>
<div class="col-sm-4" style="color:white;background-color:#FCBF49;padding-top:1%;padding-bottom:1%;text-align:center"><a href="#" style="color:white" ></a></div>
         </div></div>
     <div class="single-product-area">
        <div class="zigzag-bottom"></div>
        <div class="container">
            <div class="row">
          
                
                <div class="col-md-10">
                    <div class="product-content-right">
                        
                        
                        <div class="row">
                            <div class="col-sm-6">
                               <%-- <div class="product-images">
                                    <div class="product-main-img">
                                        <img src="img/product-2.jpg" alt="">
                                    </div>
                                    
                                    <div class="product-gallery">
                                        <img src="img/product-thumb-1.jpg" alt="">
                                        <img src="img/product-thumb-2.jpg" alt="">
                                        <img src="img/product-thumb-3.jpg" alt="">
                                    </div>
                                </div>--%>
                                <div class="slider-area">
			<!-- Slider -->
			<div class="block-slider block-slider4">
				<ul class="" id="bxslider-home4">
					<li>
						<asp:Image id="Image1" runat="server"/>
						<%--<div class="caption-group">
							<h2 class="caption title">
								iPhone <span class="primary">6 <strong>Plus</strong></span>
							</h2>--%>
							<%--<h4 class="caption subtitle">Dual SIM</h4>
							<a class="caption button-radius" href="#"><span class="icon"></span>Shop now</a>
						</div>--%>
					</li>
					<li><<asp:Image id="Image2" runat="server"/>
						<%--<div class="caption-group">
							
							<h4 class="caption subtitle">school supplies & backpacks.*</h4>
							<a class="caption button-radius" href="#"><span class="icon"></span>Shop now</a>
						</div>--%>
					</li>
					<li><asp:Image id="Image3" runat="server"/>
						<%--<div class="caption-group">
							
							<h4 class="caption subtitle">Select Item</h4>
							<a class="caption button-radius" href="#"><span class="icon"></span>Shop now</a>
						</div>--%>
					</li>
					<li> 
                        <asp:Image id="Image4" runat="server"/>
						<%--<div class="caption-group">
						  
							<h4 class="caption subtitle">& Phone</h4>
							<a class="caption button-radius" href="#"><span class="icon"></span>Shop now</a>
						</div>--%>
					</li>
                    <li> 
                        <asp:Image id="Image5" runat="server"/>
						<%--<div class="caption-group">
						  
							<h4 class="caption subtitle">& Phone</h4>
							<a class="caption button-radius" href="#"><span class="icon"></span>Shop now</a>
						</div>--%>
					</li>
				</ul>
			</div>
			<!-- ./Slider -->
	</div>
                            </div>
                            
                            <div class="col-sm-6">
                                <div class="product-inner">
                                    <h2 class="product-name"><asp:Label ID="lblname" runat="server"></asp:Label></h2>
                                    <div class="product-inner-price">
                                        <b style="color:steelblue"><ins>&#8377;<asp:Label ID="lblprice" runat="server"></asp:Label><%--</ins> <del>$100.00</del>--%></b>
                                    </div>    
                                    <h3 style="color:blue"><asp:Label ID="lbldeff" runat="server"></asp:Label></h3>
                                   <%-- <form action="" class="cart">
                                        <div class="quantity">
                                            <input type="number" size="4" class="input-text qty text" title="Qty" value="1" name="quantity" min="1" step="1">
                                        </div>
                                        <button class="add_to_cart_button" type="submit">Add to cart</button>
                                    </form>  --%> 
                                    
                                   <%-- <div class="product-inner-category">
                                        <p>Category: <a href="">Summer</a>. Tags: <a href="">awesome</a>, <a href="">best</a>, <a href="">sale</a>, <a href="">shoes</a>. </p>
                                    </div>--%> 
                                    
                                    <div role="tabpanel">
                                        <ul class="product-tab" role="tablist">
                                            <li role="presentation" class="active"><a href="#home" aria-controls="home" role="tab" data-toggle="tab">Description</a></li>
                                            <%--<li role="presentation"><a href="#profile" aria-controls="profile" role="tab" data-toggle="tab">Reviews</a></li>--%>
                                        </ul>
                                        <div class="tab-content">
                                            <div role="tabpanel" class="tab-pane fade in active" id="home">
                                                <h2>Product Description</h2>  
                                               
                                              <p> <asp:Label ID="p1" runat="server" visible="false">

                                                </asp:Label></p>
                                                <p> <asp:Label ID="p2" runat="server" visible="false">

                                                </asp:Label></p>
                                                <p><asp:Label ID="p3" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p4" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p5" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p6" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p7" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p8" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p9" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p10" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p11" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p12" runat="server" visible="false">

                                                </asp:Label></p>
                                                <p><asp:Label ID="p13" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p14" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p15" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p16" runat="server" visible="false">

                                                </asp:Label></p>
                                              <p>  <asp:Label ID="p17" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p18" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p19" runat="server" visible="false">

                                                </asp:Label></p>
                                               <p> <asp:Label ID="p20" runat="server" visible="false">

                                                </asp:Label></p>
                                              <p>  <asp:Label ID="p21" runat="server" visible="false">

                                                </asp:Label></p>
                                            </div>
                                            <div role="tabpanel" class="tab-pane fade" id="profile">
                                                <h2>Reviews</h2>
                                                <div class="submit-review">
                                                    <p><label for="name">Name</label> <input name="name" type="text"></p>
                                                    <p><label for="email">Email</label> <input name="email" type="email"></p>
                                                    <div class="rating-chooser">
                                                        <p>Your rating</p>

                                                        <div class="rating-wrap-post">
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                        </div>
                                                    </div>
                                                    <p><label for="review">Your review</label> <textarea name="review" id="" cols="30" rows="10"></textarea></p>
                                                    <p><input type="submit" value="Submit"></p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <asp:Button ID="back" runat="server" Text="OK" CssClass="btn btn-warning pull-right" OnClick="back_Click" />
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

