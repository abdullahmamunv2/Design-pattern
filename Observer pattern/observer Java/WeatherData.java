
////using java built-in api 

import java.util.Observable;
import java.util.Observer; 


public class WeatherData extends Observable{

	private float temperature;
	private float humidity;
	private float pressure;

	public WeatherData(){
		//do nothing
	}

	public void MeasurementChanged(){
		setChanged();
		notifyObservers();
	} 

	public void setMeasurement(float temperature,float humidity,float pressure){
		this.temperature=temperature;
		this.humidity=humidity;
		this.pressure=pressure;
		MeasurementChanged();
	}

	public float getTemperature(){
		return temperature;
	}

	public float getHumidity(){
		return humidity;
	}

	public float getPressure(){
		return pressure;
	}
}