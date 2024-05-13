protected void Btn1_Click(object EventArgs e){
    genderlabel.Text="";
    if(rb1.Checked){
        genderlabel.Text="male";
    }
    else if(rb2.Checked){
        genderlabel.Text="female";
    }
    else{
        genderlabel.Text="error";
    }
}