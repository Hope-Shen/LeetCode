
### 目錄命名規則
- 每個題目有獨立的文件夾：`<題號>_<題目英文名稱>/`
- 每個題目包含兩個文件：
  - `<題號>_<題目名稱>.go` - 解決方案實現
  - `<題號>_<題目名稱>_test.go` - 單元測試

## 🧪 如何執行測試

```bash
# 測試特定題目（從項目根目錄）
go test ./0001_two_sum

# 運行測試並顯示詳細輸出
go test -v ./0001_two_sum
```

## 📚 已完成題目列表

| 題號 | 題目名稱 | 難度 | 主要概念 |
|------|----------|------|----------|
| 0001 | Two Sum | Easy | 哈希表 |
| 0020 | Valid Parentheses | Easy | 棧 |
| 0021 | Merge Two Sorted Lists | Easy | 鏈表 |
| 0121 | Best Time to Buy and Sell Stock | Easy | 動態規劃 |
| 0125 | Valid Palindrome | Easy | 字串處理 |
| 0206 | Reverse Linked List | Easy | 鏈表 |
| 0217 | Contains Duplicate | Easy | 哈希表 |
| 0226 | Invert Binary Tree | Easy | 二叉樹 |
| 0235 | Lowest Common Ancestor of a BST | Easy | 二叉搜索樹 |
| 0242 | Valid Anagram | Easy | 字串處理 |
| 0344 | Reverse String | Easy | 字串處理 |
| 0704 | Binary Search | Easy | 二分查找 |
| 0733 | Flood Fill | Easy | DFS/BFS |


## 🚀 如何添加新題目

1. **創建題目目錄**：
   ```bash
   mkdir 0001_new_problem
   cd 0001_new_problem
   ```

2. **創建解決方案文件** `0001_new_problem.go`：
   ```go
   package new_problem

   // Time complexity: O(?)
   // Space complexity: O(?)
   func solutionFunction(params) returnType {
       // 你的解決方案
   }
   ```

3. **創建測試文件** `0001_new_problem_test.go`：
   ```go
   package new_problem

   import (
       "reflect"
       "testing"
   )

   func TestSolutionFunction(t *testing.T) {
       tests := []struct {
           name     string
           // 輸入參數
           expected returnType
       }{
           {
               name:     "No 1: Description",
               // 測試數據
           },
       }

       for _, tc := range tests {
           t.Run(tc.name, func(t *testing.T) {
               result := solutionFunction(tc.input)
               if !reflect.DeepEqual(result, tc.expected) {
                   t.Errorf("Case [%s] Failed! Expect: %v, Actual: %v",
                       tc.name, tc.expected, result)
               }
           })
       }
   }
   ```

4. **運行測試**：
   ```bash
   go test -v
   ```


---

**Happy Coding! 🎉**