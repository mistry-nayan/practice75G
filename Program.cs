// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Net.WebSockets;

Console.WriteLine("Hello, World!");

GetMinimumConflict.MainA(null);

// NextSpecialString1 nextSpecialString = new NextSpecialString1();
// nextSpecialString.GetNextSpecialString("abbd");
// nextSpecialString.GetNextSpecialString("abc");
// nextSpecialString.GetNextSpecialString("abcz");
// nextSpecialString.GetNextSpecialString("zzz");
// nextSpecialString.GetNextSpecialString("a");
// nextSpecialString.GetNextSpecialString("z");
// nextSpecialString.GetNextSpecialString("abb");
// nextSpecialString.GetNextSpecialString("aabb");
// nextSpecialString.GetNextSpecialString("aaaa");
// nextSpecialString.GetNextSpecialString("azaz");


// FindMinimumMachinesSize findMinimumMachinesSize = new FindMinimumMachinesSize();
// findMinimumMachinesSize.FindMinimumMachines(new int [] {1,2,3,4,5});
// findMinimumMachinesSize.FindMinimumMachines(new int [] {1,2,2,1,1});
// findMinimumMachinesSize.FindMinimumMachines(new int [] {1,5,1,5,1});
// findMinimumMachinesSize.FindMinimumMachines(new int [] {3,3,3,3});
// findMinimumMachinesSize.FindMinimumMachines(new int [] {1,2,3,2,2,1});
// findMinimumMachinesSize.FindMinimumMachines(new int [] {1,3,3,3,1});


TreeNode lvl30 = new TreeNode(8);
TreeNode lvl31 = new TreeNode(9);
TreeNode lvl32 = new TreeNode(10);
TreeNode lvl33 = new TreeNode(11);
TreeNode lvl34 = new TreeNode(12);
TreeNode lvl35 = new TreeNode(13);
TreeNode lvl36 = new TreeNode(14);
TreeNode lvl37 = new TreeNode(15);
TreeNode lvl20 = new TreeNode(4){left = lvl30, right= lvl31};;
TreeNode lvl21 = new TreeNode(5){left = lvl32, right= lvl33};
TreeNode lvl22 = new TreeNode(6){left = lvl34, right= lvl35};
TreeNode lvl23 = new TreeNode(7){left = lvl36, right= lvl37};
TreeNode lvl10 = new TreeNode(2){left = lvl20, right = lvl21};
TreeNode lvl12 = new TreeNode(3){left = lvl22, right = lvl23};
TreeNode lvl1 = new TreeNode(1){left = lvl10, right = lvl12};

ListNode lsNode1 = new ListNode(1);
lsNode1.next = new ListNode(2);
var temp = lsNode1.next;
temp.next = new ListNode(3);
var temp1 = temp.next;
temp1.next = new ListNode(4);
var temp2 = temp1.next;

ListNode listNode = new ListNode(1);
var listNode2  = new ListNode(2);
listNode.next = listNode2;
var listNode3  = new ListNode(5);
listNode2.next = listNode3;
var listNode4  = new ListNode(6);
listNode3.next = listNode4;

TreeNode treeNode = new TreeNode(1);
TreeNode treeNode1 = new TreeNode(2);
TreeNode treeNode2 = new TreeNode(3);
treeNode.left = treeNode1;
treeNode.right = treeNode2;
TreeNode treeNode3 = new TreeNode(4);
TreeNode treeNode4 = new TreeNode(5);
treeNode2.left = treeNode3;

TreeNode root = new TreeNode(5);
root.left = new TreeNode(2);
root.right = new TreeNode(7);
root.left.left = new TreeNode(1);
root.left.right = new TreeNode(4);
root.left.right.left = new TreeNode(3);
root.right.left = new TreeNode(6);
root.right.right = new TreeNode(9);

// CountingBits countingBits = new CountingBits();
// var ans = countingBits.CountBits(1);
// ans = countingBits.CountBits(2);
// ans = countingBits.CountBits(5);

// Solution solution = new Solution();
// solution.Run();

// BestTimeStock bestTimeStock = new BestTimeStock();
// bestTimeStock.MaxProfit(new int[] {7,1,5,3,6,4});

// Palindrome palindrome = new Palindrome();
// //palindrome.IsPalindrome('A man, a plan, a canal: Panama');
// palindrome.IsPalindrome('0P');

// InvertBinaryTree invertBinaryTree = new InvertBinaryTree();
// invertBinaryTree.Run();

// Anagram anagram = new Anagram();
// anagram.IsAnagram("anagram","nagarm");
// anagram.IsAnagram("rat","car");

// BinarySearch binarySearch = new BinarySearch();
// binarySearch.Search(new int[] {1,6,8,9}, 5);

// FloodFil floodFil = new FloodFil();
// floodFil.FloodFill(new int[][] {[1,1,1],[1,1,0],[1,0,1]},1,1,2);

// ReverseBit reverseBit = new ReverseBit();
// string binaryNum = "00000010100101000001111010011100";
// reverseBit.reverseBits(Convert.ToUInt32(binaryNum,2));

// OneBitTwoBit oneBitTwoBit = new OneBitTwoBit();
// oneBitTwoBit.IsOneBitCharacter(new int[] {1,0,0});

// MinBitFlip minBitFlip = new MinBitFlip();
// minBitFlip.MinBitFlips(10, 7);

// MinKBitFlip minKBitFlip = new MinKBitFlip();
// minKBitFlip.MinKBitFlips(new int[] {0,0,0,1,0,1,1,0}, 3);

