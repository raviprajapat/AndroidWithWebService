package com.test.testservices;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class TestMainActivity extends Activity {
	Button buttonFetch;
	TextView txtResultView;
	public static String rslt = "";

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_test_main);
		buttonFetch = (Button) findViewById(R.id.btnFetch);
		buttonFetch.setOnClickListener(new View.OnClickListener() {

			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				try {
					txtResultView = (TextView) findViewById(R.id.txtViewResult);
					//CalServices ser = new CalServices();

					caller c = new caller();
					c.a = "Test";
					c.join();
					c.start();
					while (rslt == "START") {
						try {
							Thread.sleep(10);
						} catch (Exception ex) {

						}
					}
				} catch (Exception e) {
					// TODO: handle exception
				}
				txtResultView.setText(rslt);

			}
		});
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.test_main, menu);
		return true;
	}

}
