protected void Page_load(object EventArgs e){

    using(SqlConnection con= new SqlConnection("data source="; database=student))
    {
        SqlDataAdapter sde = new SqlDataAdapter("Select * from student",con);
        DataSet ds= new DataSet()
        sde.fill(ds);
        DataGrid1.DataSource=ds;
        DataSrid1.DataBind();
    }
}