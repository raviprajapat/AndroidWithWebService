package com.test.testservices;


import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.PropertyInfo;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;
import org.json.JSONObject;
import android.os.Debug;

public class CalServices {
	public final String SOAP_ACTION = "http://tempuri.org/Add";

	public final String OPERATION_NAME = "Add";

	public final String WSDL_TARGET_NAMESPACE = "http://tempuri.org/";

	public final String SOAP_ADDRESS = "http://192.168.43.155/UserInterface.asmx";
	private JSONParser jsonParser;
	public CalServices()
	{
		jsonParser= new JSONParser();
	}
	
	public String Call(String value) {
		SoapObject request = new SoapObject(WSDL_TARGET_NAMESPACE,
				OPERATION_NAME);
		PropertyInfo pi = new PropertyInfo();
		pi.setName("a");
		pi.setValue(value);
		pi.setType(String.class);
		request.addProperty(pi);
		

		SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(
				SoapEnvelope.VER11);
		envelope.dotNet = true;

		envelope.setOutputSoapObject(request);

		HttpTransportSE httpTransport = new HttpTransportSE(SOAP_ADDRESS);
		Object response = null;
		try {
			httpTransport.call(SOAP_ACTION, envelope);
			response = envelope.getResponse();
		} catch (Exception exception) {
			response = exception.toString();
		}
		return response.toString();
	}
}
