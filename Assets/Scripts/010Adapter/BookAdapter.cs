using UnityEngine;
using System.Collections;

/// <summary>
/// 适配器模式
/// </summary>
public class BookAdapter : AbsEquipment
{
    private Book book;

    public BookAdapter(Book book)//使用BookAdapter使Book的方法适用于AbsEquipment的方法;
    {
        Name = "==BookAdapter==";
        this.book = book;
    }

    public override void TurnOn()
    {
        book.OpenBook();
    }

    public override void TurnOff()
    {
        book.CloseBook();
    }
}
