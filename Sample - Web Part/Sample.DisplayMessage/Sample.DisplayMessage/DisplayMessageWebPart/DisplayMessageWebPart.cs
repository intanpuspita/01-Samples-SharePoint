using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Sample.DisplayMessage.DisplayMessageWebPart
{

    public class DisplayMessageWebPart : WebPart
    {
        /**
         * Date : 04/08/2016 
         * Note : Displaying message and change action button
         * 
         **/
        private Button _button1;
        private Button _button2;
        private Label _label;

        protected override void Render(HtmlTextWriter writer)
        {
            writer.Write("Hello SharePoint 2010 (HtmlTextWriter)");
            writer.WriteBreak();

            _button1.RenderControl(writer);
            _button2.RenderControl(writer);
            _label.RenderControl(writer);
        }

        protected override void CreateChildControls()
        {
            base.CreateChildControls();

            _button1 = new Button { Text = "Click Me" };

            _button1.Click += (_button_Click);
            Controls.Add(_button1);

            _button2 = new Button { Text = "Clear" };
            _button2.Click += (_cancel_Click);
            _button2.Visible = false;
            Controls.Add(_button2);

            _label = new Label { Text = "" };
            Controls.Add(_label);
        }

        private void _button_Click(object sender, System.EventArgs e)
        {
            _label.Text = "Hello World !!!";

            _button1.Visible = false;
            _button2.Visible = true;
        }

        private void _cancel_Click(object sender, System.EventArgs e)
        {
            _label.Text = "";

            _button1.Visible = true;
            _button2.Visible = false;
        }
    }
}
