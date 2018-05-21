<%-- The following 4 lines are ASP.NET directives needed when using SharePoint components --%>

<%@ Page Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage, Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" MasterPageFile="~masterurl/default.master" Language="C#" %>

<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<%-- The markup and script in the following Content element will be placed in the <head> of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
    <script type="text/javascript" src="../Scripts/jquery-1.9.1.min.js"></script>
    <script type="text/javascript" src="/_layouts/15/sp.runtime.js"></script>
    <script type="text/javascript" src="/_layouts/15/sp.js"></script>
    <script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js" type="text/javascript"></script>
    <script src="https://cdn.datatables.net/1.10.16/js/dataTables.bootstrap.min.js" type="text/javascript"></script>
    
    <meta name="WebPartPageExpansion" content="full" />

    <!-- Add your CSS styles to the following file -->
    <link rel="Stylesheet" type="text/css" href="../Content/App.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.css"/>

    <!-- Add your JavaScript to the following file -->
    <script type="text/javascript" src="../Scripts/App.js"></script>

    
</asp:Content>

<%-- The markup in the following Content element will be placed in the TitleArea of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server">
    Page Title
</asp:Content>

<%-- The markup and script in the following Content element will be placed in the <body> of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderMain" runat="server">

    <div>
        <p id="message">
            <!-- The following content will be replaced with the user name when you run the app - see App.js -->
            initializing...
        </p>
    </div>

    <div class="container">
         <div id="row4" class="row nopadding ">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-horizontal padLeftRight">
               <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 pleft0 pright0">
                  <div class="announcment paddingwebpart " style="background:white;">
                     <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 pleft0 pright0">
                        <h5 id="BtnAlign">
                           <a class="addbtn" target="_blank" style="color:white; text-decoration:none" data-target="#ModalForNewProject" data-toggle="modal">New Employee</a>
                        </h5>
                        <br>
                     </div>
                     <table id="subsiteList" class="table table-striped table-bordered">
                        <thead>
                           <tr>
                              <th>Employee Name</th>
                              <th>Designation</th>
                              <th>Address</th>
                              <th>Email</th>
                              <th>Blood Group</th>
                              <th>Emergency Contact</th>
                              <th>Mobile</th>
                              
                               <th>Edit</th>
                              <th>Delete</th>
                           </tr>
                        </thead>
                        <tbody></tbody>
                     </table>
                  </div>
               </div>
            </div>
         </div>
         <div class="modal fade" id="ModalForNewProject" role="dialog" title="Create new Project">
            <div class="modal-dialog">
               <fieldset>
                  <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 cls-contriute">
                     <h5 class="contributtitle">Add Employee Information</h5>
                  </div>
               </fieldset>
               <div id="ModelBody">
                  <div class="form-horizontal well bs-component cls-divthoug" id="ModalValidation">
                     <fieldset id="bodymodal">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought" >Employee Name
                           <span class="red">*</span>
                           </label>

                             <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought" >
                  <input type="text" id="txtempname" />
                           </label>


                                                  </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">Designation
                           <span class="red">*</span>
                           </label>

                             <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought" >
                  <input type="text" id="txtdesignation" />
                           </label>


                                                   </div>
                          <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">Email
                           <span class="red">*</span>
                           </label>

                              <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">
                          <input type="text" id="txtemail" />
                           </label>


                                                   </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">Mobile
                           <span class="red">*</span>
                           </label>

                             <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">
                             <input type="text" id="txtmobile" />
                           </label>

                                                  </div>

                          <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">Blood Group
                           <span class="red">*</span>
                           </label>


                                <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">
                        <input type="text" id="txtbloodgrp" />
                        
                           </label>

                                                  </div>
                          <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">Address for communication
                           <span class="red">*</span>
                           </label>


                               <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">
                       <input type="text" id="txtaddress" />
                           </label>

                                                  </div>

                         <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">Emergency contact
                           <span class="red">*</span>
                           </label>


                               <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">
                            <input type="text" id="txtemergency" />
                           </label>


                                                  </div>

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <div class="col-lg-offset-7 col-lg-2 cls-divbtn ">
                              <input class="cls-savecancel" id="btnsave" type="button" onclick="createListItem();" value="Submit" />
                           </div>
                           <div class="col-lg-2 col-lg-offset-1">
                              <input class="cls-savecancel" type="reset" value="Cancel" id="btnCancel"  data-dismiss="modal" />
                           </div>
                        </div>
                     </fieldset>
                  </div>
                                           </div>
         </div>
      </div>
      
      <!-- update modal -->
      
       <div class="modal fade" id="ModalForUpdateEmployee" role="dialog" title="Update New Employee">
            <div class="modal-dialog">
               <fieldset>
                  <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 cls-contriute">
                     <h5 class="contributtitle">Update Employee Information</h5>
                  </div>
               </fieldset>
               <div id="ModelBody">
                  <div class="form-horizontal well bs-component cls-divthoug" id="ModalValidation">
                     <fieldset id="bodymodal">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought" >Employee Name
                           <span class="red">*</span>
                           </label>

                             <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought" >
                         
                                 <input type="text" id="txtempnames" />

                           </label>


                                                  </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">Designation
                           <span class="red">*</span>
                           </label>
                                <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought" >
                         
                                 <input type="text" id="txtdesignations" />

                           </label>

                                                 </div>
                          <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">Email
                           <span class="red">*</span>
                           </label>

                                  <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought" >
                         
                                 <input type="text" id="txtemails" />

                           </label>

                                                  </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">Mobile
                           <span class="red">*</span>
                           </label>
                                <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought" >
                         
                                 <input type="text"  id="txtmobiles"/>

                           </label>

                                                  </div>

                          <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">Blood Group
                           <span class="red">*</span>
                           </label>
                                   <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought" >
                         
                                 <input type="text" id="txtbloodgrps" />

                           </label>


                                                  </div>
                          <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">Address for communication
                           <span class="red">*</span>
                           </label>

                                   <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought" >
                         
                                 <input type="text"  id="txtaddresss"/>

                           </label>

                                                  </div>

                         <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought">Emergency contact
                           <span class="red">*</span>
                                   </label>
                                    <label class="col-lg-4 col-md-4 col-sm-4 col-xs-4 cls-thought" >
                         
                                 <input type="text" id="txtemergencys" />

                           </label>

                       
                                                  </div>

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 form-group">
                           <div class="col-lg-offset-7 col-lg-2 cls-divbtn ">
                              <input class="cls-savecancel" id="btnsave" type="button" onclick="update(uid);" value="Submit" />
                           </div>
                           <div class="col-lg-2 col-lg-offset-1">
                              <input class="cls-savecancel" type="reset" value="Cancel" id="btnCancel"  data-dismiss="modal" />
                           </div>
                        </div>
                     </fieldset>
                  </div>
         </div>
         </div>
      </div>

      
      
      
      
      <!--end-->
      
	</div>
         
         
    
      
	


</asp:Content>