// LeastCommonAncestor leastCommonAncestor = new();
// leastCommonAncestor.Run();

// BBT bBT = new BBT();
// bBT.Run();

// RansomNote ransomNote = new RansomNote();
// ransomNote.CanConstruct('bg', 'aabg');

// ClimbingStairs climbingStairs = new ClimbingStairs();
// var rete = climbingStairs.ClimbStairs(2);
// var ubid = '';

// LongPalindrome longPalindrome = new LongPalindrome();
// longPalindrome.LongestPalindrome('\'civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth...');

//Reverse Linked List
// RLL rLL = new RLL();
// rLL.Run();

// AddBinaryNumber addBinaryNumber = new AddBinaryNumber();
// addBinaryNumber.AddBinary('1010','1011');

// StudentMarks studentMarks = new StudentMarks();
// studentMarks.Run();

// CamelAndSnakeCase camelAndSnakeCase = new CamelAndSnakeCase()
// ;
// camelAndSnakeCase.Run('ThisIsAZariable');

// DiameterOfTree diameterOfTree = new DiameterOfTree();
// diameterOfTree.Run();

// MiddleLinkedNode middleLinkedNode = new MiddleLinkedNode();
// middleLinkedNode.Run();

// RomanToInteger romanToInteger = new();
// romanToInteger.RomanToInt('MCMXCIV');


// BackspaceStringCompare backspaceStringCompare = new BackspaceStringCompare();
// backspaceStringCompare.BackspaceCompare('xywrrmp','xywrrmu#p');

// MaxSubarray maxSubarray = new MaxSubarray();
// Console.WriteLine(maxSubarray.MaxSubArray(new int [] {-2,1,-3,4,-1,2,1,-5,4}));

// InsertInterval insertInterval = new InsertInterval();
// insertInterval.Insert(new int[][]{ [1,2],[3,5],[6,7],[8,10],[12,16] }, new int [] {4,8});

//TO:DO: Check again
// Matrix_MinDistance matrix_MinDistance = new Matrix_MinDistance();
// matrix_MinDistance.UpdateMatrix(new int[][] {[0,0,0],[0,1,0],[1,1,1]});
// matrix_MinDistance.UpdateMatrix(new int[][] {[0,0,0],[0,1,0],[0,0,0]});

// KClosestPointToOrigin kClosestPointToOrigin = new KClosestPointToOrigin();
// kClosestPointToOrigin.KClosest(new int[][]{[3,3],[5,-1],[-2,4]},2);

// ThreeSumClass threeSumClass = new ThreeSumClass();
// threeSumClass.ThreeSum(new int[]{-1,0,1,2,-1,-4});

// BinaryTreeOrderReversal binaryTreeOrderReversal = new BinaryTreeOrderReversal();
// //binaryTreeOrderReversal.LevelOrder(new TreeNode(1){left = new TreeNode(2){left = new TreeNode(4), right = new TreeNode(5)},right = new TreeNode(3)});
// binaryTreeOrderReversal.LevelOrder(lvl1);

//TO:DO Check Again
// CloneGraphSolution cloneGraphSolution = new CloneGraphSolution();
// cloneGraphSolution.CloneGraph(new GraphNode(1, new List<GraphNode>{new GraphNode(2, new List<GraphNode>{new GraphNode(1),new GraphNode(3, new List<GraphNode>{new GraphNode(2),new GraphNode(4)})}),new GraphNode(4, new List<GraphNode>{new GraphNode(3),new GraphNode(1)})}));

// EvalRPNSolution evalRPNSolution = new EvalRPNSolution();
// evalRPNSolution.EvalRPN(new string[] {'10','6','9','3','+','-11','*','/','*','17','+','5','+'});

//TO:DO Check again
// CourseSchedule courseSchedule = new CourseSchedule();
// courseSchedule.CanFinish(3, new int[][]{[1,0],[1,2]});

// ImplementPrefixTree obj = new ImplementPrefixTree();
// obj.Insert('apple');
// bool param_2 = obj.Search('app');
// bool param_3 = obj.StartsWith('app');
// var sdomf = '';

// FactorOfN factorOfN = new FactorOfN();
// factorOfN.KthFactor(12,4);

// CoinChanges coinChanges = new CoinChanges();
// coinChanges.CoinChange(new int[]{1,5,7}, 18);

// ProductExceptSelf productExceptSelf = new ();
// // productExceptSelf.ProductExceptSelf2(new int[] {1,2,3,4});
// productExceptSelf.FindWinningPlayer(new int[] {4,2,6,3,9}, 2);

// MinStack minStack = new MinStack();
// minStack.Push(-2);
// minStack.Push(0);
// minStack.Push(-3);
// minStack.GetMin(); // return -3
// minStack.Pop();
// minStack.Top();    // return 0
// minStack.GetMin(); // return -2

// ValidBST validBST = new ValidBST();
// validBST.IsValidBST(lvl1);

// RottenOranges rottenOranges = new RottenOranges();
// rottenOranges.OrangesRotting(new int[][] {[2,1,1],[1,1,0],[0,1,1]});

// CombinationSum combinationSum = new CombinationSum();
// var res = combinationSum.Combinationsum(new int[] {2,3,6,7}, 7);

// PlayerWinningKGamesInRow playerWinningKGamesInRow = new PlayerWinningKGamesInRow();
// var res = playerWinningKGamesInRow.FindWinningPlayer(new int[] {4,2,1,5}, 2);

