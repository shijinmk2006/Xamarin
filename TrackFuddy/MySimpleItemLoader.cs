using System.Collections.Generic;

namespace TrackFuddy
{
    public class MySimpleItemLoader
    {
        public List<MySimpleItem> MySimpleItems { get; private set; }
        public bool CanLoadMoreItems { get; private set; }
        public bool IsBusy { get; set; }
        public int CurrentPageValue { get; set; }

        public MySimpleItemLoader()
        {
            MySimpleItems = new List<MySimpleItem>();
        }

        public  void LoadMoreItems(int itemsPerPage)
        {
            IsBusy = true;
            for (int i = CurrentPageValue; i < CurrentPageValue + itemsPerPage; i++)
            {
                MySimpleItems.Add( new MySimpleItem()
                {
                    ImageUrl = "https://loremflickr.com/680/480?random=" + (i + 1) + "",
                    DisplayName = string.Format("This is item {0:0000}", i),
                    Description = "Regular Men's Bottom waer",
                    OrginalPrice = 4000,
                    Discount = "40%",
                    Price = 1600
                });
            }
            // normally you'd check to see if the number of items returned is less than the number requested, i.e. you've run out, and then set this accordinly.
            CanLoadMoreItems = true;
            CurrentPageValue = MySimpleItems.Count;
            IsBusy = false;
        }
    }
}