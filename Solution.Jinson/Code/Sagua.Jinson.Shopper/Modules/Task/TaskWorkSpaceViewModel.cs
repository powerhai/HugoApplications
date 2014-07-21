using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Sagua.Jinson.Shopper.Common;
using Sagua.Jinson.Shopper.Domain;
using Sagua.Jinson.Shopper.Models;
using TaskStatus = Sagua.Jinson.Shopper.Domain.TaskStatus;

namespace Sagua.Jinson.Shopper.Modules.Task
{
    public class TaskWorkSpaceViewModel : BaseViewModel 
    {
        private ObservableCollection<UiTask> mTasks;

        public ObservableCollection<UiTask> Tasks
        {
            get
            {
                return mTasks ?? (mTasks = new ObservableCollection<UiTask>());
            } 
        }

        public TaskWorkSpaceViewModel ()
        {           
            Tasks.Add(new UiTask() { Date = DateTime.Now.AddDays(2), GoodsId = "123412352123", PlanCount = 12 , ShopType = ShopType.Taobao, TaskStatus = TaskStatus.Normal  });
            Tasks.Add(new UiTask() { Date = DateTime.Now.AddDays(1), GoodsId = "123412352123", PlanCount = 11,  ShopType = ShopType.Taobao, TaskStatus = TaskStatus.Normal  });
            Tasks.Add(new UiTask() { Date = DateTime.Now.AddDays(0), GoodsId = "123412352123", PlanCount = 10, RealCount = 2, ShopType = ShopType.Taobao, TaskStatus = TaskStatus.Execute  });
            Tasks.Add(new UiTask() { Date = DateTime.Now.AddDays(-1), GoodsId = "123412352123", PlanCount = 9, RealCount = 9, ShopType = ShopType.Taobao, TaskStatus = TaskStatus.Finish });
            Tasks.Add(new UiTask() { Date = DateTime.Now.AddDays(-2), GoodsId = "123412352123", PlanCount = 8, RealCount = 9, ShopType = ShopType.Taobao, TaskStatus = TaskStatus.Finish });
            Tasks.Add(new UiTask() { Date = DateTime.Now.AddDays(-3), GoodsId = "123412352123", PlanCount = 7, RealCount = 6, ShopType = ShopType.Taobao, TaskStatus = TaskStatus.Finish });
            Tasks.Add(new UiTask() { Date = DateTime.Now.AddDays(-4), GoodsId = "123412352123", PlanCount = 6, RealCount = 5, ShopType = ShopType.Taobao, TaskStatus = TaskStatus.Finish });
            Tasks.Add(new UiTask() { Date = DateTime.Now.AddDays(-5), GoodsId = "123412352123", PlanCount = 5, RealCount = 4, ShopType = ShopType.Taobao, TaskStatus = TaskStatus.Finish });
         }

        public ICommand DelTaskCommand
        {
            get
            {
                return new DelegateCommand<UiTask>((task) =>
                {
                    Tasks.Remove(task);
                });
            }
        }



        public ICommand EditTaskCommand
        {
            get
            {
                return new DelegateCommand<UiTask>((task) =>
                {

                });
            }

        }
      
      
        
    }
}
