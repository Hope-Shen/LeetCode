package flood_fill

// Time Complexity: O(N), where N is the total number of pixels in the image. Visit every pixel once in the worst case.
// Space Complexity: O(N), for the recursion stack in the worst case.
func floodFill(image [][]int, sr int, sc int, color int) [][]int {
	orgColor := image[sr][sc]

	// If  original color is the same as the new color, no need to proceed
	if orgColor == color {
		return image
	}

	// Recursion: Depth-First Search (DFS)
	dfs(image, sr, sc, orgColor, color)

	return image
}

func dfs(image [][]int, r, c int, oldColor, newColor int) {
	// 變數 | 意義 |  方向    |  邊界檢查對象    |    物理意義
	//  r  | Row  | (列)垂直 |  len(image)    |  高度(Height)
	//  c  | Col  | (欄)水平 |  len(image[0]) |  寬度 (Width)

	if r < 0 || r >= len(image) || // Row boundary check
		c < 0 || c >= len(image[0]) || // Column boundary check
		image[r][c] != oldColor { // Color check
		return
	}

	// Process: Change the color of the current pixel
	image[r][c] = newColor

	// Recurse: Visit all 4 adjacent neighbors (Up, Down, Left, Right)
	dfs(image, r-1, c, oldColor, newColor) // Up
	dfs(image, r+1, c, oldColor, newColor) // Down
	dfs(image, r, c-1, oldColor, newColor) // Left
	dfs(image, r, c+1, oldColor, newColor) // Right
}
