public class Solution {
    public int DayOfYear(string date) {
        int ret = 0;

        string[] parts = date.Split("-");
        int[] nums = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++) {
            nums[i] = int.Parse(parts[i]);
        }

        int[] map = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 30};


        if(nums[0] % 4 == 0){
            if(nums[0] % 100 == 0){
                if(nums[0] % 400 == 0){
                    map[1]++;
                }
            }
            else{
                map[1]++;
            } 
        }

        for(int i = 0; i < nums[1] - 1; i++){
            ret = ret + map[i];
        }
        return(ret + nums[2]);
    }
}
