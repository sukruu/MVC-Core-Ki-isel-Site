﻿using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = skillManager.TGetList();
            return View(values);
        }
    }
}



