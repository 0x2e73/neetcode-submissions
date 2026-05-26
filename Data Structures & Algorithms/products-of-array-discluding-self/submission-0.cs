public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //objectif, faire le produit de tout les autres chiffres du tableau sauf le current. 
        var finalArrayProducts =  new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            int product = 1;
            for(int j = 0; j < nums.Length; j++)
            {
                if(j == i)
                {
                    continue;
                }
                product *= nums[j];
            }
            finalArrayProducts[i] = product;
        }
        return finalArrayProducts;
    }
}
