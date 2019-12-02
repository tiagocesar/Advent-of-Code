<Query Kind="Program" />

void Main()
{
	for (int noun = 0; noun <= 99; noun++)
	{
		for (int verb = 0; verb <= 99; verb++)
		{
			var nums = new[] { 1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,10,1,19,1,19,6,23,2,13,23,27,1,27,13,31,1,9,31,35,1,35,9,39,1,39,5,43,2,6,43,47,1,47,6,51,2,51,9,55,2,55,13,59,1,59,6,63,1,10,63,67,2,67,9,71,2,6,71,75,1,75,5,79,2,79,10,83,1,5,83,87,2,9,87,91,1,5,91,95,2,13,95,99,1,99,10,103,1,103,2,107,1,107,6,0,99,2,14,0,0 };
			
			nums[1] = noun;
			nums[2] = verb;

			int i = 0;
			
			for (; i < nums.Length; i += 4)
			{
				if (nums[i] == 99) break;

				switch (nums[i])
				{
					case 1:
						nums[nums[i + 3]] = nums[nums[i + 1]] + nums[nums[i + 2]];
						break;
					case 2:
						nums[nums[i + 3]] = nums[nums[i + 1]] * nums[nums[i + 2]];
						break;
				}
			}

			if (nums[0] == 19690720)
			{
				(100 * noun + verb).Dump();
			}
		}
	}
}