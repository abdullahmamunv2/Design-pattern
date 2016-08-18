

from Observer import IObserver
from DisplayElement import IDisplayElement

class CurrentConditions(IObserver,IDisplayElement):

	def __init__(self,ObserverId):
		super(CurrentConditions,self).__init__(ObserverId)

	##### implemented  IOobserver ########
	def update(self,temperature,humudity,pressure):
		pass
	##### implemented  IDisplayElement ########
	def display(self):
		pass



class ForecastDisplay(IObserver,IDisplayElement):

	def __init__(self,ObserverId):
		super(ForecastDisplay,self).__init__(ObserverId)

	def update(self,temperature,humudity,pressure):
		pass
	def display():
		pass
