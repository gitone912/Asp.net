public void Page_Load(object EventArgs e){

}
protected void Btn1_click(object EventArgs e){
    var message ="";
    if(rb1.Checked){
        message= rb1.Text;
    }
    if(rb2.Checked){
        message=rb2.Text;
    }
    flabel.Text=message
}