//ENCAPSULATION
class properties
{
    public string stu_loginid { get; set; }

    public string stu_pass { get; set; }

    public int stu_fees { get; set; }

    public int fees = 30000;

    public string[][] data =
        {
            new string[]{"Stuti", "Stuti", "30000"},
            new string[]{"Krina", "Krina", "0"},
            new string[]{"", "", ""}
        };
}