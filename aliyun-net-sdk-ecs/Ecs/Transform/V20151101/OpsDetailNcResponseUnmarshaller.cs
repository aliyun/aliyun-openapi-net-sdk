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
    public class OpsDetailNcResponseUnmarshaller
    {
        public static OpsDetailNcResponse Unmarshall(UnmarshallerContext context)
        {
			OpsDetailNcResponse opsDetailNcResponse = new OpsDetailNcResponse();

			opsDetailNcResponse.HttpResponse = context.HttpResponse;
			opsDetailNcResponse.RequestId = context.StringValue("OpsDetailNc.RequestId");
			opsDetailNcResponse.NcId = context.StringValue("OpsDetailNc.NcId");
			opsDetailNcResponse.NcIp = context.StringValue("OpsDetailNc.NcIp");
			opsDetailNcResponse.ZoneNo = context.StringValue("OpsDetailNc.ZoneNo");
			opsDetailNcResponse.RackId = context.StringValue("OpsDetailNc.RackId");
			opsDetailNcResponse.TotalCpu = context.IntegerValue("OpsDetailNc.TotalCpu");
			opsDetailNcResponse.TotalDisk = context.IntegerValue("OpsDetailNc.TotalDisk");
			opsDetailNcResponse.TotalMem = context.IntegerValue("OpsDetailNc.TotalMem");
			opsDetailNcResponse.AvailableCpu = context.IntegerValue("OpsDetailNc.AvailableCpu");
			opsDetailNcResponse.AvailableDisk = context.IntegerValue("OpsDetailNc.AvailableDisk");
			opsDetailNcResponse.AvailableMem = context.IntegerValue("OpsDetailNc.AvailableMem");
        
			return opsDetailNcResponse;
        }
    }
}