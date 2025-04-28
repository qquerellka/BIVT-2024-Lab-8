using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using Internal;


namespace Lab_8
{
  internal class Program
  {
    static void Main()
    {
      Green g = new Green_1("Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"фьорды\", в Шотландии – \"фьордс\", в Исландии – \"фьордар\". Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.");
      g.Review();
      Console.WriteLine(g.ToString());

      Green g2 = new Green_2("Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"фьорды\", в Шотландии – \"фьордс\", в Исландии – \"фьордар\". Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.");
      g2.Review();
      Console.WriteLine(g2.ToString());
      Console.WriteLine(g2.ToString() == "п, д, в, р, у, и, к, о, с, т, э, а, л, м, ч, б, г, ж, з, н, ф, я");

      Green g5 = new Green_2("William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.");
      g5.Review();
      Console.WriteLine("Мое: " + g5.ToString());
      Console.WriteLine("Нужно: a, t, w, o, i, d, e, p, b, h, m, r, s, c, j, l, f, g, n, y");
      Console.WriteLine(g5.ToString() == "a, t, w, o, i, d, e, p, b, h, m, r, s, c, j, l, f, g, n, y");


      Green g3 = new Green_3("Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.", "ви");
      g3.Review();
      Console.WriteLine(g3.ToString());

      Green g4 = new Green_4("Иванов, Петров, Смирнов, Соколов, Кузнецов, Попов, Лебедев, Волков, Козлов, Новиков, Иванова, Петрова, Смирнова, ");
      g4.Review();
      Console.WriteLine(g4.ToString());

    }
  }
}