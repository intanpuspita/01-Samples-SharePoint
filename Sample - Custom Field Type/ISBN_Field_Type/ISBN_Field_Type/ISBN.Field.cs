using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.Security;

using System.Windows.Controls;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;

//using Contoso.SharePoint.WebControls;
using Contoso.System.Windows.Controls;
using System;

namespace Contoso.SharePoint
{
    class ISBNField : SPFieldText
    {
        public ISBNField(SPFieldCollection fields, string fieldName) : base(fields, fieldName){ }
        public ISBNField(SPFieldCollection fields, string typeName, string displayName) : base(fields, typeName, displayName){ }

        public override BaseFieldControl FieldRenderingControl
        {
            [SharePointPermission(SecurityAction.LinkDemand, ObjectModel = true)]
            get
            {
                BaseFieldControl fieldControl = new ISBNFieldControl();
                fieldControl.FieldName = this.InternalName;

                return fieldControl;
            }
        }

        public override string GetValidatedString(object value)
        {
            if ((this.Required == true)
               &&
               ((value == null)
                ||
               ((String)value == "")))
            {
                throw new SPFieldValidationException(this.Title
                    + " must have a value.");
            }
            else
            {
                ISBN10ValidationRule rule = new ISBN10ValidationRule();
                ValidationResult result = rule.Validate(value, CultureInfo.InvariantCulture);

                if (!result.IsValid)
                {
                    throw new SPFieldValidationException((String)result.ErrorContent);
                }
                else
                {
                    return base.GetValidatedString(value);
                }
            }
        }
    }
}
