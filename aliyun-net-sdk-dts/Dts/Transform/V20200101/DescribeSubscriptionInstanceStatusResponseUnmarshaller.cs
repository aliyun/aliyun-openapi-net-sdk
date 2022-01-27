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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class DescribeSubscriptionInstanceStatusResponseUnmarshaller
    {
        public static DescribeSubscriptionInstanceStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSubscriptionInstanceStatusResponse describeSubscriptionInstanceStatusResponse = new DescribeSubscriptionInstanceStatusResponse();

			describeSubscriptionInstanceStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeSubscriptionInstanceStatusResponse.BeginTimestamp = _ctx.StringValue("DescribeSubscriptionInstanceStatus.BeginTimestamp");
			describeSubscriptionInstanceStatusResponse.ConsumptionCheckpoint = _ctx.StringValue("DescribeSubscriptionInstanceStatus.ConsumptionCheckpoint");
			describeSubscriptionInstanceStatusResponse.ConsumptionClient = _ctx.StringValue("DescribeSubscriptionInstanceStatus.ConsumptionClient");
			describeSubscriptionInstanceStatusResponse.EndTimestamp = _ctx.StringValue("DescribeSubscriptionInstanceStatus.EndTimestamp");
			describeSubscriptionInstanceStatusResponse.ErrMessage = _ctx.StringValue("DescribeSubscriptionInstanceStatus.ErrMessage");
			describeSubscriptionInstanceStatusResponse.PayType = _ctx.StringValue("DescribeSubscriptionInstanceStatus.PayType");
			describeSubscriptionInstanceStatusResponse.RequestId = _ctx.StringValue("DescribeSubscriptionInstanceStatus.RequestId");
			describeSubscriptionInstanceStatusResponse.Status = _ctx.StringValue("DescribeSubscriptionInstanceStatus.Status");
			describeSubscriptionInstanceStatusResponse.SubscribeTopic = _ctx.StringValue("DescribeSubscriptionInstanceStatus.SubscribeTopic");
			describeSubscriptionInstanceStatusResponse.SubscriptionInstanceID = _ctx.StringValue("DescribeSubscriptionInstanceStatus.SubscriptionInstanceID");
			describeSubscriptionInstanceStatusResponse.SubscriptionInstanceName = _ctx.StringValue("DescribeSubscriptionInstanceStatus.SubscriptionInstanceName");
			describeSubscriptionInstanceStatusResponse.ErrCode = _ctx.StringValue("DescribeSubscriptionInstanceStatus.ErrCode");
			describeSubscriptionInstanceStatusResponse.Success = _ctx.StringValue("DescribeSubscriptionInstanceStatus.Success");
			describeSubscriptionInstanceStatusResponse.ErrorMessage = _ctx.StringValue("DescribeSubscriptionInstanceStatus.ErrorMessage");
			describeSubscriptionInstanceStatusResponse.TaskId = _ctx.StringValue("DescribeSubscriptionInstanceStatus.TaskId");

			DescribeSubscriptionInstanceStatusResponse.DescribeSubscriptionInstanceStatus_SourceEndpoint sourceEndpoint = new DescribeSubscriptionInstanceStatusResponse.DescribeSubscriptionInstanceStatus_SourceEndpoint();
			sourceEndpoint.InstanceID = _ctx.StringValue("DescribeSubscriptionInstanceStatus.SourceEndpoint.InstanceID");
			sourceEndpoint.InstanceType = _ctx.StringValue("DescribeSubscriptionInstanceStatus.SourceEndpoint.InstanceType");
			describeSubscriptionInstanceStatusResponse.SourceEndpoint = sourceEndpoint;

			DescribeSubscriptionInstanceStatusResponse.DescribeSubscriptionInstanceStatus_SubscriptionDataType subscriptionDataType = new DescribeSubscriptionInstanceStatusResponse.DescribeSubscriptionInstanceStatus_SubscriptionDataType();
			subscriptionDataType.DDL = _ctx.BooleanValue("DescribeSubscriptionInstanceStatus.SubscriptionDataType.DDL");
			subscriptionDataType.DML = _ctx.BooleanValue("DescribeSubscriptionInstanceStatus.SubscriptionDataType.DML");
			describeSubscriptionInstanceStatusResponse.SubscriptionDataType = subscriptionDataType;

			DescribeSubscriptionInstanceStatusResponse.DescribeSubscriptionInstanceStatus_SubscriptionHost subscriptionHost = new DescribeSubscriptionInstanceStatusResponse.DescribeSubscriptionInstanceStatus_SubscriptionHost();
			subscriptionHost.PrivateHost = _ctx.StringValue("DescribeSubscriptionInstanceStatus.SubscriptionHost.PrivateHost");
			subscriptionHost.PublicHost = _ctx.StringValue("DescribeSubscriptionInstanceStatus.SubscriptionHost.PublicHost");
			subscriptionHost.VPCHost = _ctx.StringValue("DescribeSubscriptionInstanceStatus.SubscriptionHost.VPCHost");
			describeSubscriptionInstanceStatusResponse.SubscriptionHost = subscriptionHost;

			List<DescribeSubscriptionInstanceStatusResponse.DescribeSubscriptionInstanceStatus_SynchronousObject> describeSubscriptionInstanceStatusResponse_subscriptionObject = new List<DescribeSubscriptionInstanceStatusResponse.DescribeSubscriptionInstanceStatus_SynchronousObject>();
			for (int i = 0; i < _ctx.Length("DescribeSubscriptionInstanceStatus.SubscriptionObject.Length"); i++) {
				DescribeSubscriptionInstanceStatusResponse.DescribeSubscriptionInstanceStatus_SynchronousObject synchronousObject = new DescribeSubscriptionInstanceStatusResponse.DescribeSubscriptionInstanceStatus_SynchronousObject();
				synchronousObject.DatabaseName = _ctx.StringValue("DescribeSubscriptionInstanceStatus.SubscriptionObject["+ i +"].DatabaseName");
				synchronousObject.WholeDatabase = _ctx.StringValue("DescribeSubscriptionInstanceStatus.SubscriptionObject["+ i +"].WholeDatabase");

				List<string> synchronousObject_tableList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeSubscriptionInstanceStatus.SubscriptionObject["+ i +"].TableList.Length"); j++) {
					synchronousObject_tableList.Add(_ctx.StringValue("DescribeSubscriptionInstanceStatus.SubscriptionObject["+ i +"].TableList["+ j +"]"));
				}
				synchronousObject.TableList = synchronousObject_tableList;

				describeSubscriptionInstanceStatusResponse_subscriptionObject.Add(synchronousObject);
			}
			describeSubscriptionInstanceStatusResponse.SubscriptionObject = describeSubscriptionInstanceStatusResponse_subscriptionObject;
        
			return describeSubscriptionInstanceStatusResponse;
        }
    }
}
