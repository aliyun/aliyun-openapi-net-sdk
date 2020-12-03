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
        public static QueryEdgeDriverResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEdgeDriverResponse queryEdgeDriverResponse = new QueryEdgeDriverResponse();

			queryEdgeDriverResponse.HttpResponse = _ctx.HttpResponse;
			queryEdgeDriverResponse.RequestId = _ctx.StringValue("QueryEdgeDriver.RequestId");
			queryEdgeDriverResponse.Success = _ctx.BooleanValue("QueryEdgeDriver.Success");
			queryEdgeDriverResponse.Code = _ctx.StringValue("QueryEdgeDriver.Code");
			queryEdgeDriverResponse.ErrorMessage = _ctx.StringValue("QueryEdgeDriver.ErrorMessage");

			QueryEdgeDriverResponse.QueryEdgeDriver_Data data = new QueryEdgeDriverResponse.QueryEdgeDriver_Data();
			data.Total = _ctx.IntegerValue("QueryEdgeDriver.Data.Total");
			data.PageSize = _ctx.IntegerValue("QueryEdgeDriver.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("QueryEdgeDriver.Data.CurrentPage");

			List<QueryEdgeDriverResponse.QueryEdgeDriver_Data.QueryEdgeDriver_Driver> data_driverList = new List<QueryEdgeDriverResponse.QueryEdgeDriver_Data.QueryEdgeDriver_Driver>();
			for (int i = 0; i < _ctx.Length("QueryEdgeDriver.Data.DriverList.Length"); i++) {
				QueryEdgeDriverResponse.QueryEdgeDriver_Data.QueryEdgeDriver_Driver driver = new QueryEdgeDriverResponse.QueryEdgeDriver_Data.QueryEdgeDriver_Driver();
				driver.DriverId = _ctx.StringValue("QueryEdgeDriver.Data.DriverList["+ i +"].DriverId");
				driver.DriverName = _ctx.StringValue("QueryEdgeDriver.Data.DriverList["+ i +"].DriverName");
				driver.DriverProtocol = _ctx.StringValue("QueryEdgeDriver.Data.DriverList["+ i +"].DriverProtocol");
				driver.Runtime = _ctx.StringValue("QueryEdgeDriver.Data.DriverList["+ i +"].Runtime");
				driver.CpuArch = _ctx.StringValue("QueryEdgeDriver.Data.DriverList["+ i +"].CpuArch");
				driver.Type = _ctx.IntegerValue("QueryEdgeDriver.Data.DriverList["+ i +"].Type");
				driver.IsBuiltIn = _ctx.BooleanValue("QueryEdgeDriver.Data.DriverList["+ i +"].IsBuiltIn");
				driver.GmtCreateTimestamp = _ctx.LongValue("QueryEdgeDriver.Data.DriverList["+ i +"].GmtCreateTimestamp");
				driver.GmtModifiedTimestamp = _ctx.LongValue("QueryEdgeDriver.Data.DriverList["+ i +"].GmtModifiedTimestamp");

				data_driverList.Add(driver);
			}
			data.DriverList = data_driverList;
			queryEdgeDriverResponse.Data = data;
        
			return queryEdgeDriverResponse;
        }
    }
}
