using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._3行为型._10备忘录模式
{
    /// <summary>
    /// 管理者角色：负责保存备忘录对象。
    /// </summary>
    public class MemoManager
    {
        private Dictionary<int, Memo> memos = new Dictionary<int, Memo>();
        /// <summary>
        /// 备忘录字典集合
        /// </summary>
        public Dictionary<int, Memo> Memos
        {
            get
            {
                return memos;
            }
            set
            {
                memos = value;
            }
        }

        public void Add(int index, Memo memo)
        {
            this.memos.Add(index, memo);
        }

        public void Update(int index, Memo memo)
        {
            this.memos[index] = memo;
        }

        public void Delete(int index)
        {
            this.memos.Remove(index);
        }
    }
}
