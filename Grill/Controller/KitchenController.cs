using System; 
using System.Threading;

class KitchenController: Controller {

    static MeatloafRepository MeatloafRepository;
    static SteakRepository SteakRepository;
    static BurgerRepository BurgerRepository;

    static WhiteBreadRepository WhiteBreadRepository;
    static WholeGrainBreadRepository WholeGrainBreadRepository;


    static RussianSaladRepository RussianSaladRepository;
    static SnowWhiteSaladRepository SnowWhiteSaladRepository;
    static TomatoAndCucumberSaladRepository TomatoAndCucumberSaladRepository;
    static CarrotAndCabbageSaladRepository CarrotAndCabbageSaladRepository;

    public KitchenController(MeatloafRepository mr, 
                      SteakRepository sr,
                      BurgerRepository br,
                      WhiteBreadRepository wbr,
                      WholeGrainBreadRepository wgbr,
                      RussianSaladRepository rsr,
                      SnowWhiteSaladRepository swsr,
                      TomatoAndCucumberSaladRepository tcsr,
                      CarrotAndCabbageSaladRepository ccsr) {
                          MeatloafRepository = mr;
                          SteakRepository = sr;
                          BurgerRepository = br;

                          WhiteBreadRepository = wbr;
                          WholeGrainBreadRepository = wgbr;

                          RussianSaladRepository = rsr;
                          SnowWhiteSaladRepository = swsr;
                          TomatoAndCucumberSaladRepository = tcsr;
                          CarrotAndCabbageSaladRepository = ccsr;
                      }

    private readonly Thread meatChef = new Thread(() => CookMeat(MeatloafRepository, SteakRepository, BurgerRepository));
    private readonly Thread breadChef = new Thread(() => BakeBread(WhiteBreadRepository, WholeGrainBreadRepository));
    private readonly Thread saladChef = new Thread(() => TossSalad(RussianSaladRepository, SnowWhiteSaladRepository, TomatoAndCucumberSaladRepository, CarrotAndCabbageSaladRepository));


    override public void start() {
        meatChef.Start();
        breadChef.Start();
        saladChef.Start();
    }

    override public void stop() {
        try
        {
            meatChef.Abort();
            breadChef.Abort();
            saladChef.Abort();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static void CookMeat (MeatloafRepository mr, SteakRepository sr, BurgerRepository br) {

        Random rnd = new Random();

        while (true) {
            switch(rnd.Next(1, 4)) {
                case 1: {
                    PrepareMeatloafUseCase useCase = new PrepareMeatloafUseCase(mr);
                    useCase.Run();
                    break;
                }
                case 2: {
                    PrepareBurgerUseCase useCase = new PrepareBurgerUseCase(br);
                    useCase.Run();
                    break;
                }
                case 3: {
                    PrepareSteakUseCase useCase = new PrepareSteakUseCase(sr);
                    useCase.Run();
                    break;
                }
            }
        }
    }

    static void BakeBread (WhiteBreadRepository wbr, WholeGrainBreadRepository wgr) {

        Random rnd = new Random();

        while (true) {
            switch(rnd.Next(1, 3)) {
                case 1: {
                    PrepareWhiteBreadUseCase useCase = new PrepareWhiteBreadUseCase(wbr);
                    useCase.Run();
                    break;
                }
                case 2: {
                    PrepareWholeGrainBreadUseCase useCase = new PrepareWholeGrainBreadUseCase(wgr);
                    useCase.Run();
                    break;
                }
            }
        }
    }

    static void TossSalad (RussianSaladRepository rsr, SnowWhiteSaladRepository swr,
        TomatoAndCucumberSaladRepository tcsr, CarrotAndCabbageSaladRepository ccr) {

        Random rnd = new Random();

        while (true) {
            switch(rnd.Next(1, 5)) {
                case 1: {
                    PrepareRussianSaladUseCase useCase = new PrepareRussianSaladUseCase(rsr);
                    useCase.Run();
                    break;
                }
                case 2: {
                    PrepareSnowWhiteSaladUseCase useCase = new PrepareSnowWhiteSaladUseCase(swr);
                    useCase.Run();
                    break;
                }
                case 3: {
                    PrepareTomatoAndCucumberSaladUseCase useCase = new PrepareTomatoAndCucumberSaladUseCase(tcsr);
                    useCase.Run();
                    break;
                }
                case 4: {
                    PrepareCarrotAndCabbageSaladUseCase useCase = new PrepareCarrotAndCabbageSaladUseCase(ccr);
                    useCase.Run();
                    break;
                }
            }
        }
    }
}