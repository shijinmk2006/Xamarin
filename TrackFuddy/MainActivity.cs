using Android.App;
using Android.Util;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Views;

namespace TrackFuddy
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        private const string TAG = "InfiniteScroll";

        private GridView _gridView;
        private MySimpleItemLoader _mySimpleItemLoader;
        private MyGridViewAdapter _gridviewAdapter;
        private readonly object _scrollLockObject = new object();
        private const int ItemsPerPage = 24;


        private const int LoadNextItemsThreshold = 6;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            SetupUiElements();

        }
        private void SetupUiElements()
        {
            _mySimpleItemLoader = new MySimpleItemLoader();
            _mySimpleItemLoader.LoadMoreItems(ItemsPerPage);

            _gridView = FindViewById<GridView>(Resource.Id.gridView);
            _gridviewAdapter = new MyGridViewAdapter(this, _mySimpleItemLoader);
            _gridView.Adapter = _gridviewAdapter;
            _gridView.Scroll += KeepScrollingInfinitely;
        }

        private void KeepScrollingInfinitely(object sender, AbsListView.ScrollEventArgs args)
        {
            lock (_scrollLockObject)
            {
                var mustLoadMore = args.FirstVisibleItem + args.VisibleItemCount >= args.TotalItemCount - LoadNextItemsThreshold;
                if (mustLoadMore && _mySimpleItemLoader.CanLoadMoreItems && !_mySimpleItemLoader.IsBusy)
                {
                    _mySimpleItemLoader.IsBusy = true;
                    Log.Info(TAG, "Requested to load more items");
                    _mySimpleItemLoader.LoadMoreItems(ItemsPerPage);
                    _gridviewAdapter.NotifyDataSetChanged();
                    _gridView.InvalidateViews();
                }
            }
        }

        bool BottomNavigationView.IOnNavigationItemSelectedListener.OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                   
                    return true;
                case Resource.Id.navigation_dashboard:
                   
                    return true;
                case Resource.Id.navigation_notifications:
                   
                    return true;
            }
            return false;
        }
    }
}

