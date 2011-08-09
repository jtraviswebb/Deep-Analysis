using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Design;

namespace DeepAnalysis.Gui.WinForms
{
    public partial class CardListView : UserControl
    {
        public event EventHandler SelectedIndexChanged;

        private StringCollection items;
        private ListViewItem[] listViewItemCache; //array to cache items for the virtual list
        private int firstCachedIndex; //stores the index of the first item in the cache

        public CardListView()
        {
            InitializeComponent();
        }

        // BUG: the designer doesn't work
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [MergableProperty(false)]
        public StringCollection Items
        {
            get
            {
                if (this.items == null)
                {
                    this.items = new StringCollection(this);
                }
                return this.items;
            }
        }

        [Browsable(false)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get
            {
                if (listViewCards.SelectedIndices.Count > 0)
                {
                    return listViewCards.SelectedIndices[0];
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                if (value == -1)
                {
                    listViewCards.SelectedIndices.Clear();
                }
                else
                {
                    listViewCards.Items[value].Selected = true;
                    listViewCards.Select();
                }
            }
        }

        public string GetItemAt(int x, int y)
        {
            return Items[listViewCards.GetItemAt(x, y).Index];
        }

        public void EnsureVisible(int index)
        {
            listViewCards.EnsureVisible(index);
        }

        protected void OnSelectedIndexChanged(EventArgs e)
        {
            if (SelectedIndexChanged != null)
            {
                SelectedIndexChanged(this, e);
            }
        }

        private void listViewCards_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //The basic VirtualMode function.  Dynamically returns a ListViewItem
        //with the required properties; in this case, the square of the index.
        void listViewCards_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            //Caching is not required but improves performance on large sets.
            //To leave out caching, don't connect the CacheVirtualItems event 
            //and make sure myCache is null.

            //check to see if the requested item is currently in the cache
            //if (listViewItemCache != null && e.ItemIndex >= firstCachedIndex && e.ItemIndex < firstCachedIndex + listViewItemCache.Length)
            //{
            //    //A cache hit, so get the ListViewItem from the cache instead of making a new one.
            //    e.Item = listViewItemCache[e.ItemIndex - firstCachedIndex];
            //}
            //else
            //{
            //    //A cache miss, so create a new ListViewItem and pass it back.
            //    string imageListKey = items[e.ItemIndex];
            //    //if (!imageListCards.Images.ContainsKey(imageListKey))
            //    //{
            //    //    imageListCards.Images.Add(imageListKey, Bitmap.FromStream(System.Net.HttpWebRequest.Create(items[e.ItemIndex]).GetResponse().GetResponseStream()));
            //    //}
            //    e.Item = new ListViewItem(imageListKey);
            //    //e.Item = new ListViewItem("", imageListKey);
             
            //    //e.Item = new ListViewItem(items[e.ItemIndex]);
            //}
        }

        //Manages the cache.  ListView calls this when it might need a 
        //cache refresh.
        void listViewCards_CacheVirtualItems(object sender, CacheVirtualItemsEventArgs e)
        {
            //Console.WriteLine("cache");
            //We've gotten a request to refresh the cache.
            //First check if it's really neccesary.
            //if (listViewItemCache != null && e.StartIndex >= firstCachedIndex && e.EndIndex <= firstCachedIndex + listViewItemCache.Length)
            //{
            //    //If the newly requested cache is a subset of the old cache, 
            //    //no need to rebuild everything, so do nothing.
            //    return;
            //}

            ////Now we need to rebuild the cache.
            //firstCachedIndex = e.StartIndex;
            //int length = e.EndIndex - e.StartIndex + 1; //indexes are inclusive
            //listViewItemCache = new ListViewItem[length];

            ////Fill the cache with the appropriate ListViewItems.
            //for (int i = 0; i < length; i++)
            //{
            //    if (!imageListCards.Images.ContainsKey(items[i + firstCachedIndex]))
            //    {
            //        imageListCards.Images.Add(items[i + firstCachedIndex], Bitmap.FromStream(System.Net.HttpWebRequest.Create(items[i + firstCachedIndex]).GetResponse().GetResponseStream()));
            //    }
            //    listViewItemCache[i] = new ListViewItem("", items[i + firstCachedIndex]);
            //    //listViewItemCache[i] = new ListViewItem(items[i + firstCachedIndex]);
            //}

        }

