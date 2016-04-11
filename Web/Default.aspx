<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="hm.Web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="rt-container">
        <div class="rt-grid-9 rt-alpha">
            <div class="rt-block nomarginleft nomargintop">
                <div class="module-surround">
                    <div class="module-content">
                        <!-- START REVOLUTION SLIDER ver. 2.1.7 -->
                        <div id="rev_slider_1_1_wrapper" class="rev_slider_wrapper fullwidthbanner-container"
                            style="float: left; background-color: #E9E9E9; padding: 5px; margin-left: 0px;
                            margin-right: 0px; margin-top: 0px; margin-bottom: 0px; max-height: 350px; direction: ltr;">
                            <div id="rev_slider_1_1" class="rev_slider fullwidthabanner" style="display: none;
                                max-height: 350px; height: 350px;">
                                <ul>
                                    <li data-transition="random" data-slotamount="7" data-masterspeed="300">
                                        <img src="images/banner/1.jpg"/>
                                    </li>
                                    <li data-transition="random" data-slotamount="7" data-masterspeed="300">
                                        <img src="images/banner/2.jpg"/>
                                    </li>
                                    <li data-transition="random" data-slotamount="7" data-masterspeed="300">
                                        <img src="images/banner/3.jpg"/>
                                    </li>
                                    <li data-transition="random" data-slotamount="7" data-masterspeed="300">
                                        <img src="images/banner/4.jpg"/>
                                    </li>
                                    <%--<li data-transition="random" data-slotamount="7" data-masterspeed="300">
                                        <img src="images/banner/index5cd3.jpg?option=com_uniterevolution&amp;task=showimage&amp;img=aW1hZ2VzL2FuY2hvcl9iYW5uZXJfMy5qcGc=&amp;w=900&amp;h=350&amp;t=exact"
                                            alt="index" />
                                    </li>
                                    <li data-transition="random" data-slotamount="7" data-masterspeed="300">
                                        <img src="images/banner/indexb752.jpg?option=com_uniterevolution&amp;task=showimage&amp;img=aW1hZ2VzL2Jhbm5lcnMvTkQtUHJhaXJpZSBSZWZpbmVyeS1Hcm91bmRicmVha2luZy5qcGc=&amp;w=900&amp;h=350&amp;t=exact"
                                            alt="index" />
                                    </li>--%>
                                    <li data-transition="random" data-slotamount="7" data-masterspeed="300">
                                        <img src="images/banner/index6994.jpg?option=com_uniterevolution&amp;task=showimage&amp;img=aW1hZ2VzL2Jhbm5lcnMvQ0xNVC1jb2xsYWdlLmpwZw==&amp;w=900&amp;h=350&amp;t=exact"
                                            alt="index" />
                                    </li>
                                    <%--<li data-transition="random" data-slotamount="7" data-masterspeed="300" data-link="index7a2f.html?option=com_wrapper&amp;view=wrapper&amp;Itemid=140">
                                        <img src="images/banner/indexa82d.jpg?option=com_uniterevolution&amp;task=showimage&amp;img=aW1hZ2VzL2Jhbm5lcnMvQ0xNVC1OYXNkYXEtT3BlbmluZy1CZWxsLTEuanBn&amp;w=900&amp;h=350&amp;t=exact"
                                            alt="index" />
                                    </li>
                                    <li data-transition="random" data-slotamount="7" data-masterspeed="300" data-link="indexd462.html?option=com_content&amp;view=article&amp;id=42&amp;Itemid=154">
                                        <img src="images/banner/indexeddc.jpg?option=com_uniterevolution&amp;task=showimage&amp;img=aW1hZ2VzL2Jhbm5lcnMvTU8tR3JvdW5kYnJlYWtpbmctMjAxMy5qcGc=&amp;w=900&amp;h=350&amp;t=exact"
                                            alt="index" />
                                    </li>
                                    <li data-transition="random" data-slotamount="7" data-masterspeed="300" data-link="index7a2f.html?option=com_wrapper&amp;view=wrapper&amp;Itemid=140">
                                        <img src="images/banner/index2d0a.jpg?option=com_uniterevolution&amp;task=showimage&amp;img=aW1hZ2VzL2Jhbm5lcnMvQ0xNVC1OYXNkYXEtT3BlbmluZy1CZWxsLTIuanBn&amp;w=900&amp;h=350&amp;t=exact"
                                            alt="index" />
                                    </li>
                                    <li data-transition="random" data-slotamount="7" data-masterspeed="300" data-link="http://www.penreco.com/">
                                        <img src="images/banner/index467f.jpg?option=com_uniterevolution&amp;task=showimage&amp;img=aW1hZ2VzL2Jhbm5lcnMvcGVucmVjb19iYW5uZXIuanBn&amp;w=900&amp;h=350&amp;t=exact"
                                            alt="index" />
                                    </li>
                                    <li data-transition="random" data-slotamount="7" data-masterspeed="300">
                                        <img src="images/banner/indexc5ef.jpg?option=com_uniterevolution&amp;task=showimage&amp;img=L2ltYWdlcy9iYW5uZXJzL2NhbHVtZXQtaXItYXBwLWJhbm5lci05MDAtMzQ0LmpwZw==&amp;w=900&amp;h=350&amp;t=exact"
                                            alt="index" />
                                    </li>--%>
                                </ul>
                                <div class="tp-bannertimer">
                                </div>
                            </div>
                        </div>
                        <script type="text/javascript">

                            var tpj = jQuery;

                            tpj.noConflict();

                            var revapi1;

                            tpj(document).ready(function () {

                                if (tpj.fn.cssOriginal != undefined)
                                    tpj.fn.css = tpj.fn.cssOriginal;

                                if (tpj('#rev_slider_1_1').revolution == undefined)
                                    revslider_showDoubleJqueryError('#rev_slider_1_1', "joomla");
                                else
                                    revapi1 = tpj('#rev_slider_1_1').show().revolution(
					 {
					     delay: 9000,
					     startwidth: 900,
					     startheight: 350,
					     hideThumbs: 200,

					     thumbWidth: 100,
					     thumbHeight: 50,
					     thumbAmount: 5,

					     navigationType: "bullet",
					     navigationArrows: "verticalcentered",
					     navigationStyle: "round",

					     touchenabled: "on",
					     onHoverStop: "on",

					     shadow: 2,
					     fullWidth: "on",

					     navigationHAlign: "center",
					     navigationVAlign: "bottom",
					     navigationHOffset: 0,
					     navigationVOffset: 20,

					     stopLoop: "off",
					     stopAfterLoops: -1,
					     stopAtSlide: -1,

					     shuffle: "off",

					     hideSliderAtLimit: 0,
					     hideCaptionAtLimit: 0,
					     hideAllCaptionAtLilmit: 0
					 });

                            }); //ready
				
                        </script>
                        <!-- END REVOLUTION SLIDER -->
                    </div>
                </div>
            </div>
            <div class="rt-block ">
                <div class="module-surround">
                    <div class="module-content">
                        <div class="custom">
                            <p style="text-align: center;">
                                <strong><span style="font-size: large;">&nbsp;</span></strong></p>
                            <div style="text-align: center;">
                                <strong style="font-size: large;"><span style="font-size: large;">卡乐美公司是全球领先的高品质、专业烃类产品生产商。<br>
                                    <br>
                                    我们的产品包括环烷基基础油、石蜡基基础油、合成润滑油、脂肪族油类、沥青、燃料、白油、蜡类矿脂以及烃凝胶。</span></strong></div>
                            <div style="text-align: center;">
                                <strong style="font-size: large;"><span style="font-size: large;">&nbsp;</span></strong></div>
                            <p style="text-align: center;">
                                <strong style="font-size: large;"><span style="font-size: large;"><strong><span style="font-size: large;">
                                    卡乐美公司拥有世界上种类最多的特殊烃类产品加工能力。</span></strong><br /></span>
                                    <br />
                                    卡乐美官方网站：<a target="_blank" href="http://www.calumetspecialty.com">www.calumetspecialty.com</a></strong><br />
                                    <div style="font-size:14px;text-align:center">美国海瑞集团 ：<a target="_blank" href="http://www.thginfo.com">www.thginfo.com</a><br />
