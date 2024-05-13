protected void Page_Load(object EventArgs e){
    string currentTime = DateTime.now.Tostring()
    Response.Write(currentTime)
}