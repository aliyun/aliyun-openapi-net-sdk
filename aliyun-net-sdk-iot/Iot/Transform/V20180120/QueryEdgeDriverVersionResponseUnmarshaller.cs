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
    public class QueryEdgeDriverVersionResponseUnmarshaller
    {
        public static QueryEdgeDriverVersionResponse Unmarshall(UnmarshallerContext context)
        {
			QueryEdgeDriverVersionResponse queryEdgeDriverVersionResponse = new QueryEdgeDriverVersionResponse();

			queryEdgeDriverVersionResponse.HttpResponse = context.HttpResponse;
			queryEdgeDriverVersionResponse.RequestId = context.StringValue("QueryEdgeDriverVersion.RequestId");
			queryEdgeDriverVersionResponse.Success = context.BooleanValue("QueryEdgeDriverVersion.Success");
			queryEdgeDriverVersionResponse.Code = context.StringValue("QueryEdgeDriverVersion.Code");
			queryEdgeDriverVersionResponse.ErrorMessage = context.StringValue("QueryEdgeDriverVersion.ErrorMessage");

			QueryEdgeDriverVersionResponse.QueryEdgeDriverVersion_Data data = new QueryEdgeDriverVersionResponse.QueryEdgeDriverVersion_Data();
			data.Total = context.IntegerValue("QueryEdgeDriverVersion.Data.Total");
			data.PageSize = context.IntegerValue("QueryEdgeDriverVersion.Data.PageSize");
			data.CurrentPage = context.IntegerValue("QueryEdgeDriverVersion.Data.CurrentPage");

			List<QueryEdgeDriverVersionResponse.QueryEdgeDriverVersion_Data.QueryEdgeDriverVersion_DriverVersion> data_driverVersionList = new List<QueryEdgeDriverVersionResponse.QueryEdgeDriverVersion_Data.QueryEdgeDriverVersion_DriverVersion>();
			for (int i = 0; i < context.Length("QueryEdgeDriverVersion.Data.DriverVersionList.Length"); i++) {
				QueryEdgeDriverVersionResponse.QueryEdgeDriverVersion_Data.QueryEdgeDriverVersion_DriverVersion driverVersion = new QueryEdgeDriverVersionResponse.QueryEdgeDriverVersion_Data.QueryEdgeDriverVersion_DriverVersion();
				driverVersion.DriverId = context.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].DriverId");
				driverVersion.DriverVersion = context.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].DriverVersion");
				driverVersion.VersionState = context.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].VersionState");
				driverVersion.EdgeVersion = context.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].EdgeVersion");
				driverVersion.Description = context.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].Description");
				driverVersion.SourceConfig = context.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].SourceConfig");
				driverVersion.DriverConfig = context.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].DriverConfig");
				driverVersion.ContainerConfig = context.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].ContainerConfig");
				driverVersion.ConfigCheckRule = context.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].ConfigCheckRule");
				driverVersion.GmtCreateTimestamp = context.LongValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].GmtCreateTimestamp");
				driverVersion.GmtModifiedTimestamp = context.LongValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].GmtModifiedTimestamp");
				driverVersion.Argument = context.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].Argument");

				data_driverVersionList.Add(driverVersion);
			}
			data.DriverVersionList = data_driverVersionList;
			queryEdgeDriverVersionResponse.Data = data;
        
			return queryEdgeDriverVersionResponse;
        }
    }
}
