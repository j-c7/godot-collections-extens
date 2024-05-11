using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Godot.CollectionsExtens.List.Alias;

/// <summary>
/// We recommend using this library if you need to convert gdscript code to C# quickly.
/// </summary>
public static partial class ListExtensAlias 
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_item"></param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AppendArray<T>(this List<T> p_arr, List<T> p_item)
	{
		p_arr.AddRange(p_item);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_item"></param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Erase<T>(this List<T> p_arr, T p_item)
	{
		p_arr.Remove(p_item);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_predicate"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static List<T> Filter<T>(
		this List<T> p_arr, Func<T, bool> p_predicate)
	{
		return (List<T>)p_arr.Where(p_predicate);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_predicate"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static List<T> Filter<T>(
		this List<T> p_arr, Func<T, int, bool> p_predicate)
	{
		return (List<T>)p_arr.Where(p_predicate);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="item"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Find<T>(this List<T> p_arr, T item)
	{
		return p_arr.IndexOf(item);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="item"></param>
	/// <param name="index"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Find<T>(this List<T> p_arr, T item, int index)
	{
		return p_arr.IndexOf(item, index);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="item"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool Has<T>(this List<T> p_arr, T item)
	{
		return p_arr.Contains(item);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Hash<T>(this List<T> p_arr)
	{
		return GD.Hash(Variant.From(p_arr));
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsEmpty<T>(this List<T> p_arr)
	{
		return p_arr.Count == 0;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TResult"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_selector"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static List<TResult> Map<T, TResult>(
		this List<T> p_arr, Func<T, TResult> p_selector)
	{
		return (List<TResult>)p_arr.Select(p_selector);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TResult"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_selector"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static List<TResult> Map<T, TResult>(
		this List<T> p_arr, Func<T, int, TResult> p_selector)
	{
		return (List<TResult>)p_arr.Select(p_selector);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_func"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Reduce<T>(this List<T> p_arr, Func<T, T, T> p_func)
	{
		return p_arr.Aggregate(p_func);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TAccumulate"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="seed"></param>
	/// <param name="p_func"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TAccumulate Reduce<T, TAccumulate>(
		this List<T> p_arr, TAccumulate seed, Func<TAccumulate, T, TAccumulate> p_func)
	{
		return p_arr.Aggregate(seed, p_func);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TAccumulate"></typeparam>
	/// <typeparam name="TResult"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="seed"></param>
	/// <param name="p_func"></param>
	/// <param name="resultSelector"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TResult Reduce<T, TAccumulate, TResult>(
		this List<T> p_arr, TAccumulate seed, Func<TAccumulate, T, TAccumulate> p_func, Func<TAccumulate, TResult> resultSelector)
	{
		return p_arr.Aggregate(seed, p_func, resultSelector);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="item"></param>
	/// <param name="index"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int RFind<T>(this List<T> p_arr, T item, int index)
	{
		return p_arr.LastIndexOf(item, index);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Size<T>(this List<T> p_arr)
	{
		return p_arr.Count;
	}
}
