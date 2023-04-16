using DoAnThucTap.DTOs.Const;
using System.ComponentModel.DataAnnotations;

namespace DoAnThucTap.DTOs.Attributes
{
    public class AppRegexAttribute : RegularExpressionAttribute
    {
        public AppRegexAttribute(string pattern) : base(pattern)
        {
            ErrorMessage = AttributeErrMesg.REGEX;
        }
    }
}
