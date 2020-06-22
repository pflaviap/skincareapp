using System;
using System.Collections.Generic;
using System.Text;
using GlowOn.ViewModels;
using System.Collections.ObjectModel;
using GlowOn.ViewModels.Interfaces;
using GlowOn.Views;

namespace GlowOn.Models
{
    public static class ProductData
    {
        public static IList<Product> Products { get; private set; }
        static ProductData()
        {
            Products = new List<Product>();
            Products.Add(new Product
            {
                ID = 1,
                ProductName = "Micellar Water",
                Brand = "Garnier",
                SkinType = "Combination",
                Category = "Makeup Remover",
                Ingredients = "Aqua, Hexylene Glycol, Glycerin, Disodium Cocoamphodiacetate, Disodium Edta, Poloxamer 184, Polyaminopropyl Biguanide",
                AgeCategory = "Universal",
                SuggestedPrice = "25 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 2,
                ProductName = "Micellar Milky Water",
                Brand = "Garnier",
                SkinType = "Dry",
                Category = "Makeup Remover",
                Ingredients = "Aqua/​Water, Propanediol, Glycerin, Isopropyl Myristate, Polysorbate 20, Betaine, Sodium Polyacrylate, Citric Acid, Xanthan Gum, Panthenol, Acrylates Copolymer, Phenoxyethanol, Myrtrimonium Bromide",
                AgeCategory = "Universal",
                SuggestedPrice = "27 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 3,
                ProductName = "Hydrating Facial Cleanser",
                Brand = "Cerave",
                SkinType = "Dry",
                Category = "Cleanser",
                Ingredients = "Aqua / Water / Eau, Glycerin, Cetearyl Alcohol, Peg-40 Stearate, Stearyl Alcohol, Potassium Phosphate, Ceramide Np, Ceramide Ap, Ceramide Eop, Carbomer, Glyceryl Stearate, Behentrimonium Methosulfate, Sodium Lauroyl Lactylate, Sodium Hyaluronate, Cholesterol, Phenoxyethanol, Disodium Edta, Dipotassium Phosphate, Tocopherol, Phytosphingosine, Xanthan Gum, Cetyl Alcohol, Polysorbate 20, Ethylhexylglycerin",
                AgeCategory = "Universal",
                SuggestedPrice = "40 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 4,
                ProductName = "Natural Moisturizing Factors",
                Brand = "The Ordinary",
                SkinType = "Normal",
                Category = "Moisturizer",
                Ingredients = "Aqua (Water), Caprylic/Capric Triglyceride, Cetyl Alcohol, Propanediol, Stearyl Alcohol, Glycerin, Sodium Hyaluronate, Arginine, Aspartic Acid, Glycine, Alanine, Serine, Valine, Isoleucine, Proline, Threonine, Histidine, Phenylalanine, Glucose, Maltose, Fructose, Trehalose, Sodium Pca, Pca, Sodium Lactate, Urea, Allantoin, Linoleic Acid, Oleic Acid, Phytosteryl Canola Glycerides, Palmitic Acid, Stearic Acid, Lecithin, Triolein, Tocopherol, Carbomer, Isoceteth-20, Polysorbate 60, Sodium Chloride, Citric Acid, Trisodium Ethylenediamine Disuccinate, Pentylene Glycol, Triethanolamine, Sodium Hydroxide, Phenoxyethanol, Chlorphenesin",
                AgeCategory = "Universal",
                SuggestedPrice = "37 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 5,
                ProductName = "Gel hidratant Hydro Boost",
                Brand = "Neutrogena",
                SkinType = "Combination",
                Category = "Moisturizer",
                Ingredients = "Water, Dimethicone, Glycerin, Dimethicone/vinyl Dimethicone Crosspolymer, Phenoxyethanol, Polyacrylamide, Cetearyl Olivate, Sorbitan Olivate, Dimethiconol, C13-14 Isoparaffin, Dimethicone Crosspolymer, Chlorphenesin, Carbomer, Laureth-7, Sodium Hyaluronate, Ethylhexylglycerin, Fragrance, C12-14 Pareth -12, Sodium Hydroxide, Blue 1",
                AgeCategory = "Universal",
                SuggestedPrice = "58 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 6,
                ProductName = "Dermatologist Sunscreen SPF 30",
                Brand = "Altruist",
                SkinType = "Normal",
                Category = "SPF",
                Ingredients = "Aqua, C12-15 Alkyl Benzoate, Ethylhexyl Salicylate, Butyl Methoxydibenzoylmethane, Ethylhexyl Stearate, Octocrylene, Glycerin, Phenylbenzimidazole Sulfonic Acid, Cetearyl Alcohol, Glyceryl Stearate, Titanium Dioxide (Nano), Tris-Biphenyl Triazine (Nano), Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Panthenol, Caprylyl Glycol, Butylene Glycol, Propylene Glycol, Decyl Glucoside, Xanthan Gum, Piroctone Olamine, Titanium Dioxide, Sodium Cetearyl Sulfate, Silica, Disodium Phosphate, Diethylhexyl Sodium Sulfosuccinate, Sodium Hydroxide, Phenoxyethanol, Silver Chloride",
                AgeCategory = "Universal",
                SuggestedPrice = "35 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 7,
                ProductName = "Foaming Facial Cleanser",
                Brand = "Cerave",
                SkinType = "Oily",
                Category = "Cleanser",
                Ingredients = "Aqua / Water / Eau, Cocamidopropyl Hydroxysultaine, Glycerin, Sodium Lauroyl Sarcosinate, Peg-150 Pentaerythrityl Tetrastearate, Niacinamide, Peg-6 Caprylic/Capric Glycerides, Sodium Methyl Cocoyl, Taurate, Propylene Glycol, Ceramide Np, Ceramide Ap, Ceramide Eop, Carbomer, Methylparaben, Sodium Chloride, Sodium Lauroyl Lactylate, Cholesterol, Disodium Edta, Propylparaben, Citric Acid, Tetrasodium Edta, Hydrolyzed Hyaluronic Acid, Phytosphingosine, Xanthan Gum",
                AgeCategory = "Universal",
                SuggestedPrice = "40 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 8,
                ProductName = "PM Facial Mosturizing Lotion",
                Brand = "CeraVe",
                SkinType = "Normal",
                Category = "Moisturizer",
                Ingredients = "Aqua/​Water/​Eau, Glycerin, Caprylic/​Capric Triglyceride, Niacinamide, Cetearyl Alcohol, Potassium Phosphate, Ceramide NP, Ceramide AP, Ceramide EOP, Carbomer, Dimethicone, Ceteareth-20, Behentrimonium Methosulfate, Sodium Lauroyl Lactylate, Sodium Hyaluronate, Cholesterol, Phenoxyethanol, Disodium EDTA, Dipotassium Phosphate, Caprylyl Glycol, Phytosphingosine, Xanthan Gum, Polyglyceryl-3 Diisostearate, Ethylhexylglycerin",
                AgeCategory = "Universal",
                SuggestedPrice = "42 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 9,
                ProductName = "Daily Hydrating Lotion",
                Brand = "Cetaphil",
                SkinType = "Dry",
                Category = "Moisturizer",
                Ingredients = "Aqua, Dicaprylyl Carbonate, Cyclopentasiloxane, Glycerin, Hydroxyethyl Urea, Glyceryl Stearate, PEG-100 Stearate, Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Caprylyl Glycol, Cetyl Alcohol, Erythritol, Glycine Soja Oil, Homarine Hcl, Hydrolyzed Hyaluronic Acid, Phenoxyethanol, Potassium Sorbate, Sodium Benzoate, Sodium Hydroxide, Sodium PCA, Tocopherol",
                AgeCategory = "Universal",
                SuggestedPrice = "37 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 10,
                ProductName = "Eye Makeup Remover",
                Brand = "Balea",
                SkinType = "Normal",
                Category = "Makeup Remover",
                Ingredients = "Aqua, Ethylhexyl Stearate, Cetearyl Isononanoate, Helianthus Annuus Hybrid Oil, Panthenol, Glycerin, Sodium Chloride, Potassium Phosphate, Sodium Benzoate, Levulinic Acid, Sodium Levulinate, Ci 61565",
                AgeCategory = "Universal",
                SuggestedPrice = "10 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 11,
                ProductName = "Dermatologist Sunscreen SPF 50",
                Brand = "Altruist",
                SkinType = "Dry",
                Category = "SPF",
                Ingredients = "Aqua, C12-15 Alkyl Benzoate, Ethylhexyl Stearate, Octocrylene, Butyl Methoxydibenzoylmethane, Glycerin, Ethylhexyl Salicylate, Potassium Cetyl Phosphate, Cetearyl Alcohol, Titanium Dioxide (Nano), Phenylbenzimidazole Sulfonic Acid, Glyceryl Stearate, Tris-Biphenyl Triazine (Nano), Ethylhexyl Triazone, Bis-Ethylhexyloxyphenol Methoxyphenyl Triazine, Aminomethyl Propanol, Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Phenoxyethanol, Alumina, Piroctone Olamine, Titanium Dioxide, Decyl Glucoside, Disodium Phosphate, Simethicone, Diethylhexyl Sodium Sulfosuccinate, Xanthan Gum, Butylene Glycol, Caprylyl Glycol, Propylene Glycol, Silver Chloride",
                AgeCategory = "Universal",
                SuggestedPrice = "35 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 12,
                ProductName = "Toleriane Ultra Overnight",
                Brand = "La Roche-Posay",
                SkinType = "Dry",
                Category = "Moisturizer",
                Ingredients = "Aqua /​ Water, Glycerin, Squalane, Propanediol, Butylene Glycol, Butyrospermum Parkii Butter /​ Shea Butter, Pentylene Glycol, Niacinamide, Dimethicone, Ammonium Polyacryldimethyltauramide /​ Ammonium Polyacryloyldimethyl Taurate, Polymethylsilsesquioxane, Polysorbate 20, Allantoin, Glyceryl Acrylate/​Acrylic Acid Copolymer, Dimethiconol, Aluminum Starch Octenylsuccinate, Carnosine, Disodium Edta, Citric Acid, Acetyl Dipeptide-1 Cetyl Ester, Xanthan Gum, T-Butyl Alcohol, Toluene Sulfonic Acid, Tocopherol",
                AgeCategory = "Universal",
                SuggestedPrice = "61 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 13,
                ProductName = "Fluid SPF 50+",
                Brand = "Avene",
                SkinType = "Combination",
                Category = "SPF",
                Ingredients = "Methylene Bis-Benzotriazolyl Tetramethylbutylphenol [Nano], Water (Aqua), Diisopropyl Adipate, Isodecyl Neopentanoate, Silica, Dicaprylyl Carbonate, Bis-Ethylhexyloxyphenol Methoxyphenyl Triazine, Diethylhexyl Butamido Triazone, Aluminum Starch Octenylsuccinate, Butyl Methoxydibenzoylmethane, Potassium Cetyl Phosphate, Decyl Glucoside, 1,2-Hexanediol, C10-18 Triglycerides, Vp/​Eicosene Copolymer, Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Benzoic Acid, Butylene Glycol, Caprylic/​Capric Triglyceride, Disodium EDTA, Glyceryl Behenate, Glyceryl Dibehenate, Glyceryl Stearate, Oxothiazolidine, PEG-100 Stearate, Propylene Glycol, Sodium Benzoate, Tocopherol, Tocopheryl Glucoside, Tribehenin, Xanthan Gum",
                AgeCategory = "Universal",
                SuggestedPrice = "53 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 14,
                ProductName = "Sport Face Oil-Free Lotion SPF 50",
                Brand = "Neutrogena",
                SkinType = "Combination",
                Category = "SPF",
                Ingredients = "Water, Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Acrylates/​Dimethicone Copolymer, Adipic Acid/​Diethylene Glycol/​Glycerin Crosspolymer, Artemia Extract, Beeswax, Benzyl Alcohol, BHT, Bisabolol, Cyclopentasiloxane, Diethylhexyl 2,6-Naphthalate, Dipotassium Glycyrrhizate, Disodium EDTA, Ethylhexylglycerin, Ethylparaben, Glycerin, Glyceryl Stearate, Methylisothiazolinone, Methylparaben, Octadecene/​Ma Copolymer, PEG-100 Stearate, Propylparaben, Saccharomyces/​Calcium Ferment, Saccharomyces/​Magnesium Ferment, Saccharomyces/​Potassium Ferment, Saccharomyces/​Sodium Ferment, Saccharomyces/​Zinc Ferment, Silica, Triethanolamine",
                AgeCategory = "Universal",
                SuggestedPrice = "45 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 15,
                ProductName = "Extra Care Non-Greasy Sunscreen SPF 50",
                Brand = "Paula's Choice",
                SkinType = "Oily",
                Category = "SPF",
                Ingredients = "Water, Butylene Glycol, Peg-8, Polyethylene, Silica, Dimethicone, Picea Excelsa Wood Extract, Sodium Ascorbyl Phosphate, Retinyl Palmitate, Tocopherol, Tocopheryl Acetate, Titanium Dioxide, Aloe Barbadensis Leaf Juice, Bentonite, Methyl Glucose Sesquistearate, Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Sodium Polyacrylate, Kaolin, Ethylhexylglycerin, Disodium Edta, Sodium Hydroxide, Phenoxyethanol, Chlorphenesin",
                AgeCategory = "Universal",
                SuggestedPrice = "106 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 16,
                ProductName = "Dramatically Different Lotion",
                Brand = "Clinique",
                SkinType = "Combination",
                Category = "Moisturizer",
                Ingredients = "Water, Mineral Oil/​Paraffinum Liquidum/​Huile Minerale, Glycerin, Petrolatum, Stearic Acid, Glyceryl Stearate, Sesamum Indicum (Sesame) Oil, Urea, Lanolin Alcohol, Triethanolamine, Hordeum Vulgare (Barley) Extract/​Extrait D'Orge, Cucumis Sativus (Cucumber) Fruit Extract, Helianthus Annuus (Sunflower) Seedcake, Propylene Glycol Dicaprate, Sodium Hyaluronate, Butylene Glycol, Pentylene Glycol, Trisodium Edta, Phenoxyethanol, Yellow 6 (Ci 15985), Yellow 5 (Ci 19140), Red 33 (Ci 17200)",
                AgeCategory = "Universal",
                SuggestedPrice = "89 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 17,
                ProductName = "Waterproof Eye Makeup Remover",
                Brand = "Sephora",
                SkinType = "Normal",
                Category = "Makeup Remover",
                Ingredients = "Water, Cyclopentasiloxane, Isohexadecane, Butylene Glycol, Dipotassium Phosphate, Caprylyl Glycol, 1, 2-Hexanediol, Potassium Phosphate, Sodium Chloride, Maltodextrin, Disodium EDTA, Panthenol, Poloxamer 184, Hydroxycetyl Hydroxyethyl Dimonium Chloride, PPG-26-Buteth-26, PEG-40 Hydrogenated Castor Oil, Centaurea Cyanus Flower Extract, Ci 61570 (Green 5), Ci 42090 (Blue 1 Lake), Apigenin, Oleanolic Acid, Biotinoyl Tripeptide-1, BHT",
                AgeCategory = "Universal",
                SuggestedPrice = "40 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 18,
                ProductName = "Gentle Skin Cleanser",
                Brand = "Cetaphil",
                SkinType = "Dry",
                Category = "Cleanser",
                Ingredients = "Water, Cetyl Alcohol, Propylene Glycol, Sodium Lauryl Sulfate, Stearyl Alcohol, Methylparaben, Propylparaben, Butylparaben",
                AgeCategory = "Universal",
                SuggestedPrice = "60 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 19,
                ProductName = "Daily Facial Cleanser",
                Brand = "Cetaphil",
                SkinType = "Oily",
                Category = "Cleanser",
                Ingredients = "Water, Glycerin, PEG-200 Hydrogenated Glyceryl Palmate, Butylene Glycol, Sodium Lauroyl Sarcosinate, Acrylates/Steareth-20 Methacrylate Copolymer, PEG-7 Glyceryl Cocoate, Sodium Laureth Sulfate, Phenoxyethanol, Masking Fragrance, Panthenol, PEG-60 Hydrogenated Castor Oil, Disodium EDTA, Methylparaben",
                AgeCategory = "Universal",
                SuggestedPrice = "65 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 20,
                ProductName = "Moisture Bomb SPF 30 The Antioxidant Super Moisturizer",
                Brand = "Garnier",
                SkinType = "Dry",
                Category = "SPF",
                Ingredients = "Butane, Aqua/​Water, Homosalate, Octocrylene, Glycerin, Dimethicone, Ethylhexyl Salicylate, Dicaprylyl Carbonate, Nylon-12, Diisopropyl Sebacate, Butyl Methoxydibenzoylmethane, Styrene/​Acrylates Copolymer, P-Anisic Acid, Ascorbyl Glucoside, Caprylyl Glycol, Cyclohexasiloxane, Disodium EDTA, Drometrizole Trisiloxane, Ethylhexyl Triazone, Methyl Methacrylate Crosspolymer, PEG-32, PEG-8 Laurate, Pentylene Glycol, Phenoxyethanol, Phyllanthus Emblica Fruit Extract, Poly C10-30 Alkyl Acrylate, Polyglyceryl-6 Polyricinoleate, Punica Granatum Fruit Extract, Sodium Chloride, Sodium Hyaluronate, Tocopherol",
                AgeCategory = "Universal",
                SuggestedPrice = "30 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 21,
                ProductName = "Sebium Lotion",
                Brand = "Bioderma",
                SkinType = "Combination",
                Category = "Moisturizer",
                Ingredients = "Aqua/​Water/​Eau, PEG-11 Methyl Ether Dimethicone, Butylene Glycol, Glycerin, Fomes Officinalis (Mushroom) Extract, Capryloyl Glycine, Polysorbate 20, Sodium Citrate, Zinc Gluconate, Salicylic Acid, Sodium Hydroxide, Mannitol, Sodium Metabisulfite, Xylitol, Rhamnose, Pyridoxine Hcl, Propyl Gallate, PEG-40 Hydrogenated Castor Oil, Fructooligosaccharides, Phenoxyethanol",
                AgeCategory = "Universal",
                SuggestedPrice = "55 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 22,
                ProductName = "Sébium Sensitive Soothing Anti-Blemish Care",
                Brand = "Bioderma",
                SkinType = "Oily",
                Category = "Moisturizer",
                Ingredients = "Aqua/​Water/​Eau, Glycerin, Methyl Methacrylate Crosspolymer, Dipropylene Glycol, Zinc Gluconate, Coco-Caprylate/​Caprate, Vinyl Dimethicone/​Methicone Silsesquioxane Crosspolymer, Caprylic/​Capric Triglyceride, Arachidyl Alcohol, Behenyl Alcohol, Polyacrylate Crosspolymer-6, Sodium Polyacrylate, Glycyrrhetinic Acid, Propylene Glycol, Arachidyl Glucoside, Bakuchiol, Laminaria Ochroleuca Extract, Mannitol, Xylitol, Sodium Metabisulfite, Rhamnose, Ginkgo Biloba Leaf Extract, Tocopherol, Fructooligosaccharides",
                AgeCategory = "Universal",
                SuggestedPrice = "45 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 23,
                ProductName = "Sensibio Eye Contour Gel",
                Brand = "Bioderma",
                SkinType = "Dry",
                Category = "Moisturizer",
                Ingredients = "Water (Aqua), Glycerin, Dimethicone, Polyethylene, Tridecyl Trimellitate, Caprylic/​Capric Triglyceride, Isostearyl Alcohol, Butylene Glycol Cocoate, Fructooligosaccharides, Mannitol, Xylitol, Caffeine, Sodium Hyaluronate, Glycyrrhetinic Acid, Rhamnose, Laminaria Ochroleuca Extract, Acrylates/​ C10-30 Alkyl Acrylate Crosspolymer, Pentylene Glycol, Caprylyl Glycol, 1,2-Hexanediol, Disodium Edta, Sodium Hydroxide, Ethylcellulose",
                AgeCategory = "Universal",
                SuggestedPrice = "41 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 24,
                ProductName = "Ultra Gentle Daily Cleanser",
                Brand = "Neutrogena",
                SkinType = "Dry",
                Category = "Cleanser",
                Ingredients = "Water, glycerin, cocamidopropyl betaine, lauryl glucoside, potassium acrylates copolymer, PEG-120 methyl glucose dioleate, disodium lauroamphodiacetate, sodium cocoyl sarcosinate, ethylhexylglycerin, caprylyl glycol, potassium sorbate",
                AgeCategory = "Universal",
                SuggestedPrice = "50 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 25,
                ProductName = "Comfy Water Sunblock SPF50+ Pa++++ (Unscented)",
                Brand = "Purito",
                SkinType = "Oily",
                Category = "SPF",
                Ingredients = "Water, Cetyl Ethylhexanoate, Butylene Glycol, Glycerin, Dipropylene Glycol, Zinc Oxide, Silica, Niacinamide, 1,2-Hexanediol, Polyglyceryl-3 Methylglucose Distearate, Titanium Dioxide(Ci 77891), Sodium Polyacryloyldimethyl Taurate, Cetearyl Olivate, Sorbitan Olivate, Madecassoside, Asiaticoside, Madecassic Acid, Asiatic Acid, Stearic Acid, Lauroyl Lysine, Disodium EDTA, Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Adenosine, Hydroxyethyl Acrylate/​Sodium Acryloyldimethyl Taurate Copolymer",
                AgeCategory = "Universal",
                SuggestedPrice = "84 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 26,
                ProductName = "Centella Green Level Safe Sun SPF50+ Pa++++",
                Brand = "Purito",
                SkinType = "Combination",
                Category = "SPF",
                Ingredients = "Water, Butylene Glycol, Glycerin, Dicaprylyl Carbonate, Dibutyl Adipate, Diethylamino Hydroxybenzoyl Hexyl Benzoate 3.0%, Hydrogenated Polyisobutene, 1,2-Hexanediol, Niacinamide, Ethylhexyl Triazone 2.0%, Polyglyceryl-3 Methylglucose Distearate, Silica, Cetearyl Olivate, Cetearyl Alcohol, Centella Asiatica Extract, Hyaluronic Acid, Tocopherol, Sorbitan Olivate, Glyceryl Stearate SE, Methyl Glucose Sesquistearate, Sorbitan Stearate, Lavandula Angustifolia (Lavender) Oil, Disodium EDTA, Adenosine, Anthemis Nobilis Flower Oil, Caprylyl Glycol, Ethylhexylglycerin",
                AgeCategory = "Universal",
                SuggestedPrice = "84 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 27,
                ProductName = "Beste No. 9 Jelly Cleanser",
                Brand = "Drunk Elephant",
                SkinType = "Dry",
                Category = "Cleanser",
                Ingredients = "Water, Glycerin, Cocamidopropyl Betaine, Coco-Glucoside, Sodium Lauroyl Methyl Isethionate, Cocamidopropyl Hydroxysultaine, Sodium Methyl Oleoyl Taurate, Propanediol, Aloe Barbadensis Leaf Extract, Glycolipids, Linoleic Acid, Linolenic Acid, Lauryl Glucoside, Cucumis Melo Cantalupensis Fruit Extract, Sclerocarya Birrea Seed Oil, Dipotassium Glycyrrhizate, Tocopherol, Citric Acid, Phenoxyethanol, Sodium Hydroxide, Sodium Benzoate, Sodium Chloride, Polylysine",
                AgeCategory = "Universal",
                SuggestedPrice = "50 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 28,
                ProductName = "Gentle Touch Makeup Remover",
                Brand = "Paula's Choice",
                SkinType = "Combination",
                Category = "Makeup Remover",
                Ingredients = "Water (Aqua), Cyclotetrasiloxane, Cyclopentasiloxane, Isohexadecane, Butylene Glycol, Glycerin, Aloe Barbadensis Leaf Juice, Bisabolol, Camellia Oleifera Leaf Extract (Green Tea Extract), Poloxamer 184, Sodium Dehydroacetate, Allantoin, Glycyrrhetinic Acid, Sodium Chloride, Disodium Edta, Methylparaben, Benzalkonium Chloride, Benzyl Alcohol ",
                AgeCategory = "Universal",
                SuggestedPrice = "89 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 29,
                ProductName = "Beauty Effect Day Cream",
                Brand = "Balea",
                SkinType = "Oily",
                Category = "Moisturizer",
                Ingredients = "Aqua, Glycerin, Ethylhexyl Salicylate, Butyl Methoxydibenzoylmethane, Caprylic/​Capric Triglyceride, Glyceryl Citrate/​Lactate/​Linoleate/​Oleate, Dicaprylyl Ether, Cetearyl Alcohol, Ethylhexyl Triazone, Behenyl Alcohol, Butyrospermum Parkii Butter, Glyceryl Stearate, Tocopheryl Acetate, Panthenol, Bis-Ethylhexyloxyphenol Methoxyphenyl Triazine, Sodium Hyaluronate, C12-15 Alkyl Benzoate, Pullulan, Porphyridium Cruentum Extract, Phenoxyethanol, Hydroxypropyl Methylcellulose, Caprylyl Glycol, Myristyl Myristate, Parfum, Xanthan Gum, Sodium Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Disodium EDTA, Limonene, Linalool, Tocopherol",
                AgeCategory = "Universal",
                SuggestedPrice = "25 RON",
                ForSensitive = false,
                IsInitial = true
            });


            Products.Add(new Product
            {
                ID = 30,
                ProductName = "Aloe Soothing Sun Cream SPF 50",
                Brand = "COSRX",
                SkinType = "Normal",
                Category = "SPF",
                Ingredients = "Water, Ethylhexyl Methoxycinnamate, Glycerin, Propylene Glycol, Cyclopentasiloxane, Bis-Ethylhexyloxyphenol Methoxyphenyl Triazine, Phenylbenzimidazole Sulfonic Acid, Dicaprylyl Carbonate, Isoamyl p-Methoxycinnamate, Potassium Cetyl Phosphate, Alcohol, Dimethicone, Glyceryl Stearate, Butylene Glycol, Titanium Dioxide, C14-22 Alcohols, Polymethyl Methacrylate, Cetearyl Alcohol, Aloe Arborescens Leaf Extract (1,100 Ppm), Dipotassium Glycyrrhizate, Tocopheryl Acetate, PEG-100 Stearate, Silica",
                AgeCategory = "Universal",
                SuggestedPrice = "79 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 31,
                ProductName = "Sun UV Face Soothing Sensitive SPF 50",
                Brand = "Nivea",
                SkinType = "Combination",
                Category = "SPF",
                Ingredients = "Aqua, Homosalate, Alcohol Denat, Butyl Methoxydibenzoylmethane, Ethylhexyl Salicylate, Butylene Glycol Dicaprylate/​Dicaprate, Ethylhexyl Triazone, Bis-Ethylhexyloxyphenol Methoxyphenyl Triazine, Cyclomethicone, Phenylbenzimidazole Sulfonic Acid, Silica, Tapioca Starch, Behenyl Alcohol, Cetearyl Alcohol, Methylpropanediol, Glycerin, Glycyrrhiza Inflata Root Extract, Tocopheryl Acetate, Sodium Stearoyl Glutamate, Xanthan Gum, Carbomer, Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Sodium Chloride, Sodium Hydroxide, Dimethicone, Trisodium EDTA, Caprylyl Glycol, Ethylhexylglycerin",
                AgeCategory = "Universal",
                SuggestedPrice = "32 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 32,
                ProductName = "Oil Free Acne Facial Moisturizer with Salicylic Acid",
                Brand = "Neutrogena",
                SkinType = "Oily",
                Category = "Moisturizer",
                Ingredients = "Water, Dicaprylyl Ether, Cetearyl Alcohol, Glycerin, Neopentyl Glycol Dietheylhexanoate, Dimethicone, Methyl Gluceth-20, Aluminum Starch Octenylsuccinate, Ceteth-10 Phosphate, Dicetyl Phosphate, Steareth-20, Steareth-2, Neopentyl Glycol Diisostearate, Sodium Benzoate, Fragrance, Sodium Hydroxide, Disodium EDTA, Xanthan Gum, Magnesium Aluminum Silicate, BHT, Citrus Grandis (grapefruit) Fruit Extract",
                AgeCategory = "14-18",
                SuggestedPrice = "32 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 33,
                ProductName = "Teen Derm K Concentrate",
                Brand = "Isis Pharma",
                SkinType = "Combination",
                Category = "Moisturizer",
                Ingredients = "Water, Glycolic Acid, Gluconolactone, Alcohol Denat, Hydroxyethyl Acrylate/​Sodium Acryloyldimethyl Taurate Copolymer, Sodium Hydroxide, Butyl Avocadate, Dipropylene Glycol, PEG-7 Glyceryl Cocoate, Pentylene Glycol, Xylitylglucoside, Zinc Pca, Polyacrylate-13, Anhydroxylitol, Disodium EDTA, Hydroxyethylcellulose, Salicylic Acid, Sodium Benzoate, Polyisobutene, Xylitol, Butylene Glycol, PPG-26-Buteth-26, Chlorphenesin, Boswellia Serrata Resin Extract, Sorbitan Isostearate, PEG-40 Hydrogenated Castor Oil, Polysorbate 60, Fragrance, O-Cymen-5-Ol, Polysorbate 20, Polyquaternium-51, Linalool, Limonene, Citronellol, Hexyl Cinnamal, Propyl Gallate",
                AgeCategory = "14-18",
                SuggestedPrice = "40 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 34,
                ProductName = "Hydrating Micellar Water",
                Brand = "Cerave",
                SkinType = "Dry",
                Category = "Makeup Remover",
                Ingredients = "Water, Propanediol, PEG-6 Caprylic/​Capric Glycerides, Glycerin, 1, 2-Hexanediol, Caprylhydroxamic Acid, Niacinamide, Biosaccharide Gum-1, Glucamine, Sodium Hyaluronate, Sodium Lauroyl Lactylate, Rhamnose, Glucose, Glucuronic Acid, Ceramide NP (Ceramide 3), Ceramide AP (Ceramide 6-Ii), Phytosphingosine, Cholesterol, Xanthan Gum, Carbomer, Ceramide EOP (Ceramide 1)",
                AgeCategory = "Universal",
                SuggestedPrice = "32 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 35,
                ProductName = "Micellar Water",
                Brand = "La Roche-Posay",
                SkinType = "Combination",
                Category = "Makeup Remover",
                Ingredients = "Aqua/​Water, Butylene Glycol, Glycerin, Triethanolamine, Simethicone, Caffeine, Sodium Citrate, Ascorbyl Glucoside, Poloxamer 184, Disodium Cocoamphodiacetate, Disodium EDTA, Hydroxypropyl Guar, Citric Acid, Biosaccharide Gum-1, Dihydrocholeth-30, Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Sodium Chloride, Sodium Glycolate, Sodium Glycolate, Phenoxyethanol, Methylparaben, Ethylparaben, Propylparaben, Butylparaben, Isobutylparaben",
                AgeCategory = "Universal",
                SuggestedPrice = "45 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 36,
                ProductName = "Sensibio H2O Micellar Water",
                Brand = "Bioderma",
                SkinType = "Combination",
                Category = "Makeup Remover",
                Ingredients = "Aqua/​Water/​Eau, Peg-6 Caprylic/​Capric Glycerides, Fructooligosaccharides, Mannitol, Xylitol, Rhamnose, Cucumis Sativus (Cucumber) Fruit Extract, Propylene Glycol, Cetrimonium Bromide, Disodium Edta",
                AgeCategory = "Universal",
                SuggestedPrice = "45 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 37,
                ProductName = "Effaclar Duo (+)",
                Brand = "La Roche-Posay",
                SkinType = "Combination",
                Category = "Moisturizer",
                Ingredients = "Aqua/​Water, Glycerin, Dimethicone, Isocetyl Stearate, Niacinamide, Isopropyl Lauroyl Sarcosinate, Silica, Ammonium Polyacryloyldimethyl Taurate, Methyl Methacrylate Crosspolymer, Potassium Cetyl Phosphate, Sorbitan Oleate, Zinc Pca, Glyceryl Stearate SE, Isohexadecane, Sodium Hydroxide, Myristyl Myristate, 2-Oleamido-1,3-Octadecanediol, Aluminum Starch Octenylsuccinate, Mannose, Poloxamer 338, Disodium EDTA, Capryloyl Salicylic Acid, Caprylyl Glycol, Vitreoscilla Ferment, Xanthan Gum, Polysorbate 80, Acrylamide/​Sodium Acryloyldimethyltaurate Copolymer, Salicylic Acid, Piroctone Olamine",
                AgeCategory = "18-30",
                SuggestedPrice = "64 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 38,
                ProductName = "Kale + Green Tea Spinach Vitamins Cleanser",
                Brand = "Youth to the People",
                SkinType = "Normal",
                Category = "Cleanser",
                Ingredients = "Water, Sodium Cocoyl Glutamate, Cocamidopropyl Betaine, Panthenol (Vitamin B5),Tocopheryl Acetate (Vitamin E), Ascorbic Acid (Vitamin C), Butylene Glycol, Brassica Oleracea(Kale) Leaf Extract, Spinacia Oleracea (Spinach) Leaf Extract, Camellia Sinensis (Green Tea)Leaf Extract, Chamomilla Recutita (Matricaria) Flower Extract, Medicago Sativa (Alfalfa) Extract,Aloe Barbadensis (Aloe Vera) Leaf Extract, Natural Fragrance, Lecithin, HydroxypropylMethylcellulose, Phenoxyethanol, Potassium Sorbate, Sodium Benzoate, Chlorophyll",
                AgeCategory = "Universal",
                SuggestedPrice = "105 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 39,
                ProductName = "Toleriane Dermo",
                Brand = "La Roche-Posay",
                SkinType = "Dry",
                Category = "Cleanser",
                Ingredients = "WATER/AQUA • ETHYLHEXYL PALMITATE • GLYCERIN • DIPROPYLENE GLYCOL • CARBOMER • SODIUM HYDROXIDE • CAPRYL GLYCOL/CAPRYLYL GLYCOL • ETHYLHEXYLGLYCERIN.",
                AgeCategory = "45+",
                SuggestedPrice = "52 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 40,
                ProductName = "Normaderm Phytosolution",
                Brand = "Vichy",
                SkinType = "Oily",
                Category = "Cleanser",
                Ingredients = "AQUA /WATER - COCO-BETAINE - PROPANEDIOL - PEG-120 METHYL GLUCOSE DIOLEATE - SODIUM CHLORIDE - SODIUM COCOYL GLYCINATE - DIPROPYLENE GLYCOL - ZINC GLUCONATE - SALICYLIC ACID - BIFIDA FERMENT LYSATE - SODIUM HYDROXIDE - SODIUM BENZOATE - PHENOXYETHANOL - COPPER GLUCONATE - CAPRYLYL GLYCOL - TETRASODIUM GLUTAMATE DIACETATE",
                AgeCategory = "Universal",
                SuggestedPrice = "67 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 41,
                ProductName = "Hyséac Eau Thermale Fluid SPF 30",
                Brand = "Uriage",
                SkinType = "Oily",
                Category = "SPF",
                Ingredients = "Butane, Aqua, Cyclopentasiloxane, Dicaprylyl Ether, Ethylhexyl Methoxycinnamate, Isobutane, Ethylhexyl Salicylate, Octocrylene, Nylon-12, Propane, Cyclohexasiloxane, PEG-30 Dipolyhydroxystearate, Glycerin, Butyl Methoxydibenzoylmethane, Sodium Chloride, Phenoxyethanol, Trehalose, Urea, Chlorphenesin, Tetrasodium EDTA, Xylitylglucoside, Citric Acid, Anhydroxylitol, Hydrogenated Polydecene, Tocopheryl Acetate, Pentylene Glycol, Serine, Parfum, Xylitol, Glucose, Algin, Caprylyl Glycol, Disodium Phosphate, Glyceryl Polyacrylate, Pullulan, Sodium Hyaluronate, Ascorbyl Tetraisopalmitate, BHT, Potassium Phosphate",
                AgeCategory = "14-18",
                SuggestedPrice = "40 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 42,
                ProductName = "Sensibio Light Soothing Cream",
                Brand = "Bioderma",
                SkinType = "Combination",
                Category = "Moisturizer",
                Ingredients = "Aqua/​Water/​Eau, Glycerin, Cetearyl Isononanoate, Isohexadecane, Glycol Palmitate, Caprylic/​Capric Triglyceride, Triceteareth-4 Phosphate, Fructooligosaccharides, Mannitol, Xylitol, Glycyrrhetinic Acid, Rhamnose, Laminaria Ochroleuca Extract, Glycol Stearate, Peg-2 Stearate, Pentylene Glycol, Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, 1,2-Hexanediol, Caprylyl Glycol, Disodium Edta, Xanthan Gum, Sodium Hydroxide",
                AgeCategory = "18-30",
                SuggestedPrice = "42 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 43,
                ProductName = "Sebiaclear Active",
                Brand = "SVR",
                SkinType = "Oily",
                Category = "Moisturizer",
                Ingredients = "Aqua (Purified Water), Gluconolactone, Cyclopentasiloxane, Propanediol, Methyl Methacrylate Crosspolymer, Niacinamide, Sodium Hydroxide, Ammonium Acryloyldimethyltaurate/​Vp Copolymer, Hydroxyethyl Acrylate/​Sodium Acryloyldimethyl Taurate Copolymer, Salicylic Acid, Saccharide Isomerate, Citric Acid, Dimethiconol, Glyceryl Stearate, Peg-100 Stearate, Polysorbate 60, Sodium Citrate, Sorbitan Isostearate",
                AgeCategory = "18-30",
                SuggestedPrice = "72 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 44,
                ProductName = "Purifying cleansing gel",
                Brand = "Ivatherm",
                SkinType = "Combination",
                Category = "Cleanser",
                Ingredients = "Aqua (Water), Decyl Glucoside, Butylene Glycol, Laureth-11 Carboxylic Acid, PEG-120 Methyl Glucose Dioleate, Glycerin, Dimethicone Peg-7 Phosphate, Zinc Pca, Buteth-3, Sodium Hydroxide, Hydroxypropyl Guar Hydroxypropyltrimonium Chloride, Chlorphenesin, Sodium Benzotriazolyl Butylphenol Sulfonate, O-Cymen-5-Ol, Juniperus Oxycedrus (Cade) Wood Oil, Tetrasodium Edta, Tributyl Citrate, Tocopherol, CI 42090 (Blue 1)",
                AgeCategory = "Universal",
                SuggestedPrice = "44 RON",
                ForSensitive = true,
                IsInitial = true
            });


            Products.Add(new Product
            {
                ID = 45,
                ProductName = "Cleanance SPF 30",
                Brand = "Avene",
                SkinType = "Combination",
                Category = "SPF",
                Ingredients = "Avene Thermal Spring Water (Avene Aqua), C12-15 Alkyl Benzoate, Methylene Bis-Benzotriazolyl Tetramethylbutylphenol (Nano), Cetearyl Isononanoate, Water (Aqua), Diisopropyl Adipate, Isodecyl Neopentanoate, Bis-Ethylhexyloxyphenol Methoxyphenyl Triazine, Diethylhexyl Butamido Triazone, Polymethyl Methacrylate, Butyl Methoxydibenzoylmethane, Potassium Cetyl Phosphate, Decyl Glucoside, Glyceryl Laurate, Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Benzoic Acid, Caprylic/​Capric Triglyceride, Caprylyl Glycol, Disodium EDTA, Fragrance (Parfum), Glyceryl Behenate, Glyceryl Dibehenate, Hydrogenated Palm Glycerides, Hydrogenated Palm Kernel Glycerides, Propylene Glycol, Silica, Sodium Hydroxide, Tocopheryl Glucoside, Tribehenin, Xanthan Gum, Zinc Gluconate",
                AgeCategory = "14-18",
                SuggestedPrice = "45 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 46,
                ProductName = "Pure & Free Liquid SPF 50",
                Brand = "Neutrogena",
                SkinType = "Normal",
                Category = "SPF",
                Ingredients = "Titanium Dioxide 5, Zinc Oxide (3%), Water, C12-15 Alkyl Benzoate, Trisiloxane, Dimethicone, Styrene/​Acrylates Copolymer, Silica, Cetyl Peg/​Ppg-10/​1 Dimethicone, Polyglyceryl-4 Diisostearate/​Polyhydroxystearate/​Sebacate, Ppg-12/​Smdi Copolymer, Bisabolol, Magnesium Sulfate, Caprylyl Glycol, Dmdm Hydantoin, Triethoxycaprylylsilane, Bht",
                AgeCategory = "14-18",
                SuggestedPrice = "25 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 47,
                ProductName = "Ultra Sheer Dry-Touch Sunblock SPF 50+",
                Brand = "Neutrogena",
                SkinType = "Oily",
                Category = "SPF",
                Ingredients = "Water, Homosalate, Benzophenone-3, Ethylhexyl Salicylate, Octocrylene, Butyl Methoxydibenzoylmethane, Silica, Styrene/​Acrylates Copolymer, Potassium Cetyl Phosphate, Beeswax, Glyceryl Stearate, PEG-100 Stearate, Dimethicone, Caprylyl Methicone, Cetyl Dimethicone, Phenoxyethanol, Ethylhexylglycerin, Sodium Polyacrylate, Behenyl Alcohol, Xanthan Gum, Chlorphenesin, Acrylates/​C12-22 Alkyl Methacrylate Copolymer, Dimethicone/​PEG-10/​15 Crosspolymer, Ethylhexyl Stearate, Fragrance, Disodium EDTA, Methylparaben, Propylparaben, BHT, Chlorhexidine Digluconate, Ethylparaben, Trideceth-6, Diethylhexyl 2,6-Naphthalate",
                AgeCategory = "18-30",
                SuggestedPrice = "31 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 48,
                ProductName = "Purete Thermale 3 In 1 Micellar Water",
                Brand = "Vichy",
                SkinType = "Dry",
                Category = "Makeup Remover",
                Ingredients = "Aqua/​Water, Hexylene Glycol, Glycerin, Poloxamer 184, Disodium Cocoamphodiacetate, Disodium EDTA, Panthenol, Polyaminopropyl Biguanide, Parfum/​Fragrance",
                AgeCategory = "Universal",
                SuggestedPrice = "38 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 49,
                ProductName = "Sensifine Ar Micellar Water",
                Brand = "SVR",
                SkinType = "Dry",
                Category = "Makeup Remover",
                Ingredients = "Aqua (Purified Water), PEG-7 Glyceryl Cocoate, PEG-6 Caprylic/​Capric Glycerides, Propanediol, Pentylene Glycol, Niacinamide, Polysorbate 20, 1-2 Hexanediol, Sodium Hydroxide, Citric Acid, Cetrimonium Bromide",
                AgeCategory = "Universal",
                SuggestedPrice = "62 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 50,
                ProductName = "Teen Derm Aqua",
                Brand = "123",
                SkinType = "Oily",
                Category = "Makeup Remover",
                Ingredients = "AQUA (WATER), PEG-6 CAPRYLIC/CAPRIC GLYCERIDES, BUTYLENE GLYCOL, PENTYLENE GLYCOL, XYLITYLGLUCOSIDE, ANHYDROXYLITOL, SODIUM BENZOATE, ETHYLHEXYLGLYCERIN, XYLITOL, CETRIMONIUM BROMIDE, TETRASODIUM EDTA, PARFUM (FRAGRANCE), COPPER PCA, ZINC PCA, CITRIC ACID, TOCOPHERYL ACETATE, BUTYL AVOCADATE, DIPROPYLENE GLYCOL, LINALOOL, LIMONENE, CITRONELLOL, HEXYL CINNAMAL, BOSWELLIA SERRATA RESIN EXTRACT, PROPYL GALLATE",
                AgeCategory = "14-18",
                SuggestedPrice = "41 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 51,
                ProductName = "Hydraliane Legere",
                Brand = "SVR",
                SkinType = "Dry",
                Category = "Moisturizer",
                Ingredients = "Aqua (Purified Water), Propanediol, Cyclopentasiloxane, Caprylic/​Capric Triglyceride, Corn Starch Modified, Dimethicone, Glycerin, Butyrospermum Parkii (Shea) Butter, Glyceryl Stearate, Cetyl Alcohol, Magnesium Gluconate, Manganese Gluconate, Zinc Gluconate, Saccharide Isomerate, Squalane, 1,2-Hexanediol, Arachidyl Alcohol, C12-16 Alcohols, Ceteth-20, Citric Acid, Hydrogenated Lecithin, Hydroxyethyl Acrylate/​Sodium Acryloyldimethyl Taurate Copolymer, Palmitic Acid, PEG-75 Stearate, Polyacrylate Crosspolymer-6, Polysorbate 60, Sodium Citrate, Sodium Lactate, Sorbitan Isostearate, Steareth-20, Xanthan Gum, Chlorphenesin, O-Cymen-5-Ol",
                AgeCategory = "18-30",
                SuggestedPrice = "70 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 52,
                ProductName = "Skin Balancing Ultra-Sheer Daily Defense Broad Spectrum SPF 30",
                Brand = "Paula's Choice",
                SkinType = "Combination",
                Category = "SPF",
                Ingredients = "Water, Butylene Glycol, Silica, Aluminum Starch Octenylsuccinate, Cetyl Dimethicone, Camellia Sinensis Leaf Extract, Aloe Barbadensis Leaf Juice Powder, Ascorbyl Palmitate, Phospholipids, Superoxide Dismutase, Adenosine, Tocopherol, Bisabolol, Boerhavia Diffusa Root Extract, Colloidal Oatmeal, Panthenol, Ginkgo Biloba Leaf Extract, Salix Alba Bark Extract, Acrylate/​C10-30 Alkyl Acrylate Crosspolymer, Titanium Dioxide, Sorbic Acid, Sodium Hydroxide, Steareth-21, Steareth-2, Polysorbate 20, Disodium EDTA, Phenoxyethanol",
                AgeCategory = "18-30",
                SuggestedPrice = "120 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 53,
                ProductName = "SkinActive Micellar Foaming",
                Brand = "Garnier",
                SkinType = "Dry",
                Category = "Cleanser",
                Ingredients = "Aqua/Water, Glycerin, Peg-200 Hydrogenated Glyceryl Palmate, Coco-Betaine, Sodium Laureth Sulfate, Polysorbate 20, Peg-7 Glyceryl Cocoate, Citric Acid, Cocamide Mea, Peg-55 Propylene Glycol Oleate, Polyquaternium-11, Ppg-5 Ceteth-20, Propylene Glycol, Sodium Benzoate, Sodium Chloride, Sodium Hydroxide, Vitis Vinifera Fruit Water/Grape Fruit Water",
                AgeCategory = "Universal",
                SuggestedPrice = "30 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 54,
                ProductName = "Salicylic Acid Face Cleanser",
                Brand = "THE INKEY LIST",
                SkinType = "Combination",
                Category = "Cleanser",
                Ingredients = "Aqua (Water), Glycerin, Sodium Methyl Cocoyl Taurate, Cocamidopropyl Betaine, Cocamidopropyl Dimethylamine, PEG-120 Methyl Glucose Dioleate, Salicylic Acid, Betaine, Zinc PCA, Phenoxyethanol, Sodium Chloride, Allantoin, Coco-Glucoside, Glyceryl Oleate, Benzyl Alcohol, Coconut Acid, Ethylhexylglycerin, Sodium Benzoate, Citric Acid, Dehydroacetic Acid, Trisodium Ethylenediamine Disuccinate, Tocopherol, Hydrogenated Palm Glycerides Citrate",
                AgeCategory = "14-18",
                SuggestedPrice = "57 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 55,
                ProductName = "Anthelios Ultra Cream SPF 50+",
                Brand = "La Roche-Posay",
                SkinType = "Dry",
                Category = "SPF",
                Ingredients = "Aqua/​Water, Diisopropyl Sebacate, Glycerin, Bis-Ethylhexyloxyphenol Methoxyphenyl Triazine, Alcohol Denat, Propanediol, Ethylhexyl Salicylate, Ethylhexyl Triazone, C12-22 Alkyl Acrylate/​Hydroxyethylacrylate Copolymer, Drometrizole Trisiloxane, Butyl Methoxydibenzoylmethane, Aluminum Starch Octenylsuccinate, Silica, Tocopherol, Isopropyl Lauroyl Sarcosinate, Acrylates Copolymer, Ammonium Acryloyldimethyltaurate/​VP Copolymer, Caprylyl Glycol, Citric Acid, Disodium EDTA, Scutellaria Baicalensis Extract, Scutellaria Baicalensis Root Extract, T-Butyl Alcohol, Terephthalylidene Dicamphor Sulfonic Acid, Triethanolamine, Xanthan Gum, Parfum/​Fragrance (Code Fil:C210571/​1)",
                AgeCategory = "18-30",
                SuggestedPrice = "64 RON",
                ForSensitive = true,
                IsInitial = true
            });


            Products.Add(new Product
            {
                ID = 56,
                ProductName = "Hydrotenseur",
                Brand = "Rilastil",
                SkinType = "Dry",
                Category = "Moisturizer",
                Ingredients = "Aqua (Water), C12-20 Acid PEG-8 Ester, Butylene Glycol, Caprylyl Methicone, Hydrogenated Didecene, Dimethicone, Diethylhexyl Carbonate, Olea Europaea (Olive) Oil Unsaponifiables, Panthenol, Sodium PCA, Cetyl Alcohol, Polymethyl Methacrylate, Cyclopentasiloxane, Sodium Hyaluronate, Butyrospermum Parkii (Shea) Butter, Propanediol, Arginine, Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Polysilicone-11, Ornithine, Tocopheryl Acetate, Phospholipids, Sodium Lauroyl Lactylate, Laureth-3, Pullulan, Glycolipids, Acetyl Dipeptide-1 Cetyl Ester, Ceramide NP, Ceramide AP, Phytosphingosine, Cholesterol, Helianthus Annuus (Sunflower) Seed Oil, Sodium Dna, Ceramide EOP, Levulinic Acid, P-Anisic Acid, Hydroxyethylcellulose, Pentaerythrityl Tetra-Di-T-Butyl Hydroxyhydrocinnamate, Glycerin, Sodium Hydroxide, Carbomer, Xanthan Gum, Tocopherol, Chlorphenesin, O-Cymen-5-Ol, Phenoxyethanol, Potassium Sorbate, Ethylhexylglycerin, Disodium EDTA",
                AgeCategory = "30-45",
                SuggestedPrice = "58 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 57,
                ProductName = "Idealia Day Cream",
                Brand = "Vichy",
                SkinType = "Combination",
                Category = "Moisturizer",
                Ingredients = "Aqua, Glycerin, Dimethicone, Alcohol Denat, Pentaerythrityl Tetraethylhexanoate, Saccharomyces/​Xylinum/​Black Tea Ferment, Myreth-3 Myristate, Isopropyl Palmitate, Pentylene Glycol, Cetyl Alcohol, Propylene Glycol, Octyldodecanol, Synthetic Wax, Tin Oxide, PEG-100 Stearate, Ci 17200, Ci 15985, Ci 77891, Stearyl Alcohol, Mica, Potassium Sorbate, Carbomer, Sorbitol, Glyceryl Stearate, Vaccinium Myrtillus Fruit Extract, Dimethicone/​Vinyl Dimethicone Crosspolymer, Dimethicone Crosspolymer, Methyl Methacrylate Crosspolymer, Silica, Sodium Hydroxide, Myristyl Alcohol, Sodium Citrate, Phenoxyethanol, Adenosine, Tocopherol, Disodium EDTA, Caprylyl Glycol, Capryloyl Salicylic Acid, Hydroxyethylcellulose, Citric Acid, Biotin, Parfum",
                AgeCategory = "30-45",
                SuggestedPrice = "67 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 58,
                ProductName = "Effaclar Purifying Foaming Gel",
                Brand = "La Roche-Posay",
                SkinType = "Oily",
                Category = "Cleanser",
                Ingredients = "Water, Sodium Laureth Sulfate, Peg-8, Coco-Betaine, Hexylene Glycol, Sodium Chloride, Peg-120 Methyl Glucose Dioleate, Zinc Pca, Sodium Hydroxide, Citric Acid, Sodium Benzoate, Phenoxyethanol, Caprylyl Glycol, Parfum/​Fragrance",
                AgeCategory = "14-18",
                SuggestedPrice = "55 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 59,
                ProductName = "Hydrabio Perfecteur SPF 30",
                Brand = "Bioderma",
                SkinType = "Dry",
                Category = "SPF",
                Ingredients = "Aqua/​Water/​Eau, Glycerin, Octocrylene, Ethylhexyl Salicylate, Cyclopentasiloxane, Dimethicone, Dipropylene Glycol, Butyl Methoxydibenzoylmethane, Cetyl Alcohol, Polymethylsilsesquioxane, Niacinamide, Phenylbenzimidazole Sulfonic Acid, Styrene/​Acrylates Copolymer, Arachidyl Alcohol, Hdi/​Trimethylol Hexyllactone Crosspolymer, Arginine, Cyclohexasiloxane, Behenyl Alcohol, C30-45 Alkyl Cetearyl Dimethicone Crosspolymer, Mica (Ci 77019), Hydroxyethyl Acrylate/​Sodium Acryloyldimethyl Taurate Copolymer, Pentylene Glycol, Tocopheryl Acetate, Arachidyl Glucoside, Titanium Dioxide (Ci 77891), Disodium EDTA, PEG-8 Laurate, Salicylic Acid, Hexyldecanol, Sodium Hydroxide, Polysorbate 60, Sorbitan Isostearate, Pyrus Malus (Apple) Seed Extract, Brassica Campestris (Rapeseed) Sterols, Red 33 (Ci 17200), Tocopherol, Fragrance (Parfum)",
                AgeCategory = "30-45",
                SuggestedPrice = "45 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 60,
                ProductName = "Liftactiv Supreme Day",
                Brand = "The Ordinary",
                SkinType = "Dry",
                Category = "Moisturizer",
                Ingredients = "Aqua/​Water, Glycerin, Dimethicone, Rhamnose, Isohexadecane, Alcohol Denat, Propanediol, Isopropyl Isostearate, Vinyl Dimethicone/​Methicone Silsesquioxane Crosspolymer, Cetyl Alcohol, Dimethicone/​Vinyl Dimethicone Crosspolymer, Behenyl Alcohol, Nylon-12, PEG-100 Stearate, Ci 77163/​Bismuth Oxychloride, Ci 77891/​Titanium Dioxide, Stearic Acid, Stearyl Alcohol, Arachidyl Alcohol, Cetearyl Alcohol, Cetearyl Glucoside, Caffeine, Neohesperidin Dihydrochalcone, Palmitic Acid, Phenoxyethanol, Adenosine, Ammonium Polyacryldimethyltauramide/​Ammonium Polyacryloyldimethyl Taurate, Disodium Stearoyl Glutamate, Disodium EDTA, Caprylyl Glycol, Citric Acid, Synthetic Fluorphlogopite, Acrylamide/​Sodium Acryloyldimethyltaurate Copolymer, Ethylhexyl Hydroxystearate, Polysorbate 80",
                AgeCategory = "45+",
                SuggestedPrice = "75 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 61,
                ProductName = "Oil-Free Gentle Eye Makeup Remover",
                Brand = "Neutrogena",
                SkinType = "Combination",
                Category = "Makeup Remover",
                Ingredients = "Water, Cyclopentasiloxane, Cyclohexasiloxane, Aloe Barbadensis Leaf Juice, Benzyl Alcohol, Sodium Chloride, Dipropylene Glycol, Poloxamer 182, Allantoin, Tripotassium Edta, Benzalkonium Chloride, Glycerin, Cucumber (Cucumis Sativus) Fruit Extract, Potassium Phosphate, Dipotassium Phosphate.",
                AgeCategory = "14-18",
                SuggestedPrice = "18 RON",
                ForSensitive = true,
                IsInitial = true
            });


            Products.Add(new Product
            {
                ID = 62,
                ProductName = "Sun Fresh SPF 50",
                Brand = "Neutrogena",
                SkinType = "Combination",
                Category = "SPF",
                Ingredients = "Aqua, Neopentyl Glycol Diheptanoate, Octocrylene, Bis-Ethylhexyloxyphenol Methoxyphenyl Triazine, Butyl Methoxydibenzoylmethane, Ethylhexyl Triazone, Aluminum Starch Octenylsuccinate, Butylene Glycol, C12-15 Alkyl Benzoate, Potassium Cetyl Phosphate, Phenoxyethanol, Caprylyl Glycol, Chlorphenesin, Titanium Dioxide, Silica, Triacontanyl Pvp, Benzyl Alcohol, Cetyl Palmitate, Stearyl Alcohol, Tribehenin, Parfum, Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Sodium Hydroxide, Carbomer, Disodium EDTA, Tocopheryl Acetate, Magnesium Aspartate, Zinc Gluconate, Copper Gluconate, Sodium Ascorbyl Phosphate",
                AgeCategory = "30-45",
                SuggestedPrice = "35 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 63,
                ProductName = "Resist Skin Restoring Moisturizer With SPF 50",
                Brand = "Paula's Choice",
                SkinType = "Dry",
                Category = "SPF",
                Ingredients = "Water (Aqua), Silica, Glycerin, Cetearyl Alcohol, Dimethicone, Butylene Glycol, Pentylene Glycol, Potassium Cetyl Phosphate, Cyclopentasiloxane, Pyrus Malus (Apple) Fruit Extract, Vp/​Eicosene Copolymer, Butyrospermum Parkii (Shea) Butter, Allantoin, Niacinamide, Tocopherol, Glycyrrhiza Glabra (Licorice) Root Extract, Aloe Barbadensis Leaf Juice, Atractylodes Macrocephala Root Powder, Avena Sativa (Oat) Kernel Extract, Coffea Arabica (Coffee) Seed Extract, Portulaca Oleracea Extract, Mahonia Aquifolium Root Extract, Diethylhexyl Syringylidenemalonate, Sarcosine, Capryloyl Glycine, Maltooligosyl Glucoside, Cetearyl Glucoside, Dimethiconol, Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Hydrogenated Starch Hydrolysate, Hexylene Glycol, 4-T-Butylcyclohexanol, Glyceryl Stearate, Peg-100 Stearate, Sodium Hydroxide, Xanthan Gum, Disodium Edta, Phenoxyethanol, Caprylyl Glycol (Preservatives), Ethylhexylglycerin",
                AgeCategory = "45+",
                SuggestedPrice = "135 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 64,
                ProductName = "Ysthéal Anti-Wrinkle Emulsion",
                Brand = "Avene",
                SkinType = "Dry",
                Category = "Moisturizer",
                Ingredients = "Avène Thermal Spring Water, Caprylic/​Capric Triglyceride, Squalane, Mineral Oil (Paraffinum Liquidum), Propylene Glycol, Glyceryl Stearate, PEG-100 Stearate, Propylene Glycol, 1,2-Hexanediol, BHT, Caprylyl Glycol, Carbomer, Disodium EDTA, Oleoyl Dipeptide-15, Oleoyl Tetrapeptide-31, Polyacrylate-13, Polyisobutene, Polysorbate 20, Red 33 (Ci 17200), Retinal, Sorbitan Isostearate, Tocopheryl Glucoside, Triethanolamine",
                AgeCategory = "45+",
                SuggestedPrice = "68 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 65,
                ProductName = "Gentle Waterproof Makeup Remover",
                Brand = "Cetaphil",
                SkinType = "Dry",
                Category = "Makeup Remover",
                Ingredients = "Water, Cyclopentasiloxane, Dipropylene Glycol, Aloe Barbadensis Leaf Juice (Aloe Vera), Cucumis Sativus (Cucumber) Fruit Extract, Panax Ginseng Root Extract, Camellia Sinensis Leaf Extract (Green Tea), Glycerin, Potassium Phosphate, Dipotassium Phosphate, Poloxamer 184, Benzalkonium Chloride, Tetrasodium EDTA, Benzyl Alcohol, Sodium Chloride, Citric Acid, Allantoin.",
                AgeCategory = "14-18",
                SuggestedPrice = "35 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 66,
                ProductName = "Hydrating Gentle Soap Free Cleanser",
                Brand = "La Roche-Posay",
                SkinType = "Dry",
                Category = "Cleanser",
                Ingredients = "Aqua/Water/Eau (La Roche-Posay Prebiotic Thermal Water), Glycerin, Pentaerythrityl Tetraethylhexanoate, Propylene Glycol, Ammonium Polyacryloyldimethyl Taurate, Polysorbate 60, Ceramide Np, Niacinamide, Sodium Chloride, Coco-Betaine, Disodium Edta, Caprylyl Glycol, Panthenol, T-Butyl Alcohol, Tocopherol",
                AgeCategory = "14-18",
                SuggestedPrice = "63 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 67,
                ProductName = "Micellar Cleansing Water",
                Brand = "Simple",
                SkinType = "Combination",
                Category = "Makeup Remover",
                Ingredients = " Water (Aqua), Hexylene Glycol, Glycerin, Chamomilla Recutita (Matricaria) Flower Extract, Panthenol, Niacinamide, Sodium Ascorbyl Phosphate, DMD Hydantoin, Centrimonium Chloride, Citric Acid, Potassium Chloride, Sodium Chloride, Iodopropynyl Butylcarbamate",
                AgeCategory = "18-30",
                SuggestedPrice = "50 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 68,
                ProductName = "Camomille Gentle Eye Makeup Remover",
                Brand = "The Body Shop",
                SkinType = "Oily",
                Category = "Makeup Remover",
                Ingredients = "Water, Cyclomethicone, Glycerin, Phenoxyethanol, Coco-Glucoside, Carbomer, Algae Extract, Benzyl Alcohol, Glyceryl Polyacrylate, Sodium Laureth Sulfate, Cocamidopropyl Betaine, Anthemis Nobilis (Chamomile) Extract, Sodium Hydroxide, Dimethicone, Disodium EDTA, Chlorphenesin, Sodium Dehydroacetate, Sodium Hyaluronate, Methylparaben, Butylparaben, Ethylparaben, Isobutylparaben, Propylparaben",
                AgeCategory = "18-30",
                SuggestedPrice = "62 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 69,
                ProductName = "Renewing SA Cleanser",
                Brand = "Cerave",
                SkinType = "Normal",
                Category = "Cleanser",
                Ingredients = "Aqua/Water/Eau, Cocamidopropyl Hydroxysultaine, Glycerin, Sodium, Lauroyl Sarcosinate, Niacinamide, Gluconolactone, Peg-150 Pentaerythrityl Tetrastearate, Sodium Methyl Cocoyl Taurate, Zea Mays Oil/Corn Oil, Ceramide Np, Ceramide Ap, Ceramide Eop, Carbomer, Calcium Gluconate, Sodium Chloride, Salicylic Acid, Sodium Benzoate, Sodium Lauroyl Lactylate, Cholecalciferol, Cholesterol, Phenoxyethanol, Disodium Edta, Tetrasodium Edta, Hydrolyzed, Hyaluronic Acid, Phytosphingosine, Xanthan Gum, Ethylhexylglycerin",
                AgeCategory = "18-30",
                SuggestedPrice = "44 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 70,
                ProductName = "Low pH Good Morning Gel",
                Brand = "Cosrx",
                SkinType = "Combination",
                Category = "Cleanser",
                Ingredients = "Water, Cocamidopropyl Betaine, Sodium Lauroyl Methyl Isethionate, Polysorbate 20, Styrax Japonicus Branch/Fruit/Leaf Extract, Butylene Glycol, Saccharomyces Ferment, Cryptomeria Japonica Leaf Extract, Nelumbo Nucifera Leaf Extract, Pinus Palustris Leaf Extract, Ulmus Davidiana Root Extract, Oenothera Biennis (Evening Primrose) Flower Extract, Pueraria Lobata Root Extract, Melaleuca Alternifolia (Tea Tree) Leaf Oil, Allantoin, Caprylyl Glycol, Ethylhexylglycerin, Betaine Salicylate, Citric Acid, Ethyl Hexanediol, 1,2-Hexanediol, Trisodium Ethylenediamine Disuccinate, Sodium Benzoate, Disodium EDTA",
                AgeCategory = "18-30",
                SuggestedPrice = "62 RON",
                ForSensitive = false,
                IsInitial = true
            });
            Products.Add(new Product
            {
                ID = 71,
                ProductName = "Micellar Water Oil Infused",
                Brand = "Garnier",
                SkinType = "Dry",
                Category = "Makeup Remover",
                Ingredients = "AQUA / WATER, CYCLOPENTASILOXANE, ISOHEXADECANE, ARGANIA SPINOSA OIL / ARGANIA SPINOSA KERNEL OIL, BENZYL ALCOHOL, BENZYL SALICYLATE, BUTYL METHOXYDIBENZOYLMETHANE, CI 60725 / VIOLET 2, DECYL GLUCOSIDE, DIPOTASSIUM PHOSPHATE, DISODIUM EDTA, ETHYLHEXYL METHOXYCINNAMATE, ETHYLHEXYL SALICYLATE, GERANIOL",
                AgeCategory = "18-30",
                SuggestedPrice = "23 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 72,
                ProductName = "EAU Thermale Avene Micellar Lotion",
                Brand = "Avene",
                SkinType = "Dry",
                Category = "Makeup Remover",
                Ingredients = "Avène Thermal Spring Water, Pentylene Glycol, PEG-6 Caprylic/Capric Glycerides, Disodium EDTA, Fragrance, PEG-40 Hydrogenated Castor Oil, Sclerotium Gum, Sodium Benzoate, Sodium Chloride",
                AgeCategory = "30-45",
                SuggestedPrice = "43 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 73,
                ProductName = "Antirougeurs CLEAN Redness-relief",
                Brand = "Avene",
                SkinType = "Combination",
                Category = "Makeup Remover",
                Ingredients = "Avène Thermal Spring Water (Avène Aqua), C12-15 Alkyl Benzoate, Caprylic/Capric Triglyceride, Poloxamer 188, 4-T-Butylcyclohexanol, Acrylates/C10-30 Alkyl Acrylate Crosspolymer, Benzoic Acid, C12-20 Alkyl Glucoside, C14-22 Alcohols, Carbomer, Chlorphenesin, Disodium Edta, Octyldodecanol, Pongamia Glabra Seed Oil, Sodium Hydroxide",
                AgeCategory = "30-45",
                SuggestedPrice = "66 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 74,
                ProductName = "Salicylic Acid Daily Gentle Cleanser",
                Brand = "Cosrx",
                SkinType = "Oily",
                Category = "Cleanser",
                Ingredients = "Water, Glycerin, Myristic Acid, Stearic Acid, Potassium Hydroxide, Lauric Acid, Butylene Glycol, Glycol Distearate, Polysorbate 80, Sodium Methyl Cocoyl Taurate, Salicylic Acid, Cocamidopropyl Betaine, PEG-60 Hydrogenated Castor Oil, Fragrance, Sodium Chloride, Melaleuca Alternigolia (Tea Tree) Leaf Oil, Caprylyl Glycol, Ethylhexylglycerin, Salix Alba (Willow) Bark Water, Saccharomyces Ferment, Cryptomeria Japonica Leaf Extract, Nelumbo Nucifera Leaf Extract, Pinus Palustris Leaf Extract, Ulmus Davidiana Root Extract, Oenothera Biennis (Evening Primrose) Flower Extract, Pueraria Lobata Root Extract, 1,2-Hexanediol, Ethyl Hexanediol, Citric Acid, Disodium EDTA",
                AgeCategory = "18-30",
                SuggestedPrice = "59 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 75,
                ProductName = "Hydro Boost Hydrating Cleansing Gel",
                Brand = "Neutrogena",
                SkinType = "Dry",
                Category = "Cleanser",
                Ingredients = "Water, Glycerin, Cocamidopropyl Hydroxysultaine, Sodium Cocoyl Isethionate, Sodium Methyl Cocoyl Taurate, Sodium Hydrolyzed Potato Starch Dodecenylsuccinate, Hydrolyzed Hyaluronic Acid, Ethylhexylglycerin, Linoleamidopropyl PG-dimonium Chloride Phosphate, Polyquaternium-10, Polysorbate 20, Sodium Isethionate, Sodium Lauryl Sulfate",
                AgeCategory = "18-30",
                SuggestedPrice = "28 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 76,
                ProductName = "Soothing Cleanser Foam",
                Brand = "SkinCeuticals",
                SkinType = "Dry",
                Category = "Cleanser",
                Ingredients = "Aqua / water / eau, sorbitol, glycerin, sodium cocoyl glycinate, peg-8, hexylene glycol, coco-betaine, propylene glycol, phenoxyethanol, disodium edta, sodium chloride, orchis mascula extract, cucumis sativus fruit extract / cucumber fruit extract",
                AgeCategory = "30-45",
                SuggestedPrice = "159 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 77,
                ProductName = "Clarifying Exfoliating Cleanser",
                Brand = "SkinCeuticals",
                SkinType = "Combination",
                Category = "Cleanser",
                Ingredients = "aqua / water / eau, propylene glycol, behenyl betaine, triethanolamine, glycolic acid, salicylic acid, lactic acid, pumice, sodium chloride, phenoxyethanol, peg-100 stearate, zinc pca, glyceryl stearate, disodium edta, sodium benzoate",
                AgeCategory = "30-45",
                SuggestedPrice = "120 RON",
                ForSensitive = false,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 78,
                ProductName = "Clean it zero",
                Brand = "Banila",
                SkinType = "Oily",
                Category = "Makeup Remover",
                Ingredients = "Ethylhexyl Palmitate, Cetyl Ethylhexanoate, PEG-20 Glyceryl Triisostearate, PEG-10 Isostearate, Synthetic Wax, Onsen-Sui, Phenoxyethanol, Butylene Glycol, Lithospermum Erythrorhizon Root Extract, Tocopheryl Acetate, Fragrance, Ethylhexylglycerin, Water, 1,2-Hexanediol, Bambusa Vulgaris Leaf/​Stem Extract, Aspalathus Linearis Extract, Angelica Archangelica Root Extract, Malpighia Glabra (Acerola) Fruit Extract, Polydiethyleneglycol Adipate/​Ipdi Copolymer, Acrylates/​Ammonium Methacrylate Copolymer, Acrylates/​Methoxy PEG-15 Methacrylate Copolymer",
                AgeCategory = "30-45",
                SuggestedPrice = "93 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 79,
                ProductName = "Cleansing Oil",
                Brand = "Nivea",
                SkinType = "Dry",
                Category = "Makeup Remover",
                Ingredients = "Paraffinum Liquidum, Caprylic/​Capric Triglyceride, Isopropyl Palmitate, Isododecane, Ethylhexyl Stearate, PEG-20 Glyceryl Triisostearate, Macadamia Integrifolia Seed Oil, Prunus Amygdalus Dulcis Oil, Tocopherol, Linalool, Benzyl Alcohol, Benzyl Salicylate",
                AgeCategory = "45+",
                SuggestedPrice = "30 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 80,
                ProductName = "Ideal Soleil SPF 50 Anti Age",
                Brand = "Vichy",
                SkinType = "Dry",
                Category = "SPF",
                Ingredients = "Aqua/​Water, Homosalate, Silica, Ethylhexyl Salicylate, Ethylhexyl Triazone, Glycerin, C12-15 Alkyl Benzoate, Bis-Ethylhexyloxyphenol Methoxyphenyl Triazine, Drometrizole Trisiloxane, Butyl Methoxydibenzoylmethane, Saccharomyces/​Xylinum/​Black Tea Ferment, Aluminum Starch Octenylsuccinate, Octocrylene, Pentylene Glycol, Styrene/​Acrylates Copolymer, Potassium Cetyl Phosphate, Parfum/​Fragrance, Caprylyl Methicone, Terephthalylidene Dicamphor Sulfonic Acid, Butylene Glycol, Titanium Dioxide [Nano] /​ Titanium Dioxide, Triethanolamine, Phenoxyethanol, Caprylyl Glycol, Stearyl Alcohol, Dimethicone, Acrylates/​C10-30 Alkyl Acrylate Crosspolymer, Inulin Lauryl Carbamate, PEG-8 Laurate, Disodium EDTA, Tocopherol, Xanthan Gum, Aluminum Hydroxide, Stearic Acid, Hydroxyethylcellulose, Sodium Citrate, Citric Acid, Myrciaria Dubia Fruit Extract, Potassium Sorbate, Zingiber Officinale Root Extract /​ Ginger Root Extract, Sanguisorba Officinalis Root Extract, Cinnamomum Cassia Bark Extract, Benzyl Benzoate, Biotin, Ci 17200 /​ Red 33",
                AgeCategory = "45+",
                SuggestedPrice = "67 RON",
                ForSensitive = false,
                IsInitial = true
            });
        }
    }
}
