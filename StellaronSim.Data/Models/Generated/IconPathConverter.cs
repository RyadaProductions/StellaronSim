using System.Text.Json;
using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
internal class IconPathConverter : JsonConverter<IconPath>
{
    public override bool CanConvert(Type t) => t == typeof(IconPath);

    public override IconPath Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value switch
        {
            "2077c52919d0f523755a4d92ce338874b71561611a436572d8eb315a34f4a4c2" => IconPath
                .The2077C52919D0F523755A4D92Ce338874B71561611A436572D8Eb315A34F4A4C2,
            "2bf7f8117bb4bac5bac4a4b7866f2bf3c272b526b8d945ece48991383f5f9f96" => IconPath
                .The2Bf7F8117Bb4Bac5Bac4A4B7866F2Bf3C272B526B8D945Ece48991383F5F9F96,
            "2d1ce81848ae3af0e819f7f98badde6930dd127f20a6d2686eb806bc963989d5" => IconPath
                .The2D1Ce81848Ae3Af0E819F7F98Badde6930Dd127F20A6D2686Eb806Bc963989D5,
            "5b7a8da3b4d685c3e9cc470faae12c21e3fd75df90cd8fcfcd6c8f2784c02a3f" => IconPath
                .The5B7A8Da3B4D685C3E9Cc470Faae12C21E3Fd75Df90Cd8Fcfcd6C8F2784C02A3F,
            "5e0ea9beeaea4aebaec6fa80218757c7123e5d8d63565bc255c08d6af87ebc7e" => IconPath
                .The5E0Ea9Beeaea4Aebaec6Fa80218757C7123E5D8D63565Bc255C08D6Af87Ebc7E,
            "61fabc866a9c5c20a0ae994d2d92a286ce89872e01eb8e1a772e28eaa9260177" => IconPath
                .The61Fabc866A9C5C20A0Ae994D2D92A286Ce89872E01Eb8E1A772E28Eaa9260177,
            "6acd635b37377d308961b26cf64a7a0ceed4e922bdf0427b620249351796ecd4" => IconPath
                .The6Acd635B37377D308961B26Cf64A7A0Ceed4E922Bdf0427B620249351796Ecd4,
            "6cee422fdfafd9cab8ce9f5a86a717d069964985d2e079d359713385c93d67fb" => IconPath
                .The6Cee422Fdfafd9Cab8Ce9F5A86A717D069964985D2E079D359713385C93D67Fb,
            "70505c64ff7cb3df4a9faf76eb488438570422a20d9dd2f42225da1dd1c97648" => IconPath
                .The70505C64Ff7Cb3Df4A9Faf76Eb488438570422A20D9Dd2F42225Da1Dd1C97648,
            "7a1ea0cc58c53a61531e85b23c6f87852baae61b6f28018447b08a617cb93e1d" => IconPath
                .The7A1Ea0Cc58C53A61531E85B23C6F87852Baae61B6F28018447B08A617Cb93E1D,
            "9560c98da124f605af2e45c09f26a0b8ee24c3aa357b9701464d7c04adcd0da7" => IconPath
                .The9560C98Da124F605Af2E45C09F26A0B8Ee24C3Aa357B9701464D7C04Adcd0Da7,
            "a493793d3b77e04dfb9b717f664a7d46c36a9a8a043dedf7049a10a628eebd8e" => IconPath
                .A493793D3B77E04Dfb9B717F664A7D46C36A9A8A043Dedf7049A10A628Eebd8E,
            "b10a43943e57ac6452d5a3a6d13a98d314da19edcff2fe7de6e53bc2d55a6894" => IconPath
                .B10A43943E57Ac6452D5A3A6D13A98D314Da19Edcff2Fe7De6E53Bc2D55A6894,
            "fe44fb655f65017dcad0c260b4dcffe14de4b14816734239c2c60d4624cf8163" => IconPath
                .Fe44Fb655F65017Dcad0C260B4Dcffe14De4B14816734239C2C60D4624Cf8163,
            _ => throw new Exception("Cannot unmarshal type IconPath")
        };
    }

    public override void Write(Utf8JsonWriter writer, IconPath value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case IconPath.The2077C52919D0F523755A4D92Ce338874B71561611A436572D8Eb315A34F4A4C2:
                JsonSerializer.Serialize(writer, "2077c52919d0f523755a4d92ce338874b71561611a436572d8eb315a34f4a4c2",
                    options);
                return;
            case IconPath.The2Bf7F8117Bb4Bac5Bac4A4B7866F2Bf3C272B526B8D945Ece48991383F5F9F96:
                JsonSerializer.Serialize(writer, "2bf7f8117bb4bac5bac4a4b7866f2bf3c272b526b8d945ece48991383f5f9f96",
                    options);
                return;
            case IconPath.The2D1Ce81848Ae3Af0E819F7F98Badde6930Dd127F20A6D2686Eb806Bc963989D5:
                JsonSerializer.Serialize(writer, "2d1ce81848ae3af0e819f7f98badde6930dd127f20a6d2686eb806bc963989d5",
                    options);
                return;
            case IconPath.The5B7A8Da3B4D685C3E9Cc470Faae12C21E3Fd75Df90Cd8Fcfcd6C8F2784C02A3F:
                JsonSerializer.Serialize(writer, "5b7a8da3b4d685c3e9cc470faae12c21e3fd75df90cd8fcfcd6c8f2784c02a3f",
                    options);
                return;
            case IconPath.The5E0Ea9Beeaea4Aebaec6Fa80218757C7123E5D8D63565Bc255C08D6Af87Ebc7E:
                JsonSerializer.Serialize(writer, "5e0ea9beeaea4aebaec6fa80218757c7123e5d8d63565bc255c08d6af87ebc7e",
                    options);
                return;
            case IconPath.The61Fabc866A9C5C20A0Ae994D2D92A286Ce89872E01Eb8E1A772E28Eaa9260177:
                JsonSerializer.Serialize(writer, "61fabc866a9c5c20a0ae994d2d92a286ce89872e01eb8e1a772e28eaa9260177",
                    options);
                return;
            case IconPath.The6Acd635B37377D308961B26Cf64A7A0Ceed4E922Bdf0427B620249351796Ecd4:
                JsonSerializer.Serialize(writer, "6acd635b37377d308961b26cf64a7a0ceed4e922bdf0427b620249351796ecd4",
                    options);
                return;
            case IconPath.The6Cee422Fdfafd9Cab8Ce9F5A86A717D069964985D2E079D359713385C93D67Fb:
                JsonSerializer.Serialize(writer, "6cee422fdfafd9cab8ce9f5a86a717d069964985d2e079d359713385c93d67fb",
                    options);
                return;
            case IconPath.The70505C64Ff7Cb3Df4A9Faf76Eb488438570422A20D9Dd2F42225Da1Dd1C97648:
                JsonSerializer.Serialize(writer, "70505c64ff7cb3df4a9faf76eb488438570422a20d9dd2f42225da1dd1c97648",
                    options);
                return;
            case IconPath.The7A1Ea0Cc58C53A61531E85B23C6F87852Baae61B6F28018447B08A617Cb93E1D:
                JsonSerializer.Serialize(writer, "7a1ea0cc58c53a61531e85b23c6f87852baae61b6f28018447b08a617cb93e1d",
                    options);
                return;
            case IconPath.The9560C98Da124F605Af2E45C09F26A0B8Ee24C3Aa357B9701464D7C04Adcd0Da7:
                JsonSerializer.Serialize(writer, "9560c98da124f605af2e45c09f26a0b8ee24c3aa357b9701464d7c04adcd0da7",
                    options);
                return;
            case IconPath.A493793D3B77E04Dfb9B717F664A7D46C36A9A8A043Dedf7049A10A628Eebd8E:
                JsonSerializer.Serialize(writer, "a493793d3b77e04dfb9b717f664a7d46c36a9a8a043dedf7049a10a628eebd8e",
                    options);
                return;
            case IconPath.B10A43943E57Ac6452D5A3A6D13A98D314Da19Edcff2Fe7De6E53Bc2D55A6894:
                JsonSerializer.Serialize(writer, "b10a43943e57ac6452d5a3a6d13a98d314da19edcff2fe7de6e53bc2d55a6894",
                    options);
                return;
            case IconPath.Fe44Fb655F65017Dcad0C260B4Dcffe14De4B14816734239C2C60D4624Cf8163:
                JsonSerializer.Serialize(writer, "fe44fb655f65017dcad0c260b4dcffe14de4b14816734239c2c60d4624cf8163",
                    options);
                return;
            default:
                throw new Exception("Cannot marshal type IconPath");
        }
    }

    public static readonly IconPathConverter Singleton = new IconPathConverter();
}