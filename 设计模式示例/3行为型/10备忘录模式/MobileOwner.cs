using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._10备忘录模式
{
    /// <summary>
    /// 发起人角色：记录当前时刻的内部状态，负责创建和恢复备忘录数据。
    /// </summary>
    public class MobileOwner
    {
        private List<Person> persons = new List<Person>();
        /// <summary>
        /// 联系人集合
        /// </summary>
        public List<Person> Persons
        {
            get
            {
                return persons;
            }
            set
            {
                persons = value;
            }
        }

        public MobileOwner()
        {

        }

        public void AddPerson(Person person)
        {
            this.persons.Add(person);
        }

        public void RemovePerson(Person person)
        {
            this.persons.Remove(person);
        }

        /// <summary>
        /// 创建备忘录
        /// </summary>
        public Memo SaveMemo()
        {
            Memo cm = new Memo();

            // 下面这种方式是错误的，因为这样传递的是引用，
            // 则删除一次可以恢复，但恢复之后再删除的话就恢复不了.
            // 所以应该传递contactPersonBack的深拷贝，深拷贝可以使用序列化来完成。
            //cm.ContactPersons = this.ContactPersons;

            //深拷贝
            foreach (Person person in this.Persons)
                cm.Persons.Add(person.Clone());

            return cm;
        }

        /// <summary>
        /// 恢复备忘录
        /// </summary>
        public void RestoreMemo(Memo cm)
        {
            this.persons.Clear();
            //深拷贝
            foreach (Person person in cm.Persons)
                this.persons.Add(person.Clone());
        }

        public void Print()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("手机中共有{0}个联系人：", this.Persons.Count);

            for (int index = 0, count = this.Persons.Count; index < count; index++)
            {
                Person person = this.Persons[index];

                Console.WriteLine("{0}.姓名：{1}，电话：{2}，备注：{3}。", index + 1, person.Name, person.PhoneNum, person.Note);
            }
        }
    }
}
