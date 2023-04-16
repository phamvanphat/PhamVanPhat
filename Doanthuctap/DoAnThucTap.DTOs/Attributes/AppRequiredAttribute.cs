using DoAnThucTap.DTOs.Const;
using System.ComponentModel.DataAnnotations;

namespace DoAnThucTap.DTOs.Attributes
{
    public class AppRequiredAttribute : RequiredAttribute
    {
        public AppRequiredAttribute() : base()
        {
            ErrorMessage = AttributeErrMesg.REQUIRED;
        }
    }
}
