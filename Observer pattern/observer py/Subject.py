######## author charlie #########################################
######## subject interface(Subject in observer pattern)##########
######## each subject should implement this interface ###########

class ISubject(object):

	def registerObserver(self):
		raise not NotImplementedError("should have implemented this")

	def removeObserver(self):
		raise not NotImplementedError("should have implemented this")

	def notifyObserver(self):
		raise not NotImplementedError("should have implemented this")
		
	def setMeasurements(self,temperature,humudity,pressure):
		raise not NotImplementedError("should have implemented this")