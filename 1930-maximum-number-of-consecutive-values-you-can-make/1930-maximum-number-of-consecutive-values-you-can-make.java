class Solution {
    public int getMaximumConsecutive(int[] coins) {
         Arrays.sort(coins);
        long reachable = 1; // we can make [0, 1) initially
        for (int coin : coins) {
            if (coin > reachable) break;
            reachable += coin;
        }
        return (int)reachable;
    }
}