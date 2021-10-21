﻿export function calculatePrimes(max) {
	var result = 0;
	for (var i = 2; i <= max; i++)
	{
		var prime = true;
		for (var j = 2; j < i; j++) {
			if (i % j == 0) {
				prime = false;
			}
		}
		if (prime) {
			result++;
		}
	}
	return result;
}
