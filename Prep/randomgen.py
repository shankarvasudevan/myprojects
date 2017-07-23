#!/usr/bin/python

import random

class RandomGen(object):
    LARGE_NUM = 1000000
    EXTRAPOLATION_AMOUNT = 100

    _ext_numbers = []
    
    def __init__(self, random_nums, probabilities):
        valid = self.validate(random_nums, probabilities)
        if valid != True:
            raise Exception(valid[1])

        ext_probs = self.extrapolate(random_nums, probabilities, self.EXTRAPOLATION_AMOUNT)
        self._ext_numbers = self.fill(random_nums, ext_probs, self.EXTRAPOLATION_AMOUNT)
    
    def validate(self, nums, probs):
        if nums is None or len(nums) == 0:
            return (False, "No random numbers specified")
        
        if probs is None or len(probs) == 0:
            return (False, "No probabilities specified")

        if len(probs) != len(nums):
            return (False, "Count of probabilities not equal to count of random numbers")

        sum = 0
        for i in range(0, len(probs)):
            if probs[i] < 0 or probs[i] > 1:
                return (False, "Probabilities should be between 0 and 1")
            
            sum += probs[i]

        if sum != 1:
            return (False, "Probabilities should sum to 1")

        return True
 
    def fill(self, nums, probs, ext_amt):
	ext_nums = []
        for i in range(0, len(nums)):
	    num = nums[i]
            prob = probs[i]
            tmp_list = [num]*probs[i]
            ext_nums += tmp_list

        return ext_nums         

    def extrapolate(self, nums, probs, ext_amt):
        ext_probs = [0]*ext_amt
        should_round_up = True
        count = 0
        
        for i in range(0, len(probabilities)):
            if count >= ext_amt:
                break
            
            ext_prob = probs[i] * ext_amt
            trunc_prob = int(ext_prob)
            
            if ext_prob - trunc_prob > 0: 
                if should_round_up is True:
                    trunc_prob += 1
            
                should_round_up != should_round_up
        
            while count + trunc_prob > ext_amt:
                trunc_prob -= 1

            ext_probs[i] = trunc_prob
            count += trunc_prob
        
        return ext_probs 	    

    def next_num(self):
        """
        Returns one of the randomNums. When this method is called
        multiple times over a long period, it should return the
        numbers roughly with the initialized probabilities.
        """
        r = random.random()
        next_num_index = int((r * self.LARGE_NUM) % self.EXTRAPOLATION_AMOUNT)
        return self._ext_numbers[next_num_index]

if __name__ == '__main__':
    random_nums = [1, 2, 3, 4]
    probabilities = [0.25, 0.25, 0.25, 0.25]
    ran_gen = RandomGen(random_nums, probabilities)
    for i in range(0,10):
        print 'Next number is ', ran_gen.next_num()
