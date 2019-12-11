/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryEdgeInstanceDriverResponseUnmarshaller
    {
        public static QueryEdgeInstanceDriverResponse Unmarshall(UnmarshallerContext context)
        {
			QueryEdgeInstanceDriverResponse queryEdgeInstanceDriverResponse = new QueryEdgeInstanceDriverResponse();

			queryEdgeInstanceDriverResponse.HttpResponse = context.HttpResponse;
			queryEdgeInstanceDriverResponse.RequestId = context.StringValue("QueryEdgeInstanceDriver.RequestId");
			queryEdgeInstanceDriverResponse.Success = context.BooleanValue("QueryEdgeInstanceDriver.Success");
			queryEdgeInstanceDriverResponse.Code = context.StringValue("QueryEdgeInstanceDriver.Code");
			queryEdgeInstanceDriverResponse.ErrorMessage = context.StringValue("QueryEdgeInstanceDriver.ErrorMessage");

			QueryEdgeInstanceDriverResponse.QueryEdgeInstanceDriver_Data data = new QueryEdgeInstanceDriverResponse.QueryEdgeInstanceDriver_Data();
			data.Total = context.IntegerValue("QueryEdgeInstanceDriver.Data.Total");
			data.PageSize = context.IntegerValue("QueryEdgeInstanceDriver.Data.PageSize");
			data.CurrentPage = context.IntegerValue("QueryEdgeInstanceDriver.Data.CurrentPage");

			List<QueryEdgeInstanceDriverResponse.QueryEdgeInstanceDriver_Data.QueryEdgeInstanceDriver_Driver> data_driverList = new List<QueryEdgeInstanceDriverResponse.QueryEdgeInstanceDriver_Data.QueryEdgeInstanceDriver_Driver>();
			for (int i = 0; i < context.Length("QueryEdgeInstanceDriver.Data.DriverList.Length"); i++) {
				QueryEdgeInstanceDriverResponse.QueryEdgeInstanceDriver_Data.QueryEdgeInstanceDriver_Driver driver = new QueryEdgeInstanceDriverResponse.QueryEdgeInstanceDriver_Data.QueryEdgeInstanceDriver_Driver();
				driver.DriverId = context.StringValue("QueryEdgeInstanceDriver.Data.DriverList["+ i +"].DriverId");
				driver.DriverVersion = context.StringValue("QueryEdgeInstanceDriver.Data.DriverList["+ i +"].DriverVersion");
				driver.OrderId = context.StringValue("QueryEdgeInstanceDriver.Data.DriverList["+ i +"].OrderId");
				driver.GmtCreate = context.StringValue("QueryEdgeInstanceDriver.Data.DriverList["+ i +"].GmtCreate");
				driver.GmtModified = context.StringValue("QueryEdgeInstanceDriver.Data.DriverList["+ i +"].GmtModified");

				data_driverList.Add(driver);
			}
			data.DriverList = data_driverList;
			queryEdgeInstanceDriverResponse.Data = data;
        
			return queryEdgeInstanceDriverResponse;
        }
    }
}
