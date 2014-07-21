using System.ComponentModel.DataAnnotations;

namespace Sagua.Jinson.Shopper.Domain
{
    public enum TaskStatus
    {
        [Display(Name="待执行")]
        Normal,
        [Display(Name="执行中")]
        Execute,
        [Display(Name = "完成")]
        Finish,
    }
}