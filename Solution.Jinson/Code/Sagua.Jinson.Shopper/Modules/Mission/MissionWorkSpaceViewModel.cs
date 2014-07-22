using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;
using Sagua.Jingson.Shopper;
using Sagua.Jinson.Global.Domain;
using Sagua.Jinson.Shopper.Common;
using Sagua.Jinson.Shopper.Controllers;
using Sagua.Jinson.Shopper.Models;

namespace Sagua.Jinson.Shopper.Modules.Mission
{
    public class MissionWorkSpaceViewModel : BaseViewModel 
    {
        private readonly MissionController mMissionController;
        private ObservableCollection<UiMission> mTasks;
        private static object Lock = new object();
        public ObservableCollection<UiMission> Tasks
        {
            get
            {
                return mTasks ?? (mTasks = new ObservableCollection<UiMission>());
            } 
        }
        
        public MissionWorkSpaceViewModel (IUnityContainer container, MissionController missionController) : base(container)
        {
            mMissionController = missionController;
            BindingOperations.EnableCollectionSynchronization(Tasks, Lock);
        }

        public ICommand DelTaskCommand
        {
            get
            {
                return new DelegateCommand<UiMission>(async (task) =>
                {
                    ShowBusyBox();
                    var result = await  mMissionController.DeleteMission(task.ID);
                    if(result.IsOk)
                    {
                        Tasks.Remove(task);
                    } else
                    {
                        MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    CloseBusyBox();
                });
            }
        }



        public ICommand EditTaskCommand
        {
            get
            {
                return new DelegateCommand<UiMission>(async (task) =>
                {
                    var dialog = mContainer.Resolve<WindowModifyMission>();
                    dialog.Owner = App.Current.MainWindow;
                    dialog.ViewModel.Mission  = new UiMission( ){ ID = task.ID,  Date = task.Date , PlanCount = task.PlanCount, GoodsId = task.GoodsId, ShopType = task.ShopType};
                    var result = dialog.ShowDialog();

                    if (result.HasValue && result.Value == true)
                    {
                        var resultMission = dialog.ViewModel.Mission;
                        ShowBusyBox();
                        var serResult = await mMissionController.UpdateMission(resultMission.ID, resultMission.GoodsId, resultMission.PlanCount, resultMission.ShopType);
                        if (serResult.IsOk)
                        {
                            task.GoodsId = resultMission.GoodsId;
                            task.PlanCount = resultMission.PlanCount;
                            task.ShopType = resultMission.ShopType;
                        }
                        else
                        {
                            MessageBox.Show(serResult.ErrorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        CloseBusyBox();
                    }
                });
            }

        }

        public override async void LoadViewData ()
        {
            this.ShowBusyBox();
            var result =await mMissionController.GetMissionsOfBusinessUser();
            if(result.IsOk)
            {
                foreach(var item in result.Missions)
                {
                    Tasks.Add(new UiMission(){ ID = item.Id, GoodsId = item.GoodsId, PlanCount = item.PlanCount, RealCount = item.RealCount, ShopType = item.ShopType, TaskStatus = item.MissionStatus });
                }
            }
            this.CloseBusyBox();
            
        }
    }
}
