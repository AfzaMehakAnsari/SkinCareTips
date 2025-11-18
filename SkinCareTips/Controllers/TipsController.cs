using Microsoft.AspNetCore.Mvc;
using SkinCareTipsAPI.Models;

namespace SkinCareTipsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipsController : ControllerBase
    {
        private static readonly List<Tip> tips = new()
        {
new Tip
{
    Id = 1,
    TipTitle = "Aloe Vera: Nature's Soothing Elixir",
    TipText = "Aloe vera gel naturally soothes, hydrates, and heals the skin.",
    Description = "Aloe vera accelerates wound healing and moisturizes the skin deeply. It helps reduce acne, fade dark spots, and soothe inflammation. Rich in antioxidants and vitamins, it also protects the skin from damage and promotes a healthy, radiant complexion.",
    ImageUrl = "https://images.pexels.com/photos/12304752/pexels-photo-12304752.jpeg",
    Source = "https://www.eatingwell.com/article/7951954/benefits-of-aloe-vera-for-skin/",
    Category = "Herbal"
},
new Tip
{
    Id = 2,
    TipTitle = "Coconut Oil: Deep Moisturizer and Skin Protector",
    TipText = "Coconut oil deeply moisturizes and protects the skin.",
    Description = "Coconut oil is rich in fatty acids, forming a protective barrier that locks in moisture and soothes irritation. Its antibacterial properties help prevent infections, making it ideal for dry or sensitive skin.",
    ImageUrl = "https://cdn.pixabay.com/photo/2017/07/24/17/12/coconut-oil-2535395_1280.jpg",
    Source = "https://www.healthline.com/health/beauty-skin-care/home-remedies-for-glowing-skin",
    Category = "Herbal"
},
new Tip
{
    Id = 3,
    TipTitle = "Honey: Natural Antibacterial and Moisturizer",
    TipText = "Honey is a natural antibacterial and moisturizer for the skin.",
    Description = "Honey has antibacterial and anti-inflammatory properties, soothing tiny cuts and moisturizing the skin. Applying a thin layer before rinsing can accelerate the healing process and enhance skin hydration.",
    ImageUrl = "https://images.unsplash.com/photo-1587049352851-8d4e89133924?q=80&w=687&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
    Source = "https://www.healthline.com/health/honey-for-face",
    Category = "Herbal"
},
new Tip
{
    Id = 4,
    TipTitle = "Witch Hazel: Natural Astringent for Skin",
    TipText = "Witch hazel acts as a natural astringent for the skin.",
    Description = "Witch hazel contains tannins with natural astringent properties, making it effective in treating acne. A decoction made from its bark can be applied topically to reduce inflammation and tighten the skin.",
    ImageUrl = "https://images.pexels.com/photos/9442301/pexels-photo-9442301.jpeg",
    Source = "https://www.ncbi.nlm.nih.gov/books/NBK92761/",
    Category = "Herbal"
},
new Tip
{
    Id = 5,
    TipTitle = "Chia Seeds: Antioxidant-Rich Skin Healer",
    TipText = "Chia seeds are antioxidant-rich and help heal the skin.",
    Description = "Chia seeds are rich in antioxidants, omega-3 fatty acids, and vitamins like vitamin E. They help combat pigmentation, repair skin barriers, reduce inflammation, and support healthy cell turnover.",
    ImageUrl = "https://images.unsplash.com/photo-1737063979459-d80085fbaa4b?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
    Source = "https://pmc.ncbi.nlm.nih.gov/articles/PMC2883415/",
    Category = "Herbal"
},
new Tip
{
    Id = 6,
    TipTitle = "Turmeric: The Golden Anti-Inflammatory Herb",
    TipText = "Turmeric helps brighten skin and reduce inflammation.",
    Description = "Turmeric contains curcumin, a compound known for its strong anti-inflammatory and antioxidant properties. It helps fade dark spots, even out skin tone, and promote a healthy glow. Regular use can also soothe acne-prone and irritated skin.",
    ImageUrl = "https://cdn.pixabay.com/photo/2024/06/06/11/53/ai-generated-8812574_1280.jpg",
    Source = "https://www.healthline.com/health/turmeric-for-skin",
    Category = "Herbal"
},
new Tip
{
    Id = 7,
    TipTitle = "Green Tea: Antioxidant Power for Clear Skin",
    TipText = "Green tea reduces acne and fights free radicals.",
    Description = "Green tea contains plant-based compounds called catechins (notably EGCG) which have antibiotic, anti-inflammatory and antioxidant properties. These compounds may help reduce sebum (oil) production, inhibit acne-causing bacteria, and thereby support clearer skin.",
    ImageUrl = "https://images.unsplash.com/photo-1565117764032-21d3efebc7e3?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8ODJ8fGdyZWVuJTIwdGVhJTIwZm9yJTIwc2tpbnxlbnwwfHwwfHx8MA==",
    Source = "https://www.medicalnewstoday.com/articles/green-tea-for-acne?",
    Category = "Herbal"
},
new Tip
{
    Id = 8,
    TipTitle = "Cucumber: Instant Skin Cooling and Hydration",
    TipText = "Cucumber instantly cools and hydrates the skin.",
    Description = "Cucumber contains over 90% water, providing deep hydration and a cooling effect that soothes sunburned or irritated skin. It reduces puffiness and tightens pores, leaving the skin refreshed and revitalized.",
    ImageUrl = "https://images.pexels.com/photos/7479806/pexels-photo-7479806.jpeg",
    Source = "https://www.healthline.com/health/beauty-skin-care/cucumber-for-skin",
    Category = "Herbal"
},
new Tip
{
    Id = 9,
    TipTitle = "Oatmeal: Gentle Natural Exfoliant",
    TipText = "Oatmeal gently exfoliates and soothes sensitive skin.",
    Description = "Oatmeal contains compounds like avenanthramides that calm irritation and reduce redness. It also helps remove dead cells without stripping natural oils, making it perfect for sensitive and dry skin types.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1661456238309-dae8472e9ae7?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OXx8T2F0bWVhbCUyMGZvciUyMHNraW58ZW58MHx8MHx8fDA%3D",
    Source = "https://www.medicalnewstoday.com/articles/oatmeal-benefits-for-the-skin",
    Category = "Herbal"
},
new Tip
{
    Id = 10,
    TipTitle = "Rose Water: Natural Skin Toner and Refresher",
    TipText = "Rose water refreshes, tones, and balances the skin’s pH.",
    Description = "Rose water is known for its hydrating, antibacterial, and antioxidant properties. It refreshes tired skin, reduces redness, and balances the skin’s natural pH. Regular use helps maintain a soft, glowing complexion.",
    ImageUrl = "https://images.unsplash.com/photo-1688233944728-9e8439cfae14?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8cm9zZSUyMHdhdGVyJTIwb24lMjBza2lufGVufDB8fDB8fHww",
    Source = "https://www.medicalnewstoday.com/articles/320216",
    Category = "Herbal"
},
new Tip
{
    Id = 11,
    TipTitle = "Neem: Powerful Antibacterial Herb for Clear Skin",
    TipText = "Neem helps fight acne and purify the skin naturally.",
    Description = "Neem leaves are rich in antibacterial and antifungal compounds that cleanse the skin and prevent acne breakouts. They also help soothe irritation, reduce scars, and promote an even skin tone.",
    ImageUrl = "https://images.unsplash.com/photo-1663067600790-e13449eed2bd?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTZ8fG5lZW18ZW58MHx8MHx8fDA%3D",
    Source = "https://www.healthline.com/health/neem-oil-for-skin",
    Category = "Herbal"
},
new Tip
{
    Id = 12,
    TipTitle = "Tea Tree Oil: Natural Acne-Fighting Remedy",
    TipText = "Tea tree oil may help reduce acne lesions and calm skin inflammation when applied topically.",
    Description = "Tea tree oil possesses antimicrobial and anti-inflammatory properties. Research suggests its topical use may reduce acne lesions and oily skin, though evidence remains limited. It may also help soothe itching and irritation due to its natural antiseptic qualities.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1661575474274-e84aecf9c464?q=80&w=687&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fA%3D%3D",
    Source = "https://www.medicalnewstoday.com/articles/326376",
    Category = "Herbal"
},
new Tip
{
    Id = 13,
    TipTitle = "Lavender Oil: Soothing Essence for Sensitive Skin",
    TipText = "Lavender oil calms irritation and promotes healing.",
    Description = "Lavender essential oil helps reduce redness, calm eczema, and support faster healing. Its mild antimicrobial properties protect the skin from infection, while its relaxing aroma promotes stress-free, healthier skin.",
    ImageUrl = "https://images.pexels.com/photos/7795810/pexels-photo-7795810.jpeg",
    Source = "https://www.healthline.com/health/lavender-oil-for-skin",
    Category = "Herbal"
},
new Tip
{
    Id = 14,
    TipTitle = "Calendula: Soothing & Restorative Herb for the Skin",
    TipText = "Calendula soothes irritated skin, reduces inflammation and supports skin repair.",
    Description = "Calendula officinalis is rich in flavonoids, triterpenoids, carotenoids and saponins which deliver antioxidant and anti-inflammatory effects. Topically applied calendula extract may help calm redness and irritation, accelerate the inflammation-resolution phase of wounds, enhance skin barrier repair and support regeneration of skin tissue.",
    ImageUrl = "https://images.unsplash.com/photo-1632602304887-8439a8a14f37?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8Q2FsZW5kdWxhfGVufDB8fDB8fHww",
    Source = "https://pmc.ncbi.nlm.nih.gov/articles/PMC10142266/",
    Category = "Herbal"
},
new Tip
{
    Id = 15,
    TipTitle = "Chamomile: Gentle Herb for Redness and Irritation",
    TipText = "Chamomile soothes irritated and inflamed skin.",
    Description = "Chamomile’s bisabolol and chamazulene compounds calm inflamed skin, making it effective for eczema and rosacea. It also enhances skin repair and offers mild lightening effects.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1756487060325-bdc94b9076ee?q=80&w=687&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
    Source = "https://www.healthline.com/health/beauty-skin-care/chamomile-benefits-for-skin",
    Category = "Herbal"
},
new Tip
{
    Id = 16,
    TipTitle = "Gotu Kola: Herbal Booster for Skin Regeneration",
    TipText = "Gotu Kola extract enhances collagen synthesis and accelerates wound-healing for firmer skin.",
    Description = "Triterpenoids in Centella asiatica (such as asiaticoside and madecassoside) stimulate fibroblast proliferation, promote collagen type I production, and enhance wound contraction and skin-barrier repair. In topical studies this has led to improved tensile strength of healing skin and faster closure of wounds.",
    ImageUrl = "https://cdn.pixabay.com/photo/2021/05/12/01/23/kola-kanda-6247129_1280.jpg",
    Source = "https://www.ncbi.nlm.nih.gov/pmc/articles/PMC3834700/",
    Category = "Herbal"
},
new Tip
{
    Id = 17,
    TipTitle = "Licorice Root: Natural Brightener for Uneven Skin Tone",
    TipText = "Licorice root helps fade dark spots and even skin tone.",
    Description = "Licorice extract contains glabridin, which inhibits melanin production. It’s a natural remedy for hyperpigmentation and helps brighten dull skin without harsh chemicals.",
    ImageUrl = "https://images.unsplash.com/photo-1659580711050-6de37ed4e3ad?q=80&w=764&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
    Source = "https://www.medicalnewstoday.com/articles/323761?",
    Category = "Herbal"
},
new Tip
{
    Id = 18,
    TipTitle = "Sandalwood: Ancient Herb for Glowing Skin",
    TipText = "Sandalwood powder brightens and smooths the skin.",
    Description = "Sandalwood has cooling and antibacterial properties that soothe sunburn, acne, and rashes. It enhances complexion, reduces scars, and leaves a natural glow on the skin.",
    ImageUrl = "https://images.unsplash.com/photo-1730596628352-08a13f00f5cb?q=80&w=687&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
    Source = "https://www.healthline.com/health/beauty-skin-care/sandalwood-benefits-for-skin",
    Category = "Herbal"
},
new Tip
{
    Id = 19,
    TipTitle = "Amla: Vitamin C-Rich Herb for Radiant Skin",
    TipText = "Amla rejuvenates skin and fights signs of aging.",
    Description = "Indian gooseberry (Amla) is loaded with vitamin C and antioxidants. It boosts collagen production, prevents wrinkles, and keeps the skin supple and youthful.",
    ImageUrl = "https://images.unsplash.com/photo-1676043966983-f5bd22435e64?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8QW1sYXxlbnwwfHwwfHx8MA%3D%3D",
    Source = "https://pmc.ncbi.nlm.nih.gov/articles/PMC8146754/",
    Category = "Herbal"
},
new Tip
{
    Id = 20,
    TipTitle = "Basil (Tulsi): Detoxifying Herb for Acne-Prone Skin",
    TipText = "Basil purifies the skin and prevents breakouts.",
    Description = "Tulsi has natural antibacterial and antifungal properties that cleanse clogged pores and control oil. It reduces acne and refreshes tired, dull skin with daily use.",
    ImageUrl = "https://images.unsplash.com/photo-1737099982102-47a06b1c0725?q=80&w=687&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
    Source = "https://www.healthline.com/health/beauty-skin-care/benefits-of-tulsi-for-skin",
    Category = "Herbal"
},
new Tip
{
    Id = 21,
    TipTitle = "Mint (Peppermint): Cooling Herb for Skin Irritation Relief",
    TipText = "Peppermint oil applied topically soothes itching, inflammation and refreshes skin.",
    Description = "Topical peppermint oil (rich in menthol) increases cutaneous blood flow, exhibits antimicrobial activity and reduces pruritus and inflammation in human skin models.",
    ImageUrl = "https://cdn.pixabay.com/photo/2024/04/04/12/26/ai-generated-8675021_1280.png",
    Source = "https://www.ncbi.nlm.nih.gov/pmc/articles/PMC9018027/",
    Category = "Herbal"
},
new Tip
{
    Id = 22,
    TipTitle = "Papaya: Natural Enzyme Exfoliator for Soft Skin",
    TipText = "Papaya exfoliates dead skin and brightens the complexion.",
    Description = "Papaya contains papain, an enzyme that removes dead cells and impurities gently. It helps fade pigmentation, moisturizes dry patches, and gives the skin a smooth, even tone.",
    ImageUrl = "https://images.unsplash.com/photo-1619535962037-feb40b6823fd?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTZ8fFBhcGF5YSUzQSUyME5hdHVyYWwlMjBFbnp5bWUlMjBFeGZvbGlhdG9yJTIwZm9yJTIwU29mdCUyMFNraW58ZW58MHx8MHx8fDA%3D",
    Source = "https://www.healthline.com/health/papaya-benefits-for-skin",
    Category = "Herbal"
},
new Tip
{
    Id = 23,
    TipTitle = "Lemon: Vitamin C Boost for Radiant Skin",
    TipText = "Lemon brightens skin and reduces dark spots naturally.",
    Description = "Rich in vitamin C, lemon juice acts as a natural astringent that lightens blemishes and tightens pores. Its antibacterial properties help prevent acne and promote clearer, brighter skin.",
    ImageUrl = "https://images.pexels.com/photos/8038385/pexels-photo-8038385.jpeg",
    Source = "https://www.healthline.com/health/lemon-for-face",
    Category = "Herbal"
},
new Tip
{
    Id = 24,
    TipTitle = "Yarrow: Soothing Wild Herb for Skin Calm & Repair",
    TipText = "Yarrow herb helps calm irritation, support skin barrier repair and aid wound healing.",
    Description = "Yarrow (Achillea millefolium) has documented anti-inflammatory, antioxidant and wound-healing effects in skin applications. For example, oil extracts applied topically restored skin pH, hydration and reduced erythema in irritated human skin.",
    ImageUrl = "https://cdn.pixabay.com/photo/2024/06/01/07/02/flower-8801689_1280.jpg",
    Source = "https://pubmed.ncbi.nlm.nih.gov/28163113/",
    Category = "Herbal"
},
new Tip
{
    Id = 25,
    TipTitle = "Saffron: Luxurious Herb for Glowing Skin",
    TipText = "Saffron enhances skin glow and reduces pigmentation.",
    Description = "Saffron is packed with antioxidants and vitamins that improve skin tone and reduce dullness. It boosts circulation, fades dark spots, and gives a radiant, natural glow.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1736782400221-4730d7a97386?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=687",
    Source = "https://www.healthline.com/health/beauty-skin-care/benefits-of-saffron-for-skin",
    Category = "Herbal"
},
new Tip
{
    Id = 26,
    TipTitle = "Cinnamon: Antimicrobial Spice for Acne Control",
    TipText = "Cinnamon fights acne-causing bacteria naturally.",
    Description = "Cinnamon increases blood flow to the skin, helping with cell regeneration. Its antimicrobial properties prevent acne and pimples while promoting a healthy, rosy complexion.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1674176786870-df04e337aec6?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=687",
    Source = "https://www.healthline.com/nutrition/cinnamon-for-skin-benefits",
    Category = "Herbal"
},
new Tip
{
    Id = 27,
    TipTitle = "Fenugreek: Herbal Remedy for Skin Clarity & Anti-Aging",
    TipText = "Fenugreek seed extract helps reduce skin inflammation, improves hydration and firmness.",
    Description = "Topical fenugreek seed extract exhibits significant anti-inflammatory, antioxidant and collagen-protective activity. In vitro studies show inhibition of collagenase (IC₅₀ ≈ 0.57 mg/mL) and the extract has been incorporated into cream formulations that increased skin hydration and elasticity.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1716626436935-002513399262?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NDV8fEZlbnVncmVlayUzQSUyMEhlcmIlMjBmb3IlMjBBY25lJTIwYW5kJTIwUGlnbWVudGF0aW9ufGVufDB8fDB8fHww&auto=format&fit=crop&q=60&w=600",
    Source = "https://www.ncbi.nlm.nih.gov/pmc/articles/PMC8879298/",
    Category = "Herbal"
},
new Tip
{
    Id = 28,
    TipTitle = "Hibiscus (Hibiscus sabdariffa): Natural Anti-Ageing & Skin Barrier Booster",
    TipText = "Hibiscus mediates improved skin elasticity, hydration and collagen support.",
    Description = "Studies show that Hibiscus sabdariffa extract exerts strong anti-ageing effects: it inhibits elastase and collagenase activities, supports fibroblast collagen production, reduces transepidermal water loss (TEWL) and improves skin hydration and elasticity.",
    ImageUrl = "https://cdn.pixabay.com/photo/2022/05/22/00/33/hibiscus-flower-7212493_1280.jpg",
    Source = "https://www.ncbi.nlm.nih.gov/pmc/articles/PMC9504376/",
    Category = "Herbal"
},
new Tip
{
    Id = 29,
    TipTitle = "Black Seed Oil: Potent Remedy for Fungal and Parasitic Skin Issues",
    TipText = "Black seed oil fights fungal and parasitic infections effectively.",
    Description = "Black seed oil (Nigella sativa) contains thymoquinone, a natural antifungal and antimicrobial compound. Regular topical application can help manage fungal infections and skin irritation caused by scabies or eczema.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1678932075217-3554de7a9d84?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzN8fEJsYWNrJTIwU2VlZCUyME9pbCUzQSUyMFBvdGVudCUyMFJlbWVkeSUyMGZvciUyMEZ1bmdhbCUyMGFuZCUyMFBhcmFzaXRpYyUyMFNraW4lMjBJc3N1ZXN8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&q=60&w=600",
    Source = "https://www.healthline.com/nutrition/black-seed-oil-benefits",
    Category = "Herbal"
},
new Tip
{
    Id = 30,
    TipTitle = "Bitter Gourd: Skin-Clearing & Anti-Inflammatory Herb",
    TipText = "Bitter gourd extract helps reduce acne-related inflammation and supports clearer skin.",
    Description = "Bitter gourd leaf/fruit extracts contain phenolic and flavonoid compounds which have been shown in studies to inhibit Cutibacterium acnes-induced inflammation, reduce secretion of pro-inflammatory cytokines and act as antioxidants protecting skin cells from oxidative stress.",
    ImageUrl = "https://cdn.pixabay.com/photo/2023/01/25/12/29/bitter-gourd-7743471_1280.jpg",
    Source = "https://www.ncbi.nlm.nih.gov/pmc/articles/PMC5432827/",
    Category = "Herbal"
},
new Tip
{
    Id = 31,
    TipTitle = "Bilberry: Antioxidant Extract for Brightened, Even Skin Tone",
    TipText = "Bilberry extract helps reduce redness, improve skin tone and support skin elasticity.",
    Description = "Bilberry (Vaccinium myrtillus) is rich in anthocyanins and polyphenols which have strong antioxidant and anti-inflammatory properties. In clinical studies using fermented bilberry extract, improvements in skin lightness, reduced redness, improved firmness and elasticity. Research also shows reduced oxidative stress and enhanced skin complexion evenness.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1690561081668-3c9ef6502d70?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NTN8fEJpbGJlcnJ5JTNBJTIwTmF0dXJhbCUyMFJlbWVkeSUyMGZvciUyMERhcmslMjBDaXJjbGVzJTIwJTI2JTIwU2tpbiUyMFRvbmV8ZW58MHx8MHx8fDA=&auto=format&fit=crop&q=60&w=600",
    Source = "https://www.ncbi.nlm.nih.gov/pmc/articles/PMC11280171/",
    Category = "Herbal"
},
new Tip
{
    Id = 32,
    TipTitle = "Pomegranate: Antioxidant Powerhouse for Healthy Skin",
    TipText = "Pomegranate protects against sun damage and promotes youthful skin.",
    Description = "Rich in polyphenols and vitamin C, pomegranate helps fight free radicals, reduces signs of aging, and supports collagen production. Its antioxidants also help soothe inflammation and brighten dull skin, giving a natural glow.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1726761705035-2a2a9c4a9802?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=722",
    Source = "https://www.healthline.com/health/pomegranate-benefits-on-skin",
    Category = "Herbal"
},
new Tip
{
    Id = 33,
    TipTitle = "Wheat Germ Oil: Nourishing for Dry & Aging Skin",
    TipText = "Wheat germ oil replenishes lipids and revitalizes skin.",
    Description = "Wheat germ oil is rich in polar lipids and antioxidants that improve skin hydration and reduce signs of aging. Clinical trials have shown it can reduce wrinkles and improve skin radiance.",
    ImageUrl = "https://images.unsplash.com/photo-1707539160277-e39464517645?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8ODh8fEdyYXBlc2VlZCUyME9pbCUzQSUyMExpZ2h0d2VpZ2h0JTIwTW9pc3R1cml6ZXIlMjBmb3IlMjBBbGwlMjBTa2luJTIwVHlwZXN8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&q=60&w=600",
    Source = "https://pubmed.ncbi.nlm.nih.gov/31033133/",
    Category = "Herbal"
},
new Tip
{
    Id = 34,
    TipTitle = "Grapeseed Oil: Lightweight Moisturizer for All Skin Types",
    TipText = "Grapeseed oil balances and nourishes without heaviness.",
    Description = "Grapeseed oil is lightweight and rich in antioxidants, omega-6 fatty acids, and vitamin E. It helps moisturize skin, support elasticity, prevent breakouts, and reduce pore size. It also has antimicrobial and anti-inflammatory properties.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1700844300872-50f6bf7e0d0f?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=687",
    Source = "https://www.healthline.com/health/grapeseed-oil-for-skin",
    Category = "Herbal"
},
new Tip
{
    Id = 35,
    TipTitle = "Moringa Oil: Deep Cleanser and Nutrient-Rich Skin Food",
    TipText = "Moringa oil detoxifies skin and nourishes from within.",
    Description = "Moringa oil is rich in antioxidants, oleic acid, and vitamins. It helps draw out impurities, reduce damage from pollutants, support skin hydration, and has anti-inflammatory effects. Dermatological studies show moringa products enhance skin revitalization and reduce inflammation.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1694825173871-7b5df4d57ba5?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OTd8fGdyZWVuJTIwcG93ZGVyfGVufDB8fDB8fHww&auto=format&fit=crop&q=60&w=600",
    Source = "https://pubmed.ncbi.nlm.nih.gov/38055069/",
    Category = "Herbal"
},
new Tip
{
    Id = 36,
    TipTitle = "Centella Asiatica: Moisturizer & Barrier Strengthener",
    TipText = "Centella enhances hydration and strengthens skin barrier.",
    Description = "Cosmetic formulations with Centella asiatica improve stratum corneum hydration, reduce TEWL, and show anti-inflammatory effects on human skin.",
    ImageUrl = "https://images.pexels.com/photos/18237384/pexels-photo-18237384.jpeg",
    Source = "https://pmc.ncbi.nlm.nih.gov/articles/PMC4852572/",
    Category = "Herbal"
},
new Tip
{
    Id = 37,
    TipTitle = "Pumpkin Seed Oil: Anti-Hair Loss & Skin Repair",
    TipText = "Pumpkin seed oil helps reduce hair loss and improve skin antioxidant status.",
    Description = "Pumpkin seed oil (Cucurbita moschata) shows strong antioxidant, anti-inflammatory, and 5α-reductase inhibitory effects, which help reduce hair loss and protect skin. In vitro and animal studies also report wound healing benefits and improved skin enzyme activity.",
    ImageUrl = "https://images.unsplash.com/photo-1671871695722-b91911e9c072?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=687",
    Source = "https://pubmed.ncbi.nlm.nih.gov/36015077/",
    Category = "Herbal"
},
new Tip
{
    Id = 38,
    TipTitle = "Neem-Coconut Oil Mix: Treatment for Tungiasis & Skin Infestations",
    TipText = "A neem and coconut oil mixture treats embedded parasites and inflammation.",
    Description = "In a randomized controlled study, a topical mix of 20% neem seed oil in coconut oil significantly reduced infestation and acute pathology in children with tungiasis—a parasitic skin disease. It also reduced inflammation and itching compared to standard treatments.",
    ImageUrl = "https://images.unsplash.com/photo-1617253426949-94541a3e3353?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTEwfHxOZWVtLUNvY29udXQlMjBPaWx8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&q=60&w=600",
    Source = "https://pubmed.ncbi.nlm.nih.gov/31756189/",
    Category = "Herbal"
},
new Tip
{
    Id = 39,
    TipTitle = "Tormentil (Potentilla erecta): Herbal Aid for Eczema & Dermatitis",
    TipText = "Tormentil root helps reduce inflammation in eczema.",
    Description = "Tormentil (Potentilla erecta) contains tannins and flavonoids. Some herbal biomedicine reviews cite tormentil for its role in treating atopic dermatitis and skin inflammation.",
    ImageUrl = "https://cdn.pixabay.com/photo/2015/07/17/08/44/potentilla-erecta-848660_1280.jpg",
    Source = "https://www.mdpi.com/2227-9059/8/2/27",
    Category = "Herbal"
},
new Tip
{
    Id = 40,
    TipTitle = "Avocado Oil: Deep-Penetrating Moisturizer",
    TipText = "Avocado oil nourishes deeply and restores dry skin.",
    Description = "Avocado oil is rich in monounsaturated fats, vitamins A, D, and E, and sterolins that help repair the skin barrier, soothe dryness, and reduce inflammation.",
    ImageUrl = "https://images.pexels.com/photos/11341893/pexels-photo-11341893.jpeg",
    Source = "https://www.healthline.com/health/beauty-skin-care/avocado-oil-for-skin",
    Category = "Herbal"
},
new Tip
{
    Id = 41,
    TipTitle = "Rice Water: Traditional Skin Brightener & Anti-Aging Aid",
    TipText = "Rice water acts as a mild antioxidant and hydrating agent.",
    Description = "Rice water (leftover from soaking or boiling rice) demonstrates antioxidant activity, elastase inhibition, and good skin compatibility in studies. Gel formulations with ~96% rice water in human tests showed ~10% increase in skin hydration over 28 days.",
    ImageUrl = "https://images.unsplash.com/photo-1630056656591-0cba044ba94f?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8UmljZSUyMFdhdGVyfGVufDB8fDB8fHww&auto=format&fit=crop&q=60&w=600",
    Source = "https://www.mdpi.com/2079-9284/5/2/26",
    Category = "Herbal"
},
new Tip
{
    Id = 42,
    TipTitle = "Rosemary: Aromatic Herb for Clear & Balanced Skin",
    TipText = "Rosemary extract helps calm redness, balance oil and protect against ageing.",
    Description = "Rosemary contains antioxidants (rosmarinic acid, carnosic acid) and has been used for soothing skin irritation, redness and oily/acne-prone skin.",
    ImageUrl = "https://cdn.pixabay.com/photo/2020/02/28/09/28/rosemary-4886959_1280.jpg",
    Source = "https://www.gaiaherbs.com/blogs/seeds-of-knowledge/the-7-best-herbal-supplements-for-healthy-glowing-skin-from-the-inside-out?srsltid=AfmBOopv7ByLXb2j0lw8cnmPV-1-yfrzp34tFY4OOUvxdFwoAfFFJd_W&utm",
    Category = "Herbal"
},
new Tip
{
    Id = 43,
    TipTitle = "Jasmine Flower (Jasminum officinale): Antioxidant & Skin Ageing Defender",
    TipText = "Jasmine flower extract helps protect skin from oxidative stress and supports youthful skin.",
    Description = "An in-vitro/ex-vivo study of Jasminum officinale cell extract (JasHEx) found it reduced reactive oxygen species production in keratinocytes, inhibited advanced glycation end products (AGEs), and increased collagen I production — all key factors in skin ageing.",
    ImageUrl = "https://images.pexels.com/photos/7795816/pexels-photo-7795816.jpeg",
    Source = "https://pmc.ncbi.nlm.nih.gov/articles/PMC9774971/",
    Category = "Herbal"
},
new Tip
{
    Id = 44,
    TipTitle = "Dandelion: Detox Herb for Radiant Skin",
    TipText = "Dandelion leaf and flower extracts protect skin from UV damage, reduce oxidative stress and support clearer skin.",
    Description = "In a study on human dermal fibroblasts, dandelion leaf and flower extracts protected cells against UVB-induced damage, inhibited ROS generation and MMP activity, and helped preserve glutathione levels suggesting potential for skin ageing protection and clarity.",
    ImageUrl = "https://cdn.pixabay.com/photo/2018/05/02/15/19/dandelion-3368782_1280.jpg",
    Source = "https://www.ncbi.nlm.nih.gov/pmc/articles/PMC4630464/",
    Category = "Herbal"
},
new Tip
{
    Id = 45,
    TipTitle = "Echinacea: Herbal Remedy for Clear & Calm Skin",
    TipText = "Echinacea supports skin health by reducing inflammation and helping wound-repair.",
    Description = "According to a Health.com article, Echinacea tea/extract is high in flavonoids and antioxidants which help lower oxidative stress and inflammation. Some evidence suggests topical or internal use may support healing of minor skin irritations such as eczema or acne-prone skin.",
    ImageUrl = "https://images.pexels.com/photos/29215881/pexels-photo-29215881.jpeg",
    Source = "https://www.health.com/echinacea-tea-11805472",
    Category = "Herbal"
},
new Tip
{
    Id = 46,
    TipTitle = "Red Clover: Isoflavone-Rich Herb for Skin Ageing Support",
    TipText = "Red clover isoflavones help improve skin thickness, collagen content and moisture-retention in ageing skin.",
    Description = "In a study of ovariectomized rats, red clover extract standardized to 11% isoflavones significantly increased skin thickness, collagen content and improved skin morphology compared with controls. These findings suggest red clover isoflavones are effective in reducing skin-ageing changes induced by estrogen-deficiency.",
    ImageUrl = "https://images.unsplash.com/photo-1759350414054-bb1a10bfe150?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=627",
    Source = "https://pubmed.ncbi.nlm.nih.gov/17078110/",
    Category = "Herbal"
},
new Tip
{
    Id = 47,
    TipTitle = "Peppermint: Cooling Herb for Skin Relief",
    TipText = "Topical peppermint oil provides a cooling sensation and helps reduce itching and irritation.",
    Description = "Studies show that topical application of peppermint oil (and its main active menthol) reduces pruritus (itching) and increases skin blood flow, offering relief from irritation and supporting skin comfort.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1673264303561-de2ab31df03c?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=687",
    Source = "https://www.ncbi.nlm.nih.gov/pmc/articles/PMC5066694/",
    Category = "Herbal"
},
new Tip
{
    Id = 48,
    TipTitle = "Sage: Herbal Toner for Balanced and Clear Skin",
    TipText = "Sage leaf extract helps tone skin and reduce excess oil.",
    Description = "Sage leaves contain high levels of rosmarinic acid, ursolic acid and other flavonoids that provide antioxidant, anti-inflammatory, and astringent effects. These properties support balanced oil production, improved texture, and reduced redness in topical skincare formulations.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1661609454173-56055da4f2ad?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=687",
    Source = "https://www.ncbi.nlm.nih.gov/pmc/articles/PMC5634728/",
    Category = "Herbal"
},
new Tip
{
    Id = 49,
    TipTitle = "Propolis: Resin Healing Treatment for Skin",
    TipText = "Propolis applied topically promotes wound‑healing and provides antioxidant protection for the skin.",
    Description = "Propolis is a resinous mixture produced by bees from plant exudates. Topical research shows it contains phenolic compounds (e.g., caffeic acid, gallic acid) that penetrate the skin, reduce inflammation, improve wound contraction and collagen deposition, accelerate skin repair and support dermal antioxidant capacity.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1661454132288-2d61599196a0?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=687",
    Source = "https://www.ncbi.nlm.nih.gov/pmc/articles/PMC9502464/",
    Category = "Herbal"
},
new Tip
{
    Id = 50,
    TipTitle = "Thyme: Herbal Antiseptic for Acne Control",
    TipText = "Thyme essential oil shows strong antibacterial and anti-inflammatory effects against acne-causing bacteria.",
    Description = "Research indicates that thyme essential oil (and its major constituent thymol) exhibits potent antimicrobial activity against Cutibacterium acnes, disrupts bacterial-biofilms, and reduces inflammation in acne models.",
    ImageUrl = "https://plus.unsplash.com/premium_photo-1661454132288-2d61599196a0?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=687",
    Source = "https://www.ncbi.nlm.nih.gov/pmc/articles/PMC9503056/",
    Category = "Herbal"
}
        };
        [HttpGet]
        public IActionResult GetAllTips()
        {
            return Ok(tips);
        }
        [HttpGet("category/{category}")]
        public IActionResult GetTipsByCategory(string category)
        {
            var filtered = tips.Where(t => t.Category.ToLower() == category.ToLower()).ToList();
            if (!filtered.Any()) return NotFound($"No tips found in {category}");
            return Ok(filtered);
        }
        [HttpGet("random")]
        public IActionResult GetRandomTip()
        {
            var random = new Random();
            var tip = tips[random.Next(tips.Count)];
            return Ok(tip);
        }
    }
}
