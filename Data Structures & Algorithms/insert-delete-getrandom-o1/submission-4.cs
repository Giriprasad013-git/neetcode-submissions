public class RandomizedSet {
    public HashSet<int> data;
    public Random rand;

    public RandomizedSet() {
        data = new HashSet<int>();
        rand = new Random();
    }
    
    public bool Insert(int val) {
        if(data.Add(val)){
            return true;
        }
        return false;
    }
    
    public bool Remove(int val) {
        if(data.Remove(val)){
            return true;
        }
        return false;
    }
    
    public int GetRandom() {
        int randIndex = rand.Next(data.Count);
        return data.ElementAt(randIndex);
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */