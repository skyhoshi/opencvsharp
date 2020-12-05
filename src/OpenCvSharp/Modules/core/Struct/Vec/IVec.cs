﻿using System;

namespace OpenCvSharp
{
    /// <summary>
    /// Vec empty interface
    /// </summary>
    public interface IVec
    { }

    /// <summary>
    /// Vec** interface
    /// </summary>
    /// <typeparam name="TElem"></typeparam>
    [Obsolete]
    public interface IVec<TElem> : IVec
        where TElem : unmanaged
    {
        /// <summary>
        /// indexer
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        TElem this[int i] { get; set; }
    }

    /// <summary>
    /// Vec** interface
    /// </summary>
    /// <typeparam name="TSelf"></typeparam>
    /// <typeparam name="TElem"></typeparam>
    public interface IVec<TSelf, TElem> : IVec
        where TSelf : unmanaged, IVec
        where TElem : unmanaged
    {
        /// <summary>
        /// this + other
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public TSelf Add(TSelf other);

        /// <summary>
        /// this - other
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public TSelf Subtract(TSelf other);

        /// <summary>
        /// this * alpha
        /// </summary>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public TSelf Multiply(double alpha);

        /// <summary>
        /// this * alpha
        /// </summary>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public TSelf Divide(double alpha);

        /// <summary>
        /// indexer
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        TElem this[int i] { get; }
    }
}
