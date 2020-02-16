using System;
using System.Collections.Generic;
using System.Threading;

class SalesControllers : Controller
{
    static MeatloafRepository MeatloafRepository;
    static SteakRepository SteakRepository;
    static BurgerRepository BurgerRepository;

    static WhiteBreadRepository WhiteBreadRepository;
    static WholeGrainBreadRepository WholeGrainBreadRepository;

    static RussianSaladRepository RussianSaladRepository;
    static SnowWhiteSaladRepository SnowWhiteSaladRepository;
    static TomatoAndCucumberSaladRepository TomatoAndCucumberSaladRepository;
    static CarrotAndCabbageSaladRepository CarrotAndCabbageSaladRepository;

    static Queue<Order> orders = new Queue<Order>();

    public override void start()
    {
        seller.Start();
    }

    public override void stop()
    {
        try
        {
            seller.Abort();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void PlaceOrder(Order order)
    {
        orders.Enqueue(order);
    }

    private readonly Thread seller = new Thread(() => TakeOrders(MeatloafRepository, SteakRepository, BurgerRepository,
                                                                 WhiteBreadRepository, WholeGrainBreadRepository,
                                                                 RussianSaladRepository, SnowWhiteSaladRepository, TomatoAndCucumberSaladRepository, CarrotAndCabbageSaladRepository));

    private static void TakeOrders(MeatloafRepository meatloafRepository, SteakRepository steakRepository, BurgerRepository burgerRepository, WhiteBreadRepository whiteBreadRepository, WholeGrainBreadRepository wholeGrainBreadRepository, RussianSaladRepository russianSaladRepository, SnowWhiteSaladRepository snowWhiteSaladRepository, TomatoAndCucumberSaladRepository tomatoAndCucumberSaladRepository, CarrotAndCabbageSaladRepository carrotAndCabbageSaladRepository)
    {
        while (true)
        {
            if (orders.Count > 0)
            {
                Order order = orders.Dequeue();

                Product bread = null;
                switch (order.BreadOrder)
                {
                    case Order.Bread.WhiteBread:
                        {
                            GetWhiteBreadUseCase useCase = new GetWhiteBreadUseCase(whiteBreadRepository);
                            bread = useCase.Run();
                            break;
                        }
                    case Order.Bread.WholeGrainBread:
                        {
                            GetWholeGrainBreadUseCase useCase = new GetWholeGrainBreadUseCase(wholeGrainBreadRepository);
                            bread = useCase.Run();
                            break;
                        }
                }

                Product meat = null;
                switch (order.MeatOrder)
                {
                    case Order.Meat.Meatloaf:
                        {
                            GetMeatloafUseCase useCase = new GetMeatloafUseCase(meatloafRepository);
                            meat = useCase.Run();
                            break;
                        }
                    case Order.Meat.Steak:
                        {
                            GetSteakUseCase useCase = new GetSteakUseCase(steakRepository);
                            meat = useCase.Run();
                            break;
                        }
                    case Order.Meat.Burger:
                        {
                            GetBurgerUseCase useCase = new GetBurgerUseCase(burgerRepository);
                            meat = useCase.Run();
                            break;
                        }
                }

                Product salad = null;
                switch (order.SaladOrder)
                {
                    case Order.Salad.RussianSalad:
                        {
                            GetRussianSaladUseCase useCase = new GetRussianSaladUseCase(russianSaladRepository);
                            salad = useCase.Run()[0];
                            break;
                        }
                    case Order.Salad.SnowWhiteSalad:
                        {
                            GetSnowWhiteSaladUseCase useCase = new GetSnowWhiteSaladUseCase(snowWhiteSaladRepository);
                            salad = useCase.Run()[0];
                            break;
                        }
                    case Order.Salad.TomatoesAndCucumberSalad:
                        {
                            GetTomatoAndCucumberSaladUseCase useCase = new GetTomatoAndCucumberSaladUseCase(tomatoAndCucumberSaladRepository);
                            salad = useCase.Run()[0];
                            break;
                        }
                    case Order.Salad.CarrortsAndCabbageSalad:
                        {
                            GetCarrotAndCabbageSaladUseCase useCase = new GetCarrotAndCabbageSaladUseCase(carrotAndCabbageSaladRepository);
                            salad = useCase.Run()[0];
                            break;
                        }
                }

                CompletedOrder completedOrder = new CompletedOrder(meat, bread, salad);
                WriteOrderLogUseCase writeOrderLogUse = new WriteOrderLogUseCase(completedOrder);
                writeOrderLogUse.Run();
            }
        }
    }

    public SalesControllers(MeatloafRepository mr,
                      SteakRepository sr,
                      BurgerRepository br,
                      WhiteBreadRepository wbr,
                      WholeGrainBreadRepository wgbr,
                      RussianSaladRepository rsr,
                      SnowWhiteSaladRepository swsr,
                      TomatoAndCucumberSaladRepository tcsr,
                      CarrotAndCabbageSaladRepository ccsr)
    {
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
}
