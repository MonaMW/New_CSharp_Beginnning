namespace Begin_CSharp_2
{
    public interface IGeometry
    {
        //jede Klasse die von diesem Interface erbt muss diese zwei Methoden mit diesen Parametern haben
        float Flaeche();
        float Umfang();
    }
}