// MaxLengthofGoodSequence maxLengthofGoodSequence = new MaxLengthofGoodSequence();
// var res = maxLengthofGoodSequence.MaximumLength(new int[]{1,2,1,1,3}, 2);

// MinOperationDivisible minOperationDivisible = new MinOperationDivisible();
// var res = minOperationDivisible.MinOperations2(new int[] {1,0,0,1});

// Permutation permutation = new Permutation();
// permutation.Permute(new int[] {1,2,3});

// SolutionWC solutionWC = new SolutionWC();
// //var res = solutionWC.MinimumAverage(new int[]{7,8,3,4,15,13,4,1});
// //var area = solutionWC.MinimumArea(new int[][] {[0,0,0],[0,0,0],[0,0,0],[1,0,1]});
// var area = solutionWC.MinimumArea(new int[][] {[0,0,0],[0,0,0],[0,0,1],[0,1,0]});

// MergeINterval mergeINterval = new MergeINterval();
// var res = mergeINterval.Merge(new int[][]{[1,3],[2,6],[8,10],[15,18]});
// var res = mergeINterval.Merge(new int[][]{[1,4],[1,5]});
// var res = mergeINterval.Merge(new int[][]{[1,4],[0,1]});

// LowestCommonAncestor2 lowestCommonAncestor2 = new LowestCommonAncestor2();
// var res = lowestCommonAncestor2.LowestCommonAncestor(lvl1,lvl10,lvl12);

// TimeMap2 obj = new TimeMap2();
// obj.Set('foo', 'bar', 1);
// obj.Set('foo', 'bar2', 2);
// string param_2 = obj.Get('foo', 1);


// AccountsMerges accountsMerges = new AccountsMerges();
// List<IList<string>> accounts = new List<IList<string>>();
// accounts.Add(new List<string> {'John','johnsmith@mail.com','john_newyork@mail.com'});
// accounts.Add(new List<string> {'John','johnsmith@mail.com','john00@mail.com'});
// accounts.Add(new List<string> {'Mary','mary@mail.com'});
// accounts.Add(new List<string> {'John','johnnybravo@mail.com'});
// accountsMerges.AccountsMerge(accounts);

// int[] nums = { 2, 0, 2, 1, 1, 0 };
// SortColors sortColors = new SortColors();
// sortColors.SortCOlors(nums);

// Wordbreak wordbreak = new Wordbreak();
// var booles = wordbreak.WordBreak('cars', new List<string> {'car', 'ca', 'rs'});
// var booles1 = wordbreak.WordBreak('catsandog', new List<string> {'cats','dog','sand','and','cat'});

// PartitionEqualSubsetSum partitionEqualSubsetSum = new PartitionEqualSubsetSum();
// partitionEqualSubsetSum.CanPartition(new int [] {1,5,11,5});
// partitionEqualSubsetSum.CanPartition(new int [] {1,2,3,5});

// partitionEqualSubsetSum.CanPartition2(new int [] {1,5,11,5});
// partitionEqualSubsetSum.CanPartition2(new int [] {1,2,3,5});

// StringToInteger stringToInteger = new StringToInteger();
// var ress = stringToInteger.Atoi(' -042');
// var ress1 = stringToInteger.Atoi('1337c0d3');
// var ress2 = stringToInteger.Atoi('0-1');

// SpiralMatrix spiralMatrix = new SpiralMatrix();
// var result = spiralMatrix.SpiralOrder(new int[][] {[1,2,3,4],[5,6,7,8],[9,10,11,12]});

// Subsets subsets = new Subsets();
// var rest = subsets.Subset(new int [] {1,2,3});

// RightSideViews rightSideViews = new RightSideViews();
// rightSideViews.RightSideView(lvl1);

// LongestPalindromes  longestPalindromes = new LongestPalindromes();
// longestPalindromes.LongestPalindrome('babad');

// UniquePath uniquePath = new UniquePath();
//uniquePath.UniquePaths1D(3, 2);
// uniquePath.UniquePathsRecursion(3,2);

// ConstructBTbyArray constructBTbyArray = new ConstructBTbyArray();
// constructBTbyArray.BuildTree(new int[] {3,9,20,15,7}, new int [] {9,3,15,20,7});

// ContainerWithMostWater containerWithMostWater = new ContainerWithMostWater();
// containerWithMostWater.MaxArea(new int[] {1,4,2,3});

// LetterCombinationOfAPhoneNumber letterCombinationOfAPhoneNumber = new LetterCombinationOfAPhoneNumber();
// letterCombinationOfAPhoneNumber.LetterCombinations('23');

//SOlution405 solution405 = new SOlution405();
//solution405.GetEncryptedString('gs',7);
// solution405.ValidStrings(3);
// solution405.NumberOfSubmatrices(new char[][] {['X','Y','.'],['Y','.','.']});
//var euf = solution405.MinCostToFormTarget('r', new string[] {'r','r','r','r','r'}, new int[] {100,1,3,10,5});
//var dino = solution405.MinimumCost('abcdef', new string[] {'abdef','abc','d','def','ef'}, new int[] {100,1,1,10,5});

// WordSearch wordSearch = new WordSearch();
// var feyv = wordSearch.Exist(new char[][] {['A','B','C','E'],['S','F','C','S'],['A','D','E','E']}, 'ABCCED');

// FindAllAnagramsInString findAllAnagrams = new FindAllAnagramsInString();
// findAllAnagrams.FindAnagrams('cbaebabacd','cab');

// MinimumHeightTrees minimumHeightTrees = new MinimumHeightTrees();
// var response = minimumHeightTrees.FindMinHeightTrees(4, new int[][]{[1,0],[1,2],[1,3]});

