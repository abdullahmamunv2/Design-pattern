######## author charlie #############
######## observer interface(observer in observer pattern)##########
######## each observer should implement this interface ###########


class IObserver(object):

	def __init__(self,ObserverId):
		self.ObserverId=ObserverId

	#########  Update observer state #########
	def update(self,temperature,humudity,pressure):
		raise not NotImplementedError("should have implemented this")