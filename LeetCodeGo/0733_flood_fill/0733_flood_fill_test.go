package flood_fill

import (
	"reflect"
	"testing"
)

func TestFloodFill(t *testing.T) {
	tests := []struct {
		name     string
		image    [][]int
		sr       int
		sc       int
		color    int
		expected [][]int
	}{
		{
			name: "Example 1",
			image: [][]int{
				{1, 1, 1},
				{1, 1, 0},
				{1, 0, 1},
			},
			sr:    1,
			sc:    1,
			color: 2,
			expected: [][]int{
				{2, 2, 2},
				{2, 2, 0},
				{2, 0, 1},
			},
		},
		{
			name: "Example 2 - No Change Needed",
			image: [][]int{
				{0, 0, 0},
				{0, 0, 0},
			},
			sr:    0,
			sc:    0,
			color: 0,
			expected: [][]int{
				{0, 0, 0},
				{0, 0, 0},
			},
		},
		{
			name: "Single Pixel",
			image: [][]int{
				{1},
			},
			sr:    0,
			sc:    0,
			color: 5,
			expected: [][]int{
				{5},
			},
		},
		{
			name: "Disconnected Regions",
			image: [][]int{
				{1, 1, 0, 1, 1},
				{1, 1, 0, 1, 1},
			},
			sr:    0,
			sc:    0,
			color: 3,
			expected: [][]int{
				{3, 3, 0, 1, 1},
				{3, 3, 0, 1, 1},
			},
		},
	}

	for _, tc := range tests {
		t.Run(tc.name, func(t *testing.T) {
			inputImage := make([][]int, len(tc.image))
			for i := range tc.image {
				inputImage[i] = make([]int, len(tc.image[i]))
				copy(inputImage[i], tc.image[i])
			}

			result := floodFill(inputImage, tc.sr, tc.sc, tc.color)

			if !reflect.DeepEqual(result, tc.expected) {
				t.Errorf("Case [%s] Failed! Expect: %v, Actual: %v", tc.name, tc.expected, result)
			}
		})
	}
}
