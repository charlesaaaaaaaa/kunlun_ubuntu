package kunlun.test;

import java.io.BufferedReader;
import java.io.FileReader;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Properties;

public class PostgreSqlJdbcConnAddDatas {
	private PreparedStatement stmtGetCustWhse = null;
	private PreparedStatement payGetWhse = null;

	public static void main(String args[]) {
		Connection c = null;
		Statement stmt = null;
		Class.forName("org.postgresql.Driver");
		c = DriverManager.getConnection(
				"jdbc:postgresql://192.168.0.113:5001/benchmarksql_test", "benchmarksql_test","benchmarksql_test");
		c.setAutoCommit(false);
 
		System.out.println("连接数据库成功！");
		stmt = c.createStatement();
			
        	int a_warehouse_w_id = (int)(1+Math.random()*(1000-1+1));
        	int a_w_id = 1;
		     payUpdateWhse = stmt.prepareStatement(
                  "UPDATE benchmarksql.warehouse SET w_ytd = 30000 + ?  WHERE w_id = ? ");
              payUpdateWhse.setFloat(1,a_warehouse_w_id);
              payUpdateWhse.setInt(2,a_w_id);
              
              
                payGetWhse = stmt.prepareStatement(
                  "SELECT w_street_1, w_street_2, w_city, w_state, w_zip, w_name" +
                  " FROM benchmarksql.warehouse WHERE w_id = 1");



			stmt.close();
			c.commit();
			c.close();
 

	}
}
