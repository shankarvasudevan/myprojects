import argparse

parser = argparse.ArgumentParser(description='Process some integers')
parser.add_argument('integers', metavar='N', type=int, nargs='+', help='an integer for the accumulator')

args = parser.parse_args()
flight_length = args.integers[0]
movie_lengths = args.integers[1:]

print("flight_length:",flight_length)
print("movie_lengths:", movie_lengths)

grouped_movies = dict()
for i in range(len(movie_lengths)):
	if (grouped_movies.has_key(movie_lengths[i])):
		print("Found pair",grouped_movies[movie_lengths[i]], movie_lengths[i])
		print("True")
	else:
		grouped_movies[flight_length-movie_lengths[i]] = movie_lengths[i]
	


