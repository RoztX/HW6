using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public class Starter
    {
        public void Run()
        {
            var container = new StringBuilder();
            var actions = new Actions();
            for (var i = 0; i < 100; i++)
            {
                Random random = new Random();
                switch (random.Next(0, 3))
                {
                    case 0:
                        actions.First();
                        break;
                    case 1:
                        actions.Second();
                        break;
                    case 2:
                        actions.Third();
                        break;
                }

                container.Append(Logger.Instance.Logs[i] + "s\n");
            }

            File.WriteAllText("log.txt", container.ToString());
        }
    }
}
