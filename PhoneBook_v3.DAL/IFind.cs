﻿namespace PhoneBook_v3.DAL;

public interface IFind<out T>
{
    public IEnumerable<T> FindById(int id);
    public IEnumerable<T> FindAllByField(string field, string value);
    public IEnumerable<T> GetAll();
}