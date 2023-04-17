using System.Runtime.Serialization.Formatters.Binary;

public static class MakarSerialize
{
    static BinaryFormatter formatter = new BinaryFormatter();
    public static T Deserialize<T>(string filename)
    {
        var path = filename;

        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
        {
            return (T)formatter.Deserialize(fs);
        }
    }

    public static void Serialize<T>(T obj, string filename)
    {
        using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, obj);
        }
    }
}
