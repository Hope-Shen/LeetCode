## Phase 1: Warm-up & Basic Data Structures (Array, Slice, Map)

**Focus**:

* Mastering Go **Slice** operations (`append`, `range`).
* Proficient use of **Maps** (`make`, `comma ok` idiom).
* Understanding the time complexity advantages of **Hash Tables**.

- [X]  **[1] Two Sum** (Easy)
  - Core Concept: `HashMap`, `Space-Time Tradeoff`
  - Go Skills: `map[int]int`, `range` loop
- [X]  **[217] Contains Duplicate** (Easy)
  - Core Concept: `HashSet`
  - Go Skills: `map[int]bool`, efficient lookup
- [X]  **[242] Valid Anagram** (Easy)
  - Core Concept: Frequency Counter
  - Go Skills: Using Array as a Map optimization (`[26]int`), `rune` vs `byte`

## Phase 2: String Manipulation & Two Pointers

**Focus**:

* Understanding Go's **Immutable Strings**.
* Distinguishing between `byte` (ASCII) and `rune` (Unicode/UTF-8).
* Applying the **Two Pointers** technique for space optimization.

- [X]  **[125] Valid Palindrome** (Easy)
  - Core Concept: Two Pointers convergence, String sanitization
  - Go Skills: `strings` package, `unicode` package
- [X]  **[344] Reverse String** (Easy)
  - Core Concept: In-place Swap
  - Go Skills: Multiple assignment (`a, b = b, a`)

## Phase 3: Linked Lists

**Focus**:

* Manipulating **Pointers** (`*Node`, `&Node`).
* Understanding memory addresses and pass-by-reference.

- [ ]  **[206] Reverse Linked List** (Easy)
  - Core Concept: Pointer manipulation
  - Go Skills: Iterative vs Recursive approaches
- [ ]  **[21] Merge Two Sorted Lists** (Easy)
  - Core Concept: Merge Sort basics
  - Go Skills: Dummy Node technique

## Phase 4: Trees & Recursion

**Focus**:

* Defining **Structs** and Methods.
* Depth-First Search (DFS) and the Call Stack.

- [ ]  **[226] Invert Binary Tree** (Easy)
  - Core Concept: Swapping child nodes
  - Go Skills: Recursion base cases
- [ ]  **[104] Maximum Depth of Binary Tree** (Easy)
  - Core Concept: Calculating Tree Height
  - Go Skills: DFS, `math.Max` type casting

## Phase 5: Advanced Challenges (Sliding Window, Binary Search)

*(Unlocked after completing the basics)*

- [ ]  **[121] Best Time to Buy and Sell Stock** (Easy)
- [ ]  **[704] Binary Search** (Easy)