// TaskScheduler taskScheduler = new TaskScheduler();
// var response = taskScheduler.LeastInterval(new char [] {'A','A','A','B','B','B'}, 2);

// LRUCache lRUCache = new LRUCache(3);
// var ydbcdc = lRUCache.Get(2);
// lRUCache.Put(1,1); 
// lRUCache.Put(2,1);
// ydbcdc = lRUCache.Get(2);
// lRUCache.Put(3,1); 
// lRUCache.Put(4,1); 
// ydbcdc = lRUCache.Get(2);
// lRUCache.Put(5,1); 
// ydbcdc = lRUCache.Get(4);
// lRUCache.Put(6,1); 

// KSmallestElement kSmallestElement = new KSmallestElement();
// kSmallestElement.KthSmallest(lvl10,3);

// DailyTemperature dailyTemperature = new DailyTemperature();
// dailyTemperature.DailyTemperatures(new int [] {73,74,75,71,69,72,76,73});

// HouseRobber houseRobber = new HouseRobber();
// houseRobber.Rob(new int[] {2,1,1,2});

// GasStation gasStation = new GasStation();
// gasStation.CanCompleteCircuit(new int[] {1,2,3,4,5}, new int [] {3,4,5,1,2});

// NextPermutations nextPermutations = new NextPermutations();
// nextPermutations.NextPermutation(new int[] {4,3,2,5,4,3,1});
// nextPermutations.NextPermutation(new int[] {4,3,2,1});

// ValidSudoku validSudoku = new ValidSudoku();
// validSudoku.IsValidSudoku(new char[][]{['5','3','.','.','7','.','.','.','.']
//                                       ,['6','.','.','1','9','5','.','.','.']
//                                       ,['.','9','8','.','.','.','.','6','.']
//                                       ,['8','.','.','.','6','.','.','.','3']
//                                       ,['4','.','.','8','.','3','.','.','1']
//                                       ,['7','.','.','.','2','.','.','.','6']
//                                       ,['.','6','.','.','.','.','2','8','.']
//                                       ,['.','.','.','4','1','9','.','.','5']
//                                       ,['.','.','.','.','8','.','.','7','9']});

// GroupAnagrams groupAnagrams = new GroupAnagrams();
// groupAnagrams.GroupAnagrams();

// MaximumProductSubArray maximumProductSubArray = new MaximumProductSubArray();
// maximumProductSubArray.MaxProduct(new int [] {2,3,-2,4});

// WordDictionary wordDictionary = new WordDictionary();
// wordDictionary.AddWord("add");
// wordDictionary.AddWord("dad");
// wordDictionary.AddWord("cad");
// wordDictionary.AddWord("nad");
// wordDictionary.AddWord("bad");
// wordDictionary.AddWord("aad");
// wordDictionary.AddWord("ddd");
// wordDictionary.Search("..d");
// wordDictionary.Search(".dd");
// wordDictionary.Search("d.d");


//DFS PacificAtlanticWater pacificAtlanticWater = new PacificAtlanticWater();
//BFS PacificAtlanticWaters pacificAtlanticWater = new PacificAtlanticWaters();
// pacificAtlanticWater.PacificAtlantic(new int[][] {[1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5]});


// RemoveKthNodefromEnd removeKthNodefromEnd = new RemoveKthNodefromEnd();
// removeKthNodefromEnd.RemoveNthFromEnd(lsNode1, 2);

// FindDuplicateNumber findDuplicateNumber = new FindDuplicateNumber();
// findDuplicateNumber.FindDuplicate(new int[] {1,3,4,2,2});

// TopKFrequents topKFrequents = new TopKFrequents();
// topKFrequents.TopKFrequent(new string[] {"i","love","leetcode","i","love","coding"}, 2);

// LongestIncreasingSubsequence longestIncreasingSubsequence = new LongestIncreasingSubsequence();
// longestIncreasingSubsequence.LengthOfLISBS(new int [] {10, 9, 2, 5, 3, 7, 101, 18});

// GraphValidTree graphValidTree = new GraphValidTree();
// var refs = graphValidTree.ValidTree(5,new int [][] {[0,1],[0,2],[0,3],[1,4]});
// refs = graphValidTree.ValidTreeFS(5,new int [][] {[0,1],[0,2],[0,3],[1,4]});

// SwapNodesInPairs swapNodesInPairs = new SwapNodesInPairs();
// var recsd = swapNodesInPairs.SwapPairsTP(listNode);

// Solution406 solution406 = new Solution406();
// // solution406.ModifiedList(new int [] {1,2,3}, listNode);
// solution406.GetSmallestString("45320");

// PathSumII pathSumII = new PathSumII();
// pathSumII.PathSum(lvl1, 10);

// LongestConsecutiveSequence longestConsecutiveSequence = new LongestConsecutiveSequence();
// longestConsecutiveSequence.LongestConsecutive(new int[] {100,4,200,1,3,2});

// RotateArray rotateArray = new RotateArray();
// // rotateArray.Rotate(new int [] {1,2,3,4,5,6,7}, 3);
// rotateArray.Rotate(new int [] {-1,-100,3,99}, 2);

// OddEvenLinkedList oddEvenLinkedList = new OddEvenLinkedList();
// oddEvenLinkedList.OddEvenList(listNode);

// DecodedString decodedString = new DecodedString();
// decodedString.DecodeString("2[abc]3[cd]ef");

