using Android.App;
using Android.Widget;
using Android.OS;

namespace BuenoApp01
{
	[Activity(Label = "BuenoApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
		Switch switch1;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);

			button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

			switch1 = FindViewById<Switch>(Resource.Id.switch1);
			switch1.CheckedChange += Switch1_CheckedChange;
			var text1 = FindViewById<TextView>(Resource.Id.textView1);
			text1.Visibility = Android.Views.ViewStates.Invisible;
		}

		void Switch1_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			var text1 = FindViewById<TextView>(Resource.Id.textView1);
			if (switch1.Checked)
			{
				text1.Visibility = Android.Views.ViewStates.Visible;
			}
			else
			{
				text1.Visibility = Android.Views.ViewStates.Invisible;
			}
		}
	}
}

