using Android.Content;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using Bumptech.Glide;
using Bumptech.Glide.Request;
using Square.Picasso;
using System.Net;
using TrackFuddy.Resources.layout;

namespace TrackFuddy
{
    public class MyGridViewAdapter : BaseAdapter<MySimpleItem>
    {
        private readonly MySimpleItemLoader _mySimpleItemLoader;
        private readonly Context _context;
        RequestOptions requestOptions = null;
       
        public MyGridViewAdapter(Context context, MySimpleItemLoader mySimpleItemLoader)
        {
            _context = context;
            _mySimpleItemLoader = mySimpleItemLoader;
            requestOptions = new RequestOptions();
            requestOptions.Placeholder(Resource.Drawable.Triangles);
            requestOptions.Error(Resource.Drawable.pumafull);
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _mySimpleItemLoader.MySimpleItems[position];

            View itemView = convertView ?? LayoutInflater.From(_context).Inflate(Resource.Layout.CardView, parent, false);
            var tvDisplayName = itemView.FindViewById<TextView>(Resource.Id.title);
            var imgThumbail = itemView.FindViewById<ImageView>(Resource.Id.thumbnail);
            var count = itemView.FindViewById<TextView>(Resource.Id.count);
            var price = itemView.FindViewById<TextView>(Resource.Id.price);
            var overflowimage = itemView.FindViewById<ImageView>(Resource.Id.overflow);
            tvDisplayName.Text = "Persian";
            count.Text = "100";
            price.Text = "200.00";
            imgThumbail.Click += delegate {
                Intent intent = new Intent(this._context, typeof(DetailView));
                _context.StartActivity(intent);
            };
            Picasso.With(imgThumbail.Context).Load(item.ImageUrl).Placeholder(Resource.Drawable.pumafull).Error(Resource.Drawable.Icon).
                Into(imgThumbail);

            //Glide.With(imgThumbail.Context).SetDefaultRequestOptions(requestOptions).AsGif().Load(item.ImageUrl).

            //    Into(imgThumbail);
            return itemView;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override int Count
        {
            get { return _mySimpleItemLoader.MySimpleItems.Count; }
        }

        public override MySimpleItem this[int position]
        {
            get { return _mySimpleItemLoader.MySimpleItems[position]; }
        }
    }
}