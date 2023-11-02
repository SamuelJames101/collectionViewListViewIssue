using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace collectionViewListViewIssue;

public class MyViewModel : INotifyPropertyChanged
{
    private string[] words =
        "a\nability\nable\nabout\nabove\naccept\naccording\naccount\nacross\nact\naction\nactivity\nactually\nadd\naddress\nadministration\nadmit\nadult\naffect\nafter\nagain\nagainst\nage\nagency\nagent\nago\nagree\nagreement\nahead\nair\nall\nallow\nalmost\nalone\nalong\nalready\nalso\nalthough\nalways\nAmerican\namong\namount\nanalysis\nand\nanimal\nanother\nanswer\nany\nanyone\nanything\nappear\napply\napproach\narea\nargue\narm\naround\narrive\nart\narticle\nartist\nas\nask\nassume\nat\nattack\nattention\nattorney\naudience\nauthor\nauthority\navailable\navoid\naway\nbaby\nback\nbad\nbag\nball\nbank\nbar\nbase\nbe\nbeat\nbeautiful\nbecause\nbecome\nbed\nbefore\nbegin\nbehavior\nbehind\nbelieve\nbenefit\nbest\nbetter\nbetween\nbeyond\nbig\nbill\nbillion\nbit\nblack\nblood\nblue\nboard\nbody\nbook\nborn\nboth\nbox\nboy\nbreak\nbring\nbrother\nbudget\nbuild\nbuilding\nbusiness\nbut\nbuy\nby\ncall\ncamera\ncampaign\ncan\ncancer\ncandidate\ncapital\ncar\ncard\ncare\ncareer\ncarry\ncase\ncatch\ncause\ncell\ncenter\ncentral\ncentury\ncertain\ncertainly\nchair\nchallenge\nchance\nchange\ncharacter\ncharge\ncheck\nchild\nchoice\nchoose\nchurch\ncitizen\ncity\ncivil\nclaim\nclass\nclear\nclearly\nclose\ncoach\ncold\ncollection\ncollege\ncolor\ncome\ncommercial\ncommon\ncommunity\ncompany\ncompare\ncomputer\nconcern\ncondition\nconference\nCongress\nconsider\nconsumer\ncontain\ncontinue\ncontrol\ncost\ncould\ncountry\ncouple\ncourse\ncourt\ncover\ncreate\ncrime\ncultural\nculture\ncup\ncurrent\ncustomer\ncut\ndark\ndata\ndaughter\nday\ndead\ndeal\ndeath\ndebate\ndecade\ndecide\ndecision\ndeep\ndefense\ndegree\nDemocrat\ndemocratic\ndescribe\ndesign\ndespite\ndetail\ndetermine\ndevelop\ndevelopment\ndie\ndifference\ndifferent\ndifficult\ndinner\ndirection\ndirector\ndiscover\ndiscuss\ndiscussion\ndisease\ndo\ndoctor\ndog\ndoor\ndown\ndraw\ndream\ndrive\ndrop\ndrug\nduring\neach\nearly\neast\neasy\neat\neconomic\neconomy\nedge\neducation\neffect\neffort\neight\neither\nelection\nelse\nemployee\nend\nenergy\nenjoy\nenough\nenter\nentire\nenvironment\nenvironmental\nespecially\nestablish\neven\nevening\nevent\never\nevery\neverybody\neveryone\neverything\nevidence\nexactly\nexample\nexecutive\nexist\nexpect\nexperience\nexpert\nexplain\neye\nface\nfact\nfactor\nfail\nfall\nfamily\nfar\nfast\nfather\nfear\nfederal\nfeel\nfeeling\nfew\nfield\nfight\nfigure\nfill\nfilm\nfinal\nfinally\nfinancial\nfind\nfine\nfinger\nfinish\nfire\nfirm\nfirst\nfish\nfive\nfloor\nfly\nfocus\nfollow\nfood\nfoot\nfor\nforce\nforeign\nforget\nform\nformer\nforward\nfour\nfree\nfriend\nfrom\nfront\nfull\nfund\nfuture\ngame\ngarden\ngas\ngeneral\ngeneration\nget\ngirl\ngive\nglass\ngo\ngoal\ngood".Split("\n");

    private ObservableCollection<string> viewSource = new();

    public MyViewModel()
	{
        this.AddWordCommand = new Command(this.AddWord);
    }

    public Command AddWordCommand { get; set; }

    public ObservableCollection<string> ViewSource
    {
        get => this.viewSource;
        set
        {
            this.viewSource = value;
            this.OnPropertyChanged();
        }
    }

    private void AddWord()
    {
        Random random = new();

        var amount = words.Count();

        int number = random.Next(0, amount - 1);

        string myText = words[number] + " ";

        string myTextRandomLength = string.Concat(System.Linq.Enumerable.Repeat(myText, random.Next(1, 30)));

        this.ViewSource.Add(myTextRandomLength);
    }

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler PropertyChanged;
}

