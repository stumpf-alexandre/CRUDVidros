namespace CRUD.Models
{
    public class Glass
    {
        public Glass(){}

        public Glass(long id, string composition, int millim,long amount, long height, long width, string provider, long invoice){
            this.id=id;
            this.composition=composition;
            this.millim=millim;
            this.amount=amount;
            this.height=height;
            this.width=width;
            this.provider=provider;
            this.invoice=invoice;

        }

        public long id{get; set; }

        public string composition{get; set; }

        public long millim{get; set; }

        public long amount{get; set; }

        public long height{get; set; }

        public long width{get; set; }

        public string provider{get; set; }

        public long invoice{get; set; }
    }
}