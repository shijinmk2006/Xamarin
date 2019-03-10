using Android.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace TrackFuddy
{
    public class MyCustomListAdapter : BaseAdapter<User>
    {
        List<User> users;

        public MyCustomListAdapter(List<User> users)
        {
            this.users = users;
        }

        public override User this[int position]
        {
            get
            {
                return users[position];
            }
        }

        public override int Count
        {
            get
            {
                return users.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            //if (view == null)
            //{
            //    view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.CardView, parent, false);

            //    var photo = view.FindViewById<ImageView>(Resource.Id.photoImageView);
            //    var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
            //    var department = view.FindViewById<TextView>(Resource.Id.departmentTextView);

            //    view.Tag = new ViewHolder() { Photo = photo, Name = name, Department = department };
            //}

            //var holder = (ViewHolder)view.Tag;

            //holder.Photo.SetImageDrawable(ImageManager.Get(parent.Context, users[position].ImageUrl));
            //holder.Name.Text = users[position].Name;
            //holder.Department.Text = users[position].Department;


            return view;

        }
    }
}