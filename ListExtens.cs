using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Godot.CollectionsExtens.List;

public static partial class ListExt
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_item"></param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Assing<T>(this List<T> p_arr, List<T> p_item)
	{
		p_arr.Clear();
		p_arr.AddRange(p_item);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Back<T>(this List<T> p_arr) => p_arr[^1];

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Front<T>(this List<T> p_arr)
	{
		return p_arr[0];
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="position"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T PopAt<T>(this List<T> p_arr, int position)
	{
		T element = p_arr[position];
		p_arr.RemoveAt(position);
		return element;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="item"></param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void PushFront<T>(this List<T> p_arr, T item)
	{
		p_arr.Insert(0, item);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="item"></param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void PushBack<T>(this List<T> p_arr, T item)
	{
		p_arr.Insert(p_arr.Count, item);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T PopFront<T>(this List<T> p_arr)
	{
		T firstElement = p_arr[0];
		p_arr.RemoveAt(0);

		return firstElement;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T PopBack<T>(this List<T> p_arr)
	{
		T element = p_arr[^1];
		p_arr.RemoveAt(p_arr.Count - 1);

		return element;
	}
}