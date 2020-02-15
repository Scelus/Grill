using System;
using System.Timers;

class Grill
{
    static MeatloafRepository MeatloafRepository = new MeatloafRepository();
    static SteakRepository SteakRepository = new SteakRepository();
    static BurgerRepository BurgerRepository = new BurgerRepository();


    static WhiteBreadRepository WhiteBreadRepository = new WhiteBreadRepository();
    static WholeGrainBreadRepository WholeGrainBreadRepository = new WholeGrainBreadRepository();


    static RussianSaladRepository RussianSaladRepository = new RussianSaladRepository();
    static SnowWhiteSaladRepository SnowWhiteSaladRepository = new SnowWhiteSaladRepository();
    static TomatoAndCucumberSaladRepository TomatoAndCucumberSaladRepository = new TomatoAndCucumberSaladRepository();
    static CarrotAndCabbageSaladRepository CarrotAndCabbageSaladRepository = new CarrotAndCabbageSaladRepository();

    public static int Main () {

        KitchenController kitchen = new KitchenController(
            MeatloafRepository,
            SteakRepository,
            BurgerRepository,
            WhiteBreadRepository,
            WholeGrainBreadRepository,
            RussianSaladRepository,
            SnowWhiteSaladRepository,
            TomatoAndCucumberSaladRepository,
            CarrotAndCabbageSaladRepository
        );

        SalesControllers seller = new SalesControllers(
            MeatloafRepository,
            SteakRepository,
            BurgerRepository,
            WhiteBreadRepository,
            WholeGrainBreadRepository,
            RussianSaladRepository,
            SnowWhiteSaladRepository,
            TomatoAndCucumberSaladRepository,
            CarrotAndCabbageSaladRepository
        );

        kitchen.start();
        seller.start();

        seller.PlaceOrder(new Order(1, 1, 1));
        seller.PlaceOrder(new Order(2, 1, 1));
        seller.PlaceOrder(new Order(1, 2, 1));

        DateTime StartTime = DateTime.Now;
        while (true) {
            Double elapsedMillis = ((TimeSpan) (DateTime.Now - StartTime)).TotalMilliseconds;
            if (elapsedMillis > 1 * 60 * 1000) {
                break;
            }
        }

        seller.stop();
        kitchen.stop();
        return 0;
    }
}