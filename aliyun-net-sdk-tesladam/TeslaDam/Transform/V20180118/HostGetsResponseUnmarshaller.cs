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
using Aliyun.Acs.TeslaDam.Model.V20180118;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaDam.Transform.V20180118
{
    public class HostGetsResponseUnmarshaller
    {
        public static HostGetsResponse Unmarshall(UnmarshallerContext context)
        {
			HostGetsResponse hostGetsResponse = new HostGetsResponse();

			hostGetsResponse.HttpResponse = context.HttpResponse;
			hostGetsResponse.Status = context.BooleanValue("HostGets.Status");
			hostGetsResponse.Message = context.StringValue("HostGets.Message");

			List<HostGetsResponse.HostGets_DataItem> hostGetsResponse_data = new List<HostGetsResponse.HostGets_DataItem>();
			for (int i = 0; i < context.Length("HostGets.Data.Length"); i++) {
				HostGetsResponse.HostGets_DataItem dataItem = new HostGetsResponse.HostGets_DataItem();
				dataItem.Hostname = context.StringValue("HostGets.Data["+ i +"].Hostname");
				dataItem.Ip = context.StringValue("HostGets.Data["+ i +"].Ip");
				dataItem.AppCode = context.StringValue("HostGets.Data["+ i +"].AppCode");
				dataItem.ClusterCode = context.StringValue("HostGets.Data["+ i +"].ClusterCode");
				dataItem.SshStatus = context.IntegerValue("HostGets.Data["+ i +"].SshStatus");
				dataItem.HeartStatus = context.IntegerValue("HostGets.Data["+ i +"].HeartStatus");
				dataItem.HealthScoreLast = context.IntegerValue("HostGets.Data["+ i +"].HealthScoreLast");
				dataItem.HealthReasonLast = context.StringValue("HostGets.Data["+ i +"].HealthReasonLast");

				hostGetsResponse_data.Add(dataItem);
			}
			hostGetsResponse.Data = hostGetsResponse_data;
        
			return hostGetsResponse;
        }
    }
}