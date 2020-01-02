using System.ComponentModel;

namespace WpfApp3.Core.Mode
{
    public enum GameMode:short
    {
        None=0,
        [Description("Метал и не метал")]
        MetalAndNotMetal=1,
        [Description("Оксиды и Кислоты")]
        OxidesAndAcids=2,
        [Description("Соль и основание")]
        SaltAndBase=3
    }
}