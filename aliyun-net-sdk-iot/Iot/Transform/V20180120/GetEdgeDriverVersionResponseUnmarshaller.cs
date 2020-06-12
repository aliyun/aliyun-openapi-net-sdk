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
        public static GetEdgeDriverVersionResponse Unmarshall(UnmarshallerContext context)
        {
			GetEdgeDriverVersionResponse getEdgeDriverVersionResponse = new GetEdgeDriverVersionResponse();

			getEdgeDriverVersionResponse.HttpResponse = context.HttpResponse;
			getEdgeDriverVersionResponse.RequestId = context.StringValue("GetEdgeDriverVersion.RequestId");
			getEdgeDriverVersionResponse.Success = context.BooleanValue("GetEdgeDriverVersion.Success");
			getEdgeDriverVersionResponse.Code = context.StringValue("GetEdgeDriverVersion.Code");
			getEdgeDriverVersionResponse.ErrorMessage = context.StringValue("GetEdgeDriverVersion.ErrorMessage");

			GetEdgeDriverVersionResponse.GetEdgeDriverVersion_Data data = new GetEdgeDriverVersionResponse.GetEdgeDriverVersion_Data();
			data.DriverId = context.StringValue("GetEdgeDriverVersion.Data.DriverId");
			data.DriverVersion = context.StringValue("GetEdgeDriverVersion.Data.DriverVersion");
			data.VersionState = context.StringValue("GetEdgeDriverVersion.Data.VersionState");
			data.EdgeVersion = context.StringValue("GetEdgeDriverVersion.Data.EdgeVersion");
			data.Description = context.StringValue("GetEdgeDriverVersion.Data.Description");
			data.SourceConfig = context.StringValue("GetEdgeDriverVersion.Data.SourceConfig");
			data.DriverConfig = context.StringValue("GetEdgeDriverVersion.Data.DriverConfig");
			data.ContainerConfig = context.StringValue("GetEdgeDriverVersion.Data.ContainerConfig");
			data.ConfigCheckRule = context.StringValue("GetEdgeDriverVersion.Data.ConfigCheckRule");
			data.GmtCreateTimestamp = context.LongValue("GetEdgeDriverVersion.Data.GmtCreateTimestamp");
			data.GmtModifiedTimestamp = context.LongValue("GetEdgeDriverVersion.Data.GmtModifiedTimestamp");
			data.Argument = context.StringValue("GetEdgeDriverVersion.Data.Argument");
			getEdgeDriverVersionResponse.Data = data;
        
			return getEdgeDriverVersionResponse;
        }
    }
}
