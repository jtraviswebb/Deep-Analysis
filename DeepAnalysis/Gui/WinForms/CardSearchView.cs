using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeepAnalysis.Core;

namespace DeepAnalysis.Gui.WinForms
{
    public partial class CardSearchView : UserControl
    {
        private Database cardDatabase;
        private List<Card> searchResults;
        //private ListViewItem[] listViewItemCache; //array to cache items for the virtual list
        //private int firstCachedIndex; //stores the index of the first item in the cache

        public Database CardDatabase
        {
            get { return cardDatabase; }
            set 
            {
                cardDatabase = value;

                if (cardDatabase != null)
                {
                    //toolStripDropDownButtonEditions.DropDownItems.Clear();
                    //foreach (Edition edition in cardDatabase.Editions)
                    //{
                    //    ToolStripMenuItem item = new ToolStripMenuItem(edition.Name);
                    //    item.CheckOnClick = true;
                    //    item.Checked = true;
                    //    item.CheckStateChanged += new EventHandler(toolStripMenuItemEdition_CheckStateChanged);
                    //    toolStripDropDownButtonEditions.DropDownItems.Add(item);
                    //}
                    Search();
                }
            }
        }

        public CardSearchView()
        {
            InitializeComponent();
        }

        private void Search()
        {
            if (CardDatabase == null)
            {
                return;
            }

            IEnumerable<Card> currentResults = (IEnumerable<Card>)CardDatabase.Cards;

            // filter name
            {
                string name = toolStripTextBoxName.Text.Trim().ToLower();
                if (name != string.Empty)
                {
                    currentResults = from card in currentResults where card.Name.ToLower().Contains(name) select card;
                }
            }

            // filter text
            {
                string text = toolStripTextBoxOracleText.Text.Trim().ToLower();
                if (text != string.Empty)
                {
                    currentResults = from card in currentResults where card.Text.ToLower().Contains(text) select card;
                }
            }

            // filter manacost
            {
                string exactManaCost = toolStripTextBoxExactManaCost.Text.Trim().ToLower();
                if (exactManaCost != string.Empty)
                {
                    currentResults = from card in currentResults where card.Cost.ToString().ToLower() == exactManaCost select card;
                }
            }

            // filter cmc
            {
                string targetCmcString = toolStripTextBoxCmc.Text.Trim();
                if (targetCmcString != string.Empty)
                {
                    int targetCmc;
                    if (int.TryParse(targetCmcString, out targetCmc))
                    {
                        switch (toolStripDropDownButtonCmcRelation.Text)
                        {
                            case "=":
                                currentResults = from card in currentResults where card.Cost.ConvertedManaCost == targetCmc select card;
                                break;
                            case ">":
                                currentResults = from card in currentResults where card.Cost.ConvertedManaCost > targetCmc select card;
                                break;
                            case "<":
                                currentResults = from card in currentResults where card.Cost.ConvertedManaCost < targetCmc select card;
                                break;
                            default:
                                throw new NotImplementedException();
                        }
                    }
                }
            }

            // filter colors
            {
                if (!toolStripButtonExcludeUnselectedColors.Checked)
                {
                    currentResults = from card in currentResults
                                     where card.Cost.IsWhite && toolStripButtonShowWhite.Checked ||
                                         card.Cost.IsBlue && toolStripButtonShowBlue.Checked ||
                                         card.Cost.IsBlack && toolStripButtonShowBlack.Checked ||
                                         card.Cost.IsRed && toolStripButtonShowRed.Checked ||
                                         card.Cost.IsGreen && toolStripButtonShowGreen.Checked ||
                                         card.Cost.IsColorless && toolStripButtonShowColorless.Checked
                                     select card;
                }
                else
                {
                    currentResults = from card in currentResults
                                     where !(card.Cost.IsWhite && !toolStripButtonShowWhite.Checked ||
                                         card.Cost.IsBlue && !toolStripButtonShowBlue.Checked ||
                                         card.Cost.IsBlack && !toolStripButtonShowBlack.Checked ||
                                         card.Cost.IsRed && !toolStripButtonShowRed.Checked ||
                                         card.Cost.IsGreen && !toolStripButtonShowGreen.Checked ||
                                         card.Cost.IsColorless && !toolStripButtonShowColorless.Checked)
                                     select card;
                }
            }

            // filter types
            {
                if (!toolStripButtonExcludeUnselectedTypes.Checked)
                {
                    currentResults = from card in currentResults
                                     where card.Typeline.Contains("Artifact") && toolStripButtonShowArtifacts.Checked ||
                                     card.Typeline.Contains("Creature") && toolStripButtonShowCreatures.Checked ||
                                     card.Typeline.Contains("Enchantment") && toolStripButtonShowEnchantments.Checked ||
                                     card.Typeline.Contains("Instant") && toolStripButtonShowInstants.Checked ||
                                     card.Typeline.Contains("Land") && toolStripButtonShowLands.Checked ||
                                     card.Typeline.Contains("Planeswalker") && toolStripButtonShowPlaneswalkers.Checked ||
                                     card.Typeline.Contains("Sorcery") && toolStripButtonShowSorceries.Checked
                                     select card;
                }
                else
                {
                    currentResults = from card in currentResults
                                     where !(card.Typeline.Contains("Artifact") && !toolStripButtonShowArtifacts.Checked ||
                                     card.Typeline.Contains("Creature") && !toolStripButtonShowCreatures.Checked ||
                                     card.Typeline.Contains("Enchantment") && !toolStripButtonShowEnchantments.Checked ||
                                     card.Typeline.Contains("Instant") && !toolStripButtonShowInstants.Checked ||
                                     card.Typeline.Contains("Land") && !toolStripButtonShowLands.Checked ||
                                     card.Typeline.Contains("Planeswalker") && !toolStripButtonShowPlaneswalkers.Checked ||
                                     card.Typeline.Contains("Sorcery") && !toolStripButtonShowSorceries.Checked)
                                     select card;
                }
            }

            searchResults = currentResults.ToList();
            Console.WriteLine("done searching");

            listViewSearchResults.VirtualListSize = currentResults.Count();
        }

