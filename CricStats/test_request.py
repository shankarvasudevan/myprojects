from urllib2 import Request, urlopen, URLError

apiKey = 'CsJgqi4CeQVOY5oDsollqKYCsYy1'
uid = 1034809
url = "https://cricapi.com/api/cricket?apikey="+apiKey

try:
	request = Request(url)
	response = urlopen(request)
	output = response.read()
	print output
except URLError, e:
	print 'Got an error code:', e