// ContiguousArray contiguousArray = new ContiguousArray();
// contiguousArray.FindMaxLength(new int[] {0,0,0,1,1,1,1,1,0,0});

// MaxWidthOfBinaryTree maxWidthOfBinaryTree = new MaxWidthOfBinaryTree();
// maxWidthOfBinaryTree.WidthOfBinaryTree(treeNode);

// FindClosestElement findClosestElement = new FindClosestElement();
// findClosestElement.FindClosestElements(new int [] {1,2,3,4,5}, 4, 3);
// findClosestElement.FindClosestElements(new int [] {1,3}, 1, 2);

// MinItemsToRemoved minItemsToRemoved = new MinItemsToRemoved();
// minItemsToRemoved.MinItemsToRemove(new int[] {3,2,1,4,6,5}, 3, 11);

// MaxConsecutiveOnesIII maxConsecutiveOnesIII = new MaxConsecutiveOnesIII();
// maxConsecutiveOnesIII.LongestConsecutiveOnes("11101010110011", 2);

// LongestRepeatingCharReplacement longestRepeatingCharReplacement = new LongestRepeatingCharReplacement();
// longestRepeatingCharReplacement.CharacterReplacement("AAGAGG", 2);

// InorderSuccessorInBST inorderSuccessorInBST = new InorderSuccessorInBST();
// var res1 = inorderSuccessorInBST.InorderSuccessor(root,new TreeNode(3));
// var res2 = inorderSuccessorInBST.InorderPredecessor(root,new TreeNode(3));

// JumpGame jumpGame = new JumpGame();
// jumpGame.CanJump(new int[] {2,3,1,1,4});
// jumpGame.CanJump(new int[] {3,2,1,0,4});
ListNode listNode1 = new ListNode(1);
listNode1.next = new ListNode(4);
listNode1.next.next = new ListNode(3);
ListNode plaindrome = new ListNode(3);
plaindrome.next = new ListNode(2);
plaindrome.next.next = new ListNode(1);
listNode1.next.next.next = plaindrome;

ListNode listNode21 = new ListNode(1);
listNode21.next = new ListNode(9);
listNode21.next.next = new ListNode(9);

// AddTwoNumbersLL addTwoNumbersLL = new AddTwoNumbersLL();
// addTwoNumbersLL.AddTwoNumbers(listNode1,listNode21);

// GenerateParenthes generateParenthes = new GenerateParenthes();
// generateParenthes.GenerateParenthesis(3);

// SortLists sortLists = new SortLists();
// sortLists.SortList(listNode1);

// ConnectedCompinUDGraph connectedCompinUDGraph = new ConnectedCompinUDGraph();
// connectedCompinUDGraph.countComponents(5, new int[][] {[0,1],[1,2],[3,4]});

// SubArraySumEqualsK subArraySumEqualsK = new SubArraySumEqualsK();
// subArraySumEqualsK.SubarraySum(new int [] {1,2,3},3);

// AsteroidCollisions asteroidCollisions = new AsteroidCollisions();
// asteroidCollisions.AsteroidCollision(new int[] {5,10,-5});
// asteroidCollisions.AsteroidCollision(new int[] {5,-5});
// asteroidCollisions.AsteroidCollision(new int[] {10,2,-5});

// RandomPickWithWeight randomPickWithWeight = new RandomPickWithWeight(new int[] {1,3});
// var res1 = randomPickWithWeight.PickIndex();
// var res2 = randomPickWithWeight.PickIndex();
// var res3 = randomPickWithWeight.PickIndex();
// var res4 = randomPickWithWeight.PickIndex();

// KthLargestElementinArray kthLargestElementinArray = new KthLargestElementinArray();
// kthLargestElementinArray.FindKthLargest(new int [] {3,2,3,1,2,4,5,5,6},4);


// MaximalSquares maximalSquares = new MaximalSquares();
// maximalSquares.MaximalSquare(new char[][]{['1','0','1','0','0'],['1','0','1','1','1'],['1','1','1','1','1'],['1','0','0','1','0']});

// RotateImage rotateImage = new RotateImage();
// rotateImage.Rotate90(new int[][]{[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]});
// rotateImage.Rotate90V2(new int[][]{[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]});
// rotateImage.Rotate180(new int[][]{[1,2,3],[4,5,6],[7,8,9]});

TreeNode treerr = new TreeNode(15);
TreeNode treerl = new TreeNode(7);
TreeNode treer = new TreeNode(20);
TreeNode treel = new TreeNode(19);
TreeNode tree = new TreeNode(2);
tree.left = treel;
tree.right = treer;
treer.left = treerl;
treer.right = treerr;
// BinaryTreeZigZagTraversal binaryTreeZigZagTraversal = new BinaryTreeZigZagTraversal();
// binaryTreeZigZagTraversal.ZigzagLevelOrder(tree);

// HitCounter hitCounter = new HitCounter();
// hitCounter.GetHits(2);
// hitCounter.RecordHit(2); //Makes hit at timestamp 2
// hitCounter.RecordHit(20);
// hitCounter.RecordHit(200);
// hitCounter.GetHits(200); //get hits at given timestamp i.e 200
// hitCounter.RecordHit(310);
// hitCounter.GetHits(340);

// PathSumIII pathSumIII = new PathSumIII();
// pathSumIII.PathSum(tree,22);

Solution407 solution407 = new Solution407();
// solution407.MinChanges(4,7);
// solution407.MinChanges(8,4);
// solution407.MinChanges(7,4);
// solution407.DoesAliceWin("ifld");
// solution407.DoesAliceWin("leetcoder");
// solution407.MaxOperations("10011000");
// solution407.MaxOperations2("1001101");
//solution407.MinimumOperations(new int[]{9,2,6,10,4,8,3,4,2,3}, new int[] {9,5,5,1,7,9,8,7,6,5});

