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
    public class BatchGetEdgeDriverResponseUnmarshaller
    {
        public static BatchGetEdgeDriverResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchGetEdgeDriverResponse batchGetEdgeDriverResponse = new BatchGetEdgeDriverResponse();

			batchGetEdgeDriverResponse.HttpResponse = _ctx.HttpResponse;
			batchGetEdgeDriverResponse.RequestId = _ctx.StringValue("BatchGetEdgeDriver.RequestId");
			batchGetEdgeDriverResponse.Success = _ctx.BooleanValue("BatchGetEdgeDriver.Success");
			batchGetEdgeDriverResponse.Code = _ctx.StringValue("BatchGetEdgeDriver.Code");
			batchGetEdgeDriverResponse.ErrorMessage = _ctx.StringValue("BatchGetEdgeDriver.ErrorMessage");

			List<BatchGetEdgeDriverResponse.BatchGetEdgeDriver_Driver> batchGetEdgeDriverResponse_driverList = new List<BatchGetEdgeDriverResponse.BatchGetEdgeDriver_Driver>();
			for (int i = 0; i < _ctx.Length("BatchGetEdgeDriver.DriverList.Length"); i++) {
				BatchGetEdgeDriverResponse.BatchGetEdgeDriver_Driver driver = new BatchGetEdgeDriverResponse.BatchGetEdgeDriver_Driver();
				driver.DriverId = _ctx.StringValue("BatchGetEdgeDriver.DriverList["+ i +"].DriverId");
				driver.DriverName = _ctx.StringValue("BatchGetEdgeDriver.DriverList["+ i +"].DriverName");
				driver.DriverProtocol = _ctx.StringValue("BatchGetEdgeDriver.DriverList["+ i +"].DriverProtocol");
				driver.Runtime = _ctx.StringValue("BatchGetEdgeDriver.DriverList["+ i +"].Runtime");
				driver.CpuArch = _ctx.StringValue("BatchGetEdgeDriver.DriverList["+ i +"].CpuArch");
				driver.Type = _ctx.IntegerValue("BatchGetEdgeDriver.DriverList["+ i +"].Type");
				driver.IsBuiltIn = _ctx.BooleanValue("BatchGetEdgeDriver.DriverList["+ i +"].IsBuiltIn");
				driver.GmtCreateTimestamp = _ctx.LongValue("BatchGetEdgeDriver.DriverList["+ i +"].GmtCreateTimestamp");
				driver.GmtModifiedTimestamp = _ctx.LongValue("BatchGetEdgeDriver.DriverList["+ i +"].GmtModifiedTimestamp");

				batchGetEdgeDriverResponse_driverList.Add(driver);
			}
			batchGetEdgeDriverResponse.DriverList = batchGetEdgeDriverResponse_driverList;
        
			return batchGetEdgeDriverResponse;
        }
    }
}
