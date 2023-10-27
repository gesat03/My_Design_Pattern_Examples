using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FurnitureFactoryExample
{
    public interface IFurniceFactory
    {
        IFurniture CreateFurniture();
    }
}
