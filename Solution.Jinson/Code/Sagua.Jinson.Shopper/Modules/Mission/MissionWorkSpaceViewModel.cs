using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
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
using MessageBox = Xceed.Wpf.Toolkit.MessageBox;
namespace Sagua.Jinson.Shopper.Modules.Mission
{
    public class MissionWorkSpaceViewModel : BaseViewModel 
    {

        private MissionQueryForm mForm;
        public MissionQueryForm Form
        {
            get
            {
                return mForm ?? (mForm = new MissionQueryForm());
            }
            set
            {
                mForm = value;
                OnPropertyChanged();
            }
        }
      

        private readonly MissionController mMissionController;
        private ObservableCollection<UiMission> mTasks;
        private CollectionViewSource mMissions;
        private static object Lock = new object();
        public ObservableCollection<UiMission> Tasks
        {
            get
            {
                return mTasks ?? (mTasks = new ObservableCollection<UiMission>());
            } 
        }

        public CollectionViewSource Missions
        {
            get
            {
                if(mMissions == null)
                {
                    mMissions = new CollectionViewSource();
                    mMissions.Source = Tasks;
                    mMissions.View.SortDescriptions.Add(new SortDescription("Date", ListSortDirection.Descending));
                }
                return mMissions;
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




        public ICommand PublishMissionCommand
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    var mv = MessageBox.Show("相同日期相同宝贝的设置将会被覆盖，是否继续？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
                    if(mv == MessageBoxResult.Cancel)
                        return;
                    var rv = await mMissionController.PublishMission(Form.StartDate, Form.StartCount, Form.DayCount, Form.DayRise, Form.GoodsId, Form.Price  );
                    if(rv.IsOk)
                    {
                        foreach(var item in rv.Missions)
                        {
                           
                            if(Tasks.Any(a => a.ID == item.Id))
                            {
                                var task  = Tasks.First(a => a.ID == item.Id);
                                task.PlanCount = item.PlanCount;
                            } else
                            {
                                var task = new UiMission()
                                {
                                    Date = item.Date,
                                    GoodsId = item.GoodsId,
                                    ID = item.Id,
                                    PlanCount = item.PlanCount,
                                    TaskStatus = item.TaskStatus
                                };
                                this.Tasks.Add(task);
                            }
                        }
                    }
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
                    Tasks.Add(new UiMission(){ ID = item.Id, Date = item.Date, GoodsId = item.GoodsId, PlanCount = item.PlanCount, RealCount = item.RealCount, ShopType = item.ShopType, TaskStatus = item.MissionStatus });
                }
            }
            this.CloseBusyBox();
            
        }

    }
}
