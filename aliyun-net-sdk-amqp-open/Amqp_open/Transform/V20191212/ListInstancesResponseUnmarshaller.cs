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
using Aliyun.Acs.amqp_open.Model.V20191212;

namespace Aliyun.Acs.amqp_open.Transform.V20191212
{
    public class ListInstancesResponseUnmarshaller
    {
        public static ListInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancesResponse listInstancesResponse = new ListInstancesResponse();

			listInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listInstancesResponse.RequestId = _ctx.StringValue("ListInstances.RequestId");

			ListInstancesResponse.ListInstances_Data data = new ListInstancesResponse.ListInstances_Data();
			data.NextToken = _ctx.StringValue("ListInstances.Data.NextToken");
			data.MaxResults = _ctx.IntegerValue("ListInstances.Data.MaxResults");

			List<ListInstancesResponse.ListInstances_Data.ListInstances_InstanceVO> data_instances = new List<ListInstancesResponse.ListInstances_Data.ListInstances_InstanceVO>();
			for (int i = 0; i < _ctx.Length("ListInstances.Data.Instances.Length"); i++) {
				ListInstancesResponse.ListInstances_Data.ListInstances_InstanceVO instanceVO = new ListInstancesResponse.ListInstances_Data.ListInstances_InstanceVO();
				instanceVO.Status = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].Status");
				instanceVO.SupportEIP = _ctx.BooleanValue("ListInstances.Data.Instances["+ i +"].SupportEIP");
				instanceVO.ExpireTime = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].ExpireTime");
				instanceVO.OrderCreateTime = _ctx.LongValue("ListInstances.Data.Instances["+ i +"].OrderCreateTime");
				instanceVO.PrivateEndpoint = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].PrivateEndpoint");
				instanceVO.StorageSize = _ctx.IntegerValue("ListInstances.Data.Instances["+ i +"].StorageSize");
				instanceVO.MaxEipTps = _ctx.IntegerValue("ListInstances.Data.Instances["+ i +"].MaxEipTps");
				instanceVO.InstanceId = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].InstanceId");
				instanceVO.InstanceType = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].InstanceType");
				instanceVO.PublicEndpoint = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].PublicEndpoint");
				instanceVO.ClassicEndpoint = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].ClassicEndpoint");
				instanceVO.MaxVhost = _ctx.IntegerValue("ListInstances.Data.Instances["+ i +"].MaxVhost");
				instanceVO.MaxTps = _ctx.IntegerValue("ListInstances.Data.Instances["+ i +"].MaxTps");
				instanceVO.AutoRenewInstance = _ctx.BooleanValue("ListInstances.Data.Instances["+ i +"].AutoRenewInstance");
				instanceVO.InstanceName = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].InstanceName");
				instanceVO.MaxQueue = _ctx.IntegerValue("ListInstances.Data.Instances["+ i +"].MaxQueue");
				instanceVO.OrderType = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].OrderType");

				List<ListInstancesResponse.ListInstances_Data.ListInstances_InstanceVO.ListInstances_TagsItem> instanceVO_tags = new List<ListInstancesResponse.ListInstances_Data.ListInstances_InstanceVO.ListInstances_TagsItem>();
				for (int j = 0; j < _ctx.Length("ListInstances.Data.Instances["+ i +"].Tags.Length"); j++) {
					ListInstancesResponse.ListInstances_Data.ListInstances_InstanceVO.ListInstances_TagsItem tagsItem = new ListInstancesResponse.ListInstances_Data.ListInstances_InstanceVO.ListInstances_TagsItem();
					tagsItem.Key = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].Tags["+ j +"].Key");
					tagsItem._Value = _ctx.StringValue("ListInstances.Data.Instances["+ i +"].Tags["+ j +"].Value");

					instanceVO_tags.Add(tagsItem);
				}
				instanceVO.Tags = instanceVO_tags;

				data_instances.Add(instanceVO);
			}
			data.Instances = data_instances;
			listInstancesResponse.Data = data;
        
			return listInstancesResponse;
        }
    }
}
