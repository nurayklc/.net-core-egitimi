public abstract class Otomobil {
    public int TekerlekSayisi(){
        return 4;
    }

    public virtual Renk StandartRengi(){
        return Renk.Beyaz;
    }

    public abstract Marka Markasi();
}