using System;
using System.Timers;

class Grill
{
    static readonly MeatloafRepository MeatloafRepository = new MeatloafRepository();
    static readonly SteakRepository SteakRepository = new SteakRepository();
    static readonly BurgerRepository BurgerRepository = new BurgerRepository();

    static readonly WhiteBreadRepository WhiteBreadRepository = new WhiteBreadRepository();
    static readonly WholeGrainBreadRepository WholeGrainBreadRepository = new WholeGrainBreadRepository();

    static readonly RussianSaladRepository RussianSaladRepository = new RussianSaladRepository();
    static readonly SnowWhiteSaladRepository SnowWhiteSaladRepository = new SnowWhiteSaladRepository();
    static readonly TomatoAndCucumberSaladRepository TomatoAndCucumberSaladRepository = new TomatoAndCucumberSaladRepository();
    static readonly CarrotAndCabbageSaladRepository CarrotAndCabbageSaladRepository = new CarrotAndCabbageSaladRepository();

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

        seller.PlaceOrder(new Order(Order.Meat.Burger, Order.Bread.WhiteBread, Order.Salad.SnowWhiteSalad));
        seller.PlaceOrder(new Order(Order.Meat.Steak, Order.Bread.WhiteBread, Order.Salad.RussianSalad));
        seller.PlaceOrder(new Order(Order.Meat.Burger, Order.Bread.WholeGrainBread, Order.Salad.SnowWhiteSalad));
        seller.PlaceOrder(new Order(Order.Meat.Burger, Order.Bread.WholeGrainBread, Order.Salad.CarrortsAndCabbageSalad));
        seller.PlaceOrder(new Order(Order.Meat.Meatloaf, Order.Bread.WhiteBread, Order.Salad.RussianSalad));
        seller.PlaceOrder(new Order(Order.Meat.Steak, Order.Bread.WhiteBread, Order.Salad.TomatoesAndCucumberSalad));
        seller.PlaceOrder(new Order(Order.Meat.Meatloaf, Order.Bread.WholeGrainBread, Order.Salad.CarrortsAndCabbageSalad));

        // Run the grill for 5min.
        DateTime StartTime = DateTime.Now;
        while (true) {
            Double elapsedMillis = ((TimeSpan) (DateTime.Now - StartTime)).TotalMilliseconds;
            if (elapsedMillis > 5 * 60 * 1000) {
                break;
            }
        }

        seller.stop();
        kitchen.stop();
        return 0;
    }
}