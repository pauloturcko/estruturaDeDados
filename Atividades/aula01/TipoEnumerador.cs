namespace aula01
{
    public class TipoEnumerador
    {
        public enum language
        {
            PTBR, EN, RU
            //Atributos da Classe
        }

        public language _language = language.PTBR;

        public TipoEnumerador(){

        }
        // public TipoEnumerador(TipoEnumerador enum){
        //     _language = enum;
        // };

        public language GetLanguageEnum(string lang)
        {
            switch (lang.ToLower()) {
                case "português": return language.PTBR;
                case "inglês": return language.EN;
                case "russo": return language.RU;
                default: return language.PTBR;
            }
        }
    }


}