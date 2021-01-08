using System;

namespace StoreDB
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime Created { get; set; }
    }
}
