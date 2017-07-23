import unittest
from efficientsorter import efficientsorter

class EfficientSorterTest(unittest.TestCase):
    
    def testSortingNoneInputReturnsNoneOutput(self):
        sorter = EfficientSorter()
        self.assertIsNone(sorter.Sort(None))

if __name__ == '__main__':
	unittest.main()

