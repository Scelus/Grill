﻿using System;
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
        seller.Abort();
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
        while(true)
        {
            try
            {
                Order order = orders.Dequeue();

                switch(order.MeatOrder) 
                {
                    case 1: 
                        {
                            GetMeatloafUseCase useCase = new GetMeatloafUseCase(meatloafRepository);
                            useCase.run();
                            break;
                        }
                    case 2:
                        {
                            GetSteakUseCase useCase = new GetSteakUseCase(steakRepository);
                            useCase.run();
                            break;
                        }
                    case 3:
                        {
                            GetBurgerUseCase useCase = new GetBurgerUseCase(burgerRepository);
                            useCase.run();
                            break;
                        }
                }

                switch (order.BreadOrder)
                {
                    case 1:
                        {
                            GetWhiteBreadUseCase useCase = new GetWhiteBreadUseCase(whiteBreadRepository);
                            useCase.run();
                            break;
                        }
                    case 2:
                        {
                            GetWholeGrainBreadUseCase useCase = new GetWholeGrainBreadUseCase(wholeGrainBreadRepository);
                            useCase.run();
                            break;
                        }
                }
            }
            catch (Exception e) 
            { 
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