        //This event handler enables search functionality, and is called
        //for every search request when in Virtual mode.
        void listViewCards_SearchForVirtualItem(object sender, SearchForVirtualItemEventArgs e)
        {
            Console.WriteLine("search");
            ////We've gotten a search request.
            ////In this example, finding the item is easy since it's
            ////just the square of its index.  We'll take the square root
            ////and round.
            //double x = 0;
            //if (Double.TryParse(e.Text, out x)) //check if this is a valid search
            //{
            //    x = Math.Sqrt(x);
            //    x = Math.Round(x);
            //    e.Index = (int)x;

            //}
            ////If e.Index is not set, the search returns null.
            ////Note that this only handles simple searches over the entire
            ////list, ignoring any other settings.  Handling Direction, StartIndex,
            ////and the other properties of SearchForVirtualItemEventArgs is up
            ////to this handler.
        }

        //TODO: Remove methods allow accumulation of images in the imagelist
        public class StringCollection : IList<string>
        {
            private List<string> items;
            private CardListView owner;

            public StringCollection(CardListView Owner)
            {
                items = new List<string>();
                owner = Owner;
            }

            public int IndexOf(string item)
            {
                return items.IndexOf(item);
            }

            public void Insert(int index, string item)
            {
                items.Insert(index, item);
                // update owner
                owner.imageListCards.Images.Add(item, Bitmap.FromStream(System.Net.HttpWebRequest.Create(item).GetResponse().GetResponseStream()));
                owner.listViewCards.Items.Insert(index, new ListViewItem("", item));
                //owner.listViewCards.VirtualListSize++;
            }

            public void RemoveAt(int index)
            {
                items.RemoveAt(index);
                // update owner
                owner.listViewCards.Items.RemoveAt(index);
                //owner.listViewCards.VirtualListSize--;
            }

            public string this[int index]
            {
                get
                {
                    return items[index];
                }
                set
                {
                    items[index] = value;
                    // update owner
                    if (!owner.imageListCards.Images.ContainsKey(value))
                    {
                        owner.imageListCards.Images.Add(value, Bitmap.FromStream(System.Net.HttpWebRequest.Create(value).GetResponse().GetResponseStream()));
                    }
                    owner.listViewCards.Items[index] = new ListViewItem("", value);
                }
            }

            public void Add(string item)
            {
                items.Add(item);
                // update owner
                owner.imageListCards.Images.Add(item, Bitmap.FromStream(System.Net.HttpWebRequest.Create(item).GetResponse().GetResponseStream()));
                owner.listViewCards.Items.Add(new ListViewItem("", item));
                //owner.listViewCards.VirtualListSize++;
            }

            public void Clear()
            {
                items.Clear();
                // update owner
                owner.listViewCards.Items.Clear();
                owner.imageListCards.Images.Clear();
                //owner.listViewCards.VirtualListSize = 0;
            }

            public bool Contains(string item)
            {
                return items.Contains(item);
            }

            public void CopyTo(string[] array, int arrayIndex)
            {
                items.CopyTo(array, arrayIndex);
            }

            public int Count
            {
                get { return items.Count; }
            }

            public bool IsReadOnly
            {
                get { return false; }
            }

            public bool Remove(string item)
            {
                //owner.listViewCards.VirtualListSize--;
                int index = items.IndexOf(item);
                owner.listViewCards.Items.RemoveAt(index);
                // update owner
                return items.Remove(item);
            }

            public IEnumerator<string> GetEnumerator()
            {
                return new StringCollectionEnumerator(this);
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return new StringCollectionEnumerator(this);
            }
        }

        public class StringCollectionEnumerator : IEnumerator<string>
        {
            private StringCollection items;
            private int position;

            public StringCollectionEnumerator(StringCollection Items)
            {
                items = Items;
                Reset();
            }

            public string Current
            {
                get { return items[position]; }
            }

            object System.Collections.IEnumerator.Current
            {
                get { return items[position]; }
            }

            public bool MoveNext()
            {
                if (position < items.Count - 1)
                {
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                position = -1;
            }

            public void Dispose()
            {
            }
        }
    }
}
