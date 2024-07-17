using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using guestEnterShabat.Repositories;

namespace guestEnterShabat.FormHendlrer
{
    internal class FormNavigator
    {

        public List<FoodForm> FoodFormList;
        public int I;
        public bool Flag;

        public FormNavigator(string name, int i=0, bool flag = false)
        {
            Flag = flag;
            if (flag)
            {
                FoodFormList = fromStringListToForm(name);
                if (i == FoodFormList.Count)
                {
                    I = 0;
                }
                else
                {
                    I = i;
                    
                }
                FoodFormList[I].Show();
            }
            else
            {
                FoodFormList = fromStringListToForm(name);
                if (i == 0)
                {
                    I = FoodFormList.Count;
                }
                else
                {
                    I = i;
                }
                    FoodFormList[I-1].Show();
            }
            

        }
        public List<FoodForm> fromStringListToForm(string name)
        {
            CategoryRepository cr = new CategoryRepository();
            List<string> ls = cr.GetAllString();
            List<FoodForm> frl = new List<FoodForm>();
            int i = 1;
            foreach (string item in ls)
            {
                FoodForm fr = new FoodForm(item, name, i++);
                
                frl.Add(fr);
            }
            return frl;
        }
/*        public void getNextForm()
        {
            if (I == FoodFormList.Count)
            {
                FoodFormList[I].Hide();
                I = 0;
                FoodFormList[I].Show();
            }
            else
            {
                FoodFormList[I].Hide();
                I++;
                FoodFormList[I].Show();
            }
        }
        public void getPrevForm()
        {
            if (I == 0)
            {
                FoodFormList[I].Hide();
                I = FoodFormList.Count;
                FoodFormList[I].Show();
            }
            else
            {
                FoodFormList[I].Hide();
                I--;
                FoodFormList[I].Show();
            }
        }*/
    }
}
