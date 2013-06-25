package com.test.testservices;

public class caller extends Thread {

	public CalServices cs;
	public String a;

	public void run() {

		try {

			cs = new CalServices();

			String resp = cs.Call(a);
			TestMainActivity.rslt = resp;
		} catch (Exception ex)

		{
			TestMainActivity.rslt = ex.toString();
		}
	}

}
