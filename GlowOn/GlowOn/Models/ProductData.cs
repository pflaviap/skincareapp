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

            //MAKEUP REMOVERS
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
                ID = 4,
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
                ID = 5,
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
                ID = 6,
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
                ID = 7,
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
                ID = 8,
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
                ID = 9,
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
                ID = 10,
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
                ID = 11,
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
                ID = 12,
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
                ID = 13,
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
                ID = 14,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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

            //CLEANSERS
            Products.Add(new Product
            {
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
                ProductName = "Salicylic Acid Face Cleanser",
                Brand = "THE INKEY LIST",
                SkinType = "Combination",
                Category = "Cleanser",
                Ingredients = "Aqua (Water), Glycerin, Sodium Methyl Cocoyl Taurate, Cocamidopropyl Betaine, Cocamidopropyl Dimethylamine, PEG-120 Methyl Glucose Dioleate, Salicylic Acid, Betaine, Zinc PCA, Phenoxyethanol, Sodium Chloride, Allantoin, Coco-Glucoside, Glyceryl Oleate, Benzyl Alcohol, Coconut Acid, Ethylhexylglycerin, Sodium Benzoate, Citric Acid, Dehydroacetic Acid, Trisodium Ethylenediamine Disuccinate, Tocopherol, Hydrogenated Palm Glycerides Citrate",
                AgeCategory = "14-18",
                SuggestedPrice = "57 RON",
                ForSensitive = true,
                IsInitial = true
            }); ;

            Products.Add(new Product
            {
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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
                ID = 6,
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

            //MOISTURIZERS
            Products.Add(new Product
            {
                ID = 6,
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
                ID = 6,
                ProductName = "Natural Moisturizing Factors",
                Brand = "The Ordinary",
                SkinType = "Normal",
                Category = "Moisturizer",
                Ingredients = "",
                AgeCategory = "Universal",
                SuggestedPrice = "37 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 6,
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
                ID = 6,
                ProductName = "Natural Moisturizing Factors",
                Brand = "The Ordinary",
                SkinType = "Normal",
                Category = "Moisturizer",
                Ingredients = "",
                AgeCategory = "Universal",
                SuggestedPrice = "37 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 6,
                ProductName = "Natural Moisturizing Factors",
                Brand = "The Ordinary",
                SkinType = "Normal",
                Category = "Moisturizer",
                Ingredients = "",
                AgeCategory = "Universal",
                SuggestedPrice = "37 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 6,
                ProductName = "Natural Moisturizing Factors",
                Brand = "The Ordinary",
                SkinType = "Normal",
                Category = "Moisturizer",
                Ingredients = "",
                AgeCategory = "Universal",
                SuggestedPrice = "37 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 6,
                ProductName = "Natural Moisturizing Factors",
                Brand = "The Ordinary",
                SkinType = "Normal",
                Category = "Moisturizer",
                Ingredients = "",
                AgeCategory = "Universal",
                SuggestedPrice = "37 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 6,
                ProductName = "Natural Moisturizing Factors",
                Brand = "The Ordinary",
                SkinType = "Normal",
                Category = "Moisturizer",
                Ingredients = "",
                AgeCategory = "Universal",
                SuggestedPrice = "37 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 6,
                ProductName = "Natural Moisturizing Factors",
                Brand = "The Ordinary",
                SkinType = "Normal",
                Category = "Moisturizer",
                Ingredients = "",
                AgeCategory = "Universal",
                SuggestedPrice = "37 RON",
                ForSensitive = true,
                IsInitial = true
            });

            Products.Add(new Product
            {
                ID = 6,
                ProductName = "Natural Moisturizing Factors",
                Brand = "The Ordinary",
                SkinType = "Normal",
                Category = "Moisturizer",
                Ingredients = "",
                AgeCategory = "Universal",
                SuggestedPrice = "37 RON",
                ForSensitive = true,
                IsInitial = true
            });
        }
    }
}
