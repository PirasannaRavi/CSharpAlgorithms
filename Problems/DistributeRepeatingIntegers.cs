using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class DistributeRepeatingIntegers
    {
        public bool CanDistribute(int[] nums, int[] quantity)
        {
            var itemsInventory = nums.GroupBy(n => n).ToList().Select(g => g.Count()).ToArray();
            Array.Sort(quantity);
            return TryToDistribute(quantity, itemsInventory, quantity.Length - 1);
        }

        private bool TryToDistribute(int[] quantity, int[] itemsInventory, int qIndex)
        {
            if (qIndex == -1)
            {
                return true;
            }

            int required = quantity[qIndex];
            for (int i = 0; i < itemsInventory.Length; i++)
            {
                if (itemsInventory[i] >= required)
                {
                    itemsInventory[i] -= required;

                    if (TryToDistribute(quantity, itemsInventory, qIndex - 1))
                    {
                        return true;
                    }

                    itemsInventory[i] += required;
                }
            }
            return false;
        }
    }
}
