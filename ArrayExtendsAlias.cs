using System;
using System.Runtime.CompilerServices;
using System.Linq;
using Godot;
using GDC = Godot.Collections;

namespace Godot.CollectionsExtens.Array.Alias;

/// <summary>
/// We recommend using this library if you need to convert gdscript code to C# quickly.
/// </summary>
public static partial class ArrayExtensAlias
{
	/// <summary>
	/// Appends another array at the end of this array.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_item"></param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AppendArray<[MustBeVariant] T>(this GDC::Array<T> p_arr, GDC::Array<T> p_item)
	{
		p_arr.AddRange(p_item);
	}

	/// <summary>
	/// Removes the first occurrence of a specific object from the Array<T>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_item"></param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Erase<[MustBeVariant] T>(this GDC::Array<T> p_arr, T p_item)
	{
		p_arr.Remove(p_item);
	}

	/// <summary>
	/// Filters a sequence of values based on a predicate.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_predicate"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static GDC::Array<T> Filter<[MustBeVariant] T>(
		this GDC::Array<T> p_arr, Func<T, bool> p_predicate)
	{
		return (GDC::Array<T>)p_arr.Where(p_predicate);
	}

	/// <summary>
	/// Filters a sequence of values based on a predicate.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_predicate"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static GDC::Array<T> Filter<[MustBeVariant] T>(
		this GDC::Array<T> p_arr, Func<T, int, bool> p_predicate)
	{
		return (GDC::Array<T>)p_arr.Where(p_predicate);
	}

	/// <summary>
	/// Returns the zero-based index of the first occurrence of a value in the Array<T> or in a portion of it.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_item"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Find<[MustBeVariant] T>(this GDC::Array<T> p_arr, T p_item)
	{
		return p_arr.IndexOf(p_item);
	}

	/// <summary>
	/// Returns the zero-based index of the first occurrence of a value in the List<T> or in a portion of it.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_item"></param>
	/// <param name="p_index"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Find<[MustBeVariant] T>(this GDC::Array<T> p_arr, T p_item, int p_index)
	{
		return p_arr.IndexOf(p_item, p_index);
	}

	/// <summary>
	/// Determines whether an element is in the Array<T>.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_item"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool Has<[MustBeVariant] T>(this GDC::Array<T> p_arr, T p_item)
	{
		return p_arr.Contains(p_item);
	}

	/// <summary>
	/// Returns a hashed 32-bit integer value representing the array and its contents.
	///	Note: Arrays with equal hash values are not guaranteed to be the same, 
	///	as a result of hash collisions. On the countrary, arrays with different hash values are guaranteed to be different.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Hash<[MustBeVariant] T>(this GDC::Array<T> p_arr)
	{
		return GD.Hash(p_arr);
	}

	/// <summary>
	/// Returns true if the array is empty ([]).
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsEmpty<[MustBeVariant] T>(this GDC::Array<T> p_arr)
	{
		return p_arr.Count == 0;
	}

	/// <summary>
	/// Projects each element of a sequence into a new form.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TResult"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_selector"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static GDC::Array<TResult> Map<[MustBeVariant] T, [MustBeVariant] TResult>(
		this GDC::Array<T> p_arr, Func<T, TResult> p_selector)
	{
		return (GDC::Array<TResult>)p_arr.Select(p_selector);
	}

	/// <summary>
	/// Projects each element of a sequence into a new form.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TResult"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_selector"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static GDC::Array<TResult> Map<[MustBeVariant] T, [MustBeVariant] TResult>(
		this GDC::Array<T> p_arr, Func<T, int, TResult> p_selector)
	{
		return (GDC::Array<TResult>)p_arr.Select(p_selector);
	}

	/// <summary>
	/// Applies an accumulator function over a sequence. 
	/// The specified seed value is used as the initial accumulator value, 
	/// and the specified function is used to select the result value.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_func"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Reduce<[MustBeVariant] T>(this GDC::Array<T> p_arr, Func<T, T, T> p_func)
	{
		return p_arr.Aggregate(p_func);
	}

	/// <summary>
	/// Applies an accumulator function over a sequence. 
	/// The specified seed value is used as the initial accumulator value, 
	/// and the specified function is used to select the result value.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TAccumulate"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_seed"></param>
	/// <param name="p_func"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TAccumulate Reduce<[MustBeVariant] T, [MustBeVariant] TAccumulate>(
		this GDC::Array<T> p_arr, TAccumulate p_seed, Func<TAccumulate, T, TAccumulate> p_func)
	{
		return p_arr.Aggregate(p_seed, p_func);
	}

	/// <summary>
	/// Applies an accumulator function over a sequence. 
	/// The specified seed value is used as the initial accumulator value, 
	/// and the specified function is used to select the result value.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TAccumulate"></typeparam>
	/// <typeparam name="TResult"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_seed"></param>
	/// <param name="p_func"></param>
	/// <param name="p_resultSelector"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TResult Reduce<[MustBeVariant] T, [MustBeVariant] TAccumulate, [MustBeVariant] TResult>(
		this GDC::Array<T> p_arr, TAccumulate p_seed, Func<TAccumulate, T, TAccumulate> p_func, Func<TAccumulate, TResult> p_resultSelector)
	{
		return p_arr.Aggregate(p_seed, p_func, p_resultSelector);
	}

	/// <summary>
	/// Returns the zero-based index of the last occurrence of a value in the Array<T> or in a portion of it.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <param name="p_item"></param>
	/// <param name="p_index"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int RFind<[MustBeVariant] T>(this GDC::Array p_arr, T p_item, int p_index)
	{
		return p_arr.LastIndexOf(Variant.From(p_item), p_index);
	}

	/// <summary>
	/// Gets the number of elements contained in the Array<T>.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="p_arr"></param>
	/// <returns></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Size<[MustBeVariant] T>(this GDC::Array<T> p_arr)
	{
		return p_arr.Count;
	}
}