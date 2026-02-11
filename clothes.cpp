#include <string>
#include <vector>
#include <unordered_map>

using namespace std;

int solution(vector<vector<string>> clothes)
{
    int answer = 1;
    unordered_map<string, int> counts;
    counts.reserve(clothes.size());

    for (const auto& clothe : clothes) counts[clothe[1]]++;
    for (const auto& [type, count] : counts) answer *= (count + 1);

    return answer - 1;    
}
