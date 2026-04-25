
// public class BContest155
// {
//     public string FindCommonResponse(IList<IList<string>> responses) {
//         OrderedDictionary<string, int> stringMap = new OrderedDictionary<string, int>();

//         foreach (var item in responses)
//         {
//             Hashset<string> localStringMap = new Hashset<string>();

//             foreach (var str in item)
//             {
//                 if(localStringMap.Contains(str))
//                 continue;
//                 else{
//                     if(!stringMap.ContainsKey(str))
//                     {                        
//                         stringMap[str] = 0;
//                     }
//                     localStringMap.Add(str);
//                     stringMap[str]++;                    
//                 }
//             }            
//         }

//         int res = int.MinValue;
//         int resstring = "";
//         foreach (var item in stringMap)
//         {
//             if(stringMap[item] > res)
//             resstring = item;
//         }

//         return resstring;
//     }

//     public int CountCells(char[][] grid, string pattern) {
//         int m = grid.Length;
//         int n = grid[0].Length;
//         int patternLength = pattern.Length;

//         var horizontalMatches = new HashSet<(int, int)>();
//         var verticalMatches = new HashSet<(int, int)>();

//         // Step 1: Find horizontal matches
//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j <= n - patternLength; j++)
//             {
//                 bool match = true;
//                 for (int k = 0; k < patternLength; k++)
//                 {
//                     if (grid[i][j + k] != pattern[k])
//                     {
//                         match = false;
//                         break;
//                     }
//                 }
//                 if (match)
//                 {
//                     // Add all cells in the matched horizontal substring
//                     for (int k = 0; k < patternLength; k++)
//                     {
//                         horizontalMatches.Add((i, j + k));
//                     }
//                 }
//             }
//         }

//         // Step 2: Find vertical matches
//         for (int j = 0; j < n; j++)
//         {
//             for (int i = 0; i <= m - patternLength; i++)
//             {
//                 bool match = true;
//                 for (int k = 0; k < patternLength; k++)
//                 {
//                     if (grid[i + k][j] != pattern[k])
//                     {
//                         match = false;
//                         break;
//                     }
//                 }
//                 if (match)
//                 {
//                     // Add all cells in the matched vertical substring
//                     for (int k = 0; k < patternLength; k++)
//                     {
//                         verticalMatches.Add((i + k, j));
//                     }
//                 }
//             }
//         }

//         // Step 3: Find common cells between horizontal and vertical matches
//         int count = 0;
//         foreach (var cell in horizontalMatches)
//         {
//             if (verticalMatches.Contains(cell))
//             {
//                 count++;
//             }
//         }

//         return count;
//     }
// }