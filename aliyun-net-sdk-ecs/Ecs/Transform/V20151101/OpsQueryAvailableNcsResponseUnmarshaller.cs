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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20151101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20151101
{
    public class OpsQueryAvailableNcsResponseUnmarshaller
    {
        public static OpsQueryAvailableNcsResponse Unmarshall(UnmarshallerContext context)
        {
			OpsQueryAvailableNcsResponse opsQueryAvailableNcsResponse = new OpsQueryAvailableNcsResponse();

			opsQueryAvailableNcsResponse.HttpResponse = context.HttpResponse;
			opsQueryAvailableNcsResponse.RequestId = context.StringValue("OpsQueryAvailableNcs.RequestId");
			opsQueryAvailableNcsResponse.TotalCount = context.IntegerValue("OpsQueryAvailableNcs.TotalCount");
			opsQueryAvailableNcsResponse.PageNo = context.IntegerValue("OpsQueryAvailableNcs.PageNo");
			opsQueryAvailableNcsResponse.PageSize = context.IntegerValue("OpsQueryAvailableNcs.PageSize");

			List<OpsQueryAvailableNcsResponse.NcModel> ncModels = new List<OpsQueryAvailableNcsResponse.NcModel>();
			for (int i = 0; i < context.Length("OpsQueryAvailableNcs.NcModels.Length"); i++) {
				OpsQueryAvailableNcsResponse.NcModel ncModel = new OpsQueryAvailableNcsResponse.NcModel();
				ncModel.NcId = context.StringValue("OpsQueryAvailableNcs.NcModels["+ i +"].NcId");
				ncModel.NcIp = context.StringValue("OpsQueryAvailableNcs.NcModels["+ i +"].NcIp");
				ncModel.ZoneNo = context.StringValue("OpsQueryAvailableNcs.NcModels["+ i +"].ZoneNo");
				ncModel.RackId = context.StringValue("OpsQueryAvailableNcs.NcModels["+ i +"].RackId");
				ncModel.TotalCpu = context.IntegerValue("OpsQueryAvailableNcs.NcModels["+ i +"].TotalCpu");
				ncModel.TotalDisk = context.IntegerValue("OpsQueryAvailableNcs.NcModels["+ i +"].TotalDisk");
				ncModel.TotalMem = context.IntegerValue("OpsQueryAvailableNcs.NcModels["+ i +"].TotalMem");
				ncModel.AvailableCpu = context.IntegerValue("OpsQueryAvailableNcs.NcModels["+ i +"].AvailableCpu");
				ncModel.AvailableDisk = context.IntegerValue("OpsQueryAvailableNcs.NcModels["+ i +"].AvailableDisk");
				ncModel.AvailableMem = context.IntegerValue("OpsQueryAvailableNcs.NcModels["+ i +"].AvailableMem");

				ncModels.Add(ncModel);
			}
			opsQueryAvailableNcsResponse.NcModels = ncModels;
        
			return opsQueryAvailableNcsResponse;
        }
    }
}