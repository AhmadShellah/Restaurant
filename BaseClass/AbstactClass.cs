namespace BaseClass
{
    public abstract class AbstactClass
    {
        public int Id { get; set; }     

        public string CreatedBy { get; set; }
        public string DeletedBy { get; set;}

        public string UpdateBy { get; set;}
        public DateTime UpdateDate { get; set;}
        public DateTime CreatedDate { get; set; }
        public DateTime DeletedDate { get; set;}
    }
}
