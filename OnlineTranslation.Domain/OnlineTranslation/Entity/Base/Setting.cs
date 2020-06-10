namespace Rasmi724.Domain.Entity
{
    using Properties;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(nameof(Setting), Schema = "Base")]
    public class Setting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SettingId { get; set; }

        [Display(Name = nameof(DisplayName.DayToDelivery), ResourceType = typeof(DisplayName))]
        [Required(ErrorMessageResourceName = nameof(ErrorMessage.Required), ErrorMessageResourceType = typeof(ErrorMessage))]
        public byte DayToDelivery { get; set; }

        [Display(Name = nameof(DisplayName.LimitOrderOpenDay), ResourceType = typeof(DisplayName))]
        [Required(ErrorMessageResourceName = nameof(ErrorMessage.Required), ErrorMessageResourceType = typeof(ErrorMessage))]
        public int LimitOrderOpenDay { get; set; }
    }
}
