#!/usr/bin/python

import random

class RandomGen(object):
    EXTRAPOLATION_AMOUNT = 100

    # Values that may be returned by next_num()
    _random_nums = []
    # Probability of the occurence of random_nums
    _probabilities = []
 
    def __init__(self, random_nums, probabilities):
        self._random_nums = random_nums
        self._probabilities = probabilities
    
    def extrapolate_probabilities(self, random_nums, probabilities, ext_amt):
	    

    def next_num(self):
        """
        Returns one of the randomNums. When this method is called
        multiple times over a long period, it should return the
        numbers roughly with the initialized probabilities.
        """
        return random.random()

if __name__ == '__main__':
    random_nums = [1, 2, 3, 4]
    probabilities = [0.25, 0.25, 0.25, 0.25]
    ran_gen = RandomGen(random_nums, probabilities)
    for i in range(0,10):
        print 'Next number is ', ran_gen.next_num()