        private void listViewSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSearchResults.SelectedIndices.Count == 0)
            {
                cardViewSearchResultSelection.Card = null;
            }
            else
            {
                cardViewSearchResultSelection.Card = searchResults[listViewSearchResults.SelectedIndices[0]];
            }
        }

        #region Search Events
        private void toolStripButtonShowColor_CheckStateChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void toolStripButtonShowType_CheckStateChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void toolStripMenuItemCmcRelation_Click(object sender, EventArgs e)
        {
            toolStripDropDownButtonCmcRelation.Text = ((ToolStripMenuItem)sender).Text;
            Search();
        }

        private void toolStripTextBoxCMC_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void toolStripComboBoxCMCRelation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void toolStripTextBoxName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void toolStripTextBoxOracleText_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void toolStripTextBoxExactManaCost_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        

        private void toolStripComboBoxPrinting_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region ListView Virtualization
        private void listViewSearchResults_SearchForVirtualItem(object sender, SearchForVirtualItemEventArgs e)
        {
            Console.WriteLine("search");
            throw new NotImplementedException();
            ////We've gotten a search request.
            ////If e.Index is not set, the search returns null.
            ////Note that this only handles simple searches over the entire
            ////list, ignoring any other settings.  Handling Direction, StartIndex,
            ////and the other properties of SearchForVirtualItemEventArgs is up
            ////to this handler.
        }

        private void listViewSearchResults_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            // check to see if the requested item is currently in the cache
            //if (listViewItemCache != null && e.ItemIndex >= firstCachedIndex && e.ItemIndex < firstCachedIndex + listViewItemCache.Length)
            //{
            //    // a cache hit, so get the item from the cache instead of making a new one.
            //    e.Item = listViewItemCache[e.ItemIndex - firstCachedIndex];
            //}
            //else
            {
                //A cache miss, so create a new ListViewItem and pass it back.
                e.Item = new ListViewItem(searchResults[e.ItemIndex].Name);
            }
        }

        private void listViewSearchResults_CacheVirtualItems(object sender, CacheVirtualItemsEventArgs e)
        {
            //Console.WriteLine("cache");

            //// we've gotten a request to refresh the cache
            //// first check if it's really neccesary.
            //if (listViewItemCache != null && e.StartIndex >= firstCachedIndex && e.EndIndex <= firstCachedIndex + listViewItemCache.Length)
            //{
            //    // if the newly requested cache is a subset of the old cache we are done
            //    return;
            //}

            //// now we need to rebuild the cache.
            //firstCachedIndex = e.StartIndex;
            //int length = e.EndIndex - e.StartIndex + 1; //indexes are inclusive
            //listViewItemCache = new ListViewItem[length];

            //// fill the cache with the appropriate ListViewItems
            //for (int i = 0; i < length; i++)
            //{
            //    listViewItemCache[i] = new ListViewItem(searchResults[i + firstCachedIndex].Name);
            //}
        }
        #endregion

    }
}
