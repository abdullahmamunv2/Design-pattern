############ author charlie ##############
############ concrete class of Subject ##############

from Subject import ISubject
from Observe import IObserver

class WeatherData(ISubject):

	def __init__():
		self.ObserverList=[]
		self.temprature=0.0
		self.humidity=0.0
		self.pressure=0.0
	
	def registerObserver(self,observer):###### observer type : IObserver
		ObserverList.append(observer)
	def removeObserver(self,observer):  ###### observer type : IObserver
		observer=ObserverList.index(observer)
		if not observer:
			ObserverList.remove(observer)
	def notifyObserver(self):
		for ob in ObserverList:
			ob.update(self.temprature,self.humidity,self.pressure)
	def getTemperature(self):
		pass
	def getHumidity(self):
		pass
	def getPressure(self):
		pass
	def measurementChanged(self):
		self.notifyObserver()
	def setMeasurements(self,temperature,humudity,pressure):
		self.temperature=temperature
		self.humudity=humudity
		self.pressure=pressure
		self.measurementChanged()
