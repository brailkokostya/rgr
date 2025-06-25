// CustomVector.cs
using System;
using System.Collections.Generic;

namespace triangle
{
    public class CustomVector
    {
        private List<double> components;
        public int Dimension => components.Count;

        public CustomVector(int dimension)
        {
            if (dimension <= 0)
                throw new ArgumentException("Розмірність повинна бути більше нуля.");
            components = new List<double>(dimension);
            for (int i = 0; i < dimension; i++)
                components.Add(0);
        }

        public CustomVector(List<double> initialComponents)
        {
            if (initialComponents == null || initialComponents.Count == 0)
                throw new ArgumentException("Компоненти не можуть бути null або порожніми.");
            components = new List<double>(initialComponents);
        }

        public CustomVector(CustomVector other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));
            components = new List<double>(other.components);
        }

        ~CustomVector() { }

        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= Dimension)
                    throw new IndexOutOfRangeException();
                return components[index];
            }
            set
            {
                if (index < 0 || index >= Dimension)
                    throw new IndexOutOfRangeException();
                components[index] = value;
            }
        }

        public CustomVector Add(CustomVector other)
        {
            if (other == null || other.Dimension != Dimension)
                throw new ArgumentException("Вектори повинні мати однакову розмірність.");
            var result = new CustomVector(Dimension);
            for (int i = 0; i < Dimension; i++)
                result[i] = this[i] + other[i];
            return result;
        }

        public CustomVector Subtract(CustomVector other)
        {
            if (other == null || other.Dimension != Dimension)
                throw new ArgumentException("Вектори повинні мати однакову розмірність.");
            var result = new CustomVector(Dimension);
            for (int i = 0; i < Dimension; i++)
                result[i] = this[i] - other[i];
            return result;
        }

        public double Dot(CustomVector other)
        {
            if (other == null || other.Dimension != Dimension)
                throw new ArgumentException("Вектори повинні мати однакову розмірність.");
            double sum = 0;
            for (int i = 0; i < Dimension; i++)
                sum += this[i] * other[i];
            return sum;
        }

        public CustomVector Scale(double scalar)
        {
            var result = new CustomVector(Dimension);
            for (int i = 0; i < Dimension; i++)
                result[i] = this[i] * scalar;
            return result;
        }

        public double Length()
        {
            double sum = 0;
            for (int i = 0; i < Dimension; i++)
                sum += this[i] * this[i];
            return Math.Sqrt(sum);
        }

        public override string ToString() =>
            "(" + string.Join(", ", components) + ")";
    }
}
