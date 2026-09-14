using Azure.AI.TextAnalytics;

namespace AI_supportsystem;

public static class TicketsData
{
    public static List<Ticket> GetTickets() => new()
    {
        new Ticket
        {
            Id = 1,
            Title = "Fy farao, smakar damm",
            Description = "Idag handlade jag två paket Vårrullar och ett paket Vinterrullar på thaikiosken nere vid hamnen. När jag åt första rullen fick jag flashbacks till min barndom i Egypten, det smakade mumie. Dammråttor och rödkål var inte den bästa smaken ni kommit på. Försök igen! Ni har förlorat en kund i mig.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "första rullen" },
                new Keyword { Text = "rödkål" },
                new Keyword { Text = "bästa smaken" },
                new Keyword { Text = "två paket" },
                new Keyword { Text = "Vårrullar" },
                new Keyword { Text = "Dammråttor" },
                new Keyword { Text = "Vinterrullar" },
                new Keyword { Text = "thaikiosken" },
                new Keyword { Text = "hamnen" },
                new Keyword { Text = "flashbacks" },
                new Keyword { Text = "barndom" },
                new Keyword { Text = "Egypten" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:27.996796Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 2,
            Title = "See you in court",
            Description = "Min advokat satte i halsen när han åt en av era Höstrullar. Jag måste nu hitta en ny advokat. När jag gjort det ska jag stämma er! Han är chockad. Chockad. Chockad. Helt paff.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "Höstrullar" },
                new Keyword { Text = "advokat" },
                new Keyword { Text = "halsen" }
            },
            Sentiment = TextSentiment.Negative,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:28.460814Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 3,
            Title = "Midsommar i munnen!",
            Description = "Era Sommarrullar är helt otroliga! Fräscha, krispiga, med mynta och mango som smakar svensk sommar när den är som bäst. Tog med dem till stranden och alla ville smaka. 10 av 10, köper igen imorgon.",
            Status = Status.Open,
            Priority = Priority.Medium,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "svensk sommar" },
                new Keyword { Text = "Sommarrullar" },
                new Keyword { Text = "mynta" },
                new Keyword { Text = "mango" },
                new Keyword { Text = "stranden" },
                new Keyword { Text = "imorgon" }
            },
            Sentiment = TextSentiment.Positive,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:28.674794Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 4,
            Title = "Jul i september? Skärp er",
            Description = "Vem släpper JulRullar i september? Jag var inte redo för nejlika och kanel när jag fortfarande äter glass. Kändes som att bli tvingad att lyssna på julmusik på Ica. Nej tack, håll er till säsongen.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "säsongen" },
                new Keyword { Text = "JulRullar" },
                new Keyword { Text = "nejlika" },
                new Keyword { Text = "kanel" },
                new Keyword { Text = "glass" },
                new Keyword { Text = "julmusik" }
            },
            Sentiment = TextSentiment.Negative,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:28.849752Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 5,
            Title = "Räddade min tentanatt",
            Description = "Klockan 03 på natten, snöstorm ute, kylskåpet tomt förutom ett paket Vinterrullar. Stekte dem och grät nästan av lycka. Varma, tröstande, perfekt hetta. Ni räddade min tenta i biologi.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "kylskåpet" },
                new Keyword { Text = "Klockan 03" },
                new Keyword { Text = "natten" },
                new Keyword { Text = "Vinterrullar" },
                new Keyword { Text = "lycka" },
                new Keyword { Text = "biologi" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:29.002584Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 6,
            Title = "Vårplåga, inte vårrulle",
            Description = "Köpte era Vårrullar full av förväntan på vårkänslor. De smakade blöt kartong och sorg. Kålen var brun, ytan var seg som ett cykeldäck. Till och med min katt vägrade. Gör om, gör rätt.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "förväntan" },
                new Keyword { Text = "blöt kartong" },
                new Keyword { Text = "vårkänslor" },
                new Keyword { Text = "Vårrullar" },
                new Keyword { Text = "Kålen" },
                new Keyword { Text = "cykeldäck" },
                new Keyword { Text = "sorg" },
                new Keyword { Text = "ytan" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:29.256067Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 7,
            Title = "Höstregn aldrig smakat bättre",
            Description = "Tända ljus, regn mot rutan, te och era Höstrullar med svamp och rotselleri. Så mysigt att jag nästan blev rörd. Äntligen någon som fattar hösten. Höstrullar för folket!",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "Tända ljus" },
                new Keyword { Text = "Höstrullar" },
                new Keyword { Text = "hösten" },
                new Keyword { Text = "svamp" },
                new Keyword { Text = "rotselleri" },
                new Keyword { Text = "folket" }
            },
            Sentiment = TextSentiment.Positive,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:29.413731Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 8,
            Title = "Tomten gråter",
            Description = "Prova era JulRullar med förväntan om julmys. Det smakade mest trist ris och en ledsen russin. Var är saffranet? Var är glöggen? Tomten hade gråtit om han smakat detta. Julstämning noll.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "förvänta" },
                new Keyword { Text = "trist ris" },
                new Keyword { Text = "ledsen russin" },
                new Keyword { Text = "glöggen" },
                new Keyword { Text = "Julstämning" },
                new Keyword { Text = "JulRullar" },
                new Keyword { Text = "julmys" },
                new Keyword { Text = "saffranet" },
                new Keyword { Text = "Tomten" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:29.566857Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 9,
            Title = "Strandens hjälte",
            Description = "Tog med en kasse Sommarrullar till grillkvällen på stranden. Kalla, fräscha med chilimajo. Alla frågade var jag köpt dem. Slut på fem minuter. Ni är legender på sommaren.",
            Status = Status.Open,
            Priority = Priority.Medium,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "grillkvällen" },
                new Keyword { Text = "fem minuter" },
                new Keyword { Text = "Sommarrullar" },
                new Keyword { Text = "stranden" },
                new Keyword { Text = "chilimajo" },
                new Keyword { Text = "sommaren" }
            },
            Sentiment = TextSentiment.Positive,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:29.772742Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 10,
            Title = "Smakade frysbox",
            Description = "Era Vinterrullar smakade som om de legat i en frysbox sedan istiden. Iskristaller inuti, bränd yta utanpå. Jag ville ha vintermys och fick frostskador i munnen. Uselt.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "bränd yta" },
                new Keyword { Text = "Vinterrullar" },
                new Keyword { Text = "frysbox" },
                new Keyword { Text = "istiden" },
                new Keyword { Text = "Iskristaller" },
                new Keyword { Text = "vintermys" },
                new Keyword { Text = "frostskador" }
            },
            Sentiment = TextSentiment.Negative,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:29.918001Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 11,
            Title = "Officiellt beroende",
            Description = "Jag är beroende av era Höstrullar. Äppel, kantarell och brynt smör, är ni helt sjuka i huvudet så bra det är? Har ätit dem fyra dagar i rad. Skicka hjälp. Och skicka fler Höstrullar.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "brynt smör" },
                new Keyword { Text = "fler Höstrullar" },
                new Keyword { Text = "kantarell" }
            },
            Sentiment = TextSentiment.Positive,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:30.069546Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 12,
            Title = "Explosion i airfryern",
            Description = "Stoppa in Vårrullar i airfryern på 200 grader. De exploderade som små vårbomber och fyllde hela köket med morotsstrimlor. Smaken var okej men städningen tog två timmar. Varningstext tack!",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "hela köket" },
                new Keyword { Text = "små vårbomber" },
                new Keyword { Text = "Vårrullar" },
                new Keyword { Text = "städningen" },
                new Keyword { Text = "två timmar" },
                new Keyword { Text = "airfryern" },
                new Keyword { Text = "200 grader" },
                new Keyword { Text = "morotsstrimlor" },
                new Keyword { Text = "Smaken" },
                new Keyword { Text = "Varningstext" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:30.313124Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 13,
            Title = "Saffran-GENI!",
            Description = "Era JulRullar med saffran, grönkål och julskinka är ett genidrag. Smakar julbord i miniformat. Doppade dem i senap och grät lite. Bästa ni gjort, snälla ha dem året runt.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "grönkål" },
                new Keyword { Text = "JulRullar" },
                new Keyword { Text = "saffran" },
                new Keyword { Text = "julskinka" },
                new Keyword { Text = "genidrag" },
                new Keyword { Text = "julbord" },
                new Keyword { Text = "senap" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:30.503838Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 14,
            Title = "Grillkvällens MVP",
            Description = "Lade Sommarrullar direkt på grillen två minuter per sida. Magiskt krisp med rökt smak. Serverade med lime och koriander. Gästerna trodde jag gått kockskola. Tack för det!",
            Status = Status.Open,
            Priority = Priority.Medium,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "rökt smak" },
                new Keyword { Text = "Gästerna" },
                new Keyword { Text = "Sommarrullar" },
                new Keyword { Text = "koriander" },
                new Keyword { Text = "kockskola" }
            },
            Sentiment = TextSentiment.Positive,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:30.670093Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 15,
            Title = "Luktar blöt hund",
            Description = "Öppnade paketet med Vinterrullar och hela köket luktade blöt hund och surkål. Vågade ändå smaka. Misstag. Smakade exakt som det luktade. Hur fick ni ens till det?",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "hela köket" },
                new Keyword { Text = "blöt hund" },
                new Keyword { Text = "surkål" },
                new Keyword { Text = "paketet" },
                new Keyword { Text = "Vinterrullar" },
                new Keyword { Text = "Misstag" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:30.885897Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 16,
            Title = "Till kräftskivan? Nja",
            Description = "Testade Höstrullar till kräftskivan som alternativ till paj. Helt okej, inte wow. Lite för mycket timjan för snapsvisor, men funkade med dillmajo. Godkänt, varken mer eller mindre.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "Höstrullar" },
                new Keyword { Text = "kräftskivan" },
                new Keyword { Text = "mycket timjan" },
                new Keyword { Text = "alternativ" },
                new Keyword { Text = "snapsvisor" }
            },
            Sentiment = TextSentiment.Negative,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:31.048437Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 17,
            Title = "Mormor godkänner!",
            Description = "Mormor som hatar allt nytt åt två Vårrullar och bad om receptet. Era Vårrullar med spetskål och ingefära är fräscha utan att vara konstiga. Det är det finaste betyg som finns i vår familj.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "Vårrullar" },
                new Keyword { Text = "spetskål" },
                new Keyword { Text = "ingefära" },
                new Keyword { Text = "finaste betyg" },
                new Keyword { Text = "Mormor" },
                new Keyword { Text = "receptet" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:31.295427Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 18,
            Title = "Glögg + rulle = sant",
            Description = "Varm glögg i ena handen, het JulRulle i andra. Ute snöar det, inne doftar det apelsin och kryddnejlika. Era JulRullar gjorde första advent perfekt. Kommer köpa tio paket till jul.",
            Status = Status.Open,
            Priority = Priority.Medium,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "Varm glögg" },
                new Keyword { Text = "första advent" },
                new Keyword { Text = "het JulRulle" },
                new Keyword { Text = "tio paket" },
                new Keyword { Text = "apelsin" },
                new Keyword { Text = "kryddnejlika" },
                new Keyword { Text = "JulRullar" }
            },
            Sentiment = TextSentiment.Positive,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:31.438314Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 19,
            Title = "Sladdriga och trötta",
            Description = "Era Sommarrullar skulle vara fräscha men var sladdriga och trötta. Risplattan var gummiaktig och fyllningen smakade mest vatten. Som en dålig hotellfrukost i juli. Besviken.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "dålig hotellfrukost" },
                new Keyword { Text = "Sommarrullar" },
                new Keyword { Text = "Risplattan" },
                new Keyword { Text = "fyllningen" },
                new Keyword { Text = "vatten" }
            },
            Sentiment = TextSentiment.Negative,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:31.59893Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 20,
            Title = "Åt 20 på raken, no regrets",
            Description = "Challenge med polarna: vem äter flest Vinterrullar på tio minuter. Jag vann med 20 stycken. Het chili, krispig yta, mjukt innanmäte. Mådde illa efteråt men det var värt det. Legendarisk kväll.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "Legendarisk kväll" },
                new Keyword { Text = "tio minuter" },
                new Keyword { Text = "Het chili" },
                new Keyword { Text = "polarna" },
                new Keyword { Text = "20 stycken" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:31.818576Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 21,
            Title = "Smakade lövhög",
            Description = "Era Höstrullar smakade som en blöt lövhög luktar. Jordigt på fel sätt, ingen sälta, ingen syra. Jag älskar hösten men detta var som att äta kompost. Kom igen nu.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "blöt lövhög" },
                new Keyword { Text = "fel sätt" },
                new Keyword { Text = "Höstrullar" },
                new Keyword { Text = "hösten" },
                new Keyword { Text = "syra" },
                new Keyword { Text = "kompost" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:31.977875Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 22,
            Title = "Barnen åt grönt!?",
            Description = "Mirakel! Barnen som vägrar allt grönt slukade era Vårrullar med morot och sötmajs. De trodde det var snacks. Tack för att ni lurar i dem grönsaker så jag slipper tjatet vid middagen.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "sötmajs" },
                new Keyword { Text = "grönsaker" },
                new Keyword { Text = "Mirakel" },
                new Keyword { Text = "snacks" },
                new Keyword { Text = "tet" },
                new Keyword { Text = "middagen" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:32.126521Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 23,
            Title = "Julrullebråk på jobbet",
            Description = "Tog med JulRullar till kontorets julfika. Halva gänget älskade dem, andra halvan tyckte saffran inte hör hemma i en rulle. Nästan slagsmål vid micron. Kul ändå, bra snackis.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "Halva gänget" },
                new Keyword { Text = "andra halvan" },
                new Keyword { Text = "slagsmål" },
                new Keyword { Text = "bra snackis" },
                new Keyword { Text = "JulRullar" },
                new Keyword { Text = "kontoret" },
                new Keyword { Text = "saffran" },
                new Keyword { Text = "micron" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:32.342092Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 24,
            Title = "Till sillen? Ja!",
            Description = "Konstig combo men Sommarrullar till midsommarsillen funkade klockrent. Svalkande efter sillen och nubben. Svärmor bad om recept. Aldrig trott jag skulle säga det om en vårrulle på midsommar.",
            Status = Status.Open,
            Priority = Priority.Medium,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "Konstig combo" },
                new Keyword { Text = "Svärmor" },
                new Keyword { Text = "vårrulle" },
                new Keyword { Text = "Sommarrullar" },
                new Keyword { Text = "midsommarsillen" },
                new Keyword { Text = "nubben" },
                new Keyword { Text = "recept" }
            },
            Sentiment = TextSentiment.Positive,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:32.499157Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 25,
            Title = "Värmde hela fjällstugan",
            Description = "Efter en dag i backen stekte vi Vinterrullar på muurikkan i fjällstugan. Doften av vitlök och chili spred sig i hela stugan. Åt dem med varm choklad till barnen. Kommer bli tradition.",
            Status = Status.Open,
            Priority = Priority.Medium,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "fjällstugan" },
                new Keyword { Text = "vitlök" },
                new Keyword { Text = "hela stugan" },
                new Keyword { Text = "varm choklad" },
                new Keyword { Text = "Vinterrullar" },
                new Keyword { Text = "kan" },
                new Keyword { Text = "Doften" },
                new Keyword { Text = "chili" },
                new Keyword { Text = "barnen" },
                new Keyword { Text = "tradition" }
            },
            Sentiment = TextSentiment.Positive,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:32.648057Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 26,
            Title = "Beställde höstmys, fick ångest",
            Description = "Ville ha mys med Höstrullar och film. Rullarna var så salta att jag fick dricka en liter vatten. Sedan var de kalla i mitten trots 15 minuter i ugnen. Kvällen förstörd, jag gick och la mig arg.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "Höstrullar" },
                new Keyword { Text = "Rullarna" },
                new Keyword { Text = "vatten" },
                new Keyword { Text = "mitten" },
                new Keyword { Text = "15 minuter" }
            },
            Sentiment = TextSentiment.Negative,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:32.911909Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 27,
            Title = "Sweet chili-himlen",
            Description = "Era klassiska Vårrullar plus extra sweet chili är ren magi. Krispet håller även som matlåda dagen efter, vilket är helt sjukt bra. Bästa vardagsräddaren i frysen just nu.",
            Status = Status.Open,
            Priority = Priority.Medium,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "Bästa vardagsräddaren" },
                new Keyword { Text = "a Vårrullar" },
                new Keyword { Text = "extra sweet chili" },
                new Keyword { Text = "ren magi" },
                new Keyword { Text = "låda" },
                new Keyword { Text = "Krispet" },
                new Keyword { Text = "frysen" }
            },
            Sentiment = TextSentiment.Positive,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:33.076565Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 28,
            Title = "Pepparkakspanik",
            Description = "Vem kom på att ha pepparkakssmul i JulRullar? Det smakar julgransplundring gone wrong. Sött, salt, surt på samma gång. Mitt barn grät, jag skrattade, min man blev tyst. Aldrig igen.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "JulRullar" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:33.224029Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 29,
            Title = "Grilla dem! Gör det!",
            Description = "Tips till alla: grilla Sommarrullar! Pensla med olja, direkt värme, servera med jordnötssås. Fick stående ovationer på grillfesten. Era Sommarrullar är gjorda för grillen.",
            Status = Status.Open,
            Priority = Priority.Medium,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "direkt värme" },
                new Keyword { Text = "jordnötssås" },
                new Keyword { Text = "stående ovationer" },
                new Keyword { Text = "Tips" },
                new Keyword { Text = "Sommarrullar" },
                new Keyword { Text = "grillfesten" }
            },
            Sentiment = TextSentiment.Positive,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:33.44633Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 30,
            Title = "Nyårssuccé",
            Description = "Serverade friterade Vinterrullar som tilltugg på nyår med champagne. Gästerna blev galna. Små, heta, eleganta. Mycket bättre än löjromstoast om ni frågar mig. Kommer bli stående inslag.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "stående inslag" },
                new Keyword { Text = "Gästerna" },
                new Keyword { Text = "löjromstoast" },
                new Keyword { Text = "erade" },
                new Keyword { Text = "Vinterrullar" },
                new Keyword { Text = "tilltugg" },
                new Keyword { Text = "år" },
                new Keyword { Text = "champagne" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:33.631759Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 31,
            Title = "Äntligen svamp!",
            Description = "Som svampnörd har jag väntat på detta: Höstrullar med smörstekt kantarell och timjan. Skogens smaker i krispig form. Lite dyra men värda varenda krona. Snälla sluta aldrig med dem.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "smörstekt kantarell" },
                new Keyword { Text = "svampnörd" },
                new Keyword { Text = "krispig form" },
                new Keyword { Text = "timjan" },
                new Keyword { Text = "Skogens" }
            },
            Sentiment = TextSentiment.Positive,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:33.78708Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 32,
            Title = "Smakade disktrasa",
            Description = "Stekte Vårrullar enligt anvisning men de smakade disktrasa och gammal olja. Hela lägenheten stank i två dagar. Fick vädra med alla fönster öppna i november. Aldrig mer.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "Hela lägenheten" },
                new Keyword { Text = "två dagar" },
                new Keyword { Text = "rullar" },
                new Keyword { Text = "anvisning" }
            },
            Sentiment = TextSentiment.Negative,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:33.964292Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 33,
            Title = "Julafton räddad",
            Description = "Glömde köpa prinskorv till julafton och panikade. Räddades av ett lager JulRullar i frysen. Barnen älskade dem, svärfar tog om tre gånger. Ni räddade vår jul, tack.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "svärfar" },
                new Keyword { Text = "prinskorv" },
                new Keyword { Text = "julafton" },
                new Keyword { Text = "JulRullar" },
                new Keyword { Text = "frysen" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:34.113665Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 34,
            Title = "Ljus i oktoberdeppet",
            Description = "Oktober, mörkt klockan fyra, allt suger. Då steker jag Sommarrullar och låtsas att det är juni. Lime, mynta och ljus sommarregn i munnen. Lite terapi i fryst form.",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "ljus sommarregn" },
                new Keyword { Text = "Oktober" },
                new Keyword { Text = "Sommarrullar" },
                new Keyword { Text = "Lime" },
                new Keyword { Text = "mynta" },
                new Keyword { Text = "terapi" }
            },
            Sentiment = TextSentiment.Negative,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:34.261568Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        },
        new Ticket
        {
            Id = 35,
            Title = "Blindtestade alla fem!",
            Description = "Körde blindtest med familjen: Vårrullar, Sommarrullar, Höstrullar, Vinterrullar och JulRullar. Vinnare blev Höstrullar, tätt följt av JulRullar. Sämst kom Vårrullar men de var också okej. Kul koncept med säsonger, fortsätt!",
            Status = Status.Open,
            Priority = Priority.High,
            Keywords = new List<Keyword>
            {
                new Keyword { Text = "Höstrullar" },
                new Keyword { Text = "Vår" },
                new Keyword { Text = "säsonger" },
                new Keyword { Text = "blindtest" },
                new Keyword { Text = "familjen" },
                new Keyword { Text = "Vinterrullar" },
                new Keyword { Text = "JulRullar" },
                new Keyword { Text = "Vinnare" }
            },
            Sentiment = TextSentiment.Mixed,
            CreatedAt = DateTime.Parse("2026-09-14T12:24:34.492185Z", null, System.Globalization.DateTimeStyles.RoundtripKind),
            ClosedAt = null,
            ContactInformation = ""
        }
    };
}
