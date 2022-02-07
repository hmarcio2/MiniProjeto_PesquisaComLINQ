using System.ComponentModel;

namespace MiniProjeto_PesquisaComLINQ.Models
{
    public enum Cidade
    {
        [Description("São Paulo")]
        saopaulo,
        [Description("Rio de Janeiro")]
        riodejaneiro,
        [Description("Santa Catarina")]
        santacatarina,
        [Description("João Pessoa")]
        joaopessoa,
        [Description("Recife")]
        recife,
        [Description("Natal")]
        natal,
        [Description("Florianópolis")]
        florianopolis
    }
}

public static class EnumExtensionMethods
{
    public static string GetEnumDescription(this Enum enumValue)
    {
        var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

        var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

        return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
    }
}