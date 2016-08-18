

class myclass(object):

	def __init__(self,name):
		self.name=name

l=[]

ob1=myclass('kamrul')
ob2=myclass('real')

l.append(ob1)
l.append(ob2)
l.remove(ob1)
for o in l:
	print o.name
