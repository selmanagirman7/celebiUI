using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SliderManager : ISliderService
    {
        ISliderDal _slider;

        public SliderManager(ISliderDal slider)
        {
            _slider = slider;
        }

        public void Add(Slider slider)
        {
           _slider.Add(slider);
        }

        public Slider Get(int id)
        {
            return _slider.GetById(id);
        }

        public List<Slider> GetAll()
        {
            return _slider.GetAll();
        }

        public void Remove(Slider slider)
        {
           _slider.Delete(slider);
        }

        public void Update(Slider slider)
        {
           _slider.Update(slider);
        }
    }
}
