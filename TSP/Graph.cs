﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Przestrzeń nazw dla pliku wejściowego oraz jego przetwarzania.
/// </summary>
namespace TSP
{
    /// <summary>
    /// Publiczna klasa przechowująca informację o grafie w obiekcie.
    /// </summary>
    public class Graph
    {
        /// <summary>
        /// Pole przechowujące listę sąsiadów dla wszystkich wierzchołków po kolei.
        /// </summary>
        private readonly int[] _vertices;

        /// <summary>
        /// Pole przechowujące listę indeksów ostatniego sąsiada danego wierzchołka. Indeksy odnoszą się do tablicy  "_vertices"
        /// </summary>
        private readonly int[] _neighboursCount;

        /// <summary>
        /// Właściwość zwracająca listę sąsiadów dla wszystkich wierzchołków po kolei.
        /// </summary>
        public int[] Vertices
        {
            get { return _vertices; }
        }

        /// <summary>
        /// Właściwość zwracająca listę indeksów ostatniego sąsiada danego wierzchołka.
        /// </summary>
        public int[] NeighboursCount
        {
            get { return _neighboursCount; }
        }

        /// <summary>
        /// Właściwość zwracająca liczbę wierzchołków danego grafu.
        /// </summary>
        public int VerticesCount
        {
            get { return _neighboursCount.Length; }
        }

        /// <summary>
        /// Właściwość zwracająca liczbę wszystkich sąsiadów każdego z wierchołków
        /// </summary>
        public int AllVerticesCount
        {
            get { return _vertices.Length; }
        }

        /// <summary>
        /// Konstruktor. Na podstawie listy wierzchołków tworzy obiekt grafu.
        /// </summary>
        /// <param name="vertices">Lista sąsiadów każdego z wierzchołków danego grafu.</param>
        /// <param name="neighboursCount">Lista ostatnich numerów sąsiadów wierzchołka z tablicy "vertices".</param>
        public Graph(int[] vertices, int[] neighboursCount)
        {
            _vertices = vertices;
            _neighboursCount = neighboursCount;
        }
    }
}
