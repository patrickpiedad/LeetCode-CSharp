namespace LeetCode_CSharp;

public static class CanPlaceFlowers {
    
    public static bool CanPlaceFlowers1(int[] flowerbed, int n) {
        // Take in an integer n and array flowerbed, representing the number of flowers to be planted and the number/position of flowers already planted
        // Determine if this is possible according to the flower planting rules (no adjacent flowers)

        // [1, 0, 0, 0, 1], n = 1 => true
        // [1, 0, 0, 0, 1], n = 2 => false

        // Will the flowerbed array ever be empty or null? => No
        // Can I use any built in functions? => No
        // Will n always be > 0? => Yes
        // Can I be destructive to original array? => Yes
        // Will n ever be negative? => No


        // [1, 0, 0, 0, 1]

        // if n = 0, return true
        if (n == 0){
            return true;
        }

        // n is always greater than 0 at this point
        if (flowerbed.Length == 0){
            return false;
        }

        // [0] [1], n = 1
        if (flowerbed.Length == 1 && flowerbed[0] == 1){
            return false;
        }

        if (flowerbed.Length == 1 && flowerbed[0] == 0 && n == 1){
            return true;
        }

        // check flowerbed[0], if 0 => check flowerbed[1], if 0 decrement n and flowerbed[0] = 1
        if (flowerbed[0] == 0 && flowerbed[1] == 0){
            flowerbed[0] = 1;
            n--;
        }   

        // check flowerbed[flowerbed.Length -1], if 0 => check flowerbed[flowerbed.Length -2], if 0 decrement n and flowerbed[flowerbed>Length -1] = 1
        if (flowerbed[flowerbed.Length -1] == 0 && flowerbed[flowerbed.Length -2] == 0){
            flowerbed[flowerbed.Length -1] = 1;
            n--;
        }

        // create for loop 
        // check flowerbed[i] when i starts at 1 AND i only goes until second to last element (length -2), if 0 => check i-1 and i+1, if 0 decrement n and flowerbed[i] = 1

        for (int i = 1; i <= flowerbed.Length - 2; i++){
            if (flowerbed[i] == 0 && flowerbed[i-1] == 0 & flowerbed[i+1] == 0){
                flowerbed[i] = 1;
                n--;
            }
        }

        if (n <= 0){
            return true;
        }

        else{
            return false;
        }
    }

    public static bool CanPlaceFlowers2(int[] flowerbed, int n)
    {
        //R: Inputting integer array with 0s and 1s representing empty or planted flower place, and given n number of flowers, return true or false depending on if n number of flowers can be placed without violating rule of spaces between flowers
        //E: flowerbed = [1,0,0,0,1] n = 1 => true // flowerbed = [1,0,0,0,1] n = 2 => false
        //A: Loop through flowerbed, check previous position and forward position, if empty then plant flower and subtract from n
        //If n == 0, return true, if else keep planting
        //If loop completes return false
        //Be careful to not execute out of bounds error

        if (n == 0) return true;
        if (flowerbed.Length == 0) return false;
        if (flowerbed.Length == 1 && flowerbed[0] == 1) return false;
        if (flowerbed.Length == 1 && flowerbed[0] == 0 && n == 1) return true;

        if (flowerbed[0] == 0 && flowerbed[1] == 0)
        {
            flowerbed[0] = 1;
            n--;
        }
        
        if (flowerbed[flowerbed.Length -1] == 0 && flowerbed[flowerbed.Length -2] == 0){
            flowerbed[flowerbed.Length -1] = 1;
            n--;
        }
        
        for (int i = 1; i < flowerbed.Length - 1; i++)
        {
            if (n <= 0) return true;
            
            if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0 && flowerbed[i] == 0)
            {
                flowerbed[i] = 1;
                n--;
            }
        }

        if (n <= 0) return true;
        else return false;
    }
}