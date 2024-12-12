namespace CDX3.System.A
{
    public class Base
    {
        public int user_id { get; set; }
        public int tenant_code { get; set; }
        public string system_code { get; set; }
        public Base()
        {
            user_id = 0;
            tenant_code = 0;
            system_code = "";
        }
    }
}