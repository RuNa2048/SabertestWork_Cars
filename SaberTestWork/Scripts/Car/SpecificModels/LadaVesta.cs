﻿//Также хотелось добавить тут некоторые особенности, которых нет
//у других машин по типу количества колёс, количества дверей и прочее.
//Но данные параметры просто устанавливаются через фабрику и не нуждается
//в особой механике

namespace SaberTestWork;

public class LadaVesta: PassengerCar
{
    public LadaVesta(Parts parts) : base(parts)
    {
    }
}