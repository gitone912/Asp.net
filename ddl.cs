public void Page_Load(object EventArgs e){

}
protected void bt1_click(object EventArgs e){
    if(ddl1.SelectedValue==""){
        final.Text="please select any"
    }
    else{
        final.Text="you selected" + ddl.SelectedValue
    }
}