</div>
                                    
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="rt-grid-3 rt-omega">
            <div class="rt-block nomargintop nomarginleft">
                <div class="module-surround">
                    <div class="module-content">
                        <div class="customnomargintop nomarginleft">
                            <!-- Home Page Segments Menu -->
                            <!-- Asphalts -->
                            <div class="boxnav">
                                <a href="#" title="Asphalt Products">
                                    <img onmouseover="this.src='images/indexleft/10w.jpg';" onmouseout="this.src='images/indexleft/10.jpg';" alt="asphalts-2" src="images/indexleft/10.jpg"
                                        height="60" width="280" /></a></div>
                            <!-- Lubricants -->
                            <div class="boxnav">
                                <a href="#" title="Asphalt Products">
                                    <img onmouseover="this.src='images/indexleft/2w.jpg';" onmouseout="this.src='images/indexleft/2.jpg';" alt="asphalts-2" src="images/indexleft/2.jpg" height="60"
                                        width="280" /></a></div>
                            <!-- Branded -->
                           <div class="boxnav">
                                <a href="http://kalemei.korhst.ehtxidc.com/node.aspx?id=43" title="Asphalt Products">
                                    <img onmouseover="this.src='images/indexleft/9w.jpg" onmouseout="this.src='images/indexleft/9.jpg" alt="asphalts-2" src="images/indexleft/9.jpg" height="60"
                                        width="280" /></a></div>
                            <!-- Calumet Packaging -->
                            <div class="boxnav">
                                <a href="#" title="Asphalt Products">
                                    <img onmouseover="this.src='images/indexleft/4w.jpg';" onmouseout="this.src='images/indexleft/4.jpg';" alt="asphalts-2" src="images/indexleft/4.jpg" height="60"
                                        width="280" /></a></div>
                            <div class="boxnav">
                                <a href="#" title="Asphalt Products">
                                    <img onmouseover="this.src='images/indexleft/5w.jpg" onmouseout="this.src='images/indexleft/5.jpg" alt="asphalts-2" src="images/indexleft/5.jpg" height="60"
                                        width="280" /></a></div>
                            <!-- Penreco -->
                            <div class="boxnav">
                                <a href="#" title="Asphalt Products">
                                    <img onmouseover="this.src='images/indexleft/6w.jpg" onmouseout="this.src='images/indexleft/6.jpg" alt="asphalts-2" src="images/indexleft/6.jpg" height="60"
                                        width="280" /></a></div>
                            <!-- Solvents -->
                            <div class="boxnav">
                                <a href="#" title="Asphalt Products">
                                    <img onmouseover="this.src='images/indexleft/7w.jpg" onmouseout="this.src='images/indexleft/7.jpg" alt="asphalts-2" src="images/indexleft/7.jpg" height="60"
                                        width="280" /></a></div>
                            <!-- Esters -->
                            <div class="boxnav">
                                <a href="#" title="Asphalt Products">
                                    <img onmouseover="this.src='images/indexleft/8w.jpg" onmouseout="this.src='images/indexleft/8.jpg" alt="asphalts-2" src="images/indexleft/8.jpg" height="60"
                                        width="280" /></a></div>
                             <div class="boxnav">
                                <a href="#" title="Asphalt Products">
                                    <img onmouseover="this.src='images/indexleft/3w.jpg';" onmouseout="this.src='images/indexleft/3.jpg';" alt="asphalts-2" src="images/indexleft/3.jpg" height="60"
                                        width="280" /></a></div>
                            
                            
                                        <div class="boxnav">
                                <a href="#" title="Asphalt Products">
                                    <img onmouseover="this.src='images/indexleft/1w.jpg" onmouseout="this.src='images/indexleft/1.jpg" alt="asphalts-2" src="images/indexleft/1.jpg" height="60"
                                        width="280" /></a></div>
                            <div class="boxnav">
                                <a href="#" title="Asphalt Products">
                                    <img onmouseover="this.src='images/indexleft/11w.jpg" onmouseout="this.src='images/indexleft/11.jpg" alt="asphalts-2" src="images/indexleft/11.jpg"
                                        height="60" width="280" /></a></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="clear">
        </div>
    </div>
</asp:Content>
