using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISliderService
    {
        Slider Get(int id);

        void Add(Slider slider);
        void Remove(Slider slider);
        void Update(Slider slider);
        List<Slider> GetAll();
    }
}
