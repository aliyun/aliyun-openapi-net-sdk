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
    public class QueryEdgeDriverResponseUnmarshaller
    {
        public static QueryEdgeDriverResponse Unmarshall(UnmarshallerContext context)
        {
			QueryEdgeDriverResponse queryEdgeDriverResponse = new QueryEdgeDriverResponse();

			queryEdgeDriverResponse.HttpResponse = context.HttpResponse;
			queryEdgeDriverResponse.RequestId = context.StringValue("QueryEdgeDriver.RequestId");
			queryEdgeDriverResponse.Success = context.BooleanValue("QueryEdgeDriver.Success");
			queryEdgeDriverResponse.Code = context.StringValue("QueryEdgeDriver.Code");
			queryEdgeDriverResponse.ErrorMessage = context.StringValue("QueryEdgeDriver.ErrorMessage");

			QueryEdgeDriverResponse.QueryEdgeDriver_Data data = new QueryEdgeDriverResponse.QueryEdgeDriver_Data();
			data.Total = context.IntegerValue("QueryEdgeDriver.Data.Total");
			data.PageSize = context.IntegerValue("QueryEdgeDriver.Data.PageSize");
			data.CurrentPage = context.IntegerValue("QueryEdgeDriver.Data.CurrentPage");

			List<QueryEdgeDriverResponse.QueryEdgeDriver_Data.QueryEdgeDriver_Driver> data_driverList = new List<QueryEdgeDriverResponse.QueryEdgeDriver_Data.QueryEdgeDriver_Driver>();
			for (int i = 0; i < context.Length("QueryEdgeDriver.Data.DriverList.Length"); i++) {
				QueryEdgeDriverResponse.QueryEdgeDriver_Data.QueryEdgeDriver_Driver driver = new QueryEdgeDriverResponse.QueryEdgeDriver_Data.QueryEdgeDriver_Driver();
				driver.DriverId = context.StringValue("QueryEdgeDriver.Data.DriverList["+ i +"].DriverId");
				driver.DriverName = context.StringValue("QueryEdgeDriver.Data.DriverList["+ i +"].DriverName");
				driver.DriverProtocol = context.StringValue("QueryEdgeDriver.Data.DriverList["+ i +"].DriverProtocol");
				driver.Runtime = context.StringValue("QueryEdgeDriver.Data.DriverList["+ i +"].Runtime");
				driver.CpuArch = context.StringValue("QueryEdgeDriver.Data.DriverList["+ i +"].CpuArch");
				driver.Type = context.IntegerValue("QueryEdgeDriver.Data.DriverList["+ i +"].Type");
				driver.IsBuiltIn = context.BooleanValue("QueryEdgeDriver.Data.DriverList["+ i +"].IsBuiltIn");
				driver.GmtCreateTimestamp = context.LongValue("QueryEdgeDriver.Data.DriverList["+ i +"].GmtCreateTimestamp");
				driver.GmtModifiedTimestamp = context.LongValue("QueryEdgeDriver.Data.DriverList["+ i +"].GmtModifiedTimestamp");

				data_driverList.Add(driver);
			}
			data.DriverList = data_driverList;
			queryEdgeDriverResponse.Data = data;
        
			return queryEdgeDriverResponse;
        }
    }
}