// PowXN powXN = new PowXN();
// powXN.MyPow(2,5);

// Search2DMatrix search2DMatrix = new Search2DMatrix();
// search2DMatrix.SearchMatrix(new int [][]{[1,3,5,7],[10,11,16,20],[23,30,34,60]}, 3);

// LargestNumbers largestNumbers = new LargestNumbers();
// largestNumbers.LargestNumber(new int [] {10,2,9,39,17});
// largestNumbers.LargestNumber(new int [] {3,30,34,5,9});

// Solution408 solution408 = new Solution408();
// solution408.NonSpecialCount(5,7);
// solution408.NonSpecialCount(5,9);
// solution408.NonSpecialCount(4,16);
// solution408.NumberOfSubstrings("00011");
// solution408.CanReachCorner(3,3,new int [][] {[2,1,1],[1,2,1]});

// DecodeWays decodeWays = new DecodeWays();
// decodeWays.NumDecodings("126");

// MeetingRoomsII meetingRoomsII = new MeetingRoomsII();
// meetingRoomsII.MinMeetingRooms(new int[][] {[0,30],[5,10],[15,20]});

// ReverseInteger reverseInteger = new ReverseInteger();
// reverseInteger.Reverse(143);

// SetMatrixZeroes setMatrixZeroes = new SetMatrixZeroes();
// setMatrixZeroes.SetZeroes(new int[][] {[1,1,1],[1,0,1],[1,1,1]});
// setMatrixZeroes.SetZeroes(new int[][] {[0,1,2,0],[3,4,5,2],[1,3,1,5]});

// ReorderList1 reorderList1 = new ReorderList1();
// reorderList1.ReorderList(listNode);

// StringEncodeDecode stringEncodeDecode = new StringEncodeDecode();
// var encodedStr = stringEncodeDecode.EncodeString(new List<string> { "Hello", "Pooja", "Dhammaa" });
// var lsi = stringEncodeDecode.DecodeString1(encodedStr);

// CheapestFlight cheapestFlight = new CheapestFlight();
// cheapestFlight.FindCheapestPrice(4,new int[][] {[0,1,100],[1,2,100],[2,0,100],[1,3,600],[2,3,200]},0,3,1);

// ThreeSumClosests threeSumClosests = new ThreeSumClosests();
// threeSumClosests.ThreeSumClosest(new int [] {-1,2,1,-4},1);

// ROtateList rOtateList = new ROtateList();
// rOtateList.RotateRight(listNode, 3);

// MinimumInRotatedSortedArray minimumInRotatedSortedArray = new MinimumInRotatedSortedArray();
// minimumInRotatedSortedArray.FindMin(new int [] {3,4,5,1,2});

// BasicCalculatorII basicCalculatorII = new BasicCalculatorII();
// basicCalculatorII.Calculate(" 3/2 ");

// CombinationSum4 combinationSum4 = new CombinationSum4();
// combinationSum4.CombinationSum(new int[] {1,2,3},4);

// RandomizedSet randomizedSet = new RandomizedSet();
// randomizedSet.Insert(1); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
// randomizedSet.Remove(2); // Returns false as 2 does not exist in the set.
// randomizedSet.Insert(2); // Inserts 2 to the set, returns true. Set now contains [1,2].
// randomizedSet.Insert(4); // Inserts 2 to the set, returns true. Set now contains [1,2].
// randomizedSet.Insert(3); // Inserts 2 to the set, returns true. Set now contains [1,2].
// randomizedSet.GetRandom(); // getRandom() should return either 1 or 2 randomly.
// randomizedSet.Remove(1); // Removes 1 from the set, returns true. Set now contains [2].
// randomizedSet.Insert(2); // 2 was already in the set, so return false.
// randomizedSet.GetRandom();

// NonOverlapingIntervals nonOverlapingIntervals = new NonOverlapingIntervals();
// nonOverlapingIntervals.EraseOverlapIntervals(new int [] [] {[1,2],[2,3],[3,4],[1,3]});

// MinimumSubstringWindow minimumSubstringWindow = new MinimumSubstringWindow();
// // minimumSubstringWindow.MinWindow("a","aa");
// // minimumSubstringWindow.MinWindow("a","a");
// minimumSubstringWindow.MinWindow("ADOBECODEBANC","ABC");

// neighborSum neighborSum = new neighborSum(new int [][] {[0, 1, 2], [3, 4, 5], [6, 7, 8]});
// //neighborSum.AdjacentSum(5);
// neighborSum.DiagonalSum(4);


// Contest409 contest409 = new Contest409();
// contest409.ShortestDistanceAfterQueries(8, new int[][]{[5,7],[0,6]});

// await CallingApp.Run();

// Console.ReadLine();

// TrappingRainWater trappingRainWater = new TrappingRainWater();
// trappingRainWater.Trap(new int[] {0,1,0,2,1,0,1,3,2,1,2,1});

// MedianFinder medianFinder = new MedianFinder();
// medianFinder.AddNum(6);
// medianFinder.FindMedian();
// medianFinder.AddNum(10);
// medianFinder.FindMedian();
// medianFinder.AddNum(2);
// medianFinder.FindMedian();
// medianFinder.AddNum(6);
// medianFinder.AddNum(5);
// medianFinder.FindMedian();

