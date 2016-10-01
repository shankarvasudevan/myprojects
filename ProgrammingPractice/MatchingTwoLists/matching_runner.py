
class Instrument(object):
	
	def __init__(self, market, kind, underlying):
		self.market = market
		self.kind = kind
		self.underlying = underlying

class Product(object):
	
	def __init__(self, exchange, pg, symbol):
		self.exchange = exchange
		self.pg = pg
		self.symbol = symbol


class MatchingRunner:
	
	def run_matcher(self, instruments, products):
		for i in instruments:
			for p in products:
				if i.market = p.exchange:
					print i.market + ':' + i.kind + ':' + i.underlying
