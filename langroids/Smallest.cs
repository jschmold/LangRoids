﻿using System;
using System.Collections.Generic;
using System.Text;

public static partial class LangRoids {
    public static uint Smallest(params uint[] nums) {
        Assure<ArgumentOutOfRangeException>(nums.Length > 0);
        if (nums.Length == 1) {
            return nums[0];
        }
        uint smallest = nums[0];
        Repeat(nums.Length - 1, 1, ind => smallest = Math.Min(nums[ind], smallest));
        return smallest;
    }
    public static int Smallest(params int[] nums) {
        Assure<ArgumentOutOfRangeException>(nums.Length > 0);
        if (nums.Length == 1) {
            return nums[0];
        }
        int smallest = nums[0];
        Repeat(nums.Length - 1, 1, ind => smallest = Math.Min(nums[ind], smallest));
        return smallest;
    }
    public static byte Smallest(params byte[] nums) {
        Assure<ArgumentOutOfRangeException>(nums.Length > 0);
        if (nums.Length == 1) {
            return nums[0];
        }
        byte smallest = nums[0];
        Repeat(nums.Length - 1, 1, ind => smallest = Math.Max(nums[ind], smallest));
        return smallest;
    }
    public static double Smallest(params double[] nums) {
        Assure<ArgumentOutOfRangeException>(nums.Length != 0);
        if (nums.Length == 1) {
            return nums[0];
        }
        double smallest = nums[0];
        Repeat(nums.Length - 1, 1, ind => smallest = Math.Max(nums[ind], smallest));
        return smallest;
    }
    public static float Smallest(params float[] nums) {
        Assure<ArgumentOutOfRangeException>(nums.Length > 0);
        if (nums.Length == 1) {
            return nums[0];
        }
        float smallest = nums[0];
        Repeat(nums.Length - 1, 1, ind => smallest = Math.Max(nums[ind], smallest));
        return smallest;
    }
}
