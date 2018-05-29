using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._10备忘录模式
{
    public class MemoDemo
    {
        public static void MemoDemoTest()
        {
            MobileOwner mobileOwner = new MobileOwner();
            MemoManager memoManager = new MemoManager();

            //备份1
            mobileOwner.AddPerson(new Person()
            {
                Name = "张三",
                PhoneNum = "13240320001",
                Note = 28.222222222
            });

            mobileOwner.AddPerson(new Person()
            {
                Name = "李四",
                PhoneNum = "13240320002",
                Note = "Hello"
            });

            mobileOwner.AddPerson(new Person()
            {
                Name = "王五",
                PhoneNum = "13240320003",
                Note = 27
            });

            mobileOwner.Print();
            Memo memo1 = mobileOwner.SaveMemo();
            memoManager.Add(1, memo1);

            //备份2
            mobileOwner.RemovePerson(mobileOwner.Persons[0]);

            mobileOwner.Print();
            Memo memo2 = mobileOwner.SaveMemo();
            memoManager.Add(2, memo2);

            //备份3
            mobileOwner.AddPerson(new Person()
            {
                Name = "赵六",
                PhoneNum = "13240320005",
                Note = System.DateTime.Now.ToString()
            });

            mobileOwner.Print();
            Memo memo3 = mobileOwner.SaveMemo();
            memoManager.Add(3, memo3);

            //测试
            int count = 5;

            do
            {
                System.Threading.Thread.Sleep(3000);

                //Console.Write("是否还原到最初版本？（Y/N）");
                //ConsoleKeyInfo cki = Console.ReadKey();

                //if (cki.KeyChar == 'y')
                //{
                //    mobileOwner.RestoreMemento(memoManager.Memos[1]);
                //    mobileOwner.Print();
                //}

                Console.WriteLine();
                Console.WriteLine("---------------------------------------------");
                Console.Write("是否还原到指定版本？（1-3，默认为1）");

                int num = 1;
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {

                }
                finally
                {
                    mobileOwner.RestoreMemo(memoManager.Memos[num]);
                    mobileOwner.Print();
                }

                count--;
            } while (count > 0);
        }
    }
}
