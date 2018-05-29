using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLib._1创建型._03抽象工厂模式
{
    public class TangShiChineseSpell:ChineseSpellBase
    {
        public override void Spell()
        {
            Console.WriteLine("白日依山尽，黄河入海流。欲穷千里目，更上一层楼。");
        }
    }

    public class SongCiChineseSpell : ChineseSpellBase
    {
        public override void Spell()
        {
            Console.WriteLine("无言独上西楼，月如钩。寂寞梧桐深院锁清秋。剪不断，理还乱，是离愁。别是一般滋味在心头。");
        }
    }

    public class YuanQuChineseSpell : ChineseSpellBase
    {
        public override void Spell()
        {
            Console.WriteLine("怕见春归，枝上柳绵飞。静掩香闺，帘外晓莺啼。恨天涯锦字稀，梦才郎翠被知。宽尽衣，一搦腰肢细；痴，暗暗的添憔悴。秋景堪题，红叶满山溪。松径偏宜，黄菊绕东篱。正清樽斟泼醅，有白衣劝酒杯。官品极，到底成何济归，学取渊明醉。");
        }
    }

    public class MingXiaoShuoChineseSpell : ChineseSpellBase
    {
        public override void Spell()
        {
            Console.WriteLine("杭有卖果者，善藏柑，涉寒暑不溃。出之烨然，玉质而金色。置于市，贾十倍，人争鬻之。予贸得其一，剖之，如有烟扑口鼻，视其中，则干若败絮。予怪而问之曰：“若所市于人者，将以实笾豆，奉祭祀，供宾客乎？将炫外以惑愚瞽也？甚矣哉，为欺也！”卖者笑曰：“吾业是有年矣，吾赖是以食吾躯。吾售之，人取之，未尝有言，而独不足子所乎？世之为欺者不寡矣，而独我也乎？吾子未之思也。今夫佩虎符、坐皋比者，洸洸乎干城之具也，果能授孙、吴之略耶？ 峨大冠、 拖长绅者，昂昂乎庙堂之器也，果能建伊、皋之业耶？盗起而不知御，民困而不知救，吏奸而不知禁，法斁而不知理，坐糜廪粟而不知耻。观其坐高堂，骑大马，醉醇醴而饫肥鲜者，孰不巍巍乎可畏，赫赫乎可象也？又何往而不金玉其外，败絮其中也哉？今子是之不察，而以察吾柑！”予默默无以应。退而思其言，类东方生滑稽之流。岂其愤世疾邪者耶？而托于柑以讽耶？");
        }
    }
}
