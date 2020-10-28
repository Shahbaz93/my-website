<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ReturnPoly.aspx.cs" Inherits="ReturnPoly" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="product-big-title-area">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="product-bit-title text-center">
                        <h2>Return Policy</h2>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <div class="single-product-area">
        <div class="zigzag-bottom"></div>
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="product-content-right">
                        <div class="woocommerce">
                            <asp:Button ID="back" runat="server" Text="OK" CssClass="btn btn-warning pull-right" OnClick="back_Click" />
                            <div class="row" style="padding: 2%">
                                <h1>RETURN POLICY
                                </h1>
                                <br />
                                <p>
                                    Thank you for your purchase. We hope you are happy with your purchase. However, if you are not completely satisfied with your purchase for any reason, you may return it to us for an exchange only. Please see below for more information on our return policy.
                                </p>
                                <br />
                                <h2>RETURNS
                                </h2>
                                <br />
                                <p>
                                    All returns must be postmarked within seven (7) days of the purchase date. All returned items must be in new and unused condition, with all original tags and labels attached.
                                </p>
                                <br />
                                <h2>RETURN PROCESS
                                </h2>
                                <br />
                                <p>
                                    To return an item, please email customer service at return@killdeal.in to obtain a Return Merchandise Authorization (RMA) number. After receiving a RMA number, place the item securely in its original packaging and A note stating what happened with the product., and mail your return to the following address:
                                </p>
                                <p>
                                    KillDeal
                                </p>
                                <p>
                                    Attn: Returns
                                </p>
                                <p>
                                    RMA #
                                </p>
                                <p>
                                    9, India Exchange Place Road, Ground Floor  
                                </p>
                                <p>
                                    Kolkata, West Bengal 700001  
                                </p>
                                <p>
                                    India  
                                </p>
                                <p>
                                    Please note, you will be responsible for all return shipping charges. We strongly recommend that you use a trackable method to mail your return. 

                                </p>
                                <br />
                                <h2>REFUNDS
                                </h2>
                                <br />
                                <p>
                                    After receiving your return and inspecting the condition of your item, we will process your exchange. Please allow at least one (1) days from the receipt of your item to process your exchange. We will notify you by email when your return has been processed.
                                </p>
                                <br />
                                <h2>EXCEPTIONS  
                                </h2>
                                <br />
                                <p>
                                    For defective or damaged products, please contact us at the customer service number below to arrange a refund or exchange. 
                                </p>
                                <p>
                                    <b>Please Note
                                    </b>
                                </p>
                                <p>
                                    <b>&#x2022;</b>Sale items are FINAL SALE and cannot be returned.
                                </p>
                                <p>
                                    <b>&#x2022;</b>Product brought dead or anything happening within 7 days would be considered for 
                                </p>
                                <p>
                                    product exchange or return. Whereas any physical damage or dead due to drop will void the manufacture warranty. Product would be replaced as per the stock count - pending shipment = your product refulfillment.   
                                </p>
                                <br />
                                <h1>QUESTIONS
                                </h1>
                                <br />

                                <p>
                                    If you have any questions concerning our return policy, please contact us at:
                                </p>
                                <p>
                                    03340203380 
                                </p>
                                <p>
                                    return@killdeal.in
                                </p>
                            </div>
                            <asp:Button ID="Button1" runat="server" Text="OK" CssClass="btn btn-warning pull-right" OnClick="back_Click" />

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>

