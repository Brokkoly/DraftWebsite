using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftWebsite.Models
{
#pragma warning disable IDE1006 // Naming Styles

    public class Card
    {
        /// <summary>
        /// Name of the artist that illustrated the card art.
        /// </summary>
        public string artist { get; set; }
        /// <summary>
        ///The ASCII(Basic/128) code formatted card name with no special unicode characters.
        /// </summary>
        public string? asciiName { get; set; }
        /// <summary>
        /// List of the card's available printing types.
        /// </summary>
        public List<string> availability { get; set; }
        /// <summary>
        /// Color of the card border.
        /// </summary>
        public string borderColor { get; set; }
        /// <summary>
        /// List of all the colors found in manaCost, colorIndicator and text.
        /// </summary>
        public List<string> colorIdentity { get; set; }
        /// <summary>
        /// List of all the colors in the color indicator (The symbol prefixed to a card's types).
        /// </summary>
        public List<string> colorIndicator { get; set; }
        /// <summary>
        /// List of all the colors in manaCost and colorIndicator. 
        /// Some cards may not have a value, such as cards with "Devoid" in its text.
        /// </summary>
        public List<string> colors { get; set; }
        /// <summary>
        /// The converted mana cost of the card.
        /// </summary>
        public double convertedManaCost { get; set; }
        /// <summary>
        /// How many of this card exists in a relevant deck.
        /// </summary>
        public int? count { get; set; }
        /// <summary>
        /// An indicator for which duel deck the card is in.
        /// </summary>
        public string duelDeck { get; set; }
        /// <summary>
        /// Card rank on EDHRec.
        /// </summary>
        public int edhrecRank { get; set; }
        /// <summary>
        /// The converted mana cost of the face of either half or part of the card.
        /// </summary>
        public float? faceConvertedManaCost { get; set; }
        public string flavorText { get; set; }
        public List<ForeignData> foreignData { get; set; }
        public string frameVersion { get; set; }
        public bool hasFoil { get; set; }
        public bool hasNonFoil { get; set; }
        public Identifiers identifiers { get; set; }
        public List<string> keywords { get; set; }
        public string layout { get; set; }
        public Legalities legalities { get; set; }
        public string manaCost { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string originalText { get; set; }
        public string originalType { get; set; }
        public string power { get; set; }
        public List<string> printings { get; set; }
        public PurchaseUrls purchaseUrls { get; set; }
        public string rarity { get; set; }
        public List<Ruling> rulings { get; set; }
        public string setCode { get; set; }
        public List<string> subtypes { get; set; }
        public List<object> supertypes { get; set; }
        public string text { get; set; }
        public string toughness { get; set; }
        public string type { get; set; }
        public List<string> types { get; set; }
        public string uuid { get; set; }
    }

    public class ForeignData
    {
        public string flavorText { get; set; }
        public string language { get; set; }
        public int multiverseId { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Identifiers
    {
        public string cardKingdomFoilId { get; set; }
        public string cardKingdomId { get; set; }
        public string mcmId { get; set; }
        public string mcmMetaId { get; set; }
        public string mtgjsonV4Id { get; set; }
        public string mtgoFoilId { get; set; }
        public string mtgoId { get; set; }
        public string multiverseId { get; set; }
        public string scryfallId { get; set; }
        public string scryfallIllustrationId { get; set; }
        public string scryfallOracleId { get; set; }
        public string tcgplayerProductId { get; set; }
    }

    public class Legalities
    {
        public string commander { get; set; }
        public string duel { get; set; }
        public string legacy { get; set; }
        public string modern { get; set; }
        public string penny { get; set; }
        public string vintage { get; set; }
    }

    public class PurchaseUrls
    {
        public string cardKingdom { get; set; }
        public string cardKingdomFoil { get; set; }
        public string cardmarket { get; set; }
        public string tcgplayer { get; set; }
    }

    public class Ruling
    {
        public string date { get; set; }
        public string text { get; set; }
    }
#pragma warning restore IDE1006 // Naming Styles


}
