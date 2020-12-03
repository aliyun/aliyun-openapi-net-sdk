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
        public static QueryEdgeDriverVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEdgeDriverVersionResponse queryEdgeDriverVersionResponse = new QueryEdgeDriverVersionResponse();

			queryEdgeDriverVersionResponse.HttpResponse = _ctx.HttpResponse;
			queryEdgeDriverVersionResponse.RequestId = _ctx.StringValue("QueryEdgeDriverVersion.RequestId");
			queryEdgeDriverVersionResponse.Success = _ctx.BooleanValue("QueryEdgeDriverVersion.Success");
			queryEdgeDriverVersionResponse.Code = _ctx.StringValue("QueryEdgeDriverVersion.Code");
			queryEdgeDriverVersionResponse.ErrorMessage = _ctx.StringValue("QueryEdgeDriverVersion.ErrorMessage");

			QueryEdgeDriverVersionResponse.QueryEdgeDriverVersion_Data data = new QueryEdgeDriverVersionResponse.QueryEdgeDriverVersion_Data();
			data.Total = _ctx.IntegerValue("QueryEdgeDriverVersion.Data.Total");
			data.PageSize = _ctx.IntegerValue("QueryEdgeDriverVersion.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("QueryEdgeDriverVersion.Data.CurrentPage");

			List<QueryEdgeDriverVersionResponse.QueryEdgeDriverVersion_Data.QueryEdgeDriverVersion_DriverVersion> data_driverVersionList = new List<QueryEdgeDriverVersionResponse.QueryEdgeDriverVersion_Data.QueryEdgeDriverVersion_DriverVersion>();
			for (int i = 0; i < _ctx.Length("QueryEdgeDriverVersion.Data.DriverVersionList.Length"); i++) {
				QueryEdgeDriverVersionResponse.QueryEdgeDriverVersion_Data.QueryEdgeDriverVersion_DriverVersion driverVersion = new QueryEdgeDriverVersionResponse.QueryEdgeDriverVersion_Data.QueryEdgeDriverVersion_DriverVersion();
				driverVersion.DriverId = _ctx.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].DriverId");
				driverVersion.DriverVersion = _ctx.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].DriverVersion");
				driverVersion.VersionState = _ctx.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].VersionState");
				driverVersion.EdgeVersion = _ctx.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].EdgeVersion");
				driverVersion.Description = _ctx.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].Description");
				driverVersion.SourceConfig = _ctx.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].SourceConfig");
				driverVersion.DriverConfig = _ctx.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].DriverConfig");
				driverVersion.ContainerConfig = _ctx.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].ContainerConfig");
				driverVersion.ConfigCheckRule = _ctx.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].ConfigCheckRule");
				driverVersion.GmtCreateTimestamp = _ctx.LongValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].GmtCreateTimestamp");
				driverVersion.GmtModifiedTimestamp = _ctx.LongValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].GmtModifiedTimestamp");
				driverVersion.Argument = _ctx.StringValue("QueryEdgeDriverVersion.Data.DriverVersionList["+ i +"].Argument");

				data_driverVersionList.Add(driverVersion);
			}
			data.DriverVersionList = data_driverVersionList;
			queryEdgeDriverVersionResponse.Data = data;
        
			return queryEdgeDriverVersionResponse;
        }
    }
}
