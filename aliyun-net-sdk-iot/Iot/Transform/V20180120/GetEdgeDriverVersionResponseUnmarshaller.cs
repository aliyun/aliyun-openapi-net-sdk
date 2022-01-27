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
    public class GetEdgeDriverVersionResponseUnmarshaller
    {
        public static GetEdgeDriverVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetEdgeDriverVersionResponse getEdgeDriverVersionResponse = new GetEdgeDriverVersionResponse();

			getEdgeDriverVersionResponse.HttpResponse = _ctx.HttpResponse;
			getEdgeDriverVersionResponse.RequestId = _ctx.StringValue("GetEdgeDriverVersion.RequestId");
			getEdgeDriverVersionResponse.Success = _ctx.BooleanValue("GetEdgeDriverVersion.Success");
			getEdgeDriverVersionResponse.Code = _ctx.StringValue("GetEdgeDriverVersion.Code");
			getEdgeDriverVersionResponse.ErrorMessage = _ctx.StringValue("GetEdgeDriverVersion.ErrorMessage");

			GetEdgeDriverVersionResponse.GetEdgeDriverVersion_Data data = new GetEdgeDriverVersionResponse.GetEdgeDriverVersion_Data();
			data.DriverId = _ctx.StringValue("GetEdgeDriverVersion.Data.DriverId");
			data.DriverVersion = _ctx.StringValue("GetEdgeDriverVersion.Data.DriverVersion");
			data.VersionState = _ctx.StringValue("GetEdgeDriverVersion.Data.VersionState");
			data.EdgeVersion = _ctx.StringValue("GetEdgeDriverVersion.Data.EdgeVersion");
			data.Description = _ctx.StringValue("GetEdgeDriverVersion.Data.Description");
			data.SourceConfig = _ctx.StringValue("GetEdgeDriverVersion.Data.SourceConfig");
			data.DriverConfig = _ctx.StringValue("GetEdgeDriverVersion.Data.DriverConfig");
			data.ContainerConfig = _ctx.StringValue("GetEdgeDriverVersion.Data.ContainerConfig");
			data.ConfigCheckRule = _ctx.StringValue("GetEdgeDriverVersion.Data.ConfigCheckRule");
			data.GmtCreateTimestamp = _ctx.LongValue("GetEdgeDriverVersion.Data.GmtCreateTimestamp");
			data.GmtModifiedTimestamp = _ctx.LongValue("GetEdgeDriverVersion.Data.GmtModifiedTimestamp");
			data.Argument = _ctx.StringValue("GetEdgeDriverVersion.Data.Argument");
			getEdgeDriverVersionResponse.Data = data;
        
			return getEdgeDriverVersionResponse;
        }
    }
}
