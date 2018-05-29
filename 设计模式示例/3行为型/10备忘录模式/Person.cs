using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._10备忘录模式
{
    /// <summary>
    /// 数据对象：联系人
    /// </summary>
    [Serializable]
    public class Person
    {
        public string Name
        {
            get;
            set;
        }

        public string PhoneNum
        {
            get;
            set;
        }

        /// <summary>
        /// 对象
        /// </summary>
        public object Note
        {
            get;
            set;
        }

        /// <summary>
        /// 深拷贝
        /// </summary>
        public Person Clone()
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            binaryFormatter.Serialize(memoryStream, this);
            memoryStream.Position = 0;
            Person cloneObj = (Person)binaryFormatter.Deserialize(memoryStream);

            return cloneObj;
        }
    }
}