// Contest410 contest410 = new Contest410();
// // contest410.FinalPositionOfSnake(2, new List<string> {"RIGHT","DOWN"});
// contest410.CountGoodNodes(new int[][] {[0,1],[0,2],[1,3],[1,4],[2,5],[2,6]});

// WordLadder wordLadder = new WordLadder();
// wordLadder.LadderLength("hit", "cog", new List<string>{"hot","dot","dog","lot","log", "cog"});

// BasicCalculator basicCalculator = new BasicCalculator();
// // basicCalculator.Calculate("(1+(4+5+2)-3)+(6+8)");
// basicCalculator.Calculate("1 + 1");


// JobSchedulings jobSchedulings = new JobSchedulings();
// jobSchedulings.JobScheduling(new int[] {1,2,3,3}, new int [] {3,4,5,6}, new int [] {50,10,40,70});
// jobSchedulings.JobScheduling1(new int[] {1,2,3,3}, new int [] {3,4,5,6}, new int [] {50,10,40,70});
// jobSchedulings.JobScheduling2(new int[] {1,2,3,3}, new int [] {3,4,5,6}, new int [] {50,10,40,70});


// var l1 = new ListNode(1){next = new ListNode(2){ next = new ListNode(3)}};
// var l2 = new ListNode(1){next = new ListNode(3){next = new ListNode(4)}};
// var l3 = new ListNode(2){ next = new ListNode (6)};
// MergeKSortedList mergeKSortedList = new MergeKSortedList();
// mergeKSortedList.MergeKLists(new ListNode[] {l1, l2, l3});

// LargestRectangleHistogram largestRectangleHistogram = new LargestRectangleHistogram();
// largestRectangleHistogram.LargestRectangleArea(new int[] {2,1,5,6,2,3});

// FreqStack freqStack = new FreqStack();
// freqStack.Push(2);
// freqStack.Push(3);
// var res = freqStack.Pop();
// freqStack.Push(2);
// freqStack.Push(2);
// res = freqStack.Pop();

// MedianOfTwoSortedArray medianOfTwoSortedArray = new MedianOfTwoSortedArray();
// medianOfTwoSortedArray.FindMedianSortedArrays(new int[] {1,2}, new int[] {3,4});

// LongestIncreasingPathInMatrix longestIncreasingPathInMatrix = new LongestIncreasingPathInMatrix();
// longestIncreasingPathInMatrix.LongestIncreasingPath(new int[][] {[9,9,4],[6,6,8],[2,1,1]});

// LongestValidParenthesiss longestValidParenthesiss = new LongestValidParenthesiss();
// var res = longestValidParenthesiss.LongestValidParentheses(")()())");
// var res1 = longestValidParenthesiss.LongestValidParentheses("(()((())");
// var res2 = longestValidParenthesiss.LongestValidParenthesesDP("(()(((()))");
// res = longestValidParenthesiss.LongestValidParentheses("");

//     BiContest137 biContest137 = new BiContest137();
// var res = biContest137.ResultsArray1(new int [] {1,2,3,4,3,2,5},3);
//var res = biContest137.FindSubarrayPowers(new int [] {1,2,3,4,3,2,5},3);

// WContest411 wContest411 = new WContest411();
//wContest411.MaxEnergyBoost(new int[] {1,3,1}, new int[] {3,1,1});
//wContest411.MaxEnergyBoost(new int[] {4,1,1}, new int[] {1,1,3});
//wContest411.MaxEnergyBoost(new int[] {1,1,3}, new int[] {4,1,1});
// wContest411.MaxEnergyBoost(new int[] {3,5,3}, new int[] {3,4,5});
//wContest411.CountSubstringsWithKConstraint("10101", 1);

// WordSearchII wordSearchII = new WordSearchII();
// wordSearchII.FindWords(new char [][] {['o','a','a','n'],['e','t','a','e'],['i','h','k','r'],['i','f','l','v']}, new string [] {"oath","pea","eat","rain"});

// AlienDictionary alienDictionary = new AlienDictionary();
// alienDictionary.AlienOrder(new string[] {"baa", "abcd", "abca", "cab", "cad"});


// BusRoutes busRoutes = new BusRoutes();
// busRoutes.NumBusesToDestination(new int [][] {[1,2,7],[3,6,7]}, 1,6);

// SlidingWindowMaximum slidingWindowMaximum = new SlidingWindowMaximum();
// // slidingWindowMaximum.MaxSlidingWindow(new int[]{1,3,-1,-3,5,3,6,7},3);
// slidingWindowMaximum.MaxSlidingWindow(new int[]{1,3,1,2,0,5},3);

// PalindromePaires palindromePaires = new PalindromePaires();
// palindromePaires.PalindromePairs(new string[] {"abcd","dcba","lls","s","sssll"});

// ReverseNodesInGroup reverseNodesInGroup = new ReverseNodesInGroup();
// reverseNodesInGroup.ReverseKGroup(lsNode1, 3);

// SudokuSolver2 sudokuSolver = new SudokuSolver2();
// sudokuSolver.SolveSudoku(new char[][]{
//     ['5','3','.','.','7','.','.','.','.'],
//     ['6','.','.','1','9','5','.','.','.'],
//     ['.','9','8','.','.','.','.','6','.'],
//     ['8','.','.','.','6','.','.','.','3'],
//     ['4','.','.','8','.','3','.','.','1'],
//     ['7','.','.','.','2','.','.','.','6'],
//     ['.','6','.','.','.','.','2','8','.'],
//     ['.','.','.','4','1','9','.','.','5'],
//     ['.','.','.','.','8','.','.','7','9']
// });

