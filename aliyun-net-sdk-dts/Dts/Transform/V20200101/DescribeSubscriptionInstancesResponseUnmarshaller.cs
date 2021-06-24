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
    public class DescribeSubscriptionInstancesResponseUnmarshaller
    {
        public static DescribeSubscriptionInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSubscriptionInstancesResponse describeSubscriptionInstancesResponse = new DescribeSubscriptionInstancesResponse();

			describeSubscriptionInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeSubscriptionInstancesResponse.ErrCode = _ctx.StringValue("DescribeSubscriptionInstances.ErrCode");
			describeSubscriptionInstancesResponse.ErrMessage = _ctx.StringValue("DescribeSubscriptionInstances.ErrMessage");
			describeSubscriptionInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeSubscriptionInstances.PageNumber");
			describeSubscriptionInstancesResponse.PageRecordCount = _ctx.IntegerValue("DescribeSubscriptionInstances.PageRecordCount");
			describeSubscriptionInstancesResponse.RequestId = _ctx.StringValue("DescribeSubscriptionInstances.RequestId");
			describeSubscriptionInstancesResponse.Success = _ctx.StringValue("DescribeSubscriptionInstances.Success");
			describeSubscriptionInstancesResponse.TotalRecordCount = _ctx.LongValue("DescribeSubscriptionInstances.TotalRecordCount");

			List<DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance> describeSubscriptionInstancesResponse_subscriptionInstances = new List<DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance>();
			for (int i = 0; i < _ctx.Length("DescribeSubscriptionInstances.SubscriptionInstances.Length"); i++) {
				DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance subscriptionInstance = new DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance();
				subscriptionInstance.BeginTimestamp = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].BeginTimestamp");
				subscriptionInstance.ConsumptionCheckpoint = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].ConsumptionCheckpoint");
				subscriptionInstance.ConsumptionClient = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].ConsumptionClient");
				subscriptionInstance.EndTimestamp = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].EndTimestamp");
				subscriptionInstance.ErrorMessage = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].ErrorMessage");
				subscriptionInstance.PayType = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].PayType");
				subscriptionInstance.Status = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].Status");
				subscriptionInstance.SubscribeTopic = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SubscribeTopic");
				subscriptionInstance.SubscriptionInstanceID = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SubscriptionInstanceID");
				subscriptionInstance.SubscriptionInstanceName = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SubscriptionInstanceName");
				subscriptionInstance.JobCreateTime = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].JobCreateTime");
				subscriptionInstance.InstanceCreateTime = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].InstanceCreateTime");

				DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance.DescribeSubscriptionInstances_SourceEndpoint sourceEndpoint = new DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance.DescribeSubscriptionInstances_SourceEndpoint();
				sourceEndpoint.InstanceID = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SourceEndpoint.InstanceID");
				sourceEndpoint.InstanceType = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SourceEndpoint.InstanceType");
				subscriptionInstance.SourceEndpoint = sourceEndpoint;

				DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance.DescribeSubscriptionInstances_SubscriptionDataType subscriptionDataType = new DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance.DescribeSubscriptionInstances_SubscriptionDataType();
				subscriptionDataType.DDL = _ctx.BooleanValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SubscriptionDataType.DDL");
				subscriptionDataType.DML = _ctx.BooleanValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SubscriptionDataType.DML");
				subscriptionInstance.SubscriptionDataType = subscriptionDataType;

				DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance.DescribeSubscriptionInstances_SubscriptionHost subscriptionHost = new DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance.DescribeSubscriptionInstances_SubscriptionHost();
				subscriptionHost.PrivateHost = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SubscriptionHost.PrivateHost");
				subscriptionHost.PublicHost = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SubscriptionHost.PublicHost");
				subscriptionHost.VPCHost = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SubscriptionHost.VPCHost");
				subscriptionInstance.SubscriptionHost = subscriptionHost;

				List<DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance.DescribeSubscriptionInstances_SynchronousObject> subscriptionInstance_subscriptionObject = new List<DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance.DescribeSubscriptionInstances_SynchronousObject>();
				for (int j = 0; j < _ctx.Length("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SubscriptionObject.Length"); j++) {
					DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance.DescribeSubscriptionInstances_SynchronousObject synchronousObject = new DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance.DescribeSubscriptionInstances_SynchronousObject();
					synchronousObject.DatabaseName = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SubscriptionObject["+ j +"].DatabaseName");
					synchronousObject.WholeDatabase = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SubscriptionObject["+ j +"].WholeDatabase");

					List<string> synchronousObject_tableList = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SubscriptionObject["+ j +"].TableList.Length"); k++) {
						synchronousObject_tableList.Add(_ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].SubscriptionObject["+ j +"].TableList["+ k +"]"));
					}
					synchronousObject.TableList = synchronousObject_tableList;

					subscriptionInstance_subscriptionObject.Add(synchronousObject);
				}
				subscriptionInstance.SubscriptionObject = subscriptionInstance_subscriptionObject;

				List<DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance.DescribeSubscriptionInstances_Tag> subscriptionInstance_tags = new List<DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance.DescribeSubscriptionInstances_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].Tags.Length"); j++) {
					DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance.DescribeSubscriptionInstances_Tag tag = new DescribeSubscriptionInstancesResponse.DescribeSubscriptionInstances_SubscriptionInstance.DescribeSubscriptionInstances_Tag();
					tag.Key = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeSubscriptionInstances.SubscriptionInstances["+ i +"].Tags["+ j +"].Value");

					subscriptionInstance_tags.Add(tag);
				}
				subscriptionInstance.Tags = subscriptionInstance_tags;

				describeSubscriptionInstancesResponse_subscriptionInstances.Add(subscriptionInstance);
			}
			describeSubscriptionInstancesResponse.SubscriptionInstances = describeSubscriptionInstancesResponse_subscriptionInstances;
        
			return describeSubscriptionInstancesResponse;
        }
    }
}
