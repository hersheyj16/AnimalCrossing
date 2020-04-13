using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AnimalCrossingAlgorithm;

namespace AnimalCrossingAlgorithm
{
    //Sources:
    //https://www.polygon.com/animal-crossing-new-horizons-switch-acnh-guide/2020/3/24/21191959/flower-hybrid-crossbreed-colors-cosmos-hyacinths-lilies-mums-pansies-roses-tulips-windflowers

    public class HybridFlowers
    {

        public static void Main(string[] args)
        {

            ICollection<Combination> combinations = new List<Combination>();
            InitializeCombinations(combinations);

            //generating flowers from the combinations

            ICollection<Flower> flowers = GenerateFlowers(combinations);

            foreach (var flower in flowers)
            {
                if (flower.ChildrenDictionary.Count > 0)
                {
                    Console.WriteLine(flower);
                }
            }
        }

        private static ICollection<Flower> GenerateFlowers(ICollection<Combination> combinations)
        {
            ISet<Flower> flowers = new HashSet<Flower>();
            foreach (var combination in combinations)
            {
                Flower c1 = new Flower(combination.type, combination.Colour);
                Flower f1 = new Flower(combination.type, combination.ParentColour1);
                Flower f2 = new Flower(combination.type, combination.ParentColour2);

                //Adding c1
                var c1flower = flowers.FirstOrDefault(x => (x.Type == c1.Type && x.Colour == c1.Colour));
                if (c1flower == null)
                {
                    flowers.Add(c1);
                }


                //Adding f1
                var first = flowers.FirstOrDefault(x => (x.Type == f1.Type && x.Colour == f1.Colour));
                if (first == null)
                {
                    f1.ChildrenDictionary.Add(f2.Colour.ToString(), c1);

                    flowers.Add(f1);
                }
                else
                {

                    first.ChildrenDictionary.Add(f2.Colour.ToString(), c1);

                }

                if (f1.Colour == f2.Colour)
                {
                    continue;
                }

                //Adding f2
                var second = flowers.FirstOrDefault(x => (x.Type == f2.Type && x.Colour == f2.Colour));
                if (second == null)
                {
                    f2.ChildrenDictionary.Add(f1.Colour.ToString(), c1);
                    flowers.Add(f2);
                }
                else
                {
                    //avoid situations like white X white

                    second.ChildrenDictionary.Add(f1.Colour.ToString(), c1);


                }

            }
            return flowers;
        }

        private static void InitializeCombinations(ICollection<Combination> combinations)
        {
            Combination Lily1 = new Combination(Type.Lilies, Colour.Red, Colour.Red, Colour.Black);
            Combination Lily2 = new Combination(Type.Lilies, Colour.Yellow, Colour.Red, Colour.Orange);
            Combination Lily3 = new Combination(Type.Lilies, Colour.Red, Colour.White, Colour.Pink);
            combinations.Add(Lily1);
            combinations.Add(Lily2);
            combinations.Add(Lily3);

            Combination Roses1 = new Combination(Type.Roses, Colour.Red, Colour.Red, Colour.Black);
            Combination Roses2 = new Combination(Type.Roses, Colour.White, Colour.Red, Colour.Pink);
            Combination Roses3 = new Combination(Type.Roses, Colour.Yellow, Colour.Red, Colour.Orange);
            Combination Roses4 = new Combination(Type.Roses, Colour.White, Colour.White, Colour.Purple);
            Combination Roses5 = new Combination(Type.Roses, Colour.Purple, Colour.Orange, Colour.HybridRed);
            Combination Roses6 = new Combination(Type.Roses, Colour.HybridRed, Colour.HybridRed, Colour.HybridBlue);
            Combination Roses7 = new Combination(Type.Roses, Colour.Black, Colour.Gold, Colour.Gold);
            combinations.Add(Roses1);
            combinations.Add(Roses2);
            combinations.Add(Roses3);
            combinations.Add(Roses4);
            combinations.Add(Roses5);
            combinations.Add(Roses6);
            combinations.Add(Roses7);

            Combination Mum1 = new Combination(Type.Mums, Colour.Red, Colour.White, Colour.Pink);
            Combination Mum2 = new Combination(Type.Mums, Colour.White, Colour.White, Colour.Purple);
            Combination Mum3 = new Combination(Type.Mums, Colour.Purple, Colour.Purple, Colour.Green);
            combinations.Add(Mum1);
            combinations.Add(Mum2);
            combinations.Add(Mum3);

            Combination Pansies1 = new Combination(Type.Pansies, Colour.Red, Colour.Red, Colour.Purple);
            Combination Pansies2 = new Combination(Type.Pansies, Colour.White, Colour.White, Colour.Blue);
            Combination Pansies3 = new Combination(Type.Pansies, Colour.Yellow, Colour.Red, Colour.Orange);
            Combination Pansies4 = new Combination(Type.Pansies, Colour.Blue, Colour.Blue, Colour.Purple);
            combinations.Add(Pansies1);
            combinations.Add(Pansies2);
            combinations.Add(Pansies3);
            combinations.Add(Pansies4);


            Combination w1 = new Combination(Type.Windflowers, Colour.Orange, Colour.Red, Colour.Pink);
            Combination w2 = new Combination(Type.Windflowers, Colour.Orange, Colour.White, Colour.Blue);
            Combination w3 = new Combination(Type.Windflowers, Colour.White, Colour.White, Colour.Blue);
            Combination w4 = new Combination(Type.Windflowers, Colour.Blue, Colour.Pink, Colour.Purple);
            Combination w5 = new Combination(Type.Windflowers, Colour.Blue, Colour.Blue, Colour.Purple);
            combinations.Add(w1);
            combinations.Add(w2);
            combinations.Add(w3);
            combinations.Add(w4);
            combinations.Add(w5);


            Combination C1 = new Combination(Type.Cosmos, Colour.Red, Colour.Yellow, Colour.Orange);
            Combination C2 = new Combination(Type.Cosmos, Colour.Red, Colour.White, Colour.Pink);
            Combination C3 = new Combination(Type.Cosmos, Colour.Red, Colour.Red, Colour.Black);
            combinations.Add(C1);
            combinations.Add(C2);
            combinations.Add(C3);


            Combination T1 = new Combination(Type.Tulips, Colour.Red, Colour.Red, Colour.Black);
            Combination T2 = new Combination(Type.Tulips, Colour.Red, Colour.Yellow, Colour.Orange);
            Combination T3 = new Combination(Type.Tulips, Colour.Red, Colour.White, Colour.Pink);
            Combination T4 = new Combination(Type.Tulips, Colour.Black, Colour.Black, Colour.Purple);
            Combination T5 = new Combination(Type.Tulips, Colour.Orange, Colour.Orange, Colour.Purple);
            combinations.Add(T1);
            combinations.Add(T2);
            combinations.Add(T3);
            combinations.Add(T4);
            combinations.Add(T5);

        }


    }
}