// FirstMissingPositiveNum firstMissingPositiveNum = new FirstMissingPositiveNum();
// // int ress = firstMissingPositiveNum.FirstMissingPositive(new int[] {1,2,0});
// int ress = firstMissingPositiveNum.FirstMissingPositive(new int[] {3,4,-1,1});
// ress = firstMissingPositiveNum.FirstMissingPositive(new int[] {2,1});

// NQueens nQueens = new NQueens();
// nQueens.SolveNQueens(4);

// SmallestRangeCoveringKElem smallestRangeCoveringKElem = new SmallestRangeCoveringKElem();
// smallestRangeCoveringKElem.SmallestRange(new int[][] {[4,10,15,24,26],[0,9,12,20],[5,18,22,30]});

// NumberOf1Bit numberOf1Bit = new NumberOf1Bit();
// int ans = numberOf1Bit.HammingWeight(1);
// ans = numberOf1Bit.HammingWeight(11);
// ans = numberOf1Bit.HammingWeight(8);

// SingleNumbers  singleNumbers = new SingleNumbers();
// singleNumbers.SingleNumber(new int[]{4,1,2,1,2});

// PalindromeLinkedList palindromeLinkedList = new PalindromeLinkedList();
// palindromeLinkedList.IsPalindrome(listNode1);

// MoveZeroess moveZeroess = new MoveZeroess();
// moveZeroess.MoveZeroes(new int[]{0,1,0,3,12});

// MissingNumbers missingNumbers = new MissingNumbers();
// var ress = missingNumbers.MissingNumber(new int[] {2,0,1});

// PalindromNumber palindromNumber = new PalindromNumber();
// var res = palindromNumber.IsPalindrome(121);
// res = palindromNumber.IsPalindrome(123);
// res = palindromNumber.IsPalindrome(1);
// res = palindromNumber.IsPalindrome(-123);

// ConvertSortedArrayToBST convertSortedArrayToBST = new ConvertSortedArrayToBST();
// var res = convertSortedArrayToBST.SortedArrayToBST(new int [] {-10,-3,0,5,9});




// KnapSackProblem knapSackProblem = new KnapSackProblem();
// var res = knapSackProblem.knapSack(4, new int [] {4,5,1}, new int[] {1,2,3});

// SubsetSumProblem subsetSumProblem = new SubsetSumProblem();
// subsetSumProblem.isSubsetSum(6,new int[]{3, 34, 4, 12, 5, 2},9);

// Contest416 contest416 = new Contest416();
// // var res = contest416.ReportSpam(new string[]{"hello","world","leetcode"}, new string[] {"world","hello"});
// var res = contest416.MinNumberOfSeconds(10,new int[] {3,2,2,4});
// Console.Write(res);

// MaxCutSegments maxCutSegments = new MaxCutSegments();
// maxCutSegments.maximizeTheCuts(4,2,1,1);

// MinCostToCutStick minCostToCutStick = new MinCostToCutStick();
// minCostToCutStick.MinCost(9, new int[] {5,6,1,4,2});

// Contest417 contest417 = new Contest417();
// // var res = contest417.KthCharacter(5);
// var res = contest417.CountOfSubstrings("ieaouqqieaouqq", 1);

// PascalsTriangle pascalsTriangle = new PascalsTriangle();
// pascalsTriangle.Generate(5);

// MaximumPossibleNumberByBinaryConcatenation maximumPossibleNumberByBinaryConcatenation = new MaximumPossibleNumberByBinaryConcatenation();
// int ereerr = maximumPossibleNumberByBinaryConcatenation.MaxGoodNumber(new int[] {1, 2, 3});

// RemoveMethodsFromProject removeMethodsFromProject = new RemoveMethodsFromProject();
// // // removeMethodsFromProject.RemainingMethods(4,1,new int[][] {[1,2],[0,1],[3,2]});
// removeMethodsFromProject.RemainingMethods(3,2,new int[][] {[1,0],[2,0]});

// ConstructGrid constructGrid = new ConstructGrid();
// // constructGrid.ConstructGridLayout(4, new int[][]{[0,1],[0,2],[1,3],[2,3]});
// constructGrid.ConstructGridLayout(5, new int[][]{[0,1],[1,3],[2,3],[2,4]});

// SubStringWithKFrequency subStringWithKFrequency = new ();
// int res = subStringWithKFrequency.NumberOfSubstrings("abacb", 2);

// MinDivisionOperations minDivisionOperations = new MinDivisionOperations();
// int res = minDivisionOperations.MinOperations(new int [] {9,10,18,20,2});

// Contest421 contest421 = new Contest421();
// // contest421.LengthAfterTransformations("abcyy", 2);
// contest421.MaxScore(new int[] {2,4,8,16});

// Epam interviewQuestion = new Epam();
// interviewQuestion.ThirdLargestInteger(new int [] {1,2,5,9,8,9,9,7});
// interviewQuestion.ThirdLargestInteger(new int [] {1,2,5,9});

// Cognizant cognizant = new Cognizant();
// _ = cognizant.GetLongestSubstringLength("", "");
// _ = cognizant.GetLongestSubstringLength("abc", "c");
// _ = cognizant.GetLongestSubstringLength("abcdef", "bcdefr");

//CodingTestMethods.GetDistinctRandom();

// Program2.Main2();
//PracticeMS practiceMS = new();
// var ugduw = practiceMS.MinCostClimbingStairs(new int[] {1,100,1,1,1,100,1,1,100